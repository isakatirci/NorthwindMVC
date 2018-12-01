/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:26:31
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using NorthwindTest.DataObjects;
using NorthwindTest.DataObjects.Interfaces;
using NorthwindTest.BusinessObjects.Interfaces;
using NorthwindTest.BusinessObjects.Repository.Interfaces;

namespace NorthwindTest.BusinessObjects
{
	///<Summary>
	///Class definition
	///This is the definition of the class BOOrderDetails.
	///</Summary>
	public partial class BOOrderDetails : zNorthwindTestConn_BaseBusiness, IBOOrderDetails, IQueryableCollection, IUnitOfWorkEntity
	{
		#region member variables
		protected Int32? _orderID;
		protected Int32? _productID;
		protected decimal? _unitPrice;
		protected Int16? _quantity;
		protected float? _discount;
		protected Int32? _ctrVersion;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected IOrderDetailsRepository _iOrderDetailsRepository;
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
		public BOOrderDetails()
		{
		}

		///<Summary>
		///Initializer
		///Initializer using primary key(s)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///Int32 orderID, Int32 productID
		///</parameters>
		public void Init(Int32 orderID, Int32 productID)
		{
			try
			{
				IDAOOrderDetails daoOrderDetails = _iOrderDetailsRepository.SelectOne(orderID, productID);
				_orderID = daoOrderDetails.OrderID;
				_productID = daoOrderDetails.ProductID;
				_unitPrice = daoOrderDetails.UnitPrice;
				_quantity = daoOrderDetails.Quantity;
				_discount = daoOrderDetails.Discount;
				_ctrVersion = daoOrderDetails.CtrVersion;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///Constructor
		///This constructor initializes the business object from its respective data object
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///DAOOrderDetails
		///</parameters>
		protected internal BOOrderDetails(IDAOOrderDetails daoOrderDetails)
		{
			try
			{
				_orderID = daoOrderDetails.OrderID;
				_productID = daoOrderDetails.ProductID;
				_unitPrice = daoOrderDetails.UnitPrice;
				_quantity = daoOrderDetails.Quantity;
				_discount = daoOrderDetails.Discount;
				_ctrVersion = daoOrderDetails.CtrVersion;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new OrderDetails record to the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void SaveNew()
		{
			Doing(this);
			IDAOOrderDetails daoOrderDetails = _iOrderDetailsRepository.New();
			RegisterDataObject( _iOrderDetailsRepository, _iOrderDetailsRepository.BaseData(daoOrderDetails));
			BeginTransaction( _iOrderDetailsRepository, "savenewBOOrderDetails");
			try
			{
				daoOrderDetails.OrderID = _orderID;
				daoOrderDetails.ProductID = _productID;
				daoOrderDetails.UnitPrice = _unitPrice;
				daoOrderDetails.Quantity = _quantity;
				daoOrderDetails.Discount = _discount;
				_iOrderDetailsRepository.Insert(daoOrderDetails);
				CommitTransaction( _iOrderDetailsRepository);
				Done(this);
				
				_orderID = daoOrderDetails.OrderID;
				_productID = daoOrderDetails.ProductID;
				_unitPrice = daoOrderDetails.UnitPrice;
				_quantity = daoOrderDetails.Quantity;
				_discount = daoOrderDetails.Discount;
				_ctrVersion = daoOrderDetails.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrderDetailsRepository, "savenewBOOrderDetails");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Update
		///This method updates one OrderDetails record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrderDetails
		///</parameters>
		public virtual void Update()
		{
			Doing(this);
			IDAOOrderDetails daoOrderDetails = _iOrderDetailsRepository.New();
			RegisterDataObject(_iOrderDetailsRepository, _iOrderDetailsRepository.BaseData(daoOrderDetails));
			BeginTransaction(_iOrderDetailsRepository, "updateBOOrderDetails");
			try
			{
				daoOrderDetails.OrderID = _orderID;
				daoOrderDetails.ProductID = _productID;
				daoOrderDetails.UnitPrice = _unitPrice;
				daoOrderDetails.Quantity = _quantity;
				daoOrderDetails.Discount = _discount;
				daoOrderDetails.CtrVersion = _ctrVersion;
				_iOrderDetailsRepository.Update(daoOrderDetails);
				CommitTransaction(_iOrderDetailsRepository);
				Done(this);
				
				_orderID = daoOrderDetails.OrderID;
				_productID = daoOrderDetails.ProductID;
				_unitPrice = daoOrderDetails.UnitPrice;
				_quantity = daoOrderDetails.Quantity;
				_discount = daoOrderDetails.Discount;
				_ctrVersion = daoOrderDetails.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrderDetailsRepository, "updateBOOrderDetails");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one OrderDetails record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Delete()
		{
			Doing(this);
			IDAOOrderDetails daoOrderDetails = _iOrderDetailsRepository.New();
			RegisterDataObject(_iOrderDetailsRepository, _iOrderDetailsRepository.BaseData(daoOrderDetails));
			BeginTransaction(_iOrderDetailsRepository, "deleteBOOrderDetails");
			try
			{
				daoOrderDetails.OrderID = _orderID;
				daoOrderDetails.ProductID = _productID;
				_iOrderDetailsRepository.Delete(daoOrderDetails);
				CommitTransaction(_iOrderDetailsRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrderDetailsRepository, "deleteBOOrderDetails");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///OrderDetailsCollection
		///This method returns the collection of BOOrderDetails objects
		///</Summary>
		///<returns>
		///IList[IBOOrderDetails]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOOrderDetails> OrderDetailsCollection(IOrderDetailsRepository iOrderDetailsRepository)
		{
			Doing(null);
			try
			{
				IList<IBOOrderDetails> boOrderDetailsCollection = new List<IBOOrderDetails>();
				IList<IDAOOrderDetails> daoOrderDetailsCollection = iOrderDetailsRepository.SelectAll();
				Done(null);
				
				foreach(IDAOOrderDetails daoOrderDetails in daoOrderDetailsCollection)
					boOrderDetailsCollection.Add(new BOOrderDetails(daoOrderDetails));
				
				return boOrderDetailsCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///OrderDetailsCollectionCount
		///This method returns the collection count of BOOrderDetails objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 OrderDetailsCollectionCount(IOrderDetailsRepository iOrderDetailsRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iOrderDetailsRepository.SelectAllCount();
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
		///OrderDetailsCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOOrderDetails>
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
				return _iOrderDetailsRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boOrderDetailsCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOOrderDetails> daoOrderDetailsCollection = _iOrderDetailsRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOOrderDetails resdaoOrderDetails in daoOrderDetailsCollection)
					boOrderDetailsCollection.Add((T)(object)new BOOrderDetails(resdaoOrderDetails));
				
				return boOrderDetailsCollection;
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
		///This method returns the collection count of BOOrderDetails objects, filtered by optional criteria
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
				List<IBOOrderDetails> boOrderDetailsCollection = new List<IBOOrderDetails>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iOrderDetailsRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		public virtual IOrderDetailsRepository OrderDetailsRepository
		{
			set
			{
				_iOrderDetailsRepository = value;
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
		
		public virtual Int32? CtrVersion
		{
			get
			{
				 return _ctrVersion;
			}
			set
			{
				_ctrVersion = value;
			}
		}
		
		[XmlIgnore]
		public virtual object Repository
		{
			get {	return (object) _iOrderDetailsRepository;	}
			set {	OrderDetailsRepository = (IOrderDetailsRepository)value;	}
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
