using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AITLibrary
{
    public partial class MyForm : Form
    {
        public static int staticUserID;
        public static string staticUserName;
        public static int staticUserLevelCode;
        public static string staticUserLevelDescription;
        public static string staticUserPassword;


        public MyForm()
        {
            InitializeComponent();
        }
    }
}
