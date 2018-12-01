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
	///This is the interface definition for the Products repository
	///</Summary>
	public partial interface IProductsRepository : IGenericRepository<IDAOProducts>, IRepositoryConnection
	{
		void Insert(IDAOProducts daoProducts);
		void Update(IDAOProducts daoProducts);
		void Delete(IDAOProducts daoProducts);
		IDAOProducts SelectOne(Int32? productID);
		IList<IDAOProducts> SelectAllBySupplierID(Int32? supplierID);
		void DeleteAllBySupplierID(Int32? supplierID);
		IList<IDAOProducts> SelectAllByCategoryID(Int32? categoryID);
		void DeleteAllByCategoryID(Int32? categoryID);
	}
}