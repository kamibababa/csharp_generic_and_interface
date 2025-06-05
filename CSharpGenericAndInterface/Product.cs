using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericAndInterface
{
    internal class Product
    {
        protected int Id { set; get; }
        protected int Stock { set; get; }
        protected string Name { set; get; }

        public Product(int id, int stock, string name)
        {
            Id = id;
            Stock = stock;
            Name = name;
        }

        public void addStock(int n)
        {
            Stock += n;
        }

        public virtual void display()
        {
            Console.WriteLine($"{Name} {Stock}");
        }
    }
}
