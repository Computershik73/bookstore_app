using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreDBImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookStoreDBImplementation.Implementations
{
    public class BookLogic : IBookLogic
    {
        private readonly BookStoreContext context;
        public BookLogic(BookStoreContext context)
        {
            this.context = context;
        }

        public void CreateOrUpdate(BookBindingModel model)
        {
            Book book = context.Books.FirstOrDefault(rec =>
            rec.Title == model.Title
            && rec.AuthorID == model.AuthorID
            && rec.PublishingID == model.PublishingID
            && rec.PublicationYear == model.PublicationYear
            && rec.ID != model.ID);
            if (book != null)
            {
                throw new Exception("Book is already exist");
            }
            if (model.ID.HasValue)
            {
                book = context.Books.FirstOrDefault(rec => rec.ID == model.ID);
                if (book == null)
                {
                    throw new Exception("Book not found");
                }
            }
            else
            {
                book = new Book();
                context.Books.Add(book);
            }
            book.Title = model.Title;
            book.AuthorID = model.AuthorID;
            book.Genre = model.Genre;
            book.PublicationYear = model.PublicationYear;
            book.PublishingID = model.PublishingID;
            book.CostOfPurchase = model.CostOfPurchase;
            context.SaveChanges();
        }

        public void Delete(BookBindingModel model)
        {
            Book book = context.Books.FirstOrDefault(rec => rec.ID == model.ID);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Book not found");
            }
        }

        public List<BookViewModel> Read(BookBindingModel model)
        {
            return context.Books
                .Include(rec => rec.Author)
                .Include(rec => rec.Publishing)
                .Where(rec => model == null || rec.ID == model.ID
                || rec.PublicationYear > model.PublicationYear 
                && rec.AuthorID == model.AuthorID)
                .Select(rec => new BookViewModel
                {
                    ID = rec.ID,
                    Title = rec.Title,
                    Author = rec.Author.FirstName + " " + rec.Author.LastName,
                    Publishing = rec.Publishing.Name,
                    Genre = rec.Genre,
                    PublicationYear = rec.PublicationYear,
                    Price = rec.Price,
                    CostOfPurchase = rec.CostOfPurchase
                })
                .ToList();
        }

        public List<BookViewModel> ReadPage(int skip, int take)
        {
            return context.Books.Include(rec => rec.Author)
            .Include(rec => rec.Publishing).Skip(skip).Take(take).Select(rec =>
            new BookViewModel
            {
                ID = rec.ID,
                Title = rec.Title,
                Author = rec.Author.FirstName + " " + rec.Author.LastName,
                Publishing = rec.Publishing.Name,
                Genre = rec.Genre,
                PublicationYear = rec.PublicationYear,
                Price = rec.Price,
                CostOfPurchase = rec.CostOfPurchase
            })
            .ToList();
        }
    }
}
