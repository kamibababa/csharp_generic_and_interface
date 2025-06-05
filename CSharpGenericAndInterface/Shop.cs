using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericAndInterface
{
    internal class Shop
    {
        static void Main(string[] args)
        {
            //Book book = new Book("lisi", 2, 100, "huozhe");
            Product book = new Book("lisi", 2, 100, "huozhe");
            book.addStock(100);
            book.display();
        }
    }
}
