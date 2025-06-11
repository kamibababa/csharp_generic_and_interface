using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericAndInterface
{
    public class Student : IMyComparable<Student>, IMyEquatable<Student>
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public int CompareTo(Student other)
        {
            return this.Score.CompareTo(other.Score); // 升序
        }

        public bool Equals(Student? other)
        {
            return this.Name.Equals(other?.Name) && this.Score == other?.Score;
        }

        public override string ToString() => $"{Name}: {Score}";
    }

}
