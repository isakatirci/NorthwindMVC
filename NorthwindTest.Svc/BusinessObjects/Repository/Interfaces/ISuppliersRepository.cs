/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:26:31
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindTest.DataObjects.Interfaces;

namespace NorthwindTest.BusinessObjects.Repository.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the Suppliers repository
	///</Summary>
	public partial interface ISuppliersRepository : IGenericRepository<IDAOSuppliers>, IRepositoryConnection
	{
		void Insert(IDAOSuppliers daoSuppliers);
		void Update(IDAOSuppliers daoSuppliers);
		void Delete(IDAOSuppliers daoSuppliers);
		IDAOSuppliers SelectOne(Int32? supplierID);
	}
}
