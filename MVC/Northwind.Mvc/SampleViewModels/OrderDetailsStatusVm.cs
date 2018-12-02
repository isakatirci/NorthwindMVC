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
	public partial class OrderDetailsStatusVm
	{
		#region member properties
		
		public virtual string İd { get; set;}
		
		public virtual string StatusName { get; set;}
		#endregion
		
		public OrderDetailsStatusVm() {}
		
		public OrderDetailsStatusVm(IBOOrderDetailsStatus boOrderDetailsStatus)
		{
			İd = boOrderDetailsStatus.İd;
			StatusName = boOrderDetailsStatus.StatusName;
		}
		
		public IBOOrderDetailsStatus BOOrderDetailsStatus()
		{
			var boOrderDetailsStatus = new BOOrderDetailsStatus()
			{
				İd = this.İd,
				StatusName = this.StatusName
			};
			return boOrderDetailsStatus;
		}
		
		public IBOOrderDetailsStatus BOOrderDetailsStatus(IOrderDetailsStatusRepository repo)
		{
			BOOrderDetailsStatus boOrderDetailsStatus = (BOOrderDetailsStatus)BOOrderDetailsStatus();
			boOrderDetailsStatus.Repository = repo;
			return boOrderDetailsStatus;
		}
	}
}