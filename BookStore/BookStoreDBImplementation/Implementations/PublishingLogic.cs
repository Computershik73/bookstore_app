using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreDBImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreDBImplementation.Implementations
{
    public class PublishingLogic : IPublishingLogic
    {
        public void CreateOrUpdate(PublishingBindingModel model)
        {
            using (var context = new BookStoreContext())
            {
                Publishing publishing = context.Publishings.FirstOrDefault(rec =>
                rec.Name == model.Name && rec.ID != model.ID);
                if (publishing != null)
                {
                    throw new Exception("Publishing is already exist");
                }
                if (model.ID.HasValue)
                {
                    publishing = context.Publishings.FirstOrDefault(rec => rec.ID == model.ID);
                    if (publishing == null)
                    {
                        throw new Exception("Publishing not found");
                    }
                }
                else
                {
                    publishing = new Publishing();
                    context.Publishings.Add(publishing);
                }
                publishing.Name = model.Name;
                context.SaveChanges();
            }
        }

        public void Delete(PublishingBindingModel model)
        {
            using (var context = new BookStoreContext())
            {
                Publishing publishing = context.Publishings.FirstOrDefault(rec => rec.ID == model.ID);
                if (publishing != null)
                {
                    context.Publishings.Remove(publishing);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Publishing not found");
                }
            }
        }

        public List<PublishingViewModel> Read(PublishingBindingModel model)
        {
            using (var context = new BookStoreContext())
            {
                return context.Publishings
                    .Where(rec => model == null || rec.ID == model.ID)
                    .Select(rec => new PublishingViewModel
                    {
                        ID = rec.ID,
                        Name = rec.Name
                    })
                    .ToList();
            }
        }
    }
}
