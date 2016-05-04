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
    }
}