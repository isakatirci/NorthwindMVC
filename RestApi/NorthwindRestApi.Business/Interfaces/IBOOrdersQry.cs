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
	///This is the interface definition for the class BOOrdersQry.
	///</Summary>
	public partial interface IBOOrdersQry 
	{
		#region class methods
		
		#endregion

		#region member properties
		
		IOrdersQryRepository OrdersQryRepository	{	set;}
		
		Int32? OrderID	{	get;	set;}
		
		string CustomerID	{	get;	set;}
		
		Int32? EmployeeID	{	get;	set;}
		
		DateTime? OrderDate	{	get;	set;}
		
		DateTime? RequiredDate	{	get;	set;}
		
		DateTime? ShippedDate	{	get;	set;}
		
		Int32? ShipVia	{	get;	set;}
		
		decimal? Freight	{	get;	set;}
		
		string ShipName	{	get;	set;}
		
		string ShipAddress	{	get;	set;}
		
		string ShipCity	{	get;	set;}
		
		string ShipRegion	{	get;	set;}
		
		string ShipPostalCode	{	get;	set;}
		
		string ShipCountry	{	get;	set;}
		
		string CompanyName	{	get;	set;}
		
		string Address	{	get;	set;}
		
		string City	{	get;	set;}
		
		string Region	{	get;	set;}
		
		string PostalCode	{	get;	set;}
		
		string Country	{	get;	set;}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
