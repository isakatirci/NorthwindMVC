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
	///This is the interface definition for the class BOOrders.
	///</Summary>
	public partial interface IBOOrders 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new Orders record to the store
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
		///This method updates one Orders record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrders
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one Orders record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Delete();
		
		///<Summary>
		///İnventoryTransactionsCollection
		///This method returns its collection of BOİnventoryTransactions objects
		///</Summary>
		///<returns>
		///IList[IBOİnventoryTransactions]
		///</returns>
		///<parameters>
		///BOOrders
		///</parameters>
		IList<IBOİnventoryTransactions> İnventoryTransactionsCollection();
		
		///<Summary>
		///İnvoicesCollection
		///This method returns its collection of BOİnvoices objects
		///</Summary>
		///<returns>
		///IList[IBOİnvoices]
		///</returns>
		///<parameters>
		///BOOrders
		///</parameters>
		IList<IBOİnvoices> İnvoicesCollection();
		
		///<Summary>
		///OrderDetailsCollection
		///This method returns its collection of BOOrderDetails objects
		///</Summary>
		///<returns>
		///IList[IBOOrderDetails]
		///</returns>
		///<parameters>
		///BOOrders
		///</parameters>
		IList<IBOOrderDetails> OrderDetailsCollection();
		
		///<Summary>
		///LoadİnventoryTransactionsCollection
		///This method loads the internal collection of BOİnventoryTransactions objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void LoadİnventoryTransactionsCollection();
		
		///<Summary>
		///AddİnventoryTransactions
		///This method persists a BOİnventoryTransactions object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOİnventoryTransactions
		///</parameters>
		void AddİnventoryTransactions(IBOİnventoryTransactions boİnventoryTransactions);
		
		///<Summary>
		///DeleteAllİnventoryTransactions
		///This method deletes all BOİnventoryTransactions objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void DeleteAllİnventoryTransactions();
		
		///<Summary>
		///LoadİnvoicesCollection
		///This method loads the internal collection of BOİnvoices objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void LoadİnvoicesCollection();
		
		///<Summary>
		///Addİnvoices
		///This method persists a BOİnvoices object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOİnvoices
		///</parameters>
		void Addİnvoices(IBOİnvoices boİnvoices);
		
		///<Summary>
		///DeleteAllİnvoices
		///This method deletes all BOİnvoices objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void DeleteAllİnvoices();
		
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
		
		IOrdersRepository OrdersRepository	{	set;}
		
		IInventoryTransactionsRepository İnventoryTransactionsRepository	{	set;}
		
		IInvoicesRepository İnvoicesRepository	{	set;}
		
		IOrderDetailsRepository OrderDetailsRepository	{	set;}
		
		string İd	{	get;	set;}
		
		string Employeeİd	{	get;	set;}
		
		string Customerİd	{	get;	set;}
		
		string OrderDate	{	get;	set;}
		
		string ShippedDate	{	get;	set;}
		
		string Shipperİd	{	get;	set;}
		
		string ShipName	{	get;	set;}
		
		string ShipAddress	{	get;	set;}
		
		string ShipCity	{	get;	set;}
		
		string ShipStateProvince	{	get;	set;}
		
		string ShipZipPostalCode	{	get;	set;}
		
		string ShipCountryRegion	{	get;	set;}
		
		string ShippingFee	{	get;	set;}
		
		string Taxes	{	get;	set;}
		
		string PaymentType	{	get;	set;}
		
		string PaidDate	{	get;	set;}
		
		string Notes	{	get;	set;}
		
		double? TaxRate	{	get;	set;}
		
		string TaxStatusİd	{	get;	set;}
		
		string Statusİd	{	get;	set;}
		
		string CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
