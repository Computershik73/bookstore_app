using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreDBImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreDBImplementation.Implementations
{
    public class CustomerLogic : ICustomerLogic
    {
        public void CreateOrUpdate(CustomerBindingModel model)
        {
            using (var context = new BookStoreContext())
            {
                Customer customer = context.Customers.FirstOrDefault(rec =>
                rec.PhoneNumber == model.PhoneNumber && rec.ID != model.ID);
                if (customer != null)
                {
                    throw new Exception("Customer is already exist");
                }
                if (model.ID.HasValue)
                {
                    customer = context.Customers.FirstOrDefault(rec => rec.ID == model.ID);
                    if (customer == null)
                    {
                        throw new Exception("Customer not found");
                    }
                }
                else
                {
                    customer = new Customer();
                    context.Customers.Add(customer);
                }
                customer.FirstName = model.FirstName;
                customer.LastName = model.LastName;
                customer.PhoneNumber = model.PhoneNumber;
                customer.Email = model.Email;
                context.SaveChanges();
            }
        }

        public void Delete(CustomerBindingModel model)
        {
            using (var context = new BookStoreContext())
            {
                Customer customer = context.Customers.FirstOrDefault(rec => rec.ID == model.ID);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Customer not found");
                }
            }
        }

        public List<CustomerViewModel> Read(CustomerBindingModel model)
        {
            using (var context = new BookStoreContext())
            {
                return context.Customers
                    .Where(rec => model == null || rec.ID == model.ID)
                    .Select(rec => new CustomerViewModel
                    {
                        ID = rec.ID,
                        FirstName = rec.FirstName,
                        LastName = rec.LastName,
                        PhoneNumber = rec.PhoneNumber,
                        Email = rec.Email
                    })
                    .ToList();
            }
        }
    }
}
