/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:11:04
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using NorthwindTest2.Business;
using NorthwindTest2.Business.Interfaces;
using NorthwindTest2.Business.Repository.Interfaces;

namespace NorthwindTest2.Mvc.SampleViewModels
{
	public partial class CustomerDemographicsVm
	{
		#region member properties
		
		public virtual string CustomerTypeID { get; set;}
		
		public virtual string CustomerDesc { get; set;}
		#endregion
		
		public CustomerDemographicsVm() {}
		
		public CustomerDemographicsVm(IBOCustomerDemographics boCustomerDemographics)
		{
			CustomerTypeID = boCustomerDemographics.CustomerTypeID;
			CustomerDesc = boCustomerDemographics.CustomerDesc;
		}
		
		public IBOCustomerDemographics BOCustomerDemographics()
		{
			var boCustomerDemographics = new BOCustomerDemographics()
			{
				CustomerTypeID = this.CustomerTypeID,
				CustomerDesc = this.CustomerDesc
			};
			return boCustomerDemographics;
		}
		
		public IBOCustomerDemographics BOCustomerDemographics(ICustomerDemographicsRepository repo)
		{
			BOCustomerDemographics boCustomerDemographics = (BOCustomerDemographics)BOCustomerDemographics();
			boCustomerDemographics.Repository = repo;
			return boCustomerDemographics;
		}
	}
}