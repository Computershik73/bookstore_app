using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BookStoreBusinessLogic.Interfaces
{
    public interface IWarehouseLogic
    {
        void CreateOrUpdate(WarehouseBindingModel model);
        void Delete(WarehouseBindingModel model);
        List<WarehouseViewModel> Read(WarehouseBindingModel model);
        void Resupply(ResupplyWarehouseBindingModel model);
    }
}
