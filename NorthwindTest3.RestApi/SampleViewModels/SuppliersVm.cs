/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:31:23
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using NorthwindTest3.BusinessObjects;

namespace NorthwindTest3.RestApi.SampleViewModels
{
	public partial class SuppliersVm
	{
		#region member properties
		
		public virtual Int32? SupplierID { get; set;}
		
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
		
		public virtual string HomePage { get; set;}
		#endregion
		
		public SuppliersVm() {}
		
		public SuppliersVm(BOSuppliers boSuppliers)
		{
			SupplierID = boSuppliers.SupplierID;
			CompanyName = boSuppliers.CompanyName;
			ContactName = boSuppliers.ContactName;
			ContactTitle = boSuppliers.ContactTitle;
			Address = boSuppliers.Address;
			City = boSuppliers.City;
			Region = boSuppliers.Region;
			PostalCode = boSuppliers.PostalCode;
			Country = boSuppliers.Country;
			Phone = boSuppliers.Phone;
			Fax = boSuppliers.Fax;
			HomePage = boSuppliers.HomePage;
		}
		
		public BOSuppliers BOSuppliers()
		{
			var boSuppliers = new BOSuppliers()
			{
				SupplierID = this.SupplierID,
				CompanyName = this.CompanyName,
				ContactName = this.ContactName,
				ContactTitle = this.ContactTitle,
				Address = this.Address,
				City = this.City,
				Region = this.Region,
				PostalCode = this.PostalCode,
				Country = this.Country,
				Phone = this.Phone,
				Fax = this.Fax,
				HomePage = this.HomePage
			};
			return boSuppliers;
		}
	}
}
