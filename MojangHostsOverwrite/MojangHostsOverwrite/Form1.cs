using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojangHostsOverwrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Background.Visible = !Background.Visible;
            labelAuth.BackColor = Background.Visible ? Color.FromArgb(238, 51, 59) : Color.Transparent;
            labelAuthIP1.BackColor = Background.Visible ? Color.FromArgb(238, 51, 59) : Color.Transparent;
            labelButton.BackColor = Background.Visible ? Color.FromArgb(238, 51, 59) : Color.Transparent;

        }
    }
}
