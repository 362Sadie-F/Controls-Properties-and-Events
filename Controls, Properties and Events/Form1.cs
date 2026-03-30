using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls__Properties_and_Events
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            imgCharacter.Visible = true;
            lblStatus.Text = "Status: Clicked";
            btnQuit.Visible = true;   
            this.BackColor = Color.Black;
            this.ForeColor = Color.DarkRed;
            //lblInstruction.Font = 
        }

        private void btnSubmit_ForeColorChanged(object sender, EventArgs e)
        {
            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {
            
        }
    }
}
