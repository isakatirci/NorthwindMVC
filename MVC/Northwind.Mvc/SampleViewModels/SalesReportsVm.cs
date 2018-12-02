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
	public partial class SalesReportsVm
	{
		#region member properties
		
		public virtual string GroupBy { get; set;}
		
		public virtual string Display { get; set;}
		
		public virtual string Title { get; set;}
		
		public virtual string FilterRowSource { get; set;}
		
		public virtual string Default { get; set;}
		#endregion
		
		public SalesReportsVm() {}
		
		public SalesReportsVm(IBOSalesReports boSalesReports)
		{
			GroupBy = boSalesReports.GroupBy;
			Display = boSalesReports.Display;
			Title = boSalesReports.Title;
			FilterRowSource = boSalesReports.FilterRowSource;
			Default = boSalesReports.Default;
		}
		
		public IBOSalesReports BOSalesReports()
		{
			var boSalesReports = new BOSalesReports()
			{
				GroupBy = this.GroupBy,
				Display = this.Display,
				Title = this.Title,
				FilterRowSource = this.FilterRowSource,
				Default = this.Default
			};
			return boSalesReports;
		}
		
		public IBOSalesReports BOSalesReports(ISalesReportsRepository repo)
		{
			BOSalesReports boSalesReports = (BOSalesReports)BOSalesReports();
			boSalesReports.Repository = repo;
			return boSalesReports;
		}
	}
}