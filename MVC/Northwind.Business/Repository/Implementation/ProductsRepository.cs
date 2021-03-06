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
	///This is the definition of the ProductsRepository.
	///</Summary>
	public partial class ProductsRepository : IProductsRepository, IDisposable
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
		public virtual IzNorthwindConn_BaseData BaseData(IDAOProducts daoProducts)
		{	return (IzNorthwindConn_BaseData)(DAOProducts)daoProducts;	}

		public virtual IDAOProducts New()
		{	return new DAOProducts();	}

		public virtual void Insert(IDAOProducts daoProducts)
		{	daoProducts.Insert();	}

		public virtual void Update(IDAOProducts daoProducts)
		{	daoProducts.Update();	}

		public virtual void Delete(IDAOProducts daoProducts)
		{	daoProducts.Delete();	}

		public virtual IList<IDAOProducts> SelectAll()
		{	return DAOProducts.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOProducts.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOProducts.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOProducts> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOProducts.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOProducts.SelectAllByCriteriaCount(listCriterion);	}

		public virtual IDAOProducts SelectOne(string id)
		{	return DAOProducts.SelectOne(id);	}

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
