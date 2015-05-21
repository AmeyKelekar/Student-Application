using StudentApplication.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StudentApplication.Aggregate
{
    public class Student:IStudentApplication
    {
        private LinkedList<StudentObject> students;

        public Student()
        {
            students = new LinkedList<StudentObject>();
            
            System.Collections.Hashtable a1 = new Hashtable();
            a1.Add("Assignment1", "A");
            a1.Add("Assignment2", "A");
            a1.Add("Assignment3", "A");

            System.Collections.Hashtable a2 = new Hashtable();
            a2.Add("Assignment1", "A");
            a2.Add("Assignment2", "B");
            a2.Add("Assignment3", "B");
            
            System.Collections.Hashtable a3 = new Hashtable();
            a3.Add("Assignment1", "B");
            a3.Add("Assignment2", "B");
            a3.Add("Assignment3", "C");
            
            System.Collections.Hashtable a4 = new Hashtable();
            a4.Add("Assignment1", "A");
            a4.Add("Assignment2", "A");
            a4.Add("Assignment3", "B");
            
            System.Collections.Hashtable a5 = new Hashtable();
            a5.Add("Assignment1", "A");
            a5.Add("Assignment2", "B");
            a5.Add("Assignment3", "C");
            
            System.Collections.Hashtable a6 = new Hashtable();
            a6.Add("Assignment1", "C");
            a6.Add("Assignment2", "B");
            a6.Add("Assignment3", "C");
            
            students.AddLast(new StudentObject("Amey", a1));
            students.AddLast(new StudentObject("Deryl", a2));
            students.AddLast(new StudentObject("Jibin", a3));
            students.AddLast(new StudentObject("Sabrish", a4));
            students.AddLast(new StudentObject("Praveen", a5));
            students.AddLast(new StudentObject("Neville", a6));
        }

        public Iterator.IIterator CreateIterator()
        {
            return new StudentIterator(students);
        }
    }
}
