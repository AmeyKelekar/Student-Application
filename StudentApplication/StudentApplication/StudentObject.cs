using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StudentApplication
{
    public class StudentObject
    {
        public string name;
        public Hashtable assignments = new Hashtable();
        public Double gpa;
        public StudentObject(String name, Hashtable assignments)
        {
            this.name = name;
            this.assignments = assignments;
        }

        public Double calculateGrade()
        {
            Double total = 0;
            foreach (DictionaryEntry data in assignments)
            {
                GradeValue grade = (GradeValue)Enum.Parse(typeof(GradeValue),(String)data.Value);
                Console.Write(grade);
                total = total + (double)grade;
            }
            gpa = total / assignments.Count;
            return gpa;
        }
    }

    public enum GradeValue
    {
        A = 4,        
        B = 3,
        C = 2
    }
}
