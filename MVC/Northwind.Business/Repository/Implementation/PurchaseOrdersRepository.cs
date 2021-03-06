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
	///This is the definition of the PurchaseOrdersRepository.
	///</Summary>
	public partial class PurchaseOrdersRepository : IPurchaseOrdersRepository, IDisposable
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
		public virtual IzNorthwindConn_BaseData BaseData(IDAOPurchaseOrders daoPurchaseOrders)
		{	return (IzNorthwindConn_BaseData)(DAOPurchaseOrders)daoPurchaseOrders;	}

		public virtual IDAOPurchaseOrders New()
		{	return new DAOPurchaseOrders();	}

		public virtual void Insert(IDAOPurchaseOrders daoPurchaseOrders)
		{	daoPurchaseOrders.Insert();	}

		public virtual void Update(IDAOPurchaseOrders daoPurchaseOrders)
		{	daoPurchaseOrders.Update();	}

		public virtual void Delete(IDAOPurchaseOrders daoPurchaseOrders)
		{	daoPurchaseOrders.Delete();	}

		public virtual IList<IDAOPurchaseOrders> SelectAll()
		{	return DAOPurchaseOrders.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOPurchaseOrders.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOPurchaseOrders.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOPurchaseOrders> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOPurchaseOrders.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOPurchaseOrders.SelectAllByCriteriaCount(listCriterion);	}

		public virtual IDAOPurchaseOrders SelectOne(string id)
		{	return DAOPurchaseOrders.SelectOne(id);	}

		public virtual IList<IDAOPurchaseOrders> SelectAllBySupplierİd(string supplierİd)
		{	return DAOPurchaseOrders.SelectAllBySupplierİd(supplierİd);	}

		public virtual void DeleteAllBySupplierİd(string supplierİd)
		{	DAOPurchaseOrders.DeleteAllBySupplierİd(ConnectionProvider, supplierİd);	}

		public virtual IList<IDAOPurchaseOrders> SelectAllByCreatedBy(string createdBy)
		{	return DAOPurchaseOrders.SelectAllByCreatedBy(createdBy);	}

		public virtual void DeleteAllByCreatedBy(string createdBy)
		{	DAOPurchaseOrders.DeleteAllByCreatedBy(ConnectionProvider, createdBy);	}

		public virtual IList<IDAOPurchaseOrders> SelectAllByStatusİd(string statusİd)
		{	return DAOPurchaseOrders.SelectAllByStatusİd(statusİd);	}

		public virtual void DeleteAllByStatusİd(string statusİd)
		{	DAOPurchaseOrders.DeleteAllByStatusİd(ConnectionProvider, statusİd);	}

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
