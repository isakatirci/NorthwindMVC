/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 01:22:23
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;

namespace Northwind.Data.Interfaces
{
	public partial interface IDAOEmployees
	{
		#region class methods
		///<Summary>
		///Delete one row by primary key(s)
		///this method allows the object to delete itself from the table employees based on its primary key
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
		///This method saves a new object to the table employees
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
		///This method allows the object to update itself in the table employees based on its primary key(s)
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
		
		string Company		{	get;	set;	}
		
		string LastName		{	get;	set;	}
		
		string FirstName		{	get;	set;	}
		
		string EmailAddress		{	get;	set;	}
		
		string JobTitle		{	get;	set;	}
		
		string BusinessPhone		{	get;	set;	}
		
		string HomePhone		{	get;	set;	}
		
		string MobilePhone		{	get;	set;	}
		
		string FaxNumber		{	get;	set;	}
		
		string Address		{	get;	set;	}
		
		string City		{	get;	set;	}
		
		string StateProvince		{	get;	set;	}
		
		string ZipPostalCode		{	get;	set;	}
		
		string CountryRegion		{	get;	set;	}
		
		string WebPage		{	get;	set;	}
		
		string Notes		{	get;	set;	}
		
		byte[] Attachments		{	get;	set;	}
		
		string CtrVersion	{	get;	set;	}
		
		#endregion
	}
}
