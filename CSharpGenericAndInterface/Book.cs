using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericAndInterface
{
    internal class Book : Product
    {
        public string Author { set; get; }

        public Book(string author, int id, int stock, string name):base(id, stock, name)
        {
            Author = author;
        }

        public override void display()
        {
            Console.Write($"{Author} ");
            base.display();
        }
    }
}
