using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BookStoreBusinessLogic.Interfaces
{
    public interface ICustomerLogic
    {
        void CreateOrUpdate(CustomerBindingModel model);
        void Delete(CustomerBindingModel model);
        List<CustomerViewModel> Read(CustomerBindingModel model);
    }
}
