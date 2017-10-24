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
    public partial class NewUserDialog : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public NewUserDialog()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Login = tbxLogin.Text.Trim();
            Password = tbxPassword.Text;
            IsAdmin = cbxAdmin.Checked;

            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("用户名/密码不可为空！", "新建用户失败");
                return;
            }

            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }
    }
}
