namespace TheMist
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbxItem3 = new System.Windows.Forms.GroupBox();
            this.tbxItem3_3 = new System.Windows.Forms.TextBox();
            this.tbxItem3_2 = new System.Windows.Forms.TextBox();
            this.tbxItem3 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxItem2 = new System.Windows.Forms.ComboBox();
            this.cbxItem1 = new System.Windows.Forms.ComboBox();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxLimit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvQueryResults = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cbxQueryItem1 = new System.Windows.Forms.ComboBox();
            this.lblQueryItem1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tpSys = new System.Windows.Forms.TabPage();
            this.btnEditSys = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditOpt2 = new System.Windows.Forms.Button();
            this.btnEditOpt1 = new System.Windows.Forms.Button();
            this.tbxItem3Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxItem2Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxItem1Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSysName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpUser = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRm = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxItem3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResults)).BeginInit();
            this.tpSys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpSys);
            this.tabControl1.Controls.Add(this.tpUser);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 505);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbxItem3);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.cbxItem2);
            this.tabPage1.Controls.Add(this.cbxItem1);
            this.tabPage1.Controls.Add(this.lblItem2);
            this.tabPage1.Controls.Add(this.lblItem1);
            this.tabPage1.Location = new System.Drawing.Point(8, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据录入";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbxItem3
            // 
            this.gbxItem3.Controls.Add(this.tbxItem3_3);
            this.gbxItem3.Controls.Add(this.tbxItem3_2);
            this.gbxItem3.Controls.Add(this.tbxItem3);
            this.gbxItem3.Location = new System.Drawing.Point(39, 146);
            this.gbxItem3.Name = "gbxItem3";
            this.gbxItem3.Size = new System.Drawing.Size(783, 273);
            this.gbxItem3.TabIndex = 13;
            this.gbxItem3.TabStop = false;
            this.gbxItem3.Text = "数据项3";
            // 
            // tbxItem3_3
            // 
            this.tbxItem3_3.Location = new System.Drawing.Point(18, 189);
            this.tbxItem3_3.Multiline = true;
            this.tbxItem3_3.Name = "tbxItem3_3";
            this.tbxItem3_3.Size = new System.Drawing.Size(746, 67);
            this.tbxItem3_3.TabIndex = 2;
            // 
            // tbxItem3_2
            // 
            this.tbxItem3_2.Location = new System.Drawing.Point(17, 116);
            this.tbxItem3_2.Multiline = true;
            this.tbxItem3_2.Name = "tbxItem3_2";
            this.tbxItem3_2.Size = new System.Drawing.Size(746, 67);
            this.tbxItem3_2.TabIndex = 1;
            // 
            // tbxItem3
            // 
            this.tbxItem3.Location = new System.Drawing.Point(17, 43);
            this.tbxItem3.Multiline = true;
            this.tbxItem3.Name = "tbxItem3";
            this.tbxItem3.Size = new System.Drawing.Size(746, 67);
            this.tbxItem3.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(705, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "录入";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxItem2
            // 
            this.cbxItem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem2.FormattingEnabled = true;
            this.cbxItem2.Location = new System.Drawing.Point(161, 93);
            this.cbxItem2.Name = "cbxItem2";
            this.cbxItem2.Size = new System.Drawing.Size(661, 37);
            this.cbxItem2.TabIndex = 10;
            // 
            // cbxItem1
            // 
            this.cbxItem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem1.FormattingEnabled = true;
            this.cbxItem1.Location = new System.Drawing.Point(161, 42);
            this.cbxItem1.Name = "cbxItem1";
            this.cbxItem1.Size = new System.Drawing.Size(661, 37);
            this.cbxItem1.TabIndex = 9;
            // 
            // lblItem2
            // 
            this.lblItem2.AutoSize = true;
            this.lblItem2.Location = new System.Drawing.Point(35, 96);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(118, 30);
            this.lblItem2.TabIndex = 7;
            this.lblItem2.Text = "数据项2";
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Location = new System.Drawing.Point(35, 45);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(118, 30);
            this.lblItem1.TabIndex = 6;
            this.lblItem1.Text = "数据项1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.cbxLimit);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnExport);
            this.tabPage2.Controls.Add(this.dgvQueryResults);
            this.tabPage2.Controls.Add(this.btnQuery);
            this.tabPage2.Controls.Add(this.cbxQueryItem1);
            this.tabPage2.Controls.Add(this.lblQueryItem1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dtpEnd);
            this.tabPage2.Controls.Add(this.dtpBegin);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(8, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "删除选中项";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxLimit
            // 
            this.cbxLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLimit.FormattingEnabled = true;
            this.cbxLimit.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "不限"});
            this.cbxLimit.Location = new System.Drawing.Point(682, 26);
            this.cbxLimit.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLimit.Name = "cbxLimit";
            this.cbxLimit.Size = new System.Drawing.Size(144, 37);
            this.cbxLimit.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "查询条数";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(166, 434);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "批量删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(690, 434);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(136, 32);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "导出CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvQueryResults
            // 
            this.dgvQueryResults.AllowUserToAddRows = false;
            this.dgvQueryResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column11,
            this.Column12});
            this.dgvQueryResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQueryResults.Location = new System.Drawing.Point(22, 115);
            this.dgvQueryResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQueryResults.Name = "dgvQueryResults";
            this.dgvQueryResults.RowHeadersVisible = false;
            this.dgvQueryResults.RowTemplate.Height = 30;
            this.dgvQueryResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueryResults.Size = new System.Drawing.Size(804, 311);
            this.dgvQueryResults.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "用户";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "录入时间";
            this.Column10.Name = "Column10";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "数据项1";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "数据项2";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "数据项3";
            this.Column4.Name = "Column4";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "数据项3_2";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "数据项3_3";
            this.Column12.Name = "Column12";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(578, 67);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(248, 32);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cbxQueryItem1
            // 
            this.cbxQueryItem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQueryItem1.FormattingEnabled = true;
            this.cbxQueryItem1.Location = new System.Drawing.Point(111, 71);
            this.cbxQueryItem1.Margin = new System.Windows.Forms.Padding(4);
            this.cbxQueryItem1.Name = "cbxQueryItem1";
            this.cbxQueryItem1.Size = new System.Drawing.Size(403, 37);
            this.cbxQueryItem1.TabIndex = 5;
            // 
            // lblQueryItem1
            // 
            this.lblQueryItem1.AutoSize = true;
            this.lblQueryItem1.Location = new System.Drawing.Point(18, 74);
            this.lblQueryItem1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQueryItem1.Name = "lblQueryItem1";
            this.lblQueryItem1.Size = new System.Drawing.Size(118, 30);
            this.lblQueryItem1.TabIndex = 4;
            this.lblQueryItem1.Text = "数据项1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "-";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(334, 22);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(180, 41);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(111, 22);
            this.dtpBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(180, 41);
            this.dtpBegin.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "日期";
            // 
            // tpSys
            // 
            this.tpSys.Controls.Add(this.btnEditSys);
            this.tpSys.Controls.Add(this.groupBox1);
            this.tpSys.Controls.Add(this.tbxSysName);
            this.tpSys.Controls.Add(this.label4);
            this.tpSys.Location = new System.Drawing.Point(8, 44);
            this.tpSys.Name = "tpSys";
            this.tpSys.Size = new System.Drawing.Size(842, 453);
            this.tpSys.TabIndex = 2;
            this.tpSys.Text = "系统设定";
            this.tpSys.UseVisualStyleBackColor = true;
            // 
            // btnEditSys
            // 
            this.btnEditSys.Location = new System.Drawing.Point(709, 407);
            this.btnEditSys.Name = "btnEditSys";
            this.btnEditSys.Size = new System.Drawing.Size(117, 32);
            this.btnEditSys.TabIndex = 4;
            this.btnEditSys.Text = "保存修改";
            this.btnEditSys.UseVisualStyleBackColor = true;
            this.btnEditSys.Click += new System.EventHandler(this.btnEditSys_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditOpt2);
            this.groupBox1.Controls.Add(this.btnEditOpt1);
            this.groupBox1.Controls.Add(this.tbxItem3Title);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxItem2Title);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxItem1Title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 272);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据项设定";
            // 
            // btnEditOpt2
            // 
            this.btnEditOpt2.Location = new System.Drawing.Point(672, 106);
            this.btnEditOpt2.Name = "btnEditOpt2";
            this.btnEditOpt2.Size = new System.Drawing.Size(117, 32);
            this.btnEditOpt2.TabIndex = 7;
            this.btnEditOpt2.Text = "编辑选项";
            this.btnEditOpt2.UseVisualStyleBackColor = true;
            this.btnEditOpt2.Click += new System.EventHandler(this.btnEditOpt2_Click);
            // 
            // btnEditOpt1
            // 
            this.btnEditOpt1.Location = new System.Drawing.Point(672, 46);
            this.btnEditOpt1.Name = "btnEditOpt1";
            this.btnEditOpt1.Size = new System.Drawing.Size(117, 32);
            this.btnEditOpt1.TabIndex = 6;
            this.btnEditOpt1.Text = "编辑选项";
            this.btnEditOpt1.UseVisualStyleBackColor = true;
            this.btnEditOpt1.Click += new System.EventHandler(this.btnEditOpt1_Click);
            // 
            // tbxItem3Title
            // 
            this.tbxItem3Title.Location = new System.Drawing.Point(148, 174);
            this.tbxItem3Title.Margin = new System.Windows.Forms.Padding(4);
            this.tbxItem3Title.Name = "tbxItem3Title";
            this.tbxItem3Title.Size = new System.Drawing.Size(494, 41);
            this.tbxItem3Title.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据项3名称";
            // 
            // tbxItem2Title
            // 
            this.tbxItem2Title.Location = new System.Drawing.Point(148, 110);
            this.tbxItem2Title.Margin = new System.Windows.Forms.Padding(4);
            this.tbxItem2Title.Name = "tbxItem2Title";
            this.tbxItem2Title.Size = new System.Drawing.Size(494, 41);
            this.tbxItem2Title.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据项2名称";
            // 
            // tbxItem1Title
            // 
            this.tbxItem1Title.Location = new System.Drawing.Point(148, 50);
            this.tbxItem1Title.Margin = new System.Windows.Forms.Padding(4);
            this.tbxItem1Title.Name = "tbxItem1Title";
            this.tbxItem1Title.Size = new System.Drawing.Size(494, 41);
            this.tbxItem1Title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据项1名称";
            // 
            // tbxSysName
            // 
            this.tbxSysName.Location = new System.Drawing.Point(140, 26);
            this.tbxSysName.Name = "tbxSysName";
            this.tbxSysName.Size = new System.Drawing.Size(660, 41);
            this.tbxSysName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "系统名称";
            // 
            // tpUser
            // 
            this.tpUser.Controls.Add(this.button5);
            this.tpUser.Controls.Add(this.btnNewUser);
            this.tpUser.Controls.Add(this.dgvUsers);
            this.tpUser.Location = new System.Drawing.Point(8, 44);
            this.tpUser.Name = "tpUser";
            this.tpUser.Size = new System.Drawing.Size(842, 453);
            this.tpUser.TabIndex = 3;
            this.tpUser.Text = "用户管理";
            this.tpUser.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(565, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(269, 32);
            this.button5.TabIndex = 10;
            this.button5.Text = "更改选中用户密码";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(17, 414);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(117, 32);
            this.btnNewUser.TabIndex = 7;
            this.btnNewUser.Text = "新增用户";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvUsers.Location = new System.Drawing.Point(17, 13);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 37;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(817, 395);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellValueChanged);
            this.dgvUsers.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvUsers_CurrentCellDirtyStateChanged);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "用户名";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "管理员";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "禁用";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRefresh);
            this.tabPage3.Controls.Add(this.btnDownload);
            this.tabPage3.Controls.Add(this.dgvFiles);
            this.tabPage3.Controls.Add(this.btnRm);
            this.tabPage3.Controls.Add(this.btnUpload);
            this.tabPage3.Location = new System.Drawing.Point(8, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(842, 453);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "共享文件";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRm
            // 
            this.btnRm.Location = new System.Drawing.Point(143, 429);
            this.btnRm.Name = "btnRm";
            this.btnRm.Size = new System.Drawing.Size(146, 32);
            this.btnRm.TabIndex = 2;
            this.btnRm.Text = "删除选定文件";
            this.btnRm.UseVisualStyleBackColor = true;
            this.btnRm.Click += new System.EventHandler(this.btnRm_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(15, 429);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(110, 32);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "上传文件";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 35);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(328, 30);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.ColumnHeadersVisible = false;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13});
            this.dgvFiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFiles.Location = new System.Drawing.Point(15, 14);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowHeadersVisible = false;
            this.dgvFiles.RowTemplate.Height = 37;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(813, 404);
            this.dgvFiles.TabIndex = 3;
            this.dgvFiles.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellContentDoubleClick);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(594, 424);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(221, 32);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "下载选定文件";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(468, 424);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Column13
            // 
            this.Column13.HeaderText = "文件名";
            this.Column13.Name = "Column13";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxItem3.ResumeLayout(false);
            this.gbxItem3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResults)).EndInit();
            this.tpSys.ResumeLayout(false);
            this.tpSys.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tpSys;
        private System.Windows.Forms.TabPage tpUser;
        private System.Windows.Forms.ComboBox cbxItem2;
        private System.Windows.Forms.ComboBox cbxItem1;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxSysName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.ComboBox cbxQueryItem1;
        private System.Windows.Forms.Label lblQueryItem1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvQueryResults;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnEditOpt2;
        private System.Windows.Forms.Button btnEditOpt1;
        private System.Windows.Forms.TextBox tbxItem3Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxItem2Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxItem1Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditSys;
        private System.Windows.Forms.ComboBox cbxLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox gbxItem3;
        private System.Windows.Forms.TextBox tbxItem3_3;
        private System.Windows.Forms.TextBox tbxItem3_2;
        private System.Windows.Forms.TextBox tbxItem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRm;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}

