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
    public partial class OptEditDialog : Form
    {
        private List<string> _opts;

        public OptEditDialog(List<string> opts)
        {
            _opts = opts;
            InitializeComponent();
        }

        private void OptEditDialog_Load(object sender, EventArgs e)
        {
            Helpers.AutoSizeColumn(dgvOpts);
            foreach (var opt in _opts)
            {
                var index = dgvOpts.Rows.Add();
                dgvOpts.Rows[index].Cells[0].Value = opt;
            }
        }

        private void btnAddOpt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxOptContent.Text))
                return;


            var index = dgvOpts.Rows.Add();
            dgvOpts.Rows[index].Cells[0].Value = tbxOptContent.Text;
            tbxOptContent.Text = "";
        }

        private void btnRemoveOpt_Click(object sender, EventArgs e)
        {
            if (dgvOpts.SelectedCells.Count == 0)
                return;

            dgvOpts.Rows.RemoveAt(dgvOpts.SelectedCells[0].RowIndex);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _opts.Clear();

            for (var i = 0; i < dgvOpts.Rows.Count; i++)
            {
                var opt = dgvOpts.Rows[i].Cells[0].Value.ToString();
                _opts.Add(opt);
            }

            DialogResult = DialogResult.OK;
            Dispose();
        }
    }
}
