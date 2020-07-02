using BookStoreBusinessLogic.BindingModels;
using BookStoreDBImplementation;
using BookStoreDBImplementation.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookStoreContext())
            {
                //ShowAddresses(context);
                //ShowAuthors(context);
                //ShowBooks(context);
                //ShowCustomers(context);
                //ShowOrders(context);
                //ShowPublishings(context);
                //ShowWarehouses(context);
                //GetBooksByAuthor("George Orwell", 2010, context);
                //GetBooksOrders(DateTime.Parse("2020-05-28"), context);
                //GetBooksWarehouses("1984", context);
                //AddBooks(context);
                //GetPages(context);

            }
            Console.ReadLine();
        }

        public static void GetPages(BookStoreContext context)
        {
            OrderLogic orderLogic = new OrderLogic(context);
            var orders = orderLogic.ReadPage(0, 4);
            foreach (var order in orders)
            {
                Console.WriteLine(order.CustomerName + " "
                    + order.PlacementDate + " " + order.Status);
            }
            Console.WriteLine();
            AuthorLogic authorLogic = new AuthorLogic(context);
            var authors = authorLogic.ReadPage(0, 4);
            foreach (var author in authors)
            {
                Console.WriteLine(author.FirstName + " " + author.LastName);
            }
            Console.WriteLine();
        }

        public static void AddBooks(BookStoreContext context)
        {
            DateTime begin = DateTime.Now;
            WarehouseLogic warehouseLogic = new WarehouseLogic(context);
            Dictionary<int, int> books = new Dictionary<int, int>
            {
                { 3, 10 },
                { 5, 8 }
            };
            warehouseLogic.Resupply(new ResupplyWarehouseBindingModel
            {
                WarehouseID = 2,
                Books = books
            });
            DateTime end = DateTime.Now;
            int ms = Convert.ToInt32((end - begin).TotalMilliseconds);
            Console.WriteLine(ms);
        }

        public static void ShowAddresses(BookStoreContext context)
        {
            DateTime begin = DateTime.Now;
            AddressLogic addressLogic = new AddressLogic(context);
            var addresses = addressLogic.Read(null);
            DateTime end = DateTime.Now;
            int ms = Convert.ToInt32((end - begin).TotalMilliseconds);
            Console.WriteLine("Addresses:");
            foreach (var address in addresses)
            {
                Console.WriteLine(address.Country + " "
                    + address.State + " " + address.City
                    + " " + address.Street + " "
                    + address.Building + " " + address.ZipPostalCode);
            }
            Console.WriteLine();
            Console.WriteLine(ms);
        }

        public static void ShowAuthors(BookStoreContext context)
        {
            DateTime begin = DateTime.Now;
            Console.WriteLine("Authors:");
            AuthorLogic authorLogic = new AuthorLogic(context);
            var authors = authorLogic.Read(null);
            foreach (var author in authors)
            {
                Console.WriteLine(author.FirstName + " " + author.LastName);
            }
            Console.WriteLine();
            DateTime end = DateTime.Now;
            int ms = Convert.ToInt32((end - begin).TotalMilliseconds);
            Console.WriteLine(ms);
        }

        public static void ShowBooks(BookStoreContext context)
        {
            DateTime begin = DateTime.Now;
            BookLogic bookLogic = new BookLogic(context);
            var books = bookLogic.Read(null);
            Console.WriteLine("Books:");
            foreach (var book in books)
            {
                Console.WriteLine(book.Author + " " 
                    + book.Title + " " + book.Publishing 
                    + " " + book.Genre + " " + book.PublicationYear 
                    + " " + book.CostOfPurchase);
            }
            Console.WriteLine();
            DateTime end = DateTime.Now;
            int ms = Convert.ToInt32((end - begin).TotalMilliseconds);
            Console.WriteLine(ms);
        }

        public static void ShowCustomers(BookStoreContext context)
        {
            DateTime begin = DateTime.Now;
            CustomerLogic customerLogic = new CustomerLogic(context);
            var customers = customerLogic.Read(null);
            Console.WriteLine("Customers:");
            foreach(var customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " 
                    + customer.LastName + " " 
                    + customer.PhoneNumber + " "
                    + customer.Email);
            }
            Console.WriteLine();
            DateTime end = DateTime.Now;
            int ms = Convert.ToInt32((end - begin).TotalMilliseconds);
            Console.WriteLine(ms);
        }

        public static void ShowOrders(BookStoreContext context)
        {
            DateTime begin = DateTime.Now;
            OrderLogic orderLogic = new OrderLogic(context);
            var orders = orderLogic.Read(null);
            Console.WriteLine("Orders:");
            foreach(var order in orders)
            {
                Console.WriteLine(order.CustomerName + " " 
                    + order.PlacementDate + " " + order.Status);
            }
            Console.WriteLine();
            DateTime end = DateTime.Now;
            int ms = Convert.ToInt32((end - begin).TotalMilliseconds);
            Console.WriteLine(ms);
        }

        public static void ShowPublishings(BookStoreContext context)
        {
            DateTime begin = DateTime.Now;
            PublishingLogic publishingLogic = new PublishingLogic(context);
            var publishings = publishingLogic.Read(null);
            Console.WriteLine("Publishings:");
            foreach(var publishing in publishings)
            {
                Console.WriteLine(publishing.Name);
            }
            Console.WriteLine();
            DateTime end = DateTime.Now;
            int ms = Convert.ToInt32((end - begin).TotalMilliseconds);
            Console.WriteLine(ms);
        }

        public static void ShowWarehouses(BookStoreContext context)
        {
            DateTime begin = DateTime.Now;
            WarehouseLogic warehouseLogic = new WarehouseLogic(context);
            var warehouses = warehouseLogic.Read(null);
            Console.WriteLine("Warehouses:");
            foreach (var warehouse in warehouses)
            {
                Console.WriteLine(warehouse.Name + " " + warehouse.Capacity);
            }
            Console.WriteLine();
            DateTime end = DateTime.Now;
            int ms = Convert.ToInt32((end - begin).TotalMilliseconds);
            Console.WriteLine(ms);
        }

        public static void GetBooksByAuthor(string author, int year, BookStoreContext context)
        {
            DateTime begin = DateTime.Now;
            var books = context.Books.Join(context.Authors,
                b => b.AuthorID,
                a => a.ID,
                (b, a) => new
                {
                    BookTitle = b.Title,
                    BookAuthor = a.FirstName + " " + a.LastName,
                    BookYear = b.PublicationYear
                }).Where(book => book.BookAuthor == author && book.BookYear > year);
            DateTime end = DateTime.Now;
            int ms = Convert.ToInt32((end - begin).TotalMilliseconds);
            Console.WriteLine(ms);
            Console.WriteLine("Books by author:" + author + " where pub. year > " + year);
            foreach (var book in books)
            {
                Console.WriteLine(book.BookTitle + " " 
                    + book.BookAuthor + " " + book.BookYear);
            }
            Console.WriteLine();
        }

        public static void GetBooksOrders(DateTime date, BookStoreContext context)
        {
            DateTime begin = DateTime.Now;
            var groupBooks = context.Books.Join(context.OrderBooks,
                b => b.ID,
                ob => ob.BookID,
                (b, ob) => new
                {
                    BookTitle = b.Title,
                    BookCount = ob.Count,
                    OrderDate = context.Orders
                    .FirstOrDefault(order =>
                    order.ID == ob.OrderID).PlacementDate
                }).Where(ordBook => ordBook.OrderDate.Date == date.Date)
                .GroupBy(o => o.BookTitle).Select(rec => new
                {
                    Title = rec.Key,
                    Count = rec.Sum(s => s.BookCount),
                });
            DateTime end = DateTime.Now;
            int ms = Convert.ToInt32((end - begin).TotalMilliseconds);
            Console.WriteLine(ms);
            Console.WriteLine("Count of books in orders dated: " + date.ToShortDateString());
            foreach (var g in groupBooks)
            {
                Console.WriteLine(g.Title + " " + g.Count);
            }
            Console.WriteLine();
        }

        public static void GetBooksWarehouses(string title, BookStoreContext context)
        {
            DateTime begin = DateTime.Now;
            var books = context.Books.Join(context.BookWarehouses,
                b => b.ID,
                bw => bw.BookID,
                (b, bw) => new
                {
                    Warehouse = context.Warehouses
                    .FirstOrDefault(w => w.ID
                    == bw.WarehouseID).Name,
                    BookTitle = b.Title,
                    BookCount = bw.Count
                }).Where(book => book.BookTitle.Equals(title));
            DateTime end = DateTime.Now;
            int ms = Convert.ToInt32((end - begin).TotalMilliseconds);
            Console.WriteLine(ms);
            Console.WriteLine(title + " books left in warehouses");
            foreach (var book in books)
            {
                Console.WriteLine(book.Warehouse + " " + book.BookCount);
            }
            Console.WriteLine();
        }
    }
}
