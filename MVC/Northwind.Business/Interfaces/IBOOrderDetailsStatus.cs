/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 01:22:23
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using Northwind.Data.Interfaces;
using Northwind.Business.Repository.Interfaces;

namespace Northwind.Business.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the class BOOrderDetailsStatus.
	///</Summary>
	public partial interface IBOOrderDetailsStatus 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new OrderDetailsStatus record to the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void SaveNew();
		
		///<Summary>
		///Update
		///This method updates one OrderDetailsStatus record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrderDetailsStatus
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one OrderDetailsStatus record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Delete();
		
		///<Summary>
		///OrderDetailsCollection
		///This method returns its collection of BOOrderDetails objects
		///</Summary>
		///<returns>
		///IList[IBOOrderDetails]
		///</returns>
		///<parameters>
		///BOOrderDetailsStatus
		///</parameters>
		IList<IBOOrderDetails> OrderDetailsCollection();
		
		///<Summary>
		///LoadOrderDetailsCollection
		///This method loads the internal collection of BOOrderDetails objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void LoadOrderDetailsCollection();
		
		///<Summary>
		///AddOrderDetails
		///This method persists a BOOrderDetails object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrderDetails
		///</parameters>
		void AddOrderDetails(IBOOrderDetails boOrderDetails);
		
		///<Summary>
		///DeleteAllOrderDetails
		///This method deletes all BOOrderDetails objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void DeleteAllOrderDetails();
		
		#endregion

		#region member properties
		
		IOrderDetailsStatusRepository OrderDetailsStatusRepository	{	set;}
		
		IOrderDetailsRepository OrderDetailsRepository	{	set;}
		
		string İd	{	get;	set;}
		
		string StatusName	{	get;	set;}
		
		string CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}