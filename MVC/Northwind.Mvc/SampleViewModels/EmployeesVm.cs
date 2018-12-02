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
	public partial class EmployeesVm
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
		
		public EmployeesVm() {}
		
		public EmployeesVm(IBOEmployees boEmployees)
		{
			İd = boEmployees.İd;
			Company = boEmployees.Company;
			LastName = boEmployees.LastName;
			FirstName = boEmployees.FirstName;
			EmailAddress = boEmployees.EmailAddress;
			JobTitle = boEmployees.JobTitle;
			BusinessPhone = boEmployees.BusinessPhone;
			HomePhone = boEmployees.HomePhone;
			MobilePhone = boEmployees.MobilePhone;
			FaxNumber = boEmployees.FaxNumber;
			Address = boEmployees.Address;
			City = boEmployees.City;
			StateProvince = boEmployees.StateProvince;
			ZipPostalCode = boEmployees.ZipPostalCode;
			CountryRegion = boEmployees.CountryRegion;
			WebPage = boEmployees.WebPage;
			Notes = boEmployees.Notes;
			Attachments = boEmployees.Attachments != null ? Convert.ToBase64String(boEmployees.Attachments) : null;
		}
		
		public IBOEmployees BOEmployees()
		{
			var boEmployees = new BOEmployees()
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
			return boEmployees;
		}
		
		public IBOEmployees BOEmployees(IEmployeesRepository repo)
		{
			BOEmployees boEmployees = (BOEmployees)BOEmployees();
			boEmployees.Repository = repo;
			return boEmployees;
		}
	}
}