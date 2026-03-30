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
        }

        private void btnSubmit_ForeColorChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkRed;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
