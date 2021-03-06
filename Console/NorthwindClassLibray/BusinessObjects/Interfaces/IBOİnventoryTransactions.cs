/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 12:15:59
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindClassLibrary.DataObjects.Interfaces;
using NorthwindClassLibrary.BusinessObjects.Repository.Interfaces;

namespace NorthwindClassLibrary.BusinessObjects.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the class BOInventoryTransactions.
	///</Summary>
	public partial interface IBOInventoryTransactions 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new InventoryTransactions record to the store
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
		///This method updates one InventoryTransactions record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOInventoryTransactions
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one InventoryTransactions record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Delete();
		
		///<Summary>
		///PurchaseOrderDetailsCollection
		///This method returns its collection of BOPurchaseOrderDetails objects
		///</Summary>
		///<returns>
		///IList[IBOPurchaseOrderDetails]
		///</returns>
		///<parameters>
		///BOInventoryTransactions
		///</parameters>
		IList<IBOPurchaseOrderDetails> PurchaseOrderDetailsCollection();
		
		///<Summary>
		///LoadPurchaseOrderDetailsCollection
		///This method loads the internal collection of BOPurchaseOrderDetails objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void LoadPurchaseOrderDetailsCollection();
		
		///<Summary>
		///AddPurchaseOrderDetails
		///This method persists a BOPurchaseOrderDetails object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOPurchaseOrderDetails
		///</parameters>
		void AddPurchaseOrderDetails(IBOPurchaseOrderDetails boPurchaseOrderDetails);
		
		///<Summary>
		///DeleteAllPurchaseOrderDetails
		///This method deletes all BOPurchaseOrderDetails objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void DeleteAllPurchaseOrderDetails();
		
		#endregion

		#region member properties
		
		IInventoryTransactionsRepository InventoryTransactionsRepository	{	set;}
		
		IPurchaseOrderDetailsRepository PurchaseOrderDetailsRepository	{	set;}
		
		string Id	{	get;	set;}
		
		string TransactionType	{	get;	set;}
		
		string TransactionCreatedDate	{	get;	set;}
		
		string TransactionModifiedDate	{	get;	set;}
		
		string ProductId	{	get;	set;}
		
		string Quantity	{	get;	set;}
		
		string PurchaseOrderId	{	get;	set;}
		
		string CustomerOrderId	{	get;	set;}
		
		string Comments	{	get;	set;}
		
		string CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
