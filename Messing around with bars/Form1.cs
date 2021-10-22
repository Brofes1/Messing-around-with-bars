using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messing_around_with_bars
{
    public partial class BarProgram : Form
    {
        int test2;
        public BarProgram()
        {
            InitializeComponent();
        }
        int max = 9;
        int maxinbar = 0;
        int Health = 10;
        int Healthinbar = 0;
        private void extraboxes(int test, int test2)
        {
            HPbigger.Value = test2 / 10;
            maxbigger.Value = test / 10;
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
            max++;
            maxinbar = max;
            maxinbar = maxinbar / 10;
            maxinbar = maxinbar * 10;
            maxinbar = max - maxinbar;
            if (maxinbar >= 0)
            {
                test.Value = (maxinbar * 10);
            }
            else
            {
                test.Value = 0;
            }
            maxdisplay.Text = max + "";
            othermaxdisplay.Text = maxinbar + "";
            extraboxes(max, Health);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out test2))
                Health = Health - test2;
            Healthinbar = Health;
            Healthinbar = Healthinbar / 10;
            Healthinbar = Healthinbar * 10;
            Healthinbar = Health - Healthinbar;
            if (Healthinbar >= 0)
            {
                HP.Value = (Healthinbar * 10);
            }
            else
            {
                HP.Value = 0;
            }
            extraboxes(max, Health);
            if (Health <= 0)
            {
                textBox1.Text = "Dead";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBox1.Text, out test2))
                Health = Health + test2;
            if (Health > max)
            {
                Health = max;
            }
            Healthinbar = Health;
            Healthinbar = Healthinbar / 10;
            Healthinbar = Healthinbar * 10;
            Healthinbar = Health - Healthinbar;
            if (Healthinbar >= 0)
            {
                HP.Value = (Healthinbar * 10);
            }
            else
            {
                HP.Value = 0;
            }
            extraboxes(max, Health);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool debugmode = checkBox1.Checked;
            if (debugmode == true)
            {
                label2.Visible = true;
                maxdisplay.Visible = true;
                label3.Visible = true;
                othermaxdisplay.Visible = true;
            }
            else
            {
                label2.Visible = false;
                maxdisplay.Visible = false;
                label3.Visible = false;
                othermaxdisplay.Visible = false;
            }
        }
    }
}
