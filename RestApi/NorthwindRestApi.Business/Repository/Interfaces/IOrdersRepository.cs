/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:13
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindRestApi.Data.Interfaces;

namespace NorthwindRestApi.Business.Repository.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the Orders repository
	///</Summary>
	public partial interface IOrdersRepository : IGenericRepository<IDAOOrders>, IRepositoryConnection
	{
		void Insert(IDAOOrders daoOrders);
		void Update(IDAOOrders daoOrders);
		void Delete(IDAOOrders daoOrders);
		IDAOOrders SelectOne(Int32? orderID);
		IList<IDAOOrders> SelectAllByCustomerID(string customerID);
		void DeleteAllByCustomerID(string customerID);
		IList<IDAOOrders> SelectAllByEmployeeID(Int32? employeeID);
		void DeleteAllByEmployeeID(Int32? employeeID);
		IList<IDAOOrders> SelectAllByShipVia(Int32? shipVia);
		void DeleteAllByShipVia(Int32? shipVia);
	}
}
