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
	///This is the interface definition for the Products repository
	///</Summary>
	public partial interface IProductsRepository : IGenericRepository<IDAOProducts>, IRepositoryConnection
	{
		void Insert(IDAOProducts daoProducts);
		void Update(IDAOProducts daoProducts);
		void Delete(IDAOProducts daoProducts);
		IDAOProducts SelectOne(string id);
	}
}
