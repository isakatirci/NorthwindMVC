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
	///This is the interface definition for the class BOCategories.
	///</Summary>
	public partial interface IBOCategories 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new Categories record to the store
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
		///This method updates one Categories record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOCategories
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one Categories record from the store
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
		///BOCategories
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
		
		ICategoriesRepository CategoriesRepository	{	set;}
		
		IProductsRepository ProductsRepository	{	set;}
		
		Int32? CategoryID	{	get;	set;}
		
		string CategoryName	{	get;	set;}
		
		string Description	{	get;	set;}
		
		byte[] Picture	{	get;	set;}
		
		Int32? CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}