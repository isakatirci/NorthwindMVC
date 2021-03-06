/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:12
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using NorthwindRestApi.Data;
using NorthwindRestApi.Data.Interfaces;
using NorthwindRestApi.Business.Interfaces;
using NorthwindRestApi.Business.Repository.Interfaces;

namespace NorthwindRestApi.Business
{
	///<Summary>
	///Class definition
	///This is the definition of the class BOOrderSubtotals.
	///</Summary>
	public partial class BOOrderSubtotals : zNorthwindRestApiConn_BaseBusiness, IBOOrderSubtotals, IQueryableCollection
	{
		#region member variables
		protected Int32? _orderID;
		protected decimal? _subtotal;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected IOrderSubtotalsRepository _iOrderSubtotalsRepository;
		/*********************************************/
		#endregion

		#region class methods
		///<Summary>
		///Constructor
		///This is the default constructor
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public BOOrderSubtotals()
		{
		}

		///<Summary>
		///Constructor
		///This constructor initializes the business object from its respective data object
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///DAOOrderSubtotals
		///</parameters>
		protected internal BOOrderSubtotals(IDAOOrderSubtotals daoOrderSubtotals)
		{
			try
			{
				_orderID = daoOrderSubtotals.OrderID;
				_subtotal = daoOrderSubtotals.Subtotal;
			}
			catch
			{
				throw;
			}
		}

		
		///<Summary>
		///OrderSubtotalsCollection
		///This method returns the collection of BOOrderSubtotals objects
		///</Summary>
		///<returns>
		///IList[IBOOrderSubtotals]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOOrderSubtotals> OrderSubtotalsCollection(IOrderSubtotalsRepository iOrderSubtotalsRepository)
		{
			Doing(null);
			try
			{
				IList<IBOOrderSubtotals> boOrderSubtotalsCollection = new List<IBOOrderSubtotals>();
				IList<IDAOOrderSubtotals> daoOrderSubtotalsCollection = iOrderSubtotalsRepository.SelectAll();
				Done(null);
				
				foreach(IDAOOrderSubtotals daoOrderSubtotals in daoOrderSubtotalsCollection)
					boOrderSubtotalsCollection.Add(new BOOrderSubtotals(daoOrderSubtotals));
				
				return boOrderSubtotalsCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///OrderSubtotalsCollectionCount
		///This method returns the collection count of BOOrderSubtotals objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 OrderSubtotalsCollectionCount(IOrderSubtotalsRepository iOrderSubtotalsRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iOrderSubtotalsRepository.SelectAllCount();
				return objCount;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return -1;
			}
		}
		
		
		///<Summary>
		///OrderSubtotalsCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOOrderSubtotals>
		///</returns>
		///<parameters>
		///ICriteria icriteria
		///</parameters>
		public virtual IDictionary<string, IList<object>> Projections(object o)
		{
			Doing(this);
			try
			{
				ICriteria icriteria = (ICriteria)o;
				IList<IDataProjection> lstDataProjection = (icriteria == null) ? null : icriteria.ListDataProjection();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				return _iOrderSubtotalsRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///Collection<T>
		///This method returns the collection of T objects, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<T>
		///</returns>
		///<parameters>
		///object o (ICriteria)
		///</parameters>
		public virtual IList<T> Collection<T>(object o)
		{
			Doing(this);
			try
			{
				ICriteria icriteria = (ICriteria)o;
				IList<T> boOrderSubtotalsCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOOrderSubtotals> daoOrderSubtotalsCollection = _iOrderSubtotalsRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOOrderSubtotals resdaoOrderSubtotals in daoOrderSubtotalsCollection)
					boOrderSubtotalsCollection.Add((T)(object)new BOOrderSubtotals(resdaoOrderSubtotals));
				
				return boOrderSubtotalsCollection;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///CollectionCount
		///This method returns the collection count of BOOrderSubtotals objects, filtered by optional criteria
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///ICriteria icriteria
		///</parameters>
		public virtual Int32 CollectionCount(object o)
		{
			Doing(this);
			try
			{
				ICriteria icriteria = (ICriteria)o;
				List<IBOOrderSubtotals> boOrderSubtotalsCollection = new List<IBOOrderSubtotals>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iOrderSubtotalsRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
				return objCount;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return -1;
			}
		}
		
		#endregion

		#region member properties
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IOrderSubtotalsRepository OrderSubtotalsRepository
		{
			set
			{
				_iOrderSubtotalsRepository = value;
			}
		}
		
		public virtual Int32? OrderID
		{
			get
			{
				 return _orderID;
			}
			set
			{
				_orderID = value;
				_isDirty = true;
			}
		}
		
		public virtual decimal? Subtotal
		{
			get
			{
				 return _subtotal;
			}
			set
			{
				_subtotal = value;
				_isDirty = true;
			}
		}
		
		[XmlIgnore]
		public virtual object Repository
		{
			get {	return (object) _iOrderSubtotalsRepository;	}
			set {	OrderSubtotalsRepository = (IOrderSubtotalsRepository)value;	}
		}
		
		public virtual bool IsDirty
		{
			get
			{
				 return _isDirty;
			}
			set
			{
				_isDirty = value;
			}
		}
		#endregion
	}
}
