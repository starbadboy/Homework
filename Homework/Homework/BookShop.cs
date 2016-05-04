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
            double discount = 0;
            if (distinctBook.Count == 2)
                discount = 0.05;
            else if(distinctBook.Count==3)
            {
                discount = 0.1;
            }
            else if (distinctBook.Count == 4)
            {
                discount = 0.2;
            }
            else if (distinctBook.Count == 5)
            {
                discount = 0.25;
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
