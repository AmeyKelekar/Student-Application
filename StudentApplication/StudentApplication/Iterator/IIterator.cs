using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Iterator
{
    public interface IIterator
    {
        void First();
        StudentObject Next();
        bool IsDone();
        StudentObject CurrentItem();
    }
}
