using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostSploit_V3
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 1;
            if (panel2.Width >= 510)
            {
                timer1.Stop();
                Nebula frm = new Nebula();
                frm.Show();
                this.Hide();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

