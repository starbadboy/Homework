using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework
{
    public class BookShop
    {

        public double GetTotalPrice(List<Book> booksTobuy)
        {
            var distinctBook = booksTobuy.Distinct().ToList();
            double discount;
            if (distinctBook.Count == 2)
                discount = 0.05;
            else
            {
                discount = 0;
            }
            double Totalprice=0;
            foreach(var book in booksTobuy)
            {
                if(!distinctBook.Contains(book))
                {
                    Totalprice += book.Price;
                }
                Totalprice += book.Price * (1 - discount);
            }
            return Totalprice;
        }
    }
}
