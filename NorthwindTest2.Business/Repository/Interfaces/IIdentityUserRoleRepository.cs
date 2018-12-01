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
	///This is the interface definition for the IdentityUserRole repository
	///</Summary>
	public partial interface IIdentityUserRoleRepository : IGenericRepository<IDAOIdentityUserRole>, IRepositoryConnection
	{
		void Insert(IDAOIdentityUserRole daoIdentityUserRole);
		void Delete(IDAOIdentityUserRole daoIdentityUserRole);
		IDAOIdentityUserRole SelectOne(Int32? userId, Int32? roleId);
		IList<IDAOIdentityUserRole> SelectAllByUserId(Int32? userId);
		void DeleteAllByUserId(Int32? userId);
		IList<IDAOIdentityUserRole> SelectAllByRoleId(Int32? roleId);
		void DeleteAllByRoleId(Int32? roleId);
	}
}