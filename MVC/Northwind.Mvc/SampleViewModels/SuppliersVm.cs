/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 01:22:24
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using Northwind.Business;
using Northwind.Business.Interfaces;
using Northwind.Business.Repository.Interfaces;

namespace Northwind.Mvc.SampleViewModels
{
	public partial class SuppliersVm
	{
		#region member properties
		
		public virtual string İd { get; set;}
		
		public virtual string Company { get; set;}
		
		public virtual string LastName { get; set;}
		
		public virtual string FirstName { get; set;}
		
		public virtual string EmailAddress { get; set;}
		
		public virtual string JobTitle { get; set;}
		
		public virtual string BusinessPhone { get; set;}
		
		public virtual string HomePhone { get; set;}
		
		public virtual string MobilePhone { get; set;}
		
		public virtual string FaxNumber { get; set;}
		
		public virtual string Address { get; set;}
		
		public virtual string City { get; set;}
		
		public virtual string StateProvince { get; set;}
		
		public virtual string ZipPostalCode { get; set;}
		
		public virtual string CountryRegion { get; set;}
		
		public virtual string WebPage { get; set;}
		
		public virtual string Notes { get; set;}
		
		public virtual string Attachments { get; set;}
		#endregion
		
		public SuppliersVm() {}
		
		public SuppliersVm(IBOSuppliers boSuppliers)
		{
			İd = boSuppliers.İd;
			Company = boSuppliers.Company;
			LastName = boSuppliers.LastName;
			FirstName = boSuppliers.FirstName;
			EmailAddress = boSuppliers.EmailAddress;
			JobTitle = boSuppliers.JobTitle;
			BusinessPhone = boSuppliers.BusinessPhone;
			HomePhone = boSuppliers.HomePhone;
			MobilePhone = boSuppliers.MobilePhone;
			FaxNumber = boSuppliers.FaxNumber;
			Address = boSuppliers.Address;
			City = boSuppliers.City;
			StateProvince = boSuppliers.StateProvince;
			ZipPostalCode = boSuppliers.ZipPostalCode;
			CountryRegion = boSuppliers.CountryRegion;
			WebPage = boSuppliers.WebPage;
			Notes = boSuppliers.Notes;
			Attachments = boSuppliers.Attachments != null ? Convert.ToBase64String(boSuppliers.Attachments) : null;
		}
		
		public IBOSuppliers BOSuppliers()
		{
			var boSuppliers = new BOSuppliers()
			{
				İd = this.İd,
				Company = this.Company,
				LastName = this.LastName,
				FirstName = this.FirstName,
				EmailAddress = this.EmailAddress,
				JobTitle = this.JobTitle,
				BusinessPhone = this.BusinessPhone,
				HomePhone = this.HomePhone,
				MobilePhone = this.MobilePhone,
				FaxNumber = this.FaxNumber,
				Address = this.Address,
				City = this.City,
				StateProvince = this.StateProvince,
				ZipPostalCode = this.ZipPostalCode,
				CountryRegion = this.CountryRegion,
				WebPage = this.WebPage,
				Notes = this.Notes,
				Attachments = this.Attachments != null ? Convert.FromBase64String(this.Attachments) : null
			};
			return boSuppliers;
		}
		
		public IBOSuppliers BOSuppliers(ISuppliersRepository repo)
		{
			BOSuppliers boSuppliers = (BOSuppliers)BOSuppliers();
			boSuppliers.Repository = repo;
			return boSuppliers;
		}
	}
}
