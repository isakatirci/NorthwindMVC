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
	///This is the interface definition for the class BOSalesByCategory.
	///</Summary>
	public partial interface IBOSalesByCategory 
	{
		#region class methods
		
		#endregion

		#region member properties
		
		ISalesByCategoryRepository SalesByCategoryRepository	{	set;}
		
		Int32? CategoryID	{	get;	set;}
		
		string CategoryName	{	get;	set;}
		
		string ProductName	{	get;	set;}
		
		decimal? ProductSales	{	get;	set;}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
