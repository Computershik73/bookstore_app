using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BookStoreBusinessLogic.Interfaces
{
    public interface IAuthorLogic
    {
        void CreateOrUpdate(AuthorBindingModel model);
        void Delete(AuthorBindingModel model);
        List<AuthorViewModel> Read(AuthorBindingModel model);
    }
}
