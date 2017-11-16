namespace TheMist
{
    partial class OptEditDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvOpts = new System.Windows.Forms.DataGridView();
            this.opt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxOptContent = new System.Windows.Forms.TextBox();
            this.btnAddOpt = new System.Windows.Forms.Button();
            this.btnRemoveOpt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(731, 480);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(117, 42);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "保存修改";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(566, 480);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvOpts
            // 
            this.dgvOpts.AllowUserToAddRows = false;
            this.dgvOpts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpts.ColumnHeadersVisible = false;
            this.dgvOpts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opt});
            this.dgvOpts.Location = new System.Drawing.Point(26, 79);
            this.dgvOpts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOpts.Name = "dgvOpts";
            this.dgvOpts.RowHeadersVisible = false;
            this.dgvOpts.RowTemplate.Height = 30;
            this.dgvOpts.Size = new System.Drawing.Size(822, 385);
            this.dgvOpts.TabIndex = 7;
            // 
            // opt
            // 
            this.opt.HeaderText = "选项内容";
            this.opt.Name = "opt";
            // 
            // tbxOptContent
            // 
            this.tbxOptContent.Location = new System.Drawing.Point(26, 25);
            this.tbxOptContent.Margin = new System.Windows.Forms.Padding(4);
            this.tbxOptContent.Name = "tbxOptContent";
            this.tbxOptContent.Size = new System.Drawing.Size(682, 33);
            this.tbxOptContent.TabIndex = 8;
            // 
            // btnAddOpt
            // 
            this.btnAddOpt.Location = new System.Drawing.Point(731, 18);
            this.btnAddOpt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddOpt.Name = "btnAddOpt";
            this.btnAddOpt.Size = new System.Drawing.Size(117, 42);
            this.btnAddOpt.TabIndex = 9;
            this.btnAddOpt.Text = "添加选项";
            this.btnAddOpt.UseVisualStyleBackColor = true;
            this.btnAddOpt.Click += new System.EventHandler(this.btnAddOpt_Click);
            // 
            // btnRemoveOpt
            // 
            this.btnRemoveOpt.Location = new System.Drawing.Point(26, 480);
            this.btnRemoveOpt.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveOpt.Name = "btnRemoveOpt";
            this.btnRemoveOpt.Size = new System.Drawing.Size(170, 42);
            this.btnRemoveOpt.TabIndex = 10;
            this.btnRemoveOpt.Text = "删除选中选项";
            this.btnRemoveOpt.UseVisualStyleBackColor = true;
            this.btnRemoveOpt.Click += new System.EventHandler(this.btnRemoveOpt_Click);
            // 
            // OptEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.btnRemoveOpt);
            this.Controls.Add(this.btnAddOpt);
            this.Controls.Add(this.tbxOptContent);
            this.Controls.Add(this.dgvOpts);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OptEditDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑数据选项";
            this.Load += new System.EventHandler(this.OptEditDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvOpts;
        private System.Windows.Forms.DataGridViewTextBoxColumn opt;
        private System.Windows.Forms.TextBox tbxOptContent;
        private System.Windows.Forms.Button btnAddOpt;
        private System.Windows.Forms.Button btnRemoveOpt;
    }
}