/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 01:22:23
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Northwind.Data;
using Northwind.Data.Interfaces;
using Northwind.Business.Interfaces;
using Northwind.Business.Repository.Interfaces;

namespace Northwind.Business
{
	///<Summary>
	///Class definition
	///This is the definition of the class BOOrdersTaxStatus.
	///It maintains a collection of BOOrders objects.
	///</Summary>
	public partial class BOOrdersTaxStatus : zNorthwindConn_BaseBusiness, IBOOrdersTaxStatus, IQueryableCollection, IUnitOfWorkEntity
	{
		#region member variables
		protected string _id;
		protected string _taxStatusName;
		protected string _ctrVersion;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		List<IBOOrders> _boOrdersCollection;
		/*********************************************/
		/*repositories*********************************/
		protected IOrdersTaxStatusRepository _iOrdersTaxStatusRepository;
		protected IOrdersRepository _iOrdersRepository;
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
		public BOOrdersTaxStatus()
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
		///string id
		///</parameters>
		public void Init(string id)
		{
			try
			{
				IDAOOrdersTaxStatus daoOrdersTaxStatus = _iOrdersTaxStatusRepository.SelectOne(id);
				_id = daoOrdersTaxStatus.İd;
				_taxStatusName = daoOrdersTaxStatus.TaxStatusName;
				_ctrVersion = daoOrdersTaxStatus.CtrVersion;
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
		///DAOOrdersTaxStatus
		///</parameters>
		protected internal BOOrdersTaxStatus(IDAOOrdersTaxStatus daoOrdersTaxStatus)
		{
			try
			{
				_id = daoOrdersTaxStatus.İd;
				_taxStatusName = daoOrdersTaxStatus.TaxStatusName;
				_ctrVersion = daoOrdersTaxStatus.CtrVersion;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new OrdersTaxStatus record to the store
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
			IDAOOrdersTaxStatus daoOrdersTaxStatus = _iOrdersTaxStatusRepository.New();
			RegisterDataObject( _iOrdersTaxStatusRepository, _iOrdersTaxStatusRepository.BaseData(daoOrdersTaxStatus));
			BeginTransaction( _iOrdersTaxStatusRepository, "savenewBOOrdersTaxStatus");
			try
			{
				daoOrdersTaxStatus.İd = _id;
				daoOrdersTaxStatus.TaxStatusName = _taxStatusName;
				_iOrdersTaxStatusRepository.Insert(daoOrdersTaxStatus);
				CommitTransaction( _iOrdersTaxStatusRepository);
				Done(this);
				
				_id = daoOrdersTaxStatus.İd;
				_taxStatusName = daoOrdersTaxStatus.TaxStatusName;
				_ctrVersion = daoOrdersTaxStatus.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrdersTaxStatusRepository, "savenewBOOrdersTaxStatus");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Update
		///This method updates one OrdersTaxStatus record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrdersTaxStatus
		///</parameters>
		public virtual void Update()
		{
			Doing(this);
			IDAOOrdersTaxStatus daoOrdersTaxStatus = _iOrdersTaxStatusRepository.New();
			RegisterDataObject(_iOrdersTaxStatusRepository, _iOrdersTaxStatusRepository.BaseData(daoOrdersTaxStatus));
			BeginTransaction(_iOrdersTaxStatusRepository, "updateBOOrdersTaxStatus");
			try
			{
				daoOrdersTaxStatus.İd = _id;
				daoOrdersTaxStatus.TaxStatusName = _taxStatusName;
				daoOrdersTaxStatus.CtrVersion = _ctrVersion;
				_iOrdersTaxStatusRepository.Update(daoOrdersTaxStatus);
				CommitTransaction(_iOrdersTaxStatusRepository);
				Done(this);
				
				_id = daoOrdersTaxStatus.İd;
				_taxStatusName = daoOrdersTaxStatus.TaxStatusName;
				_ctrVersion = daoOrdersTaxStatus.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrdersTaxStatusRepository, "updateBOOrdersTaxStatus");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one OrdersTaxStatus record from the store
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
			IDAOOrdersTaxStatus daoOrdersTaxStatus = _iOrdersTaxStatusRepository.New();
			RegisterDataObject(_iOrdersTaxStatusRepository, _iOrdersTaxStatusRepository.BaseData(daoOrdersTaxStatus));
			BeginTransaction(_iOrdersTaxStatusRepository, "deleteBOOrdersTaxStatus");
			try
			{
				daoOrdersTaxStatus.İd = _id;
				_iOrdersTaxStatusRepository.Delete(daoOrdersTaxStatus);
				CommitTransaction(_iOrdersTaxStatusRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrdersTaxStatusRepository, "deleteBOOrdersTaxStatus");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///OrdersTaxStatusCollection
		///This method returns the collection of BOOrdersTaxStatus objects
		///</Summary>
		///<returns>
		///IList[IBOOrdersTaxStatus]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOOrdersTaxStatus> OrdersTaxStatusCollection(IOrdersTaxStatusRepository iOrdersTaxStatusRepository)
		{
			Doing(null);
			try
			{
				IList<IBOOrdersTaxStatus> boOrdersTaxStatusCollection = new List<IBOOrdersTaxStatus>();
				IList<IDAOOrdersTaxStatus> daoOrdersTaxStatusCollection = iOrdersTaxStatusRepository.SelectAll();
				Done(null);
				
				foreach(IDAOOrdersTaxStatus daoOrdersTaxStatus in daoOrdersTaxStatusCollection)
					boOrdersTaxStatusCollection.Add(new BOOrdersTaxStatus(daoOrdersTaxStatus));
				
				return boOrdersTaxStatusCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///OrdersTaxStatusCollectionCount
		///This method returns the collection count of BOOrdersTaxStatus objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 OrdersTaxStatusCollectionCount(IOrdersTaxStatusRepository iOrdersTaxStatusRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iOrdersTaxStatusRepository.SelectAllCount();
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
		///OrdersTaxStatusCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOOrdersTaxStatus>
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
				return _iOrdersTaxStatusRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boOrdersTaxStatusCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOOrdersTaxStatus> daoOrdersTaxStatusCollection = _iOrdersTaxStatusRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOOrdersTaxStatus resdaoOrdersTaxStatus in daoOrdersTaxStatusCollection)
					boOrdersTaxStatusCollection.Add((T)(object)new BOOrdersTaxStatus(resdaoOrdersTaxStatus));
				
				return boOrdersTaxStatusCollection;
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
		///This method returns the collection count of BOOrdersTaxStatus objects, filtered by optional criteria
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
				List<IBOOrdersTaxStatus> boOrdersTaxStatusCollection = new List<IBOOrdersTaxStatus>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iOrdersTaxStatusRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
				return objCount;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return -1;
			}
		}
		
		///<Summary>
		///OrdersCollection
		///This method returns its collection of BOOrders objects
		///</Summary>
		///<returns>
		///IList[IBOOrders]
		///</returns>
		///<parameters>
		///BOOrdersTaxStatus
		///</parameters>
		public virtual IList<IBOOrders> OrdersCollection()
		{
			Doing(this);
			try
			{
				if(_boOrdersCollection == null)
					LoadOrdersCollection();
				return _boOrdersCollection.AsReadOnly();
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///LoadOrdersCollection
		///This method loads the internal collection of BOOrders objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadOrdersCollection()
		{
			Doing(this);
			try
			{
				_boOrdersCollection = new List<IBOOrders>();
				IList<IDAOOrders> daoOrdersCollection = _iOrdersRepository.SelectAllByTaxStatusİd(_id);
				Done(this);
				
				foreach(IDAOOrders daoOrders in daoOrdersCollection)
					_boOrdersCollection.Add(new BOOrders(daoOrders));
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///AddOrders
		///This method persists a BOOrders object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrders
		///</parameters>
		public virtual void AddOrders(IBOOrders boOrders)
		{
			Doing(this);
			IDAOOrders daoOrders = _iOrdersRepository.New();
			RegisterDataObject(_iOrdersRepository, _iOrdersRepository.BaseData(daoOrders));
			BeginTransaction(_iOrdersRepository, "addOrders");
			try
			{
				daoOrders.İd = boOrders.İd;
				daoOrders.Employeeİd = boOrders.Employeeİd;
				daoOrders.Customerİd = boOrders.Customerİd;
				daoOrders.OrderDate = boOrders.OrderDate;
				daoOrders.ShippedDate = boOrders.ShippedDate;
				daoOrders.Shipperİd = boOrders.Shipperİd;
				daoOrders.ShipName = boOrders.ShipName;
				daoOrders.ShipAddress = boOrders.ShipAddress;
				daoOrders.ShipCity = boOrders.ShipCity;
				daoOrders.ShipStateProvince = boOrders.ShipStateProvince;
				daoOrders.ShipZipPostalCode = boOrders.ShipZipPostalCode;
				daoOrders.ShipCountryRegion = boOrders.ShipCountryRegion;
				daoOrders.ShippingFee = boOrders.ShippingFee;
				daoOrders.Taxes = boOrders.Taxes;
				daoOrders.PaymentType = boOrders.PaymentType;
				daoOrders.PaidDate = boOrders.PaidDate;
				daoOrders.Notes = boOrders.Notes;
				daoOrders.TaxRate = boOrders.TaxRate;
				daoOrders.Statusİd = boOrders.Statusİd;
				daoOrders.TaxStatusİd = _id;
				_iOrdersRepository.Insert(daoOrders);
				CommitTransaction(_iOrdersRepository);
				Done(this);
				
				/*pick up any primary keys, computed values etc*/
				boOrders = new BOOrders(daoOrders);
				if(_boOrdersCollection != null)
					_boOrdersCollection.Add(boOrders);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrdersRepository, "addOrders");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///DeleteAllOrders
		///This method deletes all BOOrders objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllOrders()
		{
			Doing(this);
			RegisterDataObject(_iOrdersRepository, null);
			BeginTransaction(_iOrdersRepository, "deleteAllOrders");
			try
			{
				_iOrdersRepository.DeleteAllByTaxStatusİd(_id);
				CommitTransaction(_iOrdersRepository);
				Done(this);
				if(_boOrdersCollection != null)
				{
					_boOrdersCollection.Clear();
					_boOrdersCollection = null;
				}
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrdersRepository, "deleteAllOrders");
				Handle(this, ex);
			}
		}
		
		#endregion

		#region member properties
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IOrdersTaxStatusRepository OrdersTaxStatusRepository
		{
			set
			{
				_iOrdersTaxStatusRepository = value;
			}
		}
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IOrdersRepository OrdersRepository
		{
			set
			{
				_iOrdersRepository = value;
			}
		}
		
		public virtual string İd
		{
			get
			{
				 return _id;
			}
			set
			{
				_id = value;
				_isDirty = true;
			}
		}
		
		public virtual string TaxStatusName
		{
			get
			{
				 return _taxStatusName;
			}
			set
			{
				_taxStatusName = value;
				_isDirty = true;
			}
		}
		
		public virtual string CtrVersion
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
			get {	return (object) _iOrdersTaxStatusRepository;	}
			set {	OrdersTaxStatusRepository = (IOrdersTaxStatusRepository)value;	}
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
