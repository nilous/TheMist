using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.IO;

namespace TheMist
{
    public partial class LoginDialog : Form
    {
        private MainForm _form;

        public LoginDialog(MainForm form)
        {
            _form = form;
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

            var ch = ConnectionHelper.Instance;
            ch.LoadSettings();
            tbxHost.Text = ch.Host;
            tbxDatabase.Text = ch.Database;
            tbxDbUser.Text = ch.User;
            tbxDbPassword.Text = ch.Password;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowSettingsPanel(!pnlSettings.Visible);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // DEBUG
            //_form.IsAdmin = true;
            //DialogResult = DialogResult.OK;
            //Dispose();
            //return;

            var ch = ConnectionHelper.Instance;
            ch.Host = tbxHost.Text.Trim();
            ch.User = tbxDbUser.Text.Trim();
            ch.Password = tbxDbPassword.Text;
            ch.Database = tbxDatabase.Text.Trim();

            if (string.IsNullOrWhiteSpace(ch.Host) || string.IsNullOrWhiteSpace(ch.User)
                || string.IsNullOrEmpty(ch.Password) || string.IsNullOrWhiteSpace(ch.Database))
            {
                if (!pnlSettings.Visible)
                    ShowSettingsPanel(true);
                MessageBox.Show("数据库设置不正确，请正确填写后再试。", "连接数据库失败");
                return;
            }

            // 保存数据库设置
            ch.SaveSettings();

            var user = tbxLogin.Text.Trim();
            var password = tbxPassword.Text;
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("登录账号/密码不可为空！", "登录失败");
                return;
            }

            try
            {
                using (var conn = ch.Connect())
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select id, is_disabled, is_admin from myuser where login=@l and password=@p";
                        cmd.Parameters.AddWithValue("l", user);
                        cmd.Parameters.AddWithValue("p", password);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("登录账号/密码错误，请再次确认或联系管理员。", "登录失败");
                                return;
                            }

                            var isDisabled = Convert.ToBoolean(reader[1]);
                            if (isDisabled)
                            {
                                MessageBox.Show("当前用户已被禁用，请联系管理员。", "登录失败");
                                return;
                            }

                            _form.UserID = Convert.ToInt32(reader[0]);
                            _form.IsAdmin = Convert.ToBoolean(reader[2]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"：{ex.Message}");
                return;
            }

            DialogResult = DialogResult.OK;
            Dispose();
        }

    }
}
