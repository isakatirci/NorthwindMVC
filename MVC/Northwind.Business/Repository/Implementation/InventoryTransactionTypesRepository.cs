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
	///This is the definition of the İnventoryTransactionTypesRepository.
	///</Summary>
	public partial class InventoryTransactionTypesRepository : IInventoryTransactionTypesRepository, IDisposable
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
		public virtual IzNorthwindConn_BaseData BaseData(IDAOİnventoryTransactionTypes daoİnventoryTransactionTypes)
		{	return (IzNorthwindConn_BaseData)(DAOInventoryTransactionTypes)daoİnventoryTransactionTypes;	}

		public virtual IDAOİnventoryTransactionTypes New()
		{	return new DAOInventoryTransactionTypes();	}

		public virtual void Insert(IDAOİnventoryTransactionTypes daoİnventoryTransactionTypes)
		{	daoİnventoryTransactionTypes.Insert();	}

		public virtual void Update(IDAOİnventoryTransactionTypes daoİnventoryTransactionTypes)
		{	daoİnventoryTransactionTypes.Update();	}

		public virtual void Delete(IDAOİnventoryTransactionTypes daoİnventoryTransactionTypes)
		{	daoİnventoryTransactionTypes.Delete();	}

		public virtual IList<IDAOİnventoryTransactionTypes> SelectAll()
		{	return DAOInventoryTransactionTypes.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOInventoryTransactionTypes.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOInventoryTransactionTypes.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOİnventoryTransactionTypes> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOInventoryTransactionTypes.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOInventoryTransactionTypes.SelectAllByCriteriaCount(listCriterion);	}

		public virtual IDAOİnventoryTransactionTypes SelectOne(string id)
		{	return DAOInventoryTransactionTypes.SelectOne(id);	}

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