using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreDBImplementation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BookStoreDBImplementation.Implementations
{
    public class WarehouseLogic : IWarehouseLogic
    {
        private readonly BookStoreContext context;
        
        public WarehouseLogic(BookStoreContext context)
        {
            this.context = context;
        }

        public void CreateOrUpdate(WarehouseBindingModel model)
        {
            Warehouse warehouse = context.Warehouses.FirstOrDefault(rec =>
            rec.Name == model.Name && rec.ID != model.ID);
            if (warehouse != null)
            {
                throw new Exception("Warehouse is already exist");
            }
            if (model.ID.HasValue)
            {
                warehouse = context.Warehouses.FirstOrDefault(rec => rec.ID == model.ID);
                if (warehouse == null)
                {
                    throw new Exception("Publishing not found");
                }
            }
            else
            {
                warehouse = new Warehouse();
                context.Warehouses.Add(warehouse);
            }
            Warehouse check = context.Warehouses.FirstOrDefault(rec => 
            rec.AddressID == model.AddressID);
            if (check != null)
            {
                throw new Exception("Address is already in use");
            } else
            {
                warehouse.Name = model.Name;
                warehouse.Capacity = model.Capacity;
                warehouse.AddressID = model.AddressID;
                context.SaveChanges();
            }
        }

        public void Delete(WarehouseBindingModel model)
        {
            Warehouse warehouse = context.Warehouses.FirstOrDefault(rec => rec.ID == model.ID);
            if (warehouse != null)
            {
                context.Warehouses.Remove(warehouse);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Warehouse not found");
            }
        }

        public List<WarehouseViewModel> Read(WarehouseBindingModel model)
        {
            return context.Warehouses
                .Include(rec => rec.Address)
                .Where(rec => model == null || rec.ID == model.ID)
                .ToList()
                .Select(rec => new WarehouseViewModel
                {
                    ID = rec.ID,
                    Name = rec.Name,
                    Capacity = rec.Capacity,
                    Address = rec.Address.Country + " " 
                            + rec.Address.State + " " 
                            + rec.Address.City + " " 
                            + rec.Address.Street + " " 
                            + rec.Address.Building + " " 
                            + rec.Address.ZipPostalCode.ToString(),
                })
                .ToList();
        }

        public List<WarehouseViewModel> ReadPage(int skip, int take)
        {
            return context.Warehouses.Include(rec => rec.Address)
            .Skip(skip).Take(take).Select(rec =>
            new WarehouseViewModel
            {
                ID = rec.ID,
                Name = rec.Name,
                Capacity = rec.Capacity,
                Address = rec.Address.Country + " "
                            + rec.Address.State + " "
                            + rec.Address.City + " "
                            + rec.Address.Street + " "
                            + rec.Address.Building + " "
                            + rec.Address.ZipPostalCode.ToString(),
            }).ToList();
        }

        public void Resupply(ResupplyWarehouseBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var warehouseBooks = context.BookWarehouses.Where(rec =>
                        rec.WarehouseID == model.WarehouseID).ToList();
                    foreach (var updBook in warehouseBooks)
                    {
                        updBook.Count += model.Books[updBook.BookID];
                        model.Books.Remove(updBook.BookID);
                    }
                    foreach (var book in model.Books)
                    {
                        context.BookWarehouses.Add(new BookWarehouse
                        {
                            BookID = book.Key,
                            WarehouseID = model.WarehouseID,
                            Count = book.Value
                        });
                    }
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
