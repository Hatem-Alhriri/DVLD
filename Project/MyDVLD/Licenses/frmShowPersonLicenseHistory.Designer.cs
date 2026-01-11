namespace MyDVLD.Licenses
{
	partial class frmShowPersonLicenseHistory
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
			this.ctrlPersonCardWithFilter1 = new MyDVLD.People.Controls.ctrlPersonCardWithFilter();
			this.ctrlDriverLicenses1 = new MyDVLD.Licenses.Controls.ctrlDriverLicenses();
			this.pbPersonImage = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
			this.SuspendLayout();
			// 
			// ctrlPersonCardWithFilter1
			// 
			this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
			this.ctrlPersonCardWithFilter1.FilterEnabled = true;
			this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(232, -3);
			this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
			this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
			this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(837, 399);
			this.ctrlPersonCardWithFilter1.TabIndex = 0;
			// 
			// ctrlDriverLicenses1
			// 
			this.ctrlDriverLicenses1.BackColor = System.Drawing.Color.White;
			this.ctrlDriverLicenses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctrlDriverLicenses1.Location = new System.Drawing.Point(4, 390);
			this.ctrlDriverLicenses1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
			this.ctrlDriverLicenses1.Size = new System.Drawing.Size(1061, 342);
			this.ctrlDriverLicenses1.TabIndex = 1;
			// 
			// pbPersonImage
			// 
			this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbPersonImage.Image = global::MyDVLD.Properties.Resources.PersonLicenseHistory_512;
			this.pbPersonImage.InitialImage = null;
			this.pbPersonImage.Location = new System.Drawing.Point(6, 145);
			this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pbPersonImage.Name = "pbPersonImage";
			this.pbPersonImage.Size = new System.Drawing.Size(220, 189);
			this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPersonImage.TabIndex = 131;
			this.pbPersonImage.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.AutoEllipsis = true;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::MyDVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(930, 740);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(135, 36);
			this.btnClose.TabIndex = 132;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
			// 
			// frmShowPersonLicenseHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1086, 829);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pbPersonImage);
			this.Controls.Add(this.ctrlDriverLicenses1);
			this.Controls.Add(this.ctrlPersonCardWithFilter1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmShowPersonLicenseHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "License History";
			this.Load += new System.EventHandler(this.frmShowPersonLicenseHistory_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
		private Controls.ctrlDriverLicenses ctrlDriverLicenses1;
		private System.Windows.Forms.PictureBox pbPersonImage;
		private System.Windows.Forms.Button btnClose;
	}
}