namespace MyDVLD.Tests
{
	partial class frmScheduleTest
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
			this.ctrlSecheduleTest1 = new MyDVLD.Tests.Controls.ctrlSecheduleTest();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ctrlSecheduleTest1
			// 
			this.ctrlSecheduleTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctrlSecheduleTest1.Location = new System.Drawing.Point(0, 0);
			this.ctrlSecheduleTest1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctrlSecheduleTest1.Name = "ctrlSecheduleTest1";
			this.ctrlSecheduleTest1.Size = new System.Drawing.Size(533, 722);
			this.ctrlSecheduleTest1.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Image = global::MyDVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(185, 723);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(126, 37);
			this.btnClose.TabIndex = 126;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmScheduleTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(545, 786);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.ctrlSecheduleTest1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmScheduleTest";
			this.Text = "Schedule Test";
			this.Load += new System.EventHandler(this.frmScheduleTest_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.ctrlSecheduleTest ctrlSecheduleTest1;
		private System.Windows.Forms.Button btnClose;
	}
}