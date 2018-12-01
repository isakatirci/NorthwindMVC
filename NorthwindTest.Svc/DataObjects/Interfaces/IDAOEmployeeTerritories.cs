/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:26:30
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;

namespace NorthwindTest.DataObjects.Interfaces
{
	public partial interface IDAOEmployeeTerritories 
	{
		#region class methods

		///<Summary>
		///Delete one row by primary key(s)
		///this method allows the object to delete itself from the table EmployeeTerritories based on its primary key
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
		///This method saves a new object to the table EmployeeTerritories
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Insert();






		#endregion

		#region member properties

		Int32? EmployeeID	{	get;	set;	}
		
		string TerritoryID	{	get;	set;	}
		
		#endregion
	}
}
