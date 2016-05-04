using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework.Tests
{
    [TestClass()]
    public class BookShopTests
    {
        [TestMethod()]
        public void GetTotalPriceTest_2_different_book_5percent_discount()
        {
            var bookCollection = new List<Book>
            {
                new Book { Id =1, Price=100 },
                new Book { Id =2, Price=100 },
                new Book { Id =3, Price=100 },
                new Book { Id =4, Price=100 },
                new Book { Id =5, Price=100 }
            };
            var booksTobuy = bookCollection.Where(m => m.Id == 1 || m.Id == 2).ToList() ; 
            var target = new BookShop();

            var actual = target.GetTotalPrice(booksTobuy);

            var expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTotalPriceTest_3_different_book_10percent_discount()
        {
            var bookCollection = new List<Book>
            {
                new Book { Id =1, Price=100 },
                new Book { Id =2, Price=100 },
                new Book { Id =3, Price=100 },
                new Book { Id =4, Price=100 },
                new Book { Id =5, Price=100 }
            };
            var booksTobuy = new List<Book>();
            booksTobuy.Add(bookCollection.Find(m => m.Id == 1));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 2));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 3));
            var target = new BookShop();

            var actual = target.GetTotalPrice(booksTobuy);

            var expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTotalPriceTest_4_different_book_20percent_discount()
        {
            var bookCollection = new List<Book>
            {
                new Book { Id =1, Price=100 },
                new Book { Id =2, Price=100 },
                new Book { Id =3, Price=100 },
                new Book { Id =4, Price=100 },
                new Book { Id =5, Price=100 }
            };
            var booksTobuy = new List<Book>();
            booksTobuy.Add(bookCollection.Find(m => m.Id == 1));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 2));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 3));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 5));
            var target = new BookShop();

            var actual = target.GetTotalPrice(booksTobuy);

            var expected = 320;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTotalPriceTest_5_different_book_25percent_discount()
        {
            var bookCollection = new List<Book>
            {
                new Book { Id =1, Price=100 },
                new Book { Id =2, Price=100 },
                new Book { Id =3, Price=100 },
                new Book { Id =4, Price=100 },
                new Book { Id =5, Price=100 }
            };
            var booksTobuy = new List<Book>();
            booksTobuy.Add(bookCollection.Find(m => m.Id == 1));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 2));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 3));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 4));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 5));
            var target = new BookShop();

            var actual = target.GetTotalPrice(booksTobuy);

            var expected = 375;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTotalPriceTest_4_books_3differentbook_10percent_discount_for_3different_book()
        {
            var bookCollection = new List<Book>
            {
                new Book { Id =1, Price=100 },
                new Book { Id =2, Price=100 },
                new Book { Id =3, Price=100 },
                new Book { Id =4, Price=100 },
                new Book { Id =5, Price=100 }
            };
            var booksTobuy = new List<Book>();
            booksTobuy.Add(bookCollection.Find(m => m.Id == 1));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 2));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 3));
            booksTobuy.Add(bookCollection.Find(m => m.Id == 1));
            var target = new BookShop();

            var actual = target.GetTotalPrice(booksTobuy);

            var expected = 370;
            Assert.AreEqual(expected, actual);
        }


    }
}