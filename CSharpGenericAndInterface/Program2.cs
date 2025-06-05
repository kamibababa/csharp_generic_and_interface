using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericAndInterface
{
    public class Program2
    {
        public static void Main()
        {
            var array = new MyArray<Student>();

            array.Add(new Student { Name = "Alice", Score = 90 });
            array.Add(new Student { Name = "Bob", Score = 70 });
            array.Add(new Student { Name = "Charlie", Score = 85 });

            Console.WriteLine("Before sort:");
            array.PrintAll();

            array.Sort();

            Console.WriteLine("\nAfter sort:");
            array.PrintAll();
        }
    }

}
