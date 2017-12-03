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
    partial class ResultBox : Form
    {

        public ResultBox()
        {
            InitializeComponent();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Balint\Desktop\snakeWinForm\Snake\result.txt");
        
            foreach (string line in lines)
            {
                resultList.Items.Add(line);
            }
        }

        private void CloseButton_Click(Object sender,EventArgs e)
        {
            Close();
        }


    }
}
