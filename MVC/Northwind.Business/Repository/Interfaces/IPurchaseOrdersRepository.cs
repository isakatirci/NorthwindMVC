/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 01:22:24
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using Northwind.Data.Interfaces;

namespace Northwind.Business.Repository.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the PurchaseOrders repository
	///</Summary>
	public partial interface IPurchaseOrdersRepository : IGenericRepository<IDAOPurchaseOrders>, IRepositoryConnection
	{
		void Insert(IDAOPurchaseOrders daoPurchaseOrders);
		void Update(IDAOPurchaseOrders daoPurchaseOrders);
		void Delete(IDAOPurchaseOrders daoPurchaseOrders);
		IDAOPurchaseOrders SelectOne(string id);
		IList<IDAOPurchaseOrders> SelectAllBySupplierİd(string supplierİd);
		void DeleteAllBySupplierİd(string supplierİd);
		IList<IDAOPurchaseOrders> SelectAllByCreatedBy(string createdBy);
		void DeleteAllByCreatedBy(string createdBy);
		IList<IDAOPurchaseOrders> SelectAllByStatusİd(string statusİd);
		void DeleteAllByStatusİd(string statusİd);
	}
}
