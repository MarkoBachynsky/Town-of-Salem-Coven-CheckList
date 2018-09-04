using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TownOfSalemCovenCheckList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            foreach (Control c in Controls)
            {
                ChangeButtonColor(c);
            } */
        }

        public void ChangeButtonColor(Control myControl)
        {
            if (myControl is Button)
            {
                myControl.BackColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
        }

        private void ChangeColorTown(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.Black)
                button.BackColor = Color.Lime;
            else if (button.BackColor == Color.Lime)
                button.BackColor = Color.Black;
            label1.Focus();
        }

        private void ChangeColorMafia(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.Black)
                button.BackColor = Color.Fuchsia;
            else if (button.BackColor == Color.Fuchsia)
                button.BackColor = Color.Black;
            label1.Focus();
        }

        private void ChangeColorNeutral(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.Black)
                button.BackColor = Color.White;
            else if (button.BackColor == Color.White)
                button.BackColor = Color.Black;
            label1.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Button)
                    control.BackColor = Color.Black;
            }
            label1.Focus();
        }
    }




}
