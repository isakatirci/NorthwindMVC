/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 01:22:24
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using Northwind.Data;
using Northwind.Data.Interfaces;
using Northwind.Business.Repository.Interfaces;

namespace Northwind.Business.Repository
{
	///<Summary>
	///Class definition
	///This is the definition of the IdentityuserprofileRepository.
	///</Summary>
	public partial class IdentityuserprofileRepository : IIdentityuserprofileRepository, IDisposable
	{
		#region member variables
		IzNorthwindConn_TxConnectionProvider _connectionProvider;
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
		public virtual IzNorthwindConn_BaseData BaseData(IDAOIdentityuserprofile daoIdentityuserprofile)
		{	return (IzNorthwindConn_BaseData)(DAOIdentityuserprofile)daoIdentityuserprofile;	}

		public virtual IDAOIdentityuserprofile New()
		{	return new DAOIdentityuserprofile();	}

		public virtual void Insert(IDAOIdentityuserprofile daoIdentityuserprofile)
		{	daoIdentityuserprofile.Insert();	}

		public virtual void Update(IDAOIdentityuserprofile daoIdentityuserprofile)
		{	daoIdentityuserprofile.Update();	}

		public virtual void Delete(IDAOIdentityuserprofile daoIdentityuserprofile)
		{	daoIdentityuserprofile.Delete();	}

		public virtual IList<IDAOIdentityuserprofile> SelectAll()
		{	return DAOIdentityuserprofile.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOIdentityuserprofile.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOIdentityuserprofile.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOIdentityuserprofile> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOIdentityuserprofile.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOIdentityuserprofile.SelectAllByCriteriaCount(listCriterion);	}

		public virtual IDAOIdentityuserprofile SelectOne(string userId)
		{	return DAOIdentityuserprofile.SelectOne(userId);	}

		#endregion

		#region properties
		public virtual IzNorthwindConn_TxConnectionProvider ConnectionProvider
		{
			get { return _connectionProvider; }
			set { _connectionProvider = value; }
		}

		#endregion

	}
}