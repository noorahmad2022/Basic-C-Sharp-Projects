using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    class Employee<T1, T2, T3, T4>
    {
        public T1 ID { get; set; }
        public T2 firstName { get; set; }
        public T3 lastName { get; set; }
        public T4 things { get; set; }

    }
}
