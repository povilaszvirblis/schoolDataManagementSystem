using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDataManagementSystem
{
    public partial class Form1 : Form
    {
        private DatabaseDataManager manager = new DatabaseDataManager(new StudentEntity());

        public Form1()
        {
            InitializeComponent();
        }

        private void averageButton_Click(object sender, EventArgs e)
        {

        }

        private void hoursButton_Click(object sender, EventArgs e)
        {

        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            manager.PerformSelect();
           // Dictionary<string, string> dictionary = manager.ParameterDictionary;
           // dictionary["id"] = "39507043580";
           // manager.PerformDelete(dictionary);
        }

        private void guardiansButton_Click(object sender, EventArgs e)
        {

        }

        private void teachersButton_Click(object sender, EventArgs e)
        {

        }

        private void coursesButton_Click(object sender, EventArgs e)
        {

        }

        private void lessonsButton_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
