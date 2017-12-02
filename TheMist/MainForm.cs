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
using System.Diagnostics;

namespace TheMist
{
    public partial class MainForm : Form
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public bool IsAdmin { get; set; } = false;

        public string SystemName { get; set; }
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
        public string Item5 { get; set; }
        public List<string> Item1Opts = new List<string>();
        public List<string> Item2Opts = new List<string>();

        private bool _editingUser = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var loginDialog = new LoginDialog(this);
            if (loginDialog.ShowDialog() != DialogResult.OK)
            {
                Dispose();
                return;
            }

            WindowState = FormWindowState.Maximized;

            // 删除需要管理员权限的标签
            if (!IsAdmin)
            {
                tabControl1.TabPages.RemoveAt(2);
                tabControl1.TabPages.RemoveAt(2);

                dgvQueryResults.Columns[1].Visible = false;
                btnUpload.Visible = btnRm.Visible = false;
            }

            

            var type = IsAdmin ? "管理员" : "普通用户";
            toolStripStatusLabel1.Text = $"当前用户: {Login} [{type}]";

            using (var conn = ConnectionHelper.Instance.Connect())
            {
                conn.Open();

                // 读系统信息
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from mysys";

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            if (IsAdmin)
                            {
                                tabControl1.SelectedIndex = 2;
                                MessageBox.Show("请先进行系统设置。", "系统尚未设置");
                            }
                            else
                            {
                                MessageBox.Show("请先使用管理员账号进行系统设置。", "系统尚未设置");
                            }
                            return;
                        }

