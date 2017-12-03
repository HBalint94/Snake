using SnakeWindowsFormsApplication.Model;
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
    partial class GameOverBox : Form
    {
        private SnakeGameModel _model;
        

        public GameOverBox(SnakeGameModel model)
        {
            InitializeComponent();
            _model = model;
        }
        public void okButton_Click(object sender,EventArgs e)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Balint\Desktop\snakeWinForm\Snake\result.txt", true))
            {
                file.WriteLine("nev: " + nameBox.Text + ", pont: " + _model.GameScore);
            }
            Close();
        }
        public void GameOverBox_Load(object sender,EventArgs e)
        {
            scoreLabel.Text = _model.GameScore.ToString();

        }

    }
}
