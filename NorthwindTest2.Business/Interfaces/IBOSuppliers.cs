/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:11:04
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindTest2.Data.Interfaces;
using NorthwindTest2.Business.Repository.Interfaces;

namespace NorthwindTest2.Business.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the class BOSuppliers.
	///</Summary>
	public partial interface IBOSuppliers 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new Suppliers record to the store
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
		///This method updates one Suppliers record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOSuppliers
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one Suppliers record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Delete();
		
		///<Summary>
		///ProductsCollection
		///This method returns its collection of BOProducts objects
		///</Summary>
		///<returns>
		///IList[IBOProducts]
		///</returns>
		///<parameters>
		///BOSuppliers
		///</parameters>
		IList<IBOProducts> ProductsCollection();
		
		///<Summary>
		///LoadProductsCollection
		///This method loads the internal collection of BOProducts objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void LoadProductsCollection();
		
		///<Summary>
		///AddProducts
		///This method persists a BOProducts object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOProducts
		///</parameters>
		void AddProducts(IBOProducts boProducts);
		
		///<Summary>
		///DeleteAllProducts
		///This method deletes all BOProducts objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void DeleteAllProducts();
		
		#endregion

		#region member properties
		
		ISuppliersRepository SuppliersRepository	{	set;}
		
		IProductsRepository ProductsRepository	{	set;}
		
		Int32? SupplierID	{	get;	set;}
		
		string CompanyName	{	get;	set;}
		
		string ContactName	{	get;	set;}
		
		string ContactTitle	{	get;	set;}
		
		string Address	{	get;	set;}
		
		string City	{	get;	set;}
		
		string Region	{	get;	set;}
		
		string PostalCode	{	get;	set;}
		
		string Country	{	get;	set;}
		
		string Phone	{	get;	set;}
		
		string Fax	{	get;	set;}
		
		string HomePage	{	get;	set;}
		
		Int32? CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
