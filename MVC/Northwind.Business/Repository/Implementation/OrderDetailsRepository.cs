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
	///This is the definition of the OrderDetailsRepository.
	///</Summary>
	public partial class OrderDetailsRepository : IOrderDetailsRepository, IDisposable
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
		public virtual IzNorthwindConn_BaseData BaseData(IDAOOrderDetails daoOrderDetails)
		{	return (IzNorthwindConn_BaseData)(DAOOrderDetails)daoOrderDetails;	}

		public virtual IDAOOrderDetails New()
		{	return new DAOOrderDetails();	}

		public virtual void Insert(IDAOOrderDetails daoOrderDetails)
		{	daoOrderDetails.Insert();	}

		public virtual void Update(IDAOOrderDetails daoOrderDetails)
		{	daoOrderDetails.Update();	}

		public virtual void Delete(IDAOOrderDetails daoOrderDetails)
		{	daoOrderDetails.Delete();	}

		public virtual IList<IDAOOrderDetails> SelectAll()
		{	return DAOOrderDetails.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOOrderDetails.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOOrderDetails.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOOrderDetails> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOOrderDetails.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOOrderDetails.SelectAllByCriteriaCount(listCriterion);	}

		public virtual IDAOOrderDetails SelectOne(string id)
		{	return DAOOrderDetails.SelectOne(id);	}

		public virtual IList<IDAOOrderDetails> SelectAllByOrderİd(string orderİd)
		{	return DAOOrderDetails.SelectAllByOrderİd(orderİd);	}

		public virtual void DeleteAllByOrderİd(string orderİd)
		{	DAOOrderDetails.DeleteAllByOrderİd(ConnectionProvider, orderİd);	}

		public virtual IList<IDAOOrderDetails> SelectAllByProductİd(string productİd)
		{	return DAOOrderDetails.SelectAllByProductİd(productİd);	}

		public virtual void DeleteAllByProductİd(string productİd)
		{	DAOOrderDetails.DeleteAllByProductİd(ConnectionProvider, productİd);	}

		public virtual IList<IDAOOrderDetails> SelectAllByStatusİd(string statusİd)
		{	return DAOOrderDetails.SelectAllByStatusİd(statusİd);	}

		public virtual void DeleteAllByStatusİd(string statusİd)
		{	DAOOrderDetails.DeleteAllByStatusİd(ConnectionProvider, statusİd);	}

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
