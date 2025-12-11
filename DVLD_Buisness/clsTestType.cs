using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
	public class clsTestType
	{
		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;

		public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

		public enTestType ID { set; get; }

		public string Title { set; get; }
		public string Description { set; get; }
		public float Fees { set; get; }

		public clsTestType()
		{
			ID = enTestType.VisionTest;
			Title = "";
			Description = "";
			Fees = 0;
			Mode = enMode.AddNew;
		}

		public clsTestType(enTestType ID, string TestTypeTitel, string Description, float TestTypeFees)

		{
			this.ID = ID;
			Title = TestTypeTitel;
			this.Description = Description;
			Fees = TestTypeFees;
			Mode = enMode.Update;
		}

		private bool _AddNewTestType()
		{
			//call DataAccess Layer

			ID = (enTestType)clsTestTypeData.AddNewTestType(Title, Description, Fees);

			return Title != "";
		}


		private bool _UpdateTestType()
		{
			//call DataAccess layer

			return clsTestTypeData.UpdateTestType((int)ID, Title, Description, Fees);
		}


		public static clsTestType Find(enTestType TestTypeID)
		{
			string Title = "", Description = ""; float Fees = 0;

			if (clsTestTypeData.GetTestTypeInfoByID((int)TestTypeID, ref Title, ref Description, ref Fees))

				return new clsTestType(TestTypeID, Title, Description, Fees);
			else
				return null;
		}


		public static DataTable GetAllTestTypes()
		{
			return clsTestTypeData.GetAllTestTypes();

		}

		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewTestType())
					{
						Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}

				case enMode.Update:

					return _UpdateTestType();

			}

			return false;
		}


	}
}

