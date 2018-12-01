/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:26:31
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindTest.DataObjects;
using NorthwindTest.DataObjects.Interfaces;
using NorthwindTest.BusinessObjects.Repository.Interfaces;

namespace NorthwindTest.BusinessObjects.Repository
{
	///<Summary>
	///Class definition
	///This is the definition of the OrderDetailsRepository.
	///</Summary>
	public partial class OrderDetailsRepository : IOrderDetailsRepository, IDisposable
	{
		#region member variables
		IzNorthwindTestConn_TxConnectionProvider _connectionProvider;
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
		public virtual IzNorthwindTestConn_BaseData BaseData(IDAOOrderDetails daoOrderDetails)
		{	return (IzNorthwindTestConn_BaseData)(DAOOrderDetails)daoOrderDetails;	}

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

		public virtual IDAOOrderDetails SelectOne(Int32? orderID, Int32? productID)
		{	return DAOOrderDetails.SelectOne(orderID, productID);	}

		public virtual IList<IDAOOrderDetails> SelectAllByOrderID(Int32? orderID)
		{	return DAOOrderDetails.SelectAllByOrderID(orderID);	}

		public virtual void DeleteAllByOrderID(Int32? orderID)
		{	DAOOrderDetails.DeleteAllByOrderID(ConnectionProvider, orderID);	}

		public virtual IList<IDAOOrderDetails> SelectAllByProductID(Int32? productID)
		{	return DAOOrderDetails.SelectAllByProductID(productID);	}

		public virtual void DeleteAllByProductID(Int32? productID)
		{	DAOOrderDetails.DeleteAllByProductID(ConnectionProvider, productID);	}

		#endregion

		#region properties
		public virtual IzNorthwindTestConn_TxConnectionProvider ConnectionProvider
		{
			get { return _connectionProvider; }
			set { _connectionProvider = value; }
		}

		#endregion

	}
}
