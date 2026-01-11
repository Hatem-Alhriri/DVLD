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

namespace MyDVLD.Users
{
	public partial class ctrlUesrCard : UserControl
	{

		private clsUser _User;
		private int _UserID = -1;


		public int UserID
		{
			get { return _UserID; }
		}

		public ctrlUesrCard()
		{
			InitializeComponent();
		}

		public void LoadUserInfo(int UserID)
		{
			_UserID = UserID;	
			_User = clsUser.FindByUserID(UserID);
			if (_User == null)
			{
				_RestPersonInfo();
				MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
		        return;
			}

			_FillUserInfo();
		}


		private void _FillUserInfo()
		{
			ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
			lblUserID.Text = _User.UserID.ToString();
			lblUserName.Text = _User.UserName.ToString();

			if (_User.IsActive)
				lblIsActive.Text = "Yes";
			else
				lblIsActive.Text = "No";
		}

		private void _RestPersonInfo()
		{
			ctrlPersonCard1.ResetPersonInfo();
			lblUserID.Text = "[???]";
			lblUserName.Text = "[???]";
			lblIsActive.Text = "[???]";
		}
	}
}
