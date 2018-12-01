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
	public partial class OrderDetailsVm
	{
		#region member properties
		
		public virtual Int32? OrderID { get; set;}
		
		public virtual Int32? ProductID { get; set;}
		
		public virtual decimal? UnitPrice { get; set;}
		
		public virtual Int16? Quantity { get; set;}
		
		public virtual float? Discount { get; set;}
		#endregion
		
		public OrderDetailsVm() {}
		
		public OrderDetailsVm(IBOOrderDetails boOrderDetails)
		{
			OrderID = boOrderDetails.OrderID;
			ProductID = boOrderDetails.ProductID;
			UnitPrice = boOrderDetails.UnitPrice;
			Quantity = boOrderDetails.Quantity;
			Discount = boOrderDetails.Discount;
		}
		
		public IBOOrderDetails BOOrderDetails()
		{
			var boOrderDetails = new BOOrderDetails()
			{
				OrderID = this.OrderID,
				ProductID = this.ProductID,
				UnitPrice = this.UnitPrice,
				Quantity = this.Quantity,
				Discount = this.Discount
			};
			return boOrderDetails;
		}
		
		public IBOOrderDetails BOOrderDetails(IOrderDetailsRepository repo)
		{
			BOOrderDetails boOrderDetails = (BOOrderDetails)BOOrderDetails();
			boOrderDetails.Repository = repo;
			return boOrderDetails;
		}
	}
}
