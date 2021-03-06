/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 01:22:23
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;

namespace Northwind.Data.Interfaces
{
	public partial interface IDAOPrivileges
	{
		#region class methods
		///<Summary>
		///Delete one row by primary key(s)
		///this method allows the object to delete itself from the table privileges based on its primary key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Delete();

		///<Summary>
		///Insert a new row
		///This method saves a new object to the table privileges
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Insert();

		///<Summary>
		///Update one row by primary key(s)
		///This method allows the object to update itself in the table privileges based on its primary key(s)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Update();

		#endregion

		#region member properties
		string İd		{	get;	set;	}
		
		string PrivilegeName		{	get;	set;	}
		
		string CtrVersion	{	get;	set;	}
		
		#endregion
	}
}
