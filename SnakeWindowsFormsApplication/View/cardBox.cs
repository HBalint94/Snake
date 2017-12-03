using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeWindowsFormsApplication.View
{
    partial class cardBox : Form
    {
        public cardBox()
        {
            InitializeComponent();
           
        }

        public void ExitButton_Click(Object sender,EventArgs e)
        {
            Close();
        }

      

       
    }
}
