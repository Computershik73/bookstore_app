using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreDBImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreDBImplementation.Implementations
{
    public class AuthorLogic : IAuthorLogic
    {
        private readonly BookStoreContext context;

        public AuthorLogic(BookStoreContext context)
        {
            this.context = context;
        }

        public void CreateOrUpdate(AuthorBindingModel model)
        {
            Author author = context.Authors.FirstOrDefault(rec =>
            rec.FirstName == model.FirstName && rec.LastName == model.LastName && rec.ID != model.ID);
            if (author != null)
            {
                throw new Exception("Author is already exist");
            }
            if (model.ID.HasValue)
            {
                author = context.Authors.FirstOrDefault(rec => rec.ID == model.ID);
                if (author == null)
                {
                    throw new Exception("Author not found");
                }
            }
            else
            {
                author = new Author();
                context.Authors.Add(author);
            }
            author.FirstName = model.FirstName;
            author.LastName = model.LastName;
            context.SaveChanges();
        }

        public void Delete(AuthorBindingModel model)
        {
            Author author = context.Authors.FirstOrDefault(rec => rec.ID == model.ID);
            if (author != null)
            {
                context.Authors.Remove(author);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Author not found");
            }
        }

        public List<AuthorViewModel> Read(AuthorBindingModel model)
        {
            return context.Authors
                .Where(rec => model == null || rec.ID == model.ID)
                .Select(rec => new AuthorViewModel
                {
                    ID = rec.ID,
                    FirstName = rec.FirstName,
                    LastName = rec.LastName
                })
                .ToList();
        }

        public List<AuthorViewModel> ReadPage(int skip, int take)
        {
            return context.Authors
            .Skip(skip).Take(take).Select(rec =>
            new AuthorViewModel
            {
                ID = rec.ID,
                FirstName = rec.FirstName,
                LastName = rec.LastName
            })
            .ToList();
        }
    }
}
