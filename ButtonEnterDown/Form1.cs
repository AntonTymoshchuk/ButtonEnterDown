using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEnterDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(60, 60, 60);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 180, 180);
            button1.GotFocus += Button1_GotFocus;
            button1.LostFocus += Button1_LostFocus;
            button1.Click += Button1_Click;
        }
        
        private void Button1_GotFocus(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(120, 120, 120);
        }

        private void Button1_LostFocus(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