                        SystemName = reader[0].ToString();
                        Item1 = reader[1].ToString();
                        Item2 = reader[2].ToString();
                        Item3 = reader[3].ToString();
                        Item4 = reader[4].ToString();
                        Item5 = reader[5].ToString();
                    }
                }

                // 读数据项1选项
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from item1opt";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Item1Opts.Add(reader[0].ToString());
                        }
                    }
                }

                // 读数据项2选项
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from item2opt";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Item2Opts.Add(reader[0].ToString());
                        }
                    }
                }
            }

            UpdateSysInfo();

            cbxLimit.SelectedIndex = 0;
        }

        private void UpdateSysInfo()
        {
            Text = string.IsNullOrEmpty(SystemName) ? "MyApp" : SystemName;

            lblItem1.Text = Item1;
            lblItem1.AutoSize = true;
            lblItem2.Text = Item2;
            lblItem2.AutoSize = true;
            //lblItem3.Text = Item3;
            //lblItem3.AutoSize = true;
            //gbxItem3.Text = Item3;
            lblItem3.Text = Item3;
            lblItem4.Text = Item4;
            lblItem5.Text = Item5;

            lblQueryItem1.Text = Item1;
            lblQueryItem1.AutoSize = true;

            cbxItem1.Items.Clear();
            cbxItem1.Items.AddRange(Item1Opts.ToArray());
            if (cbxItem1.Items.Count != 0)
                cbxItem1.SelectedIndex = 0;

            cbxItem2.Items.Clear();
            cbxItem2.Items.AddRange(Item2Opts.ToArray());
            if (cbxItem2.Items.Count != 0)
                cbxItem2.SelectedIndex = 0;

            cbxQueryItem1.Items.Clear();
            cbxQueryItem1.Items.AddRange(Item1Opts.ToArray());
            cbxQueryItem1.Items.Add("不限");
            if (cbxQueryItem1.Items.Count != 0)
                cbxQueryItem1.SelectedIndex = 0;


            dgvQueryResults.Columns[3].HeaderText = Item1;
            dgvQueryResults.Columns[4].HeaderText = Item2;
            dgvQueryResults.Columns[5].HeaderText = Item3;
            dgvQueryResults.Columns[6].HeaderText = Item4; // $"{Item3}_2";
            dgvQueryResults.Columns[7].HeaderText = Item5; // $"{Item3}_3";
        }


        private void btnEditOpt1_Click(object sender, EventArgs e)
        {
            var optEditDialog = new OptEditDialog(Item1Opts);

            if (optEditDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var conn = ConnectionHelper.Instance.Connect())
                    {
                        conn.Open();

                        // 删除之前选项
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "delete from item1opt";
                            cmd.ExecuteNonQuery();
                        }

                        // 插入各选项
                        foreach (var opt in Item1Opts)
                        {
                            using (var cmd = new NpgsqlCommand())
                            {
                                cmd.Connection = conn;
                                cmd.CommandText = "insert into item1opt(content) values (@c)";
                                cmd.Parameters.AddWithValue("c", opt);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (NpgsqlException)
                {

                }

                UpdateSysInfo();
            }
        }

        private void btnEditOpt2_Click(object sender, EventArgs e)
        {
            var optEditDialog = new OptEditDialog(Item2Opts);

            if (optEditDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var conn = ConnectionHelper.Instance.Connect())
                    {
                        conn.Open();

                        // 删除之前选项
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "delete from item2opt";
                            cmd.ExecuteNonQuery();
                        }

                        // 插入各选项
                        foreach (var opt in Item2Opts)
                        {
                            using (var cmd = new NpgsqlCommand())
                            {
                                cmd.Connection = conn;
                                cmd.CommandText = "insert into item2opt(content) values (@c)";
                                cmd.Parameters.AddWithValue("c", opt);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (NpgsqlException)
                {

                }

                UpdateSysInfo();
            }
        }

        private void btnEditSys_Click(object sender, EventArgs e)
        {
            var name = tbxSysName.Text.Trim();
            var item1 = tbxItem1Title.Text.Trim();
            var item2 = tbxItem2Title.Text.Trim();
            var item3 = tbxItem3Title.Text.Trim();
            var item4 = tbxItem4Title.Text.Trim();
            var item5 = tbxItem5Title.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(item1) 
                || string.IsNullOrEmpty(item2) || string.IsNullOrEmpty(item3))
            {
                MessageBox.Show("请完整填写上面内容", "更改系统设置失败");
                return;
            }

            try
            {
                using (var conn = ConnectionHelper.Instance.Connect())
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "delete from mysys";
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "insert into mysys values(@n, @x, @y, @z, @a, @b)";
                        cmd.Parameters.AddWithValue("n", name);
                        cmd.Parameters.AddWithValue("x", item1);
                        cmd.Parameters.AddWithValue("y", item2);
                        cmd.Parameters.AddWithValue("z", item3);
                        cmd.Parameters.AddWithValue("a", item4);
                        cmd.Parameters.AddWithValue("b", item5);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
                return;
            }

            SystemName = name;
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            UpdateSysInfo();

            MessageBox.Show("系统设置更新成功！", "操作成功");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 系统设置
            if (tabControl1.SelectedIndex == 2)
            {
                tbxSysName.Text = SystemName;
                tbxItem1Title.Text = Item1;
                tbxItem2Title.Text = Item2;
                tbxItem3Title.Text = Item3;
                tbxItem4Title.Text = Item4;
                tbxItem5Title.Text = Item5;
            }
            // 用户管理
            else if (tabControl1.SelectedIndex == 3)
            {
                _editingUser = false;
                dgvUsers.Rows.Clear();
                try
                {
                    using (var conn = ConnectionHelper.Instance.Connect())
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "select id, login, is_admin, is_disabled from myuser";

                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var index = dgvUsers.Rows.Add();
                                    dgvUsers.Rows[index].Cells[0].Value = reader[0];
                                    dgvUsers.Rows[index].Cells[1].Value = reader[1];
                                    dgvUsers.Rows[index].Cells[2].Value = reader[2];
                                    dgvUsers.Rows[index].Cells[3].Value = reader[3];

                                    // 当前用户
                                    if (Convert.ToInt32(reader[0]) == UserID)
                                    {
                                        dgvUsers.Rows[index].ReadOnly = true;
                                        //dgvUsers.Rows[index].DefaultCellStyle.SelectionBackColor = Color.LightGray;
                                        dgvUsers.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
                                        
                                    }
                                }
                            }
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message, "读取用户列表失败");
                    return;
                }

                Helpers.AutoSizeColumn(dgvUsers);
                _editingUser = true;
            }
            // 共享文件
            else if (tabControl1.SelectedIndex == 4)
            {
                RefreshFileList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = ConnectionHelper.Instance.Connect())
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "insert into info(user_id, item1, item2, item3, item3_2, item3_3) values(@user, @x, @y, @u, @v, @w)";
                        cmd.Parameters.AddWithValue("user", UserID);
                        cmd.Parameters.AddWithValue("x", cbxItem1.Text);
                        cmd.Parameters.AddWithValue("y", cbxItem2.Text);
                        cmd.Parameters.AddWithValue("u", tbxItem3.Text.Trim());
                        cmd.Parameters.AddWithValue("v", tbxItem3_2.Text.Trim());
                        cmd.Parameters.AddWithValue("w", tbxItem3_3.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {

            }

            tbxItem3.Text = "";
            tbxItem3_2.Text = "";
            tbxItem3_3.Text = "";
            MessageBox.Show("数据成功写入数据库", "操作成功");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dgvQueryResults.Rows.Clear();

            try
            {
                using (var conn = ConnectionHelper.Instance.Connect())
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        var cmdText = "select info.id, item1, item2, item3, login, created_at, item3_2, item3_3 from info, myuser where myuser.id = info.user_id and created_at >= @b::timestamp and created_at <= @e::timestamp";

                        if (cbxQueryItem1.SelectedIndex != cbxQueryItem1.Items.Count - 1)
                            cmdText += $" and item1 = @x";

                        // 非管理员只能查询自己录入的数据
                        if (!IsAdmin)
                            cmdText += $" and user_id = {UserID} ";

                        if (cbxLimit.SelectedIndex != 3)
                        {
                            int limit = 10;
                            switch (cbxLimit.SelectedIndex)
                            {
                                case 0: limit = 10; break;
                                case 1: limit = 100; break;
                                case 2: limit = 1000; break;
                            }
                            cmdText += $" limit {limit}";
                        }
                        cmd.CommandText = cmdText;
                        //MessageBox.Show(cmd.CommandText);
                        //MessageBox.Show(cbxQueryItem1.Text);

                        if (cbxQueryItem1.SelectedIndex != cbxQueryItem1.Items.Count - 1)
                            cmd.Parameters.AddWithValue("x", cbxQueryItem1.Text);
                        cmd.Parameters.AddWithValue("b", dtpBegin.Value.ToString("yyyy-MM-dd 00:00:00"));
                        cmd.Parameters.AddWithValue("e", dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59"));

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var index = dgvQueryResults.Rows.Add();
                                dgvQueryResults.Rows[index].Cells[0].Value = Convert.ToInt32(reader[0]);
                                dgvQueryResults.Rows[index].Cells[3].Value = reader[1].ToString();
                                dgvQueryResults.Rows[index].Cells[4].Value = reader[2].ToString();
                                dgvQueryResults.Rows[index].Cells[5].Value = reader[3].ToString();
                                dgvQueryResults.Rows[index].Cells[1].Value = reader[4].ToString();
                                dgvQueryResults.Rows[index].Cells[2].Value = reader[5].ToString();
                                dgvQueryResults.Rows[index].Cells[6].Value = reader[6].ToString();
                                dgvQueryResults.Rows[index].Cells[7].Value = reader[7].ToString();
                            }
                        }
                    }
                }

                //dtpBegin.Value.ToShortDateString();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败");
                return;
            }

            if (dgvQueryResults.Rows.Count == 0)
            {
                MessageBox.Show("没有符合条件的数据记录！", "查询完毕");
            }
            else
            {
                Helpers.AutoSizeColumn(dgvQueryResults);
                dgvQueryResults.Columns[0].Width = 60;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvQueryResults.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show("确认删除选中记录？", "删除记录", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;

            //MessageBox.Show(dgvQueryResults.SelectedRows[0].Index.ToString());
            try
            {
                using (var conn = ConnectionHelper.Instance.Connect())
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "delete from info where id=@i";

                        var index = dgvQueryResults.SelectedRows[0].Index;
                        cmd.Parameters.AddWithValue("i", dgvQueryResults.Rows[index].Cells[0].Value);
                        cmd.ExecuteNonQuery();

                        dgvQueryResults.Rows.RemoveAt(index);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败");
                return;
            }
        }

        private static string CellValueToString(string cellValue)
        {
            var spliter = new string[1];
            spliter[0] = Environment.NewLine;
            var contents = cellValue.Split(spliter, StringSplitOptions.None).ToList();
            var r = string.Join(" ", contents);
            return r;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "(*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    var title = $"id, 用户, 录入时间, {Item1}, {Item2}, {Item3}, {Item4}, {Item5}" + Environment.NewLine;

                    using (var w = new BinaryWriter(fs))
                    {
                        var bytes = Encoding.GetEncoding("GBK").GetBytes(title);
                        w.Write(bytes, 0, bytes.Length);

                        for (var i = 0; i < dgvQueryResults.Rows.Count; i++)
                        {
                            var row = dgvQueryResults.Rows[i];
                            /*
                            var content = row.Cells[5].Value.ToString();
                            var spliter = new string[1];
                            spliter[0] = Environment.NewLine;
                            var contents = content.Split(spliter, StringSplitOptions.None).ToList();
                            var r = string.Join(" ", contents);
                            */
                            var i3 = CellValueToString(row.Cells[5].Value.ToString()).Replace(',', '，');
                            var i3_2 = CellValueToString(row.Cells[6].Value.ToString()).Replace(',', '，');
                            var i3_3 = CellValueToString(row.Cells[7].Value.ToString()).Replace(',', '，');

                            var s = $"{row.Cells[0].Value}, {row.Cells[1].Value}, {row.Cells[2].Value}, {row.Cells[3].Value}, {row.Cells[4].Value}, {i3}, {i3_2}, {i3_3}" + Environment.NewLine;
                            //s = s.Replace(',', '，');

                            bytes = Encoding.GetEncoding("GBK").GetBytes(s);
                            w.Write(bytes, 0, bytes.Length);
                        }
                    }
                }

                MessageBox.Show($"文件保存至：{sfd.FileName}", "导出数据成功");
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            var newUserDialog = new NewUserDialog();
            if (newUserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var conn = ConnectionHelper.Instance.Connect())
                    {
                        conn.Open();

                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "insert into myuser(login, password, is_admin) values(@l, @p, @a) returning id";
                            cmd.Parameters.AddWithValue("l", newUserDialog.Login);
                            cmd.Parameters.AddWithValue("p", newUserDialog.Password);
                            cmd.Parameters.AddWithValue("a", newUserDialog.IsAdmin);
                            //cmd.ExecuteNonQuery();
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    var id = Convert.ToInt32(reader[0]);

                                    var index = dgvUsers.Rows.Add();
                                    dgvUsers.Rows[index].Cells[0].Value = id;
                                    dgvUsers.Rows[index].Cells[1].Value = newUserDialog.Login;
                                    dgvUsers.Rows[index].Cells[2].Value = newUserDialog.IsAdmin;
                                    dgvUsers.Rows[index].Cells[3].Value = false;
                                }
                            }
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message, "新增用户失败");
                    return;
                }
            }

            
        }

        private void dgvUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!_editingUser || (e.ColumnIndex != 2 && e.ColumnIndex != 3))
                return;

            using (var conn = ConnectionHelper.Instance.Connect())
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    var f = (e.ColumnIndex == 2) ? "is_admin" : "is_disabled";
                    
                    cmd.CommandText = $"update myuser set {f} = @b where id = @i";
                    cmd.Parameters.AddWithValue("b", dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    cmd.Parameters.AddWithValue("i", Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value));
                    cmd.ExecuteNonQuery();
                }
            }

        }

        private void dgvUsers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvUsers.IsCurrentCellDirty)
            {
                dgvUsers.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
                return;

            var index = dgvUsers.SelectedRows[0].Index;
            var user = dgvUsers.Rows[index].Cells[1].Value.ToString();

            var editPasswordDialog = new EditPasswordDialog(user);
            if (editPasswordDialog.ShowDialog() == DialogResult.OK)
            {
                var newPassword = editPasswordDialog.NewPassword;

                try
                {
                    using (var conn = ConnectionHelper.Instance.Connect())
                    {
                        conn.Open();

                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = $"update myuser set password=@p where login=@l";
                            cmd.Parameters.AddWithValue("p", newPassword);
                            cmd.Parameters.AddWithValue("l", user);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message, "修改密码失败");
                    return;
                }

                MessageBox.Show($"用户 {user} 的密码已经修改！", "操作成功");
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            // 重设 Tab Control 尺寸
            tabControl1.Width = Width - tabControl1.Left - 30;
            tabControl1.Height = Height - tabControl1.Top - 80;

            // 录入画面
            cbxItem1.Width = cbxItem2.Width = Width - cbxItem1.Left - 80;
            tbxItem3.Width = tbxItem3_2.Width = tbxItem3_3.Width = cbxItem1.Width;

            var totalHeight = Height - tbxItem3.Top - 160;
            var height = (totalHeight - 40) / 3;

            tbxItem3.Height = tbxItem3_2.Height = tbxItem3_3.Height = height;
            lblItem4.Top = tbxItem3_2.Top = tbxItem3.Top + tbxItem3.Height + 10;
            lblItem5.Top = tbxItem3_3.Top = tbxItem3_2.Top + tbxItem3_2.Height + 10;

            btnSave.Top = tbxItem3_3.Top + tbxItem3_3.Height + 10;
            btnSave.Left = tbxItem3.Left + tbxItem3.Width - btnSave.Width;

            /*
            gbxItem3.Width = Width - gbxItem3.Left - 80;
            tbxItem3.Width = tbxItem3_2.Width = tbxItem3_3.Width = gbxItem3.Width - tbxItem3.Left - 20;

            var totalHeight = Height - gbxItem3.Top - 160;
            gbxItem3.Height = totalHeight;
            var height = (totalHeight - 100) / 3;
            tbxItem3.Height = tbxItem3_2.Height = tbxItem3_3.Height = height;
            tbxItem3_2.Top = tbxItem3.Top + tbxItem3.Height + 20;
            tbxItem3_3.Top = tbxItem3_2.Top + tbxItem3_2.Height + 20;

            btnSave.Top = gbxItem3.Top + gbxItem3.Height + 5;
            btnSave.Left = gbxItem3.Left + gbxItem3.Width - btnSave.Width;
            */

            // 查询画面
            btnQuery.Left = tabControl1.Left + tabControl1.Width - btnQuery.Width - 40;

            cbxQueryItem1.Width = btnQuery.Left - cbxQueryItem1.Left- 20;
            label7.Left = btnQuery.Left;
            cbxLimit.Left = label7.Left + label7.Width + 30;

            dgvQueryResults.Width = btnQuery.Left + btnQuery.Width - dgvQueryResults.Left;
            dgvQueryResults.Height = Height - (btnQuery.Top + btnQuery.Height) - 180;

            button1.Top = dgvQueryResults.Top + dgvQueryResults.Height + 5;
            btnExport.Top = button1.Top;
            btnExport.Left = dgvQueryResults.Left + dgvQueryResults.Width - btnExport.Width;

            // 系统设定
            groupBox1.Width = Width - groupBox1.Left - 80;
            groupBox1.Height = Height - groupBox1.Top - 160;

            tbxSysName.Width = groupBox1.Left + groupBox1.Width - tbxSysName.Left;

            btnEditOpt1.Left = btnEditOpt2.Left = groupBox1.Left + groupBox1.Width - btnEditOpt1.Width - 40;
            tbxItem1Title.Width = tbxItem2Title.Width = tbxItem3Title.Width = tbxItem4Title.Width = tbxItem5Title.Width = btnEditOpt1.Left - tbxItem1Title.Left - 20;

            btnEditSys.Top = groupBox1.Top + groupBox1.Height + 5;
            btnEditSys.Left = groupBox1.Left + groupBox1.Width - btnEditSys.Width;

            // 用户管理
            dgvUsers.Width = Width - dgvUsers.Left - 60;
            dgvUsers.Height = Height - dgvUsers.Top - 160;

            btnNewUser.Top = dgvUsers.Top + dgvUsers.Height + 5;
            button5.Top = btnNewUser.Top;
            button5.Left = dgvUsers.Left + dgvUsers.Width - button5.Width;

            // 共享文件
            dgvFiles.Width = Width - dgvFiles.Left - 60;
            dgvFiles.Height = Height - dgvFiles.Top - 160;

            btnUpload.Top = btnRm.Top = btnRefresh.Top = btnDownload.Top = dgvFiles.Top + dgvFiles.Height + 5;
            btnDownload.Left = dgvFiles.Left + dgvFiles.Width - btnDownload.Width;
            btnRefresh.Left = btnDownload.Left - btnRefresh.Width - 20;
        }

        private void RefreshFileList()
        {
            dgvFiles.Rows.Clear();

            using (var conn = ConnectionHelper.Instance.Connect())
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select name from mydoc";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var index = dgvFiles.Rows.Add();
                            dgvFiles.Rows[index].Cells[0].Value = reader[0].ToString();
                        }
                    }
                }
            }

            Helpers.AutoSizeColumn(dgvFiles);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] bytes;
                try
                {
                    using (var fs = new FileStream(ofd.FileName, FileMode.Open))
                    {
                        using (var reader = new BinaryReader(fs))
                        {
                            var fileInfo = new FileInfo(ofd.FileName);
                            var len = Convert.ToInt32(fileInfo.Length);  // FIXME:
                            bytes = reader.ReadBytes(len);
                        }
                    }

                    using (var conn = ConnectionHelper.Instance.Connect())
                    {
                        conn.Open();

                        var fn = Path.GetFileName(ofd.FileName);
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = $"insert into mydoc(name, content) values(@n, @c)";
                            cmd.Parameters.AddWithValue("n", fn);
                            cmd.Parameters.AddWithValue("c", bytes);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"上传文件出错：{ex.Message}");
                    return;
                }
            }

            MessageBox.Show($"文件 {ofd.FileName} 上传成功！");
            RefreshFileList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFileList();
        }

        private void btnRm_Click(object sender, EventArgs e)
        {
            if (dgvFiles.SelectedRows.Count == 0)
                return;

            var row = dgvFiles.SelectedRows[0].Index;
            var fn = dgvFiles.Rows[row].Cells[0].Value.ToString();

            if (MessageBox.Show($"确定删除文件 {fn} 吗？", "删除共享文件", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;

            try
            {
                using (var conn = ConnectionHelper.Instance.Connect())
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "delete from mydoc where name=@n";

                        cmd.Parameters.AddWithValue("n", fn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除文件出错：{ex.Message}");
                return;
            }

            RefreshFileList();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (dgvFiles.SelectedRows.Count == 0)
                return;

            var index = dgvFiles.SelectedRows[0].Index;
            var fn = dgvFiles.Rows[index].Cells[0].Value.ToString();
            var ext = Path.GetExtension(fn);

            var sfd = new SaveFileDialog();
            sfd.FileName = fn;
            sfd.Filter = $"(*{ext})|{ext}";
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            byte[] bytes;
            try
            {
                using (var conn = ConnectionHelper.Instance.Connect())
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select content from mydoc where name=@n";
                        cmd.Parameters.AddWithValue("n", fn);

                        using (var reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            bytes = (byte[])reader[0];
                        }
                    }
                }

                using (var fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(fs))
                    {
                        writer.Write(bytes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"下载文件出错: {ex.Message}");
                return;
            }
        }

        private void dgvFiles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var fn = dgvFiles.Rows[e.RowIndex].Cells[0].Value.ToString();

            byte[] bytes;
            try
            {
                using (var conn = ConnectionHelper.Instance.Connect())
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select content from mydoc where name=@n";
                        cmd.Parameters.AddWithValue("n", fn);

                        using (var reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            bytes = (byte[])reader[0];
                        }
                    }
                }

                var fullPath = Path.GetTempPath() + Path.DirectorySeparatorChar + fn;
                if (File.Exists(fullPath))
                    File.Delete(fullPath);
                using (var fs = new FileStream(fullPath, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(fs))
                    {
                        writer.Write(bytes);
                    }
                }

                var process = new Process();
                process.StartInfo.FileName = fullPath;
                process.StartInfo.Verb = "Open";
                process.StartInfo.CreateNoWindow = true;
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开文件出错: {ex.Message}");
                return;
            }
        }
    }
}
