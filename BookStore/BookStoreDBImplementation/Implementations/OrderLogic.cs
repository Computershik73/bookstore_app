using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreDBImplementation.Models;
using BookStoreBusinessLogic.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace BookStoreDBImplementation.Implementations
{
    public class OrderLogic : IOrderLogic
    {
        private readonly BookStoreContext context;
        public OrderLogic(BookStoreContext context)
        {
            this.context = context;
        }

        public void CreateOrUpdate(OrderBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Order order;
                    if (model.ID.HasValue)
                    {
                        order = context.Orders.FirstOrDefault(rec => rec.ID == model.ID);
                        if (order == null)
                        {
                            throw new Exception("Order not found");
                        }
                    }
                    else
                    {
                        order = new Order();
                        context.Orders.Add(order);
                    }
                    order.CustomerID = model.CustomerID;
                    order.PlacementDate = model.PlacementDate;
                    order.Status = model.Status;
                    context.SaveChanges();
                    if (!model.ID.HasValue)
                    {
                        foreach (var book in model.Books)
                        {
                            context.OrderBooks.Add(new OrderBook
                            {
                                OrderID = order.ID,
                                BookID = book.Key,
                                Count = book.Value.Item2
                            });
                            context.SaveChanges();
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void Delete(OrderBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.OrderBooks.RemoveRange(context
                        .OrderBooks.Where(rec => rec.OrderID == model.ID));
                    Order order = context.Orders.FirstOrDefault(rec => rec.ID == model.ID);
                    if (order != null)
                    {
                        context.Orders.Remove(order);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Order not found");
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            return context.Orders
                .Include(rec => rec.Customer)
                .Where(rec => model == null || rec.ID == model.ID)
                .ToList()
                .Select(rec => new OrderViewModel
                {
                    ID = rec.ID,
                    CustomerID = rec.CustomerID,
                    CustomerName = rec.Customer.FirstName + " " 
                                    + rec.Customer.LastName,
                    PlacementDate = rec.PlacementDate,
                    Status = rec.Status,
                    Books = context.OrderBooks
                        .Include(recOB => recOB.Book)
                        .Where(recOB => recOB.OrderID == rec.ID)
                        .ToDictionary(recOB => recOB.BookID, recOB =>
                        (recOB.Book?.Title, recOB.Count))
                })
                .ToList();
        }

        public List<OrderViewModel> ReadPage(int skip, int take)
        {
            return context.Orders.Include(rec => rec.Customer)
            .Skip(skip).Take(take).ToList().Select(rec =>
            new OrderViewModel
            {
                ID = rec.ID,
                CustomerID = rec.CustomerID,
                CustomerName = rec.Customer.FirstName + " "
                                    + rec.Customer.LastName,
                PlacementDate = rec.PlacementDate,
                Status = rec.Status,
                Books = context.OrderBooks
                        .Include(recOB => recOB.Book)
                        .Where(recOB => recOB.OrderID == rec.ID)
                        .ToDictionary(recOB => recOB.BookID, recOB =>
                        (recOB.Book?.Title, recOB.Count))
            }).ToList();
        }
    }
}
