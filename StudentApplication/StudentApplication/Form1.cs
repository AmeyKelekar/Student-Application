using StudentApplication.Aggregate;
using StudentApplication.Iterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            label1.Text = "Please click View Overall grade button to view details";
        }
        IStudentApplication s = new Student();
        IIterator studentIterator;
        private void button1_Click(object sender, EventArgs e)
        {
            studentIterator = s.CreateIterator();            
            Printstudents(studentIterator);
        }

        public void Printstudents(IIterator iterate)
        {
            label1.Text = "Please click on View button to view assignment details";
            DataTable dt = new DataTable();
            DataColumn name = new DataColumn("Student Name");
            DataColumn grades = new DataColumn("GPA");
            dt.Columns.Add(name);
            dt.Columns.Add(grades);
            while(!iterate.IsDone()){
                StudentObject data =  iterate.Next();
                DataRow rw = dt.NewRow();
                rw["Student Name"] = data.name;
                rw["GPA"] = data.calculateGrade();
                dt.Rows.Add(rw);                           
                
            }
            dataGridView1.DataSource = dt;
            if (dataGridView1.ColumnCount < 3)
            {
                DataGridViewButtonColumn viewAssignments = new DataGridViewButtonColumn();
                viewAssignments.UseColumnTextForButtonValue = true;
                viewAssignments.Text = "View";
                viewAssignments.Name = "View Assignments";
                dataGridView1.Columns.Add(viewAssignments);
            }
            if (dt.Rows.Count > 0)
                dataGridView1.Visible = true;
            else
                label1.Text = "No records found for student";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void printAssignment(String student, IIterator iterate)
        {
            DataTable dt = new DataTable();           
            DataColumn assignment = new DataColumn("Assignment");
            DataColumn grade = new DataColumn("Grade");
            dt.Columns.Add(assignment);
            dt.Columns.Add(grade);
           
            while (!iterate.IsDone())
            {    
                StudentObject data = iterate.Next();
               
                label2.Text = student;
                if (data.name == student)
                {
                    Hashtable assigns = data.assignments;
                    foreach (DictionaryEntry assign in assigns)
                    {
                        DataRow rw = dt.NewRow();
                        rw["Assignment"] = assign.Key;
                        rw["Grade"] = assign.Value;
                        dt.Rows.Add(rw);
                    }
                }

            }
            dataGridView2.DataSource = dt;
            if (dt.Rows.Count > 0)
                dataGridView2.Visible = true;
            else
                label1.Text = "No records found for student";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0)
            {
                label3.Text = "Student Name: ";
                studentIterator = s.CreateIterator();
                printAssignment(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), studentIterator);
            }
        }
    }
}
