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
	public partial class ProductsVm
	{
		#region member properties
		
		public virtual string Supplierİds { get; set;}
		
		public virtual string İd { get; set;}
		
		public virtual string ProductCode { get; set;}
		
		public virtual string ProductName { get; set;}
		
		public virtual string Description { get; set;}
		
		public virtual string StandardCost { get; set;}
		
		public virtual string ListPrice { get; set;}
		
		public virtual string ReorderLevel { get; set;}
		
		public virtual string TargetLevel { get; set;}
		
		public virtual string QuantityPerUnit { get; set;}
		
		public virtual string Discontinued { get; set;}
		
		public virtual string MinimumReorderQuantity { get; set;}
		
		public virtual string Category { get; set;}
		
		public virtual string Attachments { get; set;}
		#endregion
		
		public ProductsVm() {}
		
		public ProductsVm(IBOProducts boProducts)
		{
			Supplierİds = boProducts.Supplierİds;
			İd = boProducts.İd;
			ProductCode = boProducts.ProductCode;
			ProductName = boProducts.ProductName;
			Description = boProducts.Description;
			StandardCost = boProducts.StandardCost;
			ListPrice = boProducts.ListPrice;
			ReorderLevel = boProducts.ReorderLevel;
			TargetLevel = boProducts.TargetLevel;
			QuantityPerUnit = boProducts.QuantityPerUnit;
			Discontinued = boProducts.Discontinued;
			MinimumReorderQuantity = boProducts.MinimumReorderQuantity;
			Category = boProducts.Category;
			Attachments = boProducts.Attachments != null ? Convert.ToBase64String(boProducts.Attachments) : null;
		}
		
		public IBOProducts BOProducts()
		{
			var boProducts = new BOProducts()
			{
				Supplierİds = this.Supplierİds,
				İd = this.İd,
				ProductCode = this.ProductCode,
				ProductName = this.ProductName,
				Description = this.Description,
				StandardCost = this.StandardCost,
				ListPrice = this.ListPrice,
				ReorderLevel = this.ReorderLevel,
				TargetLevel = this.TargetLevel,
				QuantityPerUnit = this.QuantityPerUnit,
				Discontinued = this.Discontinued,
				MinimumReorderQuantity = this.MinimumReorderQuantity,
				Category = this.Category,
				Attachments = this.Attachments != null ? Convert.FromBase64String(this.Attachments) : null
			};
			return boProducts;
		}
		
		public IBOProducts BOProducts(IProductsRepository repo)
		{
			BOProducts boProducts = (BOProducts)BOProducts();
			boProducts.Repository = repo;
			return boProducts;
		}
	}
}
