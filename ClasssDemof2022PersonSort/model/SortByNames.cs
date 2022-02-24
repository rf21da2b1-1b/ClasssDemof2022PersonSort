using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssDemof2022PersonSort.model
{
    public class SortByNames: IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if (x == null || y == null)
            {
                return 0;
            }


            return x.Name.CompareTo(y.Name);
        }
    }
}
