using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BookStoreBusinessLogic.Interfaces
{
    public interface IAddressLogic
    {
        void CreateOrUpdate(AddressBindingModel model);
        void Delete(AddressBindingModel model);
        List<AddressViewModel> Read(AddressBindingModel model);
    }
}
