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
	///This is the definition of the IdentityUserClaimRepository.
	///</Summary>
	public partial class IdentityUserClaimRepository : IIdentityUserClaimRepository, IDisposable
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
		public virtual IzNorthwindTest2Conn_BaseData BaseData(IDAOIdentityUserClaim daoIdentityUserClaim)
		{	return (IzNorthwindTest2Conn_BaseData)(DAOIdentityUserClaim)daoIdentityUserClaim;	}

		public virtual IDAOIdentityUserClaim New()
		{	return new DAOIdentityUserClaim();	}

		public virtual void Insert(IDAOIdentityUserClaim daoIdentityUserClaim)
		{	daoIdentityUserClaim.Insert();	}

		public virtual void Update(IDAOIdentityUserClaim daoIdentityUserClaim)
		{	daoIdentityUserClaim.Update();	}

		public virtual void Delete(IDAOIdentityUserClaim daoIdentityUserClaim)
		{	daoIdentityUserClaim.Delete();	}

		public virtual IList<IDAOIdentityUserClaim> SelectAll()
		{	return DAOIdentityUserClaim.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOIdentityUserClaim.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOIdentityUserClaim.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOIdentityUserClaim> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOIdentityUserClaim.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOIdentityUserClaim.SelectAllByCriteriaCount(listCriterion);	}

		public virtual IDAOIdentityUserClaim SelectOne(Int32? ıd)
		{	return DAOIdentityUserClaim.SelectOne(ıd);	}

		public virtual IList<IDAOIdentityUserClaim> SelectAllByUserId(Int32? userId)
		{	return DAOIdentityUserClaim.SelectAllByUserId(userId);	}

		public virtual void DeleteAllByUserId(Int32? userId)
		{	DAOIdentityUserClaim.DeleteAllByUserId(ConnectionProvider, userId);	}

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