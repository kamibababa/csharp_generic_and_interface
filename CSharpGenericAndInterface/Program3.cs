using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericAndInterface
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            MyIntArray array = new MyIntArray();
            array.Add(1);
            array.Add(31);
            array.Add(3);
            array.Sort();
            array.PrintAll();

        }
    }
}
