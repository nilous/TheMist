using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMist
{
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void ShowSettingsPanel(bool show)
        {
            pnlSettings.Visible = show;
            if (show)
                Height += pnlSettings.Height;
            else
                Height -= pnlSettings.Height;
        }

        private void LoginDialog_Load(object sender, EventArgs e)
        {
            ShowSettingsPanel(false);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowSettingsPanel(!pnlSettings.Visible);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
