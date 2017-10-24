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
    public partial class EditPasswordDialog : Form
    {
        private string _user;
        public string NewPassword { get; set; }

        public EditPasswordDialog(string user)
        {
            _user = user;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var newPassword = tbxNewPassword.Text;
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("新密码不可为空！", "重设密码错误");
                return;
            }

            NewPassword = newPassword;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void EditPasswordDialog_Load(object sender, EventArgs e)
        {
            lblInfo.Text = $"重新设置用户 {_user} 的密码:";
        }
    }
}
