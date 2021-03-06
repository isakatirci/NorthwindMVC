/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:12
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindRestApi.Data.Interfaces;
using NorthwindRestApi.Business.Repository.Interfaces;

namespace NorthwindRestApi.Business.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the class BOOrderDetailsExtended.
	///</Summary>
	public partial interface IBOOrderDetailsExtended 
	{
		#region class methods
		
		#endregion

		#region member properties
		
		IOrderDetailsExtendedRepository OrderDetailsExtendedRepository	{	set;}
		
		Int32? OrderID	{	get;	set;}
		
		Int32? ProductID	{	get;	set;}
		
		string ProductName	{	get;	set;}
		
		decimal? UnitPrice	{	get;	set;}
		
		Int16? Quantity	{	get;	set;}
		
		float? Discount	{	get;	set;}
		
		decimal? ExtendedPrice	{	get;	set;}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
