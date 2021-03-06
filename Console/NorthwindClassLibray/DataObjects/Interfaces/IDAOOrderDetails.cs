/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 12:15:59
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;

namespace NorthwindClassLibrary.DataObjects.Interfaces
{
	public partial interface IDAOOrderDetails
	{
		#region class methods
		///<Summary>
		///Delete one row by primary key(s)
		///this method allows the object to delete itself from the table order_details based on its primary key
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
		///This method saves a new object to the table order_details
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
		///This method allows the object to update itself in the table order_details based on its primary key(s)
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
		string Id		{	get;	set;	}
		
		string OrderId		{	get;	set;	}
		
		string ProductId		{	get;	set;	}
		
		string Quantity		{	get;	set;	}
		
		string UnitPrice		{	get;	set;	}
		
		double? Discount		{	get;	set;	}
		
		string StatusId		{	get;	set;	}
		
		string DateAllocated		{	get;	set;	}
		
		string PurchaseOrderId		{	get;	set;	}
		
		string InventoryId		{	get;	set;	}
		
		string CtrVersion	{	get;	set;	}
		
		#endregion
	}
}
