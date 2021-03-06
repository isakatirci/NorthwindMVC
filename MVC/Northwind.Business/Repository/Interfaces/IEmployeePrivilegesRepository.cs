/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 01:22:23
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using Northwind.Data.Interfaces;

namespace Northwind.Business.Repository.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the EmployeePrivileges repository
	///</Summary>
	public partial interface IEmployeePrivilegesRepository : IGenericRepository<IDAOEmployeePrivileges>, IRepositoryConnection
	{
		void Insert(IDAOEmployeePrivileges daoEmployeePrivileges);
		void Delete(IDAOEmployeePrivileges daoEmployeePrivileges);
		IDAOEmployeePrivileges SelectOne(string employeeİd, string privilegeİd);
		IList<IDAOEmployeePrivileges> SelectAllByEmployeeİd(string employeeİd);
		void DeleteAllByEmployeeİd(string employeeİd);
		IList<IDAOEmployeePrivileges> SelectAllByPrivilegeİd(string privilegeİd);
		void DeleteAllByPrivilegeİd(string privilegeİd);
	}
}
