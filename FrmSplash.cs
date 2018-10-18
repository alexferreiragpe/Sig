using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SIG
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 100;
            progressBar1.Maximum = 100;
            timer1.Tick += new EventHandler(timer1_Tick);

        }
    }
}
