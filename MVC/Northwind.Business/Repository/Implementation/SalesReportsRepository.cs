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
	///This is the definition of the SalesReportsRepository.
	///</Summary>
	public partial class SalesReportsRepository : ISalesReportsRepository, IDisposable
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
		public virtual IzNorthwindConn_BaseData BaseData(IDAOSalesReports daoSalesReports)
		{	return (IzNorthwindConn_BaseData)(DAOSalesReports)daoSalesReports;	}

		public virtual IDAOSalesReports New()
		{	return new DAOSalesReports();	}

		public virtual void Insert(IDAOSalesReports daoSalesReports)
		{	daoSalesReports.Insert();	}

		public virtual void Update(IDAOSalesReports daoSalesReports)
		{	daoSalesReports.Update();	}

		public virtual void Delete(IDAOSalesReports daoSalesReports)
		{	daoSalesReports.Delete();	}

		public virtual IList<IDAOSalesReports> SelectAll()
		{	return DAOSalesReports.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOSalesReports.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOSalesReports.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOSalesReports> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOSalesReports.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOSalesReports.SelectAllByCriteriaCount(listCriterion);	}

		public virtual IDAOSalesReports SelectOne(string groupBy)
		{	return DAOSalesReports.SelectOne(groupBy);	}

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