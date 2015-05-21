using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Iterator
{
    public class StudentIterator:IIterator
    {
        private LinkedList<StudentObject> students;
        private int position;

        public StudentIterator(LinkedList<StudentObject> students)
        {
            this.students = students;
            position = 0;
        }
        public void First()
        {
            position = 0;
        }

        public StudentObject Next()
        {
            return students.ElementAt(position++);
        }

        public bool IsDone()
        {
            return position >= students.Count;
        }

        public StudentObject CurrentItem()
        {
            return students.ElementAt(position);
        }
    }
}
