using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project
{
    public partial class InventoryForm : Form
    {
        HospitalDBEntities4 db = new HospitalDBEntities4();
        Medicine _medicine = null;
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Medicines.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Medicines.Add(new Medicine()
            {
                
                Medicine_Name = textBox2.Text,
                Medicine_Salary = textBox3.Text,
                Expiry_Date = dateTimePicker1.Value,
                Production_Date = dateTimePicker2.Value,
            });
            db.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _medicine.Medicine_Name = textBox2.Text;
            _medicine.Medicine_Salary = textBox3.Text;
            _medicine.Expiry_Date = dateTimePicker1.Value;
            _medicine.Production_Date = dateTimePicker2.Value;
            db.SaveChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            db.Medicines.Remove(_medicine);
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);
            _medicine = db.Medicines.First(p1 => p1.Medicine_ID == ID);
            textBox2.Text = _medicine.Medicine_Name;
            textBox3.Text = _medicine.Medicine_Salary;
            dateTimePicker1.Text = _medicine.Expiry_Date.ToString();
            dateTimePicker2.Text = _medicine.Production_Date.ToString();

        }
    }
}
