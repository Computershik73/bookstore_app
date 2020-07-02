using System.Collections.Generic;
using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;

namespace BookStoreBusinessLogic.Interfaces
{
    public interface IOrderLogic
    {
        void CreateOrUpdate(OrderBindingModel model);
        void Delete(OrderBindingModel model);
        List<OrderViewModel> Read(OrderBindingModel model);
    }
}
