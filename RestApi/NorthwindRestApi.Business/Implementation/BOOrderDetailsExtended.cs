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
	///This is the definition of the class BOOrderDetailsExtended.
	///</Summary>
	public partial class BOOrderDetailsExtended : zNorthwindRestApiConn_BaseBusiness, IBOOrderDetailsExtended, IQueryableCollection
	{
		#region member variables
		protected Int32? _orderID;
		protected Int32? _productID;
		protected string _productName;
		protected decimal? _unitPrice;
		protected Int16? _quantity;
		protected float? _discount;
		protected decimal? _extendedPrice;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected IOrderDetailsExtendedRepository _iOrderDetailsExtendedRepository;
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
		public BOOrderDetailsExtended()
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
		///DAOOrderDetailsExtended
		///</parameters>
		protected internal BOOrderDetailsExtended(IDAOOrderDetailsExtended daoOrderDetailsExtended)
		{
			try
			{
				_orderID = daoOrderDetailsExtended.OrderID;
				_productID = daoOrderDetailsExtended.ProductID;
				_productName = daoOrderDetailsExtended.ProductName;
				_unitPrice = daoOrderDetailsExtended.UnitPrice;
				_quantity = daoOrderDetailsExtended.Quantity;
				_discount = daoOrderDetailsExtended.Discount;
				_extendedPrice = daoOrderDetailsExtended.ExtendedPrice;
			}
			catch
			{
				throw;
			}
		}

		
		///<Summary>
		///OrderDetailsExtendedCollection
		///This method returns the collection of BOOrderDetailsExtended objects
		///</Summary>
		///<returns>
		///IList[IBOOrderDetailsExtended]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOOrderDetailsExtended> OrderDetailsExtendedCollection(IOrderDetailsExtendedRepository iOrderDetailsExtendedRepository)
		{
			Doing(null);
			try
			{
				IList<IBOOrderDetailsExtended> boOrderDetailsExtendedCollection = new List<IBOOrderDetailsExtended>();
				IList<IDAOOrderDetailsExtended> daoOrderDetailsExtendedCollection = iOrderDetailsExtendedRepository.SelectAll();
				Done(null);
				
				foreach(IDAOOrderDetailsExtended daoOrderDetailsExtended in daoOrderDetailsExtendedCollection)
					boOrderDetailsExtendedCollection.Add(new BOOrderDetailsExtended(daoOrderDetailsExtended));
				
				return boOrderDetailsExtendedCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///OrderDetailsExtendedCollectionCount
		///This method returns the collection count of BOOrderDetailsExtended objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 OrderDetailsExtendedCollectionCount(IOrderDetailsExtendedRepository iOrderDetailsExtendedRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iOrderDetailsExtendedRepository.SelectAllCount();
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
		///OrderDetailsExtendedCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOOrderDetailsExtended>
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
				return _iOrderDetailsExtendedRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boOrderDetailsExtendedCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOOrderDetailsExtended> daoOrderDetailsExtendedCollection = _iOrderDetailsExtendedRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOOrderDetailsExtended resdaoOrderDetailsExtended in daoOrderDetailsExtendedCollection)
					boOrderDetailsExtendedCollection.Add((T)(object)new BOOrderDetailsExtended(resdaoOrderDetailsExtended));
				
				return boOrderDetailsExtendedCollection;
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
		///This method returns the collection count of BOOrderDetailsExtended objects, filtered by optional criteria
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
				List<IBOOrderDetailsExtended> boOrderDetailsExtendedCollection = new List<IBOOrderDetailsExtended>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iOrderDetailsExtendedRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		public virtual IOrderDetailsExtendedRepository OrderDetailsExtendedRepository
		{
			set
			{
				_iOrderDetailsExtendedRepository = value;
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
		
		public virtual Int32? ProductID
		{
			get
			{
				 return _productID;
			}
			set
			{
				_productID = value;
				_isDirty = true;
			}
		}
		
		public virtual string ProductName
		{
			get
			{
				 return _productName;
			}
			set
			{
				_productName = value;
				_isDirty = true;
			}
		}
		
		public virtual decimal? UnitPrice
		{
			get
			{
				 return _unitPrice;
			}
			set
			{
				_unitPrice = value;
				_isDirty = true;
			}
		}
		
		public virtual Int16? Quantity
		{
			get
			{
				 return _quantity;
			}
			set
			{
				_quantity = value;
				_isDirty = true;
			}
		}
		
		public virtual float? Discount
		{
			get
			{
				 return _discount;
			}
			set
			{
				_discount = value;
				_isDirty = true;
			}
		}
		
		public virtual decimal? ExtendedPrice
		{
			get
			{
				 return _extendedPrice;
			}
			set
			{
				_extendedPrice = value;
				_isDirty = true;
			}
		}
		
		[XmlIgnore]
		public virtual object Repository
		{
			get {	return (object) _iOrderDetailsExtendedRepository;	}
			set {	OrderDetailsExtendedRepository = (IOrderDetailsExtendedRepository)value;	}
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
