using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITLibrary
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            DateTime actualDate = DateTime.Today.AddDays(-7);
            DateTime returnDate = DateTime.Today;
           

            TimeSpan t = actualDate - returnDate;
            int comp = (int) t.TotalDays;

            int x = (int)comp;
            decimal y = 2 * x;

            if (t.Days > 0)
            {
                y = 2 * t.Days;
                label1.Text = y.ToString();
            }
            else
            {
                label1.Text = "0";
            }


            


        }
    }
}
