using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreDBImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreDBImplementation.Implementations
{
    public class AddressLogic : IAddressLogic
    {
        private readonly BookStoreContext context;
        public AddressLogic(BookStoreContext context)
        {
            this.context = context;
        }

        public void CreateOrUpdate(AddressBindingModel model)
        {
            Address address = context.Addresses.FirstOrDefault(rec =>
            rec.Country == model.Country
            && rec.City == model.City
            && rec.State == model.State
            && rec.Street == model.Street
            && rec.Building == model.Building
            && rec.ID != model.ID);
            if (address != null)
            {
                throw new Exception("Address is already exist");
            }
            if (model.ID.HasValue)
            {
                address = context.Addresses.FirstOrDefault(rec => rec.ID == model.ID);
                if (address == null)
                {
                    throw new Exception("Address not found");
                }
            }
            else
            {
                address = new Address();
                context.Addresses.Add(address);
            }
            address.Country = model.Country;
            address.State = model.State;
            address.City = model.City;
            address.Street = model.Street;
            address.Building = model.Building;
            address.ZipPostalCode = model.ZipPostalCode;
            context.SaveChanges();
        }

        public void Delete(AddressBindingModel model)
        {
            Address address = context.Addresses.FirstOrDefault(rec => rec.ID == model.ID);
            if (address != null)
            {
                context.Addresses.Remove(address);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Address not found");
            }
        }

        public List<AddressViewModel> Read(AddressBindingModel model)
        {
            return context.Addresses
                .Where(rec => model == null || rec.ID == model.ID)
                .Select(rec => new AddressViewModel
                {
                    ID = rec.ID,
                    Country = rec.Country,
                    State = rec.State,
                    City = rec.City,
                    Street = rec.Street,
                    Building = rec.Building,
                    ZipPostalCode = rec.ZipPostalCode
                })
                .ToList();
        }

        public List<AddressViewModel> ReadPage(int skip, int take)
        {
            return context.Addresses
            .Skip(skip).Take(take).Select(rec =>
            new AddressViewModel
            {
                ID = rec.ID,
                Country = rec.Country,
                State = rec.State,
                City = rec.City,
                Street = rec.Street,
                Building = rec.Building,
                ZipPostalCode = rec.ZipPostalCode
            })
            .ToList();
        }
    }
}
