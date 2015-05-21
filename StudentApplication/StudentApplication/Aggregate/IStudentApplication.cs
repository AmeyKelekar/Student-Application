using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApplication.Iterator;

namespace StudentApplication.Aggregate
{
    public interface IStudentApplication
    {
        IIterator CreateIterator();
    }
}
