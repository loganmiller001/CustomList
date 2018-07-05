using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
}
