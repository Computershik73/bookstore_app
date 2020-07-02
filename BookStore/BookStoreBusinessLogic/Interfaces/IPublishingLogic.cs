using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BookStoreBusinessLogic.Interfaces
{
    public interface IPublishingLogic
    {
        void CreateOrUpdate(PublishingBindingModel model);
        void Delete(PublishingBindingModel model);
        List<PublishingViewModel> Read(PublishingBindingModel model);
    }
}
