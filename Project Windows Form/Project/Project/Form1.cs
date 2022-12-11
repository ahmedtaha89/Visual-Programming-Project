using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void emploToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addPitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PatientForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PatientForm().ShowDialog();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EmployeeForm().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new InventoryForm().ShowDialog();
        }

        private void addMedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventoryForm().ShowDialog();
        }
    }
}
