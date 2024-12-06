using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_5_pr2
{
    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
}
