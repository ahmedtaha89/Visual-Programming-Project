using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class PatientForm : Form
    {
      HospitalDBEntities4   db = new HospitalDBEntities4();
       PATIENT _patient = null;
        public PatientForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.PATIENTs.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.PATIENTs.Add(new PATIENT()
            {

                Name = textBox2.Text,
                Gender = radioButton1.Checked || false,
                Birthdate = dateTimePicker1.Value,
                Smoking = checkBox1.Checked,
                Diabetes = checkBox2.Checked,
                Pressure_disease = checkBox3.Checked
            });
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);
            _patient = db.PATIENTs.First(p1 => p1.ID == ID);
            textBox2.Text = _patient.Name;
            if (_patient.Gender == true)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            dateTimePicker1.Value = Convert.ToDateTime(_patient.Birthdate);
            checkBox1.Checked = Convert.ToBoolean(_patient.Smoking);
            checkBox2.Checked = Convert.ToBoolean(_patient.Diabetes);
            checkBox3.Checked = Convert.ToBoolean(_patient.Pressure_disease);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _patient.Name = textBox2.Text;
            _patient.Birthdate = dateTimePicker1.Value;
            db.SaveChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            db.PATIENTs.Remove(_patient);
            db.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false; 
            radioButton2.Checked = false;
            checkBox1.Checked= false;
            checkBox2.Checked= false;
            checkBox3.Checked= false;
            dateTimePicker1.Value= DateTime.Now;

        }
    }
}
