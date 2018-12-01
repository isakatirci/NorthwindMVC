/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:12
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;

namespace NorthwindRestApi.Data.Interfaces
{
	public partial interface IDAOInvoices 
	{
		#region class methods





		#endregion

		#region member properties

		string ShipName	{	get;	set;	}
		
		string ShipAddress	{	get;	set;	}
		
		string ShipCity	{	get;	set;	}
		
		string ShipRegion	{	get;	set;	}
		
		string ShipPostalCode	{	get;	set;	}
		
		string ShipCountry	{	get;	set;	}
		
		string CustomerID	{	get;	set;	}
		
		string CustomerName	{	get;	set;	}
		
		string Address	{	get;	set;	}
		
		string City	{	get;	set;	}
		
		string Region	{	get;	set;	}
		
		string PostalCode	{	get;	set;	}
		
		string Country	{	get;	set;	}
		
		string Salesperson	{	get;	set;	}
		
		Int32? OrderID	{	get;	set;	}
		
		DateTime? OrderDate	{	get;	set;	}
		
		DateTime? RequiredDate	{	get;	set;	}
		
		DateTime? ShippedDate	{	get;	set;	}
		
		string ShipperName	{	get;	set;	}
		
		Int32? ProductID	{	get;	set;	}
		
		string ProductName	{	get;	set;	}
		
		decimal? UnitPrice	{	get;	set;	}
		
		Int16? Quantity	{	get;	set;	}
		
		float? Discount	{	get;	set;	}
		
		decimal? ExtendedPrice	{	get;	set;	}
		
		decimal? Freight	{	get;	set;	}
		
		#endregion
	}
}
