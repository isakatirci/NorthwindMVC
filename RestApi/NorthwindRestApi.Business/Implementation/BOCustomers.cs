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
	///This is the definition of the class BOCustomers.
	///It maintains a collection of BOCustomerCustomerDemo,BOOrders objects.
	///</Summary>
	public partial class BOCustomers : zNorthwindRestApiConn_BaseBusiness, IBOCustomers, IQueryableCollection, IUnitOfWorkEntity
	{
		#region member variables
		protected string _customerID;
		protected string _companyName;
		protected string _contactName;
		protected string _contactTitle;
		protected string _address;
		protected string _city;
		protected string _region;
		protected string _postalCode;
		protected string _country;
		protected string _phone;
		protected string _fax;
		protected Int32? _ctrVersion;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		List<IBOCustomerCustomerDemo> _boCustomerCustomerDemoCollection;
		List<IBOOrders> _boOrdersCollection;
		/*********************************************/
		/*repositories*********************************/
		protected ICustomersRepository _iCustomersRepository;
		protected ICustomerCustomerDemoRepository _iCustomerCustomerDemoRepository;
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
		public BOCustomers()
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
		///string customerID
		///</parameters>
		public void Init(string customerID)
		{
			try
			{
				IDAOCustomers daoCustomers = _iCustomersRepository.SelectOne(customerID);
				_customerID = daoCustomers.CustomerID;
				_companyName = daoCustomers.CompanyName;
				_contactName = daoCustomers.ContactName;
				_contactTitle = daoCustomers.ContactTitle;
				_address = daoCustomers.Address;
				_city = daoCustomers.City;
				_region = daoCustomers.Region;
				_postalCode = daoCustomers.PostalCode;
				_country = daoCustomers.Country;
				_phone = daoCustomers.Phone;
				_fax = daoCustomers.Fax;
				_ctrVersion = daoCustomers.CtrVersion;
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
		///DAOCustomers
		///</parameters>
		protected internal BOCustomers(IDAOCustomers daoCustomers)
		{
			try
			{
				_customerID = daoCustomers.CustomerID;
				_companyName = daoCustomers.CompanyName;
				_contactName = daoCustomers.ContactName;
				_contactTitle = daoCustomers.ContactTitle;
				_address = daoCustomers.Address;
				_city = daoCustomers.City;
				_region = daoCustomers.Region;
				_postalCode = daoCustomers.PostalCode;
				_country = daoCustomers.Country;
				_phone = daoCustomers.Phone;
				_fax = daoCustomers.Fax;
				_ctrVersion = daoCustomers.CtrVersion;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new Customers record to the store
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
			IDAOCustomers daoCustomers = _iCustomersRepository.New();
			RegisterDataObject( _iCustomersRepository, _iCustomersRepository.BaseData(daoCustomers));
			BeginTransaction( _iCustomersRepository, "savenewBOCustomers");
			try
			{
				daoCustomers.CustomerID = _customerID;
				daoCustomers.CompanyName = _companyName;
				daoCustomers.ContactName = _contactName;
				daoCustomers.ContactTitle = _contactTitle;
				daoCustomers.Address = _address;
				daoCustomers.City = _city;
				daoCustomers.Region = _region;
				daoCustomers.PostalCode = _postalCode;
				daoCustomers.Country = _country;
				daoCustomers.Phone = _phone;
				daoCustomers.Fax = _fax;
				_iCustomersRepository.Insert(daoCustomers);
				CommitTransaction( _iCustomersRepository);
				Done(this);
				
				_customerID = daoCustomers.CustomerID;
				_companyName = daoCustomers.CompanyName;
				_contactName = daoCustomers.ContactName;
				_contactTitle = daoCustomers.ContactTitle;
				_address = daoCustomers.Address;
				_city = daoCustomers.City;
				_region = daoCustomers.Region;
				_postalCode = daoCustomers.PostalCode;
				_country = daoCustomers.Country;
				_phone = daoCustomers.Phone;
				_fax = daoCustomers.Fax;
				_ctrVersion = daoCustomers.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iCustomersRepository, "savenewBOCustomers");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Update
		///This method updates one Customers record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOCustomers
		///</parameters>
		public virtual void Update()
		{
			Doing(this);
			IDAOCustomers daoCustomers = _iCustomersRepository.New();
			RegisterDataObject(_iCustomersRepository, _iCustomersRepository.BaseData(daoCustomers));
			BeginTransaction(_iCustomersRepository, "updateBOCustomers");
			try
			{
				daoCustomers.CustomerID = _customerID;
				daoCustomers.CompanyName = _companyName;
				daoCustomers.ContactName = _contactName;
				daoCustomers.ContactTitle = _contactTitle;
				daoCustomers.Address = _address;
				daoCustomers.City = _city;
				daoCustomers.Region = _region;
				daoCustomers.PostalCode = _postalCode;
				daoCustomers.Country = _country;
				daoCustomers.Phone = _phone;
				daoCustomers.Fax = _fax;
				daoCustomers.CtrVersion = _ctrVersion;
				_iCustomersRepository.Update(daoCustomers);
				CommitTransaction(_iCustomersRepository);
				Done(this);
				
				_customerID = daoCustomers.CustomerID;
				_companyName = daoCustomers.CompanyName;
				_contactName = daoCustomers.ContactName;
				_contactTitle = daoCustomers.ContactTitle;
				_address = daoCustomers.Address;
				_city = daoCustomers.City;
				_region = daoCustomers.Region;
				_postalCode = daoCustomers.PostalCode;
				_country = daoCustomers.Country;
				_phone = daoCustomers.Phone;
				_fax = daoCustomers.Fax;
				_ctrVersion = daoCustomers.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iCustomersRepository, "updateBOCustomers");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one Customers record from the store
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
			IDAOCustomers daoCustomers = _iCustomersRepository.New();
			RegisterDataObject(_iCustomersRepository, _iCustomersRepository.BaseData(daoCustomers));
			BeginTransaction(_iCustomersRepository, "deleteBOCustomers");
			try
			{
				daoCustomers.CustomerID = _customerID;
				_iCustomersRepository.Delete(daoCustomers);
				CommitTransaction(_iCustomersRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iCustomersRepository, "deleteBOCustomers");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///CustomersCollection
		///This method returns the collection of BOCustomers objects
		///</Summary>
		///<returns>
		///IList[IBOCustomers]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOCustomers> CustomersCollection(ICustomersRepository iCustomersRepository)
		{
			Doing(null);
			try
			{
				IList<IBOCustomers> boCustomersCollection = new List<IBOCustomers>();
				IList<IDAOCustomers> daoCustomersCollection = iCustomersRepository.SelectAll();
				Done(null);
				
				foreach(IDAOCustomers daoCustomers in daoCustomersCollection)
					boCustomersCollection.Add(new BOCustomers(daoCustomers));
				
				return boCustomersCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///CustomersCollectionCount
		///This method returns the collection count of BOCustomers objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 CustomersCollectionCount(ICustomersRepository iCustomersRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iCustomersRepository.SelectAllCount();
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
		///CustomersCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOCustomers>
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
				return _iCustomersRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boCustomersCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOCustomers> daoCustomersCollection = _iCustomersRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOCustomers resdaoCustomers in daoCustomersCollection)
					boCustomersCollection.Add((T)(object)new BOCustomers(resdaoCustomers));
				
				return boCustomersCollection;
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
		///This method returns the collection count of BOCustomers objects, filtered by optional criteria
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
				List<IBOCustomers> boCustomersCollection = new List<IBOCustomers>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iCustomersRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		///CustomerCustomerDemoCollection
		///This method returns its collection of BOCustomerCustomerDemo objects
		///</Summary>
		///<returns>
		///IList[IBOCustomerCustomerDemo]
		///</returns>
		///<parameters>
		///BOCustomers
		///</parameters>
		public virtual IList<IBOCustomerCustomerDemo> CustomerCustomerDemoCollection()
		{
			Doing(this);
			try
			{
				if(_boCustomerCustomerDemoCollection == null)
					LoadCustomerCustomerDemoCollection();
				return _boCustomerCustomerDemoCollection.AsReadOnly();
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
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
		///BOCustomers
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
		///LoadCustomerCustomerDemoCollection
		///This method loads the internal collection of BOCustomerCustomerDemo objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadCustomerCustomerDemoCollection()
		{
			Doing(this);
			try
			{
				_boCustomerCustomerDemoCollection = new List<IBOCustomerCustomerDemo>();
				IList<IDAOCustomerCustomerDemo> daoCustomerCustomerDemoCollection = _iCustomerCustomerDemoRepository.SelectAllByCustomerID(_customerID);
				Done(this);
				
				foreach(IDAOCustomerCustomerDemo daoCustomerCustomerDemo in daoCustomerCustomerDemoCollection)
					_boCustomerCustomerDemoCollection.Add(new BOCustomerCustomerDemo(daoCustomerCustomerDemo));
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///AddCustomerCustomerDemo
		///This method persists a BOCustomerCustomerDemo object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOCustomerCustomerDemo
		///</parameters>
		public virtual void AddCustomerCustomerDemo(IBOCustomerCustomerDemo boCustomerCustomerDemo)
		{
			Doing(this);
			IDAOCustomerCustomerDemo daoCustomerCustomerDemo = _iCustomerCustomerDemoRepository.New();
			RegisterDataObject(_iCustomerCustomerDemoRepository, _iCustomerCustomerDemoRepository.BaseData(daoCustomerCustomerDemo));
			BeginTransaction(_iCustomerCustomerDemoRepository, "addCustomerCustomerDemo");
			try
			{
				daoCustomerCustomerDemo.CustomerTypeID = boCustomerCustomerDemo.CustomerTypeID;
				daoCustomerCustomerDemo.CustomerID = _customerID;
				_iCustomerCustomerDemoRepository.Insert(daoCustomerCustomerDemo);
				CommitTransaction(_iCustomerCustomerDemoRepository);
				Done(this);
				
				/*pick up any primary keys, computed values etc*/
				boCustomerCustomerDemo = new BOCustomerCustomerDemo(daoCustomerCustomerDemo);
				if(_boCustomerCustomerDemoCollection != null)
					_boCustomerCustomerDemoCollection.Add(boCustomerCustomerDemo);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iCustomerCustomerDemoRepository, "addCustomerCustomerDemo");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///DeleteAllCustomerCustomerDemo
		///This method deletes all BOCustomerCustomerDemo objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllCustomerCustomerDemo()
		{
			Doing(this);
			RegisterDataObject(_iCustomerCustomerDemoRepository, null);
			BeginTransaction(_iCustomerCustomerDemoRepository, "deleteAllCustomerCustomerDemo");
			try
			{
				_iCustomerCustomerDemoRepository.DeleteAllByCustomerID(_customerID);
				CommitTransaction(_iCustomerCustomerDemoRepository);
				Done(this);
				if(_boCustomerCustomerDemoCollection != null)
				{
					_boCustomerCustomerDemoCollection.Clear();
					_boCustomerCustomerDemoCollection = null;
				}
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iCustomerCustomerDemoRepository, "deleteAllCustomerCustomerDemo");
				Handle(this, ex);
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
				IList<IDAOOrders> daoOrdersCollection = _iOrdersRepository.SelectAllByCustomerID(_customerID);
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
				daoOrders.OrderID = boOrders.OrderID;
				daoOrders.EmployeeID = boOrders.EmployeeID;
				daoOrders.OrderDate = boOrders.OrderDate;
				daoOrders.RequiredDate = boOrders.RequiredDate;
				daoOrders.ShippedDate = boOrders.ShippedDate;
				daoOrders.ShipVia = boOrders.ShipVia;
				daoOrders.Freight = boOrders.Freight;
				daoOrders.ShipName = boOrders.ShipName;
				daoOrders.ShipAddress = boOrders.ShipAddress;
				daoOrders.ShipCity = boOrders.ShipCity;
				daoOrders.ShipRegion = boOrders.ShipRegion;
				daoOrders.ShipPostalCode = boOrders.ShipPostalCode;
				daoOrders.ShipCountry = boOrders.ShipCountry;
				daoOrders.CustomerID = _customerID;
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
				_iOrdersRepository.DeleteAllByCustomerID(_customerID);
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
		public virtual ICustomersRepository CustomersRepository
		{
			set
			{
				_iCustomersRepository = value;
			}
		}
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual ICustomerCustomerDemoRepository CustomerCustomerDemoRepository
		{
			set
			{
				_iCustomerCustomerDemoRepository = value;
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
		
		public virtual string CustomerID
		{
			get
			{
				 return _customerID;
			}
			set
			{
				_customerID = value;
				_isDirty = true;
			}
		}
		
		public virtual string CompanyName
		{
			get
			{
				 return _companyName;
			}
			set
			{
				_companyName = value;
				_isDirty = true;
			}
		}
		
		public virtual string ContactName
		{
			get
			{
				 return _contactName;
			}
			set
			{
				_contactName = value;
				_isDirty = true;
			}
		}
		
		public virtual string ContactTitle
		{
			get
			{
				 return _contactTitle;
			}
			set
			{
				_contactTitle = value;
				_isDirty = true;
			}
		}
		
		public virtual string Address
		{
			get
			{
				 return _address;
			}
			set
			{
				_address = value;
				_isDirty = true;
			}
		}
		
		public virtual string City
		{
			get
			{
				 return _city;
			}
			set
			{
				_city = value;
				_isDirty = true;
			}
		}
		
		public virtual string Region
		{
			get
			{
				 return _region;
			}
			set
			{
				_region = value;
				_isDirty = true;
			}
		}
		
		public virtual string PostalCode
		{
			get
			{
				 return _postalCode;
			}
			set
			{
				_postalCode = value;
				_isDirty = true;
			}
		}
		
		public virtual string Country
		{
			get
			{
				 return _country;
			}
			set
			{
				_country = value;
				_isDirty = true;
			}
		}
		
		public virtual string Phone
		{
			get
			{
				 return _phone;
			}
			set
			{
				_phone = value;
				_isDirty = true;
			}
		}
		
		public virtual string Fax
		{
			get
			{
				 return _fax;
			}
			set
			{
				_fax = value;
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
			get {	return (object) _iCustomersRepository;	}
			set {	CustomersRepository = (ICustomersRepository)value;	}
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
