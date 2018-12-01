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
	///This is the interface definition for the class BOOrderDetails.
	///</Summary>
	public partial interface IBOOrderDetails 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new OrderDetails record to the store
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
		///This method updates one OrderDetails record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrderDetails
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one OrderDetails record from the store
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
		
		IOrderDetailsRepository OrderDetailsRepository	{	set;}
		
		Int32? OrderID	{	get;	set;}
		
		Int32? ProductID	{	get;	set;}
		
		decimal? UnitPrice	{	get;	set;}
		
		Int16? Quantity	{	get;	set;}
		
		float? Discount	{	get;	set;}
		
		Int32? CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
