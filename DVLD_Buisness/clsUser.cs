using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
	public class clsUser
	{
		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;

		public int UserID { set; get; }
		public int PersonID { set; get; }

		public clsPerson PersonInfo;
		public string UserName { set; get; }
		public string Password { set; get; }
		public bool IsActive { set; get; }

		public clsUser()
		{
			UserID = -1;
			UserName = "";
			Password = "";
			IsActive = true;
			Mode = enMode.AddNew;
		}

		public clsUser(int UserID, int PersonID, string UserName, string Password,
			bool IsActive)
		{
			this.UserID = UserID;
			this.PersonID = PersonID;
			PersonInfo = clsPerson.Find(PersonID);
			this.UserName = UserName;
			this.Password = Password;
			this.IsActive = IsActive;

			Mode = enMode.Update;
		}


		private bool _AddNewUser()
		{
			// call DataAccess Layer

			UserID = clsUserData.AddNewUser(PersonID, UserName,
				Password, IsActive);

			return UserID != -1;
		}

		private bool _UpdateUser()
		{
			//call DataAccess Layer 

			return clsUserData.UpdateUser(UserID, PersonID, UserName,
				Password, IsActive);
		}

		public static clsUser FindByUserID(int UserID)
		{
			int PersonID = -1;
			string UserName = "", Password = "";
			bool IsActive = false;

			bool IsFound = clsUserData.GetUserInfoByUserID(UserID, ref PersonID,
			   ref UserName, ref Password, ref IsActive);

			if (IsFound)
				//we return new object of that User with the right data
				return new clsUser(UserID, PersonID, UserName, Password, IsActive);
			else
				return null;
		}

		public static clsUser FindByPersonID(int PersonID)
		{
			int UserID = -1;
			string UserName = "", Password = "";
			bool IsActive = false;

			bool IsFound = clsUserData.GetUserInfoByPersonID(PersonID, ref UserID,
			   ref UserName, ref Password, ref IsActive);

			if (IsFound)
				//we return new object of that User with the right data
				return new clsUser(UserID, PersonID, UserName, Password, IsActive);
			else
				return null;
		}

		public static clsUser FindByUsernameAndPassword(string UserName, string Password)
		{
			int UserID = -1;
			int PersonID = -1;

			bool IsActive = false;

			bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword(UserName, Password, ref UserID, ref PersonID, ref IsActive);

			if (IsFound)
				//we return new object of that User with the right data
				return new clsUser(UserID, PersonID, UserName, Password, IsActive);
			else
				return null;
		}

		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewUser())
					{
						Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}

				case enMode.Update:
					return _UpdateUser();
			}

			return false;
		}

		public static DataTable GetAllUsers()
		{
			return clsUserData.GetAllUsers();
		}

		public static bool DeleteUser(int UserID)
		{
			return clsUserData.DeleteUser(UserID);
		}

		public static bool IsUserExist(int UserID)
		{
			return clsUserData.IsUserExist(UserID);
		}

		public static bool IsUserExist(string UserName)
		{
			return clsUserData.IsUserExist(UserName);
		}

		public static bool IsUserExistForPersonID(int PersonID)
		{
			return clsUserData.IsUserExistForPersonID(PersonID);
		}
	}
}
