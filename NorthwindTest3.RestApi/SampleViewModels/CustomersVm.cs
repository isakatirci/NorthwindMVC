/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:31:22
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using NorthwindTest3.BusinessObjects;

namespace NorthwindTest3.RestApi.SampleViewModels
{
	public partial class CustomersVm
	{
		#region member properties
		
		public virtual string CustomerID { get; set;}
		
		public virtual string CompanyName { get; set;}
		
		public virtual string ContactName { get; set;}
		
		public virtual string ContactTitle { get; set;}
		
		public virtual string Address { get; set;}
		
		public virtual string City { get; set;}
		
		public virtual string Region { get; set;}
		
		public virtual string PostalCode { get; set;}
		
		public virtual string Country { get; set;}
		
		public virtual string Phone { get; set;}
		
		public virtual string Fax { get; set;}
		#endregion
		
		public CustomersVm() {}
		
		public CustomersVm(BOCustomers boCustomers)
		{
			CustomerID = boCustomers.CustomerID;
			CompanyName = boCustomers.CompanyName;
			ContactName = boCustomers.ContactName;
			ContactTitle = boCustomers.ContactTitle;
			Address = boCustomers.Address;
			City = boCustomers.City;
			Region = boCustomers.Region;
			PostalCode = boCustomers.PostalCode;
			Country = boCustomers.Country;
			Phone = boCustomers.Phone;
			Fax = boCustomers.Fax;
		}
		
		public BOCustomers BOCustomers()
		{
			var boCustomers = new BOCustomers()
			{
				CustomerID = this.CustomerID,
				CompanyName = this.CompanyName,
				ContactName = this.ContactName,
				ContactTitle = this.ContactTitle,
				Address = this.Address,
				City = this.City,
				Region = this.Region,
				PostalCode = this.PostalCode,
				Country = this.Country,
				Phone = this.Phone,
				Fax = this.Fax
			};
			return boCustomers;
		}
	}
}
