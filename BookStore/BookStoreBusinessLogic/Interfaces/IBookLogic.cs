using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BookStoreBusinessLogic.Interfaces
{
    public interface IBookLogic
    {
        void CreateOrUpdate(BookBindingModel model);
        void Delete(BookBindingModel model);
        List<BookViewModel> Read(BookBindingModel model);
    }
}
