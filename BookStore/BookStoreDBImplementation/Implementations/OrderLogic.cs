using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreDBImplementation.Models;
using BookStoreBusinessLogic.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreDBImplementation.Implementations
{
    public class OrderLogic : IOrderLogic
    {
        public void CreateOrUpdate(OrderBindingModel model)
        {
            using (var context = new BookStoreContext())
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
                            else if (model.Status == OrderStatus.Created)
                            {
                                var orderBooks = context.OrderBooks
                                    .Where(rec => rec.OrderID == model.ID.Value).ToList();
                                context.OrderBooks.RemoveRange(orderBooks.Where(rec =>
                                    !model.Books.ContainsKey(rec.BookID)).ToList());
                                foreach (var updBook in orderBooks)
                                {
                                    updBook.Count = model.Books[updBook.BookID].Item2;
                                    model.Books.Remove(updBook.BookID);
                                }
                                context.SaveChanges();
                            }
                            else
                            {
                                throw new Exception("Unable to edit order");
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

        public void Delete(OrderBindingModel model)
        {
            if (model.Status == OrderStatus.Created)
            {
                using (var context = new BookStoreContext())
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
            }
        }

        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            using (var context = new BookStoreContext())
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
        }
    }
}
