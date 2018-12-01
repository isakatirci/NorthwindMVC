/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:09:42
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindTest2.Data.Interfaces;

namespace NorthwindTest2.Business.Repository.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the IdentityUser repository
	///</Summary>
	public partial interface IIdentityUserRepository : IGenericRepository<IDAOIdentityUser>, IRepositoryConnection
	{
		void Insert(IDAOIdentityUser daoIdentityUser);
		void Update(IDAOIdentityUser daoIdentityUser);
		void Delete(IDAOIdentityUser daoIdentityUser);
		IDAOIdentityUser SelectOne(Int32? userId);
	}
}
