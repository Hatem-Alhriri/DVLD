using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Buisness
{
	public class clsPerson
	{
		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;

		public int PersonID { get; set; }
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public string ThirdName { get; set; }
		public string LastName { get; set; }
		public string FullName
		{
			get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

		}
		public string NationalNo { get; set; }
		public DateTime DateOfBirth { get; set; }
		public short Gendor { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public int NationalityCountryID { get; set; }

		public clsCountry CountryInfo;

		private string _ImagePath;
		public string ImagePath
		{
			get { return _ImagePath; }
			set { _ImagePath = value; }
		}

		public clsPerson()
		{
			PersonID = -1;
			FirstName = "";
			SecondName = "";
			ThirdName = "";
			LastName = "";
			DateOfBirth = DateTime.Now;
			Address = "";
			Phone = "";
			Email = "";
			NationalityCountryID = -1;
			ImagePath = "";
			Mode = enMode.AddNew;
		}

		private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName,
		  string LastName, string NationalNo, DateTime DateOfBirth, short Gendor,
		   string Address, string Phone, string Email,
		  int NationalityCountryID, string ImagePath)

		{
			this.PersonID = PersonID;
			this.FirstName = FirstName;
			this.SecondName = SecondName;
			this.ThirdName = ThirdName;
			this.LastName = LastName;
			this.NationalNo = NationalNo;
			this.DateOfBirth = DateOfBirth;
			this.Gendor = Gendor;
			this.Address = Address;
			this.Phone = Phone;
			this.Email = Email;
			this.NationalityCountryID = NationalityCountryID;
			this.ImagePath = ImagePath;
			CountryInfo = clsCountry.Find(NationalityCountryID);
			Mode = enMode.Update;
		}



		private bool _AddNewPerson()
		{
			//call DataAccess Layer

			PersonID = clsPersonData.AddNewPerson(
				FirstName, SecondName, ThirdName,
				LastName, NationalNo,
				DateOfBirth, Gendor, Address, Phone, Email,
				NationalityCountryID, ImagePath);

			return PersonID != -1;
		}

		private bool _UpdatePerson()
		{
			return clsPersonData.UpdatePerson(
				PersonID, FirstName, SecondName, ThirdName,
				LastName, NationalNo, DateOfBirth, Gendor,
				Address, Phone, Email,
				NationalityCountryID, ImagePath);
		}


		public static clsPerson Find(int PersonID)
		{

			string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
			DateTime DateOfBirth = DateTime.Now;
			int NationalityCountryID = -1;
			short Gendor = 0;

			bool IsFound = clsPersonData.GetPersonInfoByID
							   (PersonID, ref FirstName, ref SecondName,
							   ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth,
							   ref Gendor, ref Address, ref Phone, ref Email,
							   ref NationalityCountryID, ref ImagePath
							   );

			if (IsFound)
				//we return new object of that person with the right data
				return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
					NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
			else
				return null;
		}


		public static clsPerson Find(string NationalNo)
		{

			string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
			DateTime DateOfBirth = DateTime.Now;
			int PersonID = -1, NationalityCountryID = -1;
			short Gendor = 0;

			bool IsFound = clsPersonData.GetPersonInfoByNationalNo
							   (NationalNo, ref PersonID, ref FirstName, ref SecondName,
							   ref ThirdName, ref LastName, ref DateOfBirth,
							   ref Gendor, ref Address, ref Phone, ref Email,
							   ref NationalityCountryID, ref ImagePath
							   );

			if (IsFound)
				//we return new object of that person with the right data
				return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
					NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
			else
				return null;
		}


		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewPerson())
					{
						Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}
				case enMode.Update:

					return _UpdatePerson();
			}

			return false;
		}


		public static DataTable GetAllPeople()
		{
			return clsPersonData.GetAllPeople();
		}


		public static bool DeletePerson(int ID)
		{
			return clsPersonData.DeletePerson(ID);
		}


		public static bool isPersonExist(int ID)
		{
			return clsPersonData.IsPersonExist(ID);
		}

		public static bool isPersonExist(string NationalNo)
		{
			return clsPersonData.IsPersonExist(NationalNo);
		}
	}
}
