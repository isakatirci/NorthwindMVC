/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:11:04
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindTest2.Data.Interfaces;

namespace NorthwindTest2.Business.Repository.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the CustomerCustomerDemo repository
	///</Summary>
	public partial interface ICustomerCustomerDemoRepository : IGenericRepository<IDAOCustomerCustomerDemo>, IRepositoryConnection
	{
		void Insert(IDAOCustomerCustomerDemo daoCustomerCustomerDemo);
		void Delete(IDAOCustomerCustomerDemo daoCustomerCustomerDemo);
		IDAOCustomerCustomerDemo SelectOne(string customerID, string customerTypeID);
		IList<IDAOCustomerCustomerDemo> SelectAllByCustomerID(string customerID);
		void DeleteAllByCustomerID(string customerID);
		IList<IDAOCustomerCustomerDemo> SelectAllByCustomerTypeID(string customerTypeID);
		void DeleteAllByCustomerTypeID(string customerTypeID);
	}
}
