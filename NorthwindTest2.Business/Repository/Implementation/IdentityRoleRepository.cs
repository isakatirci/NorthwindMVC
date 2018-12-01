/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:09:42
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindTest2.Data;
using NorthwindTest2.Data.Interfaces;
using NorthwindTest2.Business.Repository.Interfaces;

namespace NorthwindTest2.Business.Repository
{
	///<Summary>
	///Class definition
	///This is the definition of the IdentityRoleRepository.
	///</Summary>
	public partial class IdentityRoleRepository : IIdentityRoleRepository, IDisposable
	{
		#region member variables
		IzNorthwindTest2Conn_TxConnectionProvider _connectionProvider;
		bool _isDisposed = false;
		#endregion

		#region disposable interface support
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool isDisposing)
		{
			if(!_isDisposed)
			{
				if(isDisposing)
				{
					if(_connectionProvider != null)
					{
						((IDisposable)_connectionProvider).Dispose();
						_connectionProvider = null;
					}
				}
			}
			_isDisposed = true;
		}
		#endregion

		#region methods
		public virtual IzNorthwindTest2Conn_BaseData BaseData(IDAOIdentityRole daoIdentityRole)
		{	return (IzNorthwindTest2Conn_BaseData)(DAOIdentityRole)daoIdentityRole;	}

		public virtual IDAOIdentityRole New()
		{	return new DAOIdentityRole();	}

		public virtual void Insert(IDAOIdentityRole daoIdentityRole)
		{	daoIdentityRole.Insert();	}

		public virtual void Update(IDAOIdentityRole daoIdentityRole)
		{	daoIdentityRole.Update();	}

		public virtual void Delete(IDAOIdentityRole daoIdentityRole)
		{	daoIdentityRole.Delete();	}

		public virtual IList<IDAOIdentityRole> SelectAll()
		{	return DAOIdentityRole.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOIdentityRole.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOIdentityRole.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOIdentityRole> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOIdentityRole.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOIdentityRole.SelectAllByCriteriaCount(listCriterion);	}

		public virtual IDAOIdentityRole SelectOne(Int32? ıd)
		{	return DAOIdentityRole.SelectOne(ıd);	}

		#endregion

		#region properties
		public virtual IzNorthwindTest2Conn_TxConnectionProvider ConnectionProvider
		{
			get { return _connectionProvider; }
			set { _connectionProvider = value; }
		}

		#endregion

	}
}
