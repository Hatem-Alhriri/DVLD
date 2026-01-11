namespace MyDVLD.Applications.Application_Types
{
	partial class frmListApplications
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pbApplicationTypesmage = new System.Windows.Forms.PictureBox();
			this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.lblRecordsCount = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.cmsApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypesmage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
			this.cmsApplicationTypes.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(136, 219);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(446, 39);
			this.lblTitle.TabIndex = 114;
			this.lblTitle.Text = "Manage Application Types";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbApplicationTypesmage
			// 
			this.pbApplicationTypesmage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbApplicationTypesmage.Image = global::MyDVLD.Properties.Resources.Application_Types_512;
			this.pbApplicationTypesmage.InitialImage = null;
			this.pbApplicationTypesmage.Location = new System.Drawing.Point(260, 14);
			this.pbApplicationTypesmage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbApplicationTypesmage.Name = "pbApplicationTypesmage";
			this.pbApplicationTypesmage.Size = new System.Drawing.Size(220, 189);
			this.pbApplicationTypesmage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbApplicationTypesmage.TabIndex = 113;
			this.pbApplicationTypesmage.TabStop = false;
			// 
			// dgvApplicationTypes
			// 
			this.dgvApplicationTypes.AllowUserToAddRows = false;
			this.dgvApplicationTypes.AllowUserToDeleteRows = false;
			this.dgvApplicationTypes.AllowUserToResizeRows = false;
			this.dgvApplicationTypes.BackgroundColor = System.Drawing.Color.White;
			this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvApplicationTypes.ContextMenuStrip = this.cmsApplicationTypes;
			this.dgvApplicationTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvApplicationTypes.Location = new System.Drawing.Point(16, 279);
			this.dgvApplicationTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvApplicationTypes.MultiSelect = false;
			this.dgvApplicationTypes.Name = "dgvApplicationTypes";
			this.dgvApplicationTypes.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvApplicationTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvApplicationTypes.RowHeadersWidth = 51;
			this.dgvApplicationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvApplicationTypes.Size = new System.Drawing.Size(679, 354);
			this.dgvApplicationTypes.TabIndex = 112;
			this.dgvApplicationTypes.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 651);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 25);
			this.label2.TabIndex = 115;
			this.label2.Text = "# Records:";
			// 
			// lblRecordsCount
			// 
			this.lblRecordsCount.AutoSize = true;
			this.lblRecordsCount.Location = new System.Drawing.Point(114, 651);
			this.lblRecordsCount.Name = "lblRecordsCount";
			this.lblRecordsCount.Size = new System.Drawing.Size(34, 25);
			this.lblRecordsCount.TabIndex = 116;
			this.lblRecordsCount.Text = "??";
			// 
			// btnClose
			// 
			this.btnClose.AutoEllipsis = true;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::MyDVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(560, 645);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(135, 36);
			this.btnClose.TabIndex = 117;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// cmsApplicationTypes
			// 
			this.cmsApplicationTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
			this.cmsApplicationTypes.Name = "cmsApplicationTypes";
			this.cmsApplicationTypes.Size = new System.Drawing.Size(225, 30);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.edit_32;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.editToolStripMenuItem.Text = "&Edit Application Type";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
			// 
			// frmListApplications
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(719, 695);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblRecordsCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.pbApplicationTypesmage);
			this.Controls.Add(this.dgvApplicationTypes);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmListApplications";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmListApplications";
			this.Load += new System.EventHandler(this.frmListApplications_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypesmage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
			this.cmsApplicationTypes.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox pbApplicationTypesmage;
		private System.Windows.Forms.DataGridView dgvApplicationTypes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRecordsCount;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ContextMenuStrip cmsApplicationTypes;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
	}
}