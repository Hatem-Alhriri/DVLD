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

namespace MyDVLD.Applications.Application_Types
{
	public partial class frmListApplications : Form
	{
		private DataTable _dtAllApplicationType;
		public frmListApplications()
		{
			InitializeComponent();
		}

		private void frmListApplications_Load(object sender, EventArgs e)
		{
			_dtAllApplicationType = clsApplicationType.GetAllApplicationTypes();
			dgvApplicationTypes.DataSource = _dtAllApplicationType;
			lblRecordsCount.Text = dgvApplicationTypes.Rows.Count.ToString();

			dgvApplicationTypes.Columns[0].HeaderText = "ID";
			dgvApplicationTypes.Columns[0].Width = 110;


			dgvApplicationTypes.Columns[1].HeaderText = "Title";
			dgvApplicationTypes.Columns[1].Width = 400;

			dgvApplicationTypes.Columns[2].HeaderText = "Fees";
			dgvApplicationTypes.Columns[2].Width = 100;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			frmEditeApplicationType frm = new frmEditeApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
			frmListApplications_Load(null, null);
		}
	}
}
