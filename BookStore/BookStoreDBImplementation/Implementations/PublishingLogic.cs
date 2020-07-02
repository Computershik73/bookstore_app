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
        private readonly BookStoreContext context;

        public PublishingLogic(BookStoreContext context)
        {
            this.context = context;
        }

        public void CreateOrUpdate(PublishingBindingModel model)
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

        public void Delete(PublishingBindingModel model)
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

        public List<PublishingViewModel> Read(PublishingBindingModel model)
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

        public List<PublishingViewModel> ReadPage(int skip, int take)
        {
            return context.Publishings.Skip(skip).Take(take).Select(rec =>
            new PublishingViewModel
            {
                ID = rec.ID,
                Name = rec.Name
            }).ToList();
        }
    }
}
