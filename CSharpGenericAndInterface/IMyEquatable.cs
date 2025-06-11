using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericAndInterface
{
    public interface IMyEquatable<T>
    {
        bool Equals(T? other);
    }
}
