using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project
{
    public partial class EmployeeForm : Form
    {
        HospitalDBEntities4 db = new HospitalDBEntities4();
        Employee _employee = null;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            db.Employees.Add(new Employee()
            {
                Name = textBox2.Text,
                Gender = radioButton1.Checked || false,
                Phone = textBox3.Text,
                Address = textBox4.Text,
                Salary = textBox5.Text

            }) ; 
            db.SaveChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _employee.Name = textBox2.Text;
            _employee.Phone = textBox3.Text;
            _employee.Address = textBox4.Text;
            _employee.Salary = textBox5.Text;
            db.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.Employees.Remove(_employee);
            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(textBox1.Text);
            _employee = db.Employees.First(p1 => p1.ID == ID);
            textBox2.Text = _employee.Name;
            if (_employee.Gender == true)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            textBox3.Text = _employee.Phone;
            textBox4.Text = _employee.Address;
            textBox5.Text = _employee.Salary;   


        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
         
        }
    }
}
