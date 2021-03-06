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
	///This is the interface definition for the class BOEmployees.
	///</Summary>
	public partial interface IBOEmployees 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new Employees record to the store
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
		///This method updates one Employees record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOEmployees
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one Employees record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Delete();
		
		///<Summary>
		///EmployeePrivilegesCollection
		///This method returns its collection of BOEmployeePrivileges objects
		///</Summary>
		///<returns>
		///IList[IBOEmployeePrivileges]
		///</returns>
		///<parameters>
		///BOEmployees
		///</parameters>
		IList<IBOEmployeePrivileges> EmployeePrivilegesCollection();
		
		///<Summary>
		///OrdersCollection
		///This method returns its collection of BOOrders objects
		///</Summary>
		///<returns>
		///IList[IBOOrders]
		///</returns>
		///<parameters>
		///BOEmployees
		///</parameters>
		IList<IBOOrders> OrdersCollection();
		
		///<Summary>
		///PurchaseOrdersCollection
		///This method returns its collection of BOPurchaseOrders objects
		///</Summary>
		///<returns>
		///IList[IBOPurchaseOrders]
		///</returns>
		///<parameters>
		///BOEmployees
		///</parameters>
		IList<IBOPurchaseOrders> PurchaseOrdersCollection();
		
		///<Summary>
		///LoadEmployeePrivilegesCollection
		///This method loads the internal collection of BOEmployeePrivileges objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void LoadEmployeePrivilegesCollection();
		
		///<Summary>
		///AddEmployeePrivileges
		///This method persists a BOEmployeePrivileges object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOEmployeePrivileges
		///</parameters>
		void AddEmployeePrivileges(IBOEmployeePrivileges boEmployeePrivileges);
		
		///<Summary>
		///DeleteAllEmployeePrivileges
		///This method deletes all BOEmployeePrivileges objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void DeleteAllEmployeePrivileges();
		
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
		
		///<Summary>
		///LoadPurchaseOrdersCollection
		///This method loads the internal collection of BOPurchaseOrders objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void LoadPurchaseOrdersCollection();
		
		///<Summary>
		///AddPurchaseOrders
		///This method persists a BOPurchaseOrders object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOPurchaseOrders
		///</parameters>
		void AddPurchaseOrders(IBOPurchaseOrders boPurchaseOrders);
		
		///<Summary>
		///DeleteAllPurchaseOrders
		///This method deletes all BOPurchaseOrders objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void DeleteAllPurchaseOrders();
		
		#endregion

		#region member properties
		
		IEmployeesRepository EmployeesRepository	{	set;}
		
		IEmployeePrivilegesRepository EmployeePrivilegesRepository	{	set;}
		
		IOrdersRepository OrdersRepository	{	set;}
		
		IPurchaseOrdersRepository PurchaseOrdersRepository	{	set;}
		
		string İd	{	get;	set;}
		
		string Company	{	get;	set;}
		
		string LastName	{	get;	set;}
		
		string FirstName	{	get;	set;}
		
		string EmailAddress	{	get;	set;}
		
		string JobTitle	{	get;	set;}
		
		string BusinessPhone	{	get;	set;}
		
		string HomePhone	{	get;	set;}
		
		string MobilePhone	{	get;	set;}
		
		string FaxNumber	{	get;	set;}
		
		string Address	{	get;	set;}
		
		string City	{	get;	set;}
		
		string StateProvince	{	get;	set;}
		
		string ZipPostalCode	{	get;	set;}
		
		string CountryRegion	{	get;	set;}
		
		string WebPage	{	get;	set;}
		
		string Notes	{	get;	set;}
		
		byte[] Attachments	{	get;	set;}
		
		string CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
