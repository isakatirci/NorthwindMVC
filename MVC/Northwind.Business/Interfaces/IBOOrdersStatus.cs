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
	///This is the interface definition for the class BOOrdersStatus.
	///</Summary>
	public partial interface IBOOrdersStatus 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new OrdersStatus record to the store
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
		///This method updates one OrdersStatus record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrdersStatus
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one OrdersStatus record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Delete();
		
		///<Summary>
		///OrdersCollection
		///This method returns its collection of BOOrders objects
		///</Summary>
		///<returns>
		///IList[IBOOrders]
		///</returns>
		///<parameters>
		///BOOrdersStatus
		///</parameters>
		IList<IBOOrders> OrdersCollection();
		
		///<Summary>
		///LoadOrdersCollection
		///This method loads the internal collection of BOOrders objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void LoadOrdersCollection();
		
		///<Summary>
		///AddOrders
		///This method persists a BOOrders object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrders
		///</parameters>
		void AddOrders(IBOOrders boOrders);
		
		///<Summary>
		///DeleteAllOrders
		///This method deletes all BOOrders objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void DeleteAllOrders();
		
		#endregion

		#region member properties
		
		IOrdersStatusRepository OrdersStatusRepository	{	set;}
		
		IOrdersRepository OrdersRepository	{	set;}
		
		string İd	{	get;	set;}
		
		string StatusName	{	get;	set;}
		
		string CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
