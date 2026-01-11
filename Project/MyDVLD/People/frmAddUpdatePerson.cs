using DVLD_Buisness;
using MyDVLD.Global_Classes;
using MyDVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD.People
{
	public partial class frmAddUpdatePerson : Form
	{
		// Declare a delegate
		public delegate void DataBackEventHandler(object sender, int PersonID);

		// Declare an event using the delegate
		public event DataBackEventHandler DataBack;
		public enum enMode { AddNew = 0, Update = 1 };

		public enum enGender { Male = 0,  Female = 1 };

		private enMode _Mode;
		private int _PersonID = -1;
		clsPerson _Person;

		public frmAddUpdatePerson()
		{
			InitializeComponent();
			_Mode = enMode.AddNew;
		}

		public frmAddUpdatePerson(int personID)
		{
			InitializeComponent();

			_Mode = enMode.Update;
			_PersonID = personID;
		}


		private void _RestDefultValues()
		{
			//this will initialize the reset the defult values
			_FiilCountriesInComboBox();

			if (_Mode == enMode.AddNew)
			{
				lblTitle.Text = "Add New Person";
				_Person = new clsPerson();
			}
			else
			{
				lblTitle.Text = "Udate Person";
			}

			//set defult image for the person.
			if (rbMale.Checked)
				pbPersonImage.Image = Resources.Male_512;
			else
				pbPersonImage.Image= Resources.Female_512;

			//hide/show the remove linke incase threre is no image for the person.
			llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

			//we set the max date to 18 years from today, and set the defult value the same.
			dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
			dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

			//should not allow adding age more than 100 years
			dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

			//this will set defult country to jordan.
			cbCountry.SelectedIndex = cbCountry.FindString("Jordan");

			txtFirstName.Text = "";
			txtSecondName.Text = "";
			txtThirdName.Text = "";
			txtLastName.Text = "";
			txtNationalNo.Text = "";
			rbMale.Checked = true;
			txtPhone.Text = "";
			txtEmail.Text = "";
			txtAddress.Text = "";
		}


		private void _FiilCountriesInComboBox()
		{
			DataTable dtCountries = clsCountry.GetAllCountries();


			foreach (DataRow row in dtCountries.Rows)
			{
				cbCountry.Items.Add(row["CountryName"]);
			}
		}

		private void _LoadData()
		{
			_Person = clsPerson.Find(_PersonID);

			if(_Person == null)
			{
				MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.Close();
				return;
			}

			//the following code will not be executed if the person was not found
			lblPersonID.Text = _PersonID.ToString();
			txtFirstName.Text = _Person.FirstName;
			txtSecondName.Text = _Person.SecondName;
			txtThirdName.Text = _Person.ThirdName;
			txtLastName.Text = _Person.LastName;
			txtNationalNo.Text= _Person.NationalNo;
			dtpDateOfBirth.Value = _Person.DateOfBirth;

			if (_Person.Gendor == 0)
				rbMale.Checked = true;
			else
				rbFemale.Checked = true;

			txtAddress.Text = _Person.Address;
			txtPhone.Text = _Person.Phone;
			txtEmail.Text = _Person.Email;
			cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);

			//load person image incase it was set.
			if(_Person.ImagePath != "")
			{
				pbPersonImage.ImageLocation = _Person.ImagePath;
			}

			//hide/show the remove linke incase there is no image for the person.
			llRemoveImage.Visible = (_Person.ImagePath != "");
		}


		private void frmAddUpdatePerson_Load(object sender, EventArgs e)
		{
			_RestDefultValues();

			if(_Mode==enMode.Update)
				_LoadData();
		}

		private bool _HandelPersonImage()
		{
			if(_Person.ImagePath != pbPersonImage.ImageLocation)
			{
				if(_Person.ImagePath != "")
				{
					//_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
					try
					{
						File.Delete(_Person.ImagePath);
					}
					catch (IOException)
					{
						// We could not delete the file.
						//log it later   
					}
				}

				if(pbPersonImage.ImageLocation != null)
				{
					//then we copy the new image to the image folder after we rename it
					string SourceImageFile = pbPersonImage.ImageLocation.ToString();

					if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
					{
						pbPersonImage.ImageLocation = SourceImageFile;
						return true;
					}
					else
					{
						MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
			}
			return true;
		}
		 
	
		private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
		{
			// First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
			TextBox Temp = ((TextBox)sender);
			if (string.IsNullOrEmpty(Temp.Text.Trim()))
			{
				e.Cancel = true;
				errorProvider1.SetError(Temp, "This field is required!");
			}
			else
			{
				//e.Cancel = false;
				errorProvider1.SetError(Temp, null);
			}
		}

		private void btnSave_Click_1(object sender, EventArgs e)
		{

			if (!this.ValidateChildren())
			{
				//Here we dont continue becuase the from not valid
				MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!_HandelPersonImage())
				return;

			int NationalityCountryID = clsCountry.Find(cbCountry.Text).ID;

			_Person.FirstName = txtFirstName.Text.Trim();
			_Person.SecondName = txtSecondName.Text.Trim();
			_Person.ThirdName = txtThirdName.Text.Trim();
			_Person.LastName = txtLastName.Text.Trim();
			_Person.NationalNo = txtNationalNo.Text.Trim();
			_Person.Email = txtEmail.Text.Trim();
			_Person.Phone = txtPhone.Text.Trim();
			_Person.Address = txtAddress.Text.Trim();
			_Person.DateOfBirth = dtpDateOfBirth.Value;

			if (rbMale.Checked)
				_Person.Gendor = (short)enGender.Male;
			else
				_Person.Gendor = (short)enGender.Female;

			_Person.NationalityCountryID = NationalityCountryID;


			if (pbPersonImage.ImageLocation != null)
				_Person.ImagePath = pbPersonImage.ImageLocation.Trim();
			else

				_Person.ImagePath = "";

			if (_Person.Save())
			{
				lblPersonID.Text = _Person.PersonID.ToString();
				//change form mode to update
				_Mode = enMode.Update;
				lblTitle.Text = "Update Person";

				MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Trigger the event to send data back to the caller form.
				DataBack?.Invoke(this, _Person.PersonID);
			}
			else
			{
				MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtEmail_Validating_1(object sender, CancelEventArgs e)
		{
			//no need to validate the email incase it's empty.
			if (txtEmail.Text.Trim() == "")
				return;

			//validate email foramt
			if (!clsValidation.ValidateEmail(txtEmail.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
			}
			else
			{
				errorProvider1.SetError(txtEmail, null);
			}
		}

		private void txtNationalNo_Validating_1(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
			{
				e.Cancel = true;
				errorProvider1.SetError(txtNationalNo, "This field is required!");
				return;
			}

			else
			{
				errorProvider1.SetError(txtNationalNo, null);
			}

			//Make sure the national number is not used by another person
			if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.isPersonExist(txtNationalNo.Text.Trim()))
			{
				e.Cancel = true;
				errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");
			}

			else
			{
				errorProvider1.SetError(txtNationalNo, null);
			}
		}

		private void rbMale_CheckedChanged(object sender, EventArgs e)
		{
			//change the defult image to male icase there is no image set.
			if (pbPersonImage.ImageLocation == null)
				pbPersonImage.Image = Resources.Male_512;
		}

		private void rbFemale_CheckedChanged(object sender, EventArgs e)
		{
			//change the defult image to Femal icase there is no image set.
			if (pbPersonImage.ImageLocation == null)
				pbPersonImage.Image = Resources.Female_512;
		}

		private void llSetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// Process the selected file
				string selectedFilePath = openFileDialog1.FileName;
				pbPersonImage.Load(selectedFilePath);
				llRemoveImage.Visible = true;
				// ...
			}
		}

		private void llRemoveImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// Process the selected file
				string selectedFilePath = openFileDialog1.FileName;
				pbPersonImage.Load(selectedFilePath);
				llRemoveImage.Visible = true;
				// ...
			}
		}
	}
}
