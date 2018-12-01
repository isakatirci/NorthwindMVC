/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:13
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using NorthwindRestApi.Business;
using NorthwindRestApi.Business.Interfaces;
using NorthwindRestApi.Business.Repository.Interfaces;

namespace NorthwindRestApi.RestApi.SampleViewModels
{
	public partial class ProductsAboveAveragePriceVm
	{
		#region member properties
		
		public virtual string ProductName { get; set;}
		
		public virtual decimal? UnitPrice { get; set;}
		#endregion
		
		public ProductsAboveAveragePriceVm() {}
		
		public ProductsAboveAveragePriceVm(IBOProductsAboveAveragePrice boProductsAboveAveragePrice)
		{
			ProductName = boProductsAboveAveragePrice.ProductName;
			UnitPrice = boProductsAboveAveragePrice.UnitPrice;
		}
		
		public IBOProductsAboveAveragePrice BOProductsAboveAveragePrice()
		{
			var boProductsAboveAveragePrice = new BOProductsAboveAveragePrice()
			{
				ProductName = this.ProductName,
				UnitPrice = this.UnitPrice
			};
			return boProductsAboveAveragePrice;
		}
		
		public IBOProductsAboveAveragePrice BOProductsAboveAveragePrice(IProductsAboveAveragePriceRepository repo)
		{
			BOProductsAboveAveragePrice boProductsAboveAveragePrice = (BOProductsAboveAveragePrice)BOProductsAboveAveragePrice();
			boProductsAboveAveragePrice.Repository = repo;
			return boProductsAboveAveragePrice;
		}
	}
}