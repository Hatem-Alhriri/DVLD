using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD.Tests.Test_Type
{
	public partial class frmListTestType : Form
	{
		private DataTable _dtAllTestTypes;

		public frmListTestType()
		{
			InitializeComponent();
		}

		private void frmListTestType_Load(object sender, EventArgs e)
		{
			_dtAllTestTypes = clsTestType.GetAllTestTypes();
			dgvTestTypes.DataSource = _dtAllTestTypes;
			lblRecordsCount.Text = dgvTestTypes.Rows.Count.ToString();

			if (dgvTestTypes.Rows.Count > 0)
			{
				dgvTestTypes.Columns[0].HeaderText = "ID";
				dgvTestTypes.Columns[0].Width = 120;

				dgvTestTypes.Columns[1].HeaderText = "Title";
				dgvTestTypes.Columns[1].Width = 200;

				dgvTestTypes.Columns[2].HeaderText = "Description";
				dgvTestTypes.Columns[2].Width = 400;

				dgvTestTypes.Columns[3].HeaderText = "Fees";
				dgvTestTypes.Columns[3].Width = 100;
			}

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmEditeTestType frm = new frmEditeTestType((clsTestType.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
			frmListTestType_Load(null, null);
		}
	}
}
