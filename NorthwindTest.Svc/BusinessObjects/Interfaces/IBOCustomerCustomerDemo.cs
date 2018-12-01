/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:26:30
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindTest.DataObjects.Interfaces;
using NorthwindTest.BusinessObjects.Repository.Interfaces;

namespace NorthwindTest.BusinessObjects.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the class BOCustomerCustomerDemo.
	///</Summary>
	public partial interface IBOCustomerCustomerDemo 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new CustomerCustomerDemo record to the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void SaveNew();
		
		
		///<Summary>
		///Delete
		///This method deletes one CustomerCustomerDemo record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Delete();
		
		#endregion

		#region member properties
		
		ICustomerCustomerDemoRepository CustomerCustomerDemoRepository	{	set;}
		
		string CustomerID	{	get;	set;}
		
		string CustomerTypeID	{	get;	set;}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
