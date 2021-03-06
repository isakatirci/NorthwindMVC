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
	///This is the definition of the class BOCustomers.
	///It maintains a collection of BOOrders objects.
	///</Summary>
	public partial class BOCustomers : zNorthwindConn_BaseBusiness, IBOCustomers, IQueryableCollection, IUnitOfWorkEntity
	{
		#region member variables
		protected string _id;
		protected string _company;
		protected string _lastName;
		protected string _firstName;
		protected string _emailAddress;
		protected string _jobTitle;
		protected string _businessPhone;
		protected string _homePhone;
		protected string _mobilePhone;
		protected string _faxNumber;
		protected string _address;
		protected string _city;
		protected string _stateProvince;
		protected string _zipPostalCode;
		protected string _countryRegion;
		protected string _webPage;
		protected string _notes;
		protected byte[] _attachments;
		protected string _ctrVersion;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		List<IBOOrders> _boOrdersCollection;
		/*********************************************/
		/*repositories*********************************/
		protected ICustomersRepository _iCustomersRepository;
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
		///string id
		///</parameters>
		public void Init(string id)
		{
			try
			{
				IDAOCustomers daoCustomers = _iCustomersRepository.SelectOne(id);
				_id = daoCustomers.İd;
				_company = daoCustomers.Company;
				_lastName = daoCustomers.LastName;
				_firstName = daoCustomers.FirstName;
				_emailAddress = daoCustomers.EmailAddress;
				_jobTitle = daoCustomers.JobTitle;
				_businessPhone = daoCustomers.BusinessPhone;
				_homePhone = daoCustomers.HomePhone;
				_mobilePhone = daoCustomers.MobilePhone;
				_faxNumber = daoCustomers.FaxNumber;
				_address = daoCustomers.Address;
				_city = daoCustomers.City;
				_stateProvince = daoCustomers.StateProvince;
				_zipPostalCode = daoCustomers.ZipPostalCode;
				_countryRegion = daoCustomers.CountryRegion;
				_webPage = daoCustomers.WebPage;
				_notes = daoCustomers.Notes;
				_attachments = daoCustomers.Attachments;
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
				_id = daoCustomers.İd;
				_company = daoCustomers.Company;
				_lastName = daoCustomers.LastName;
				_firstName = daoCustomers.FirstName;
				_emailAddress = daoCustomers.EmailAddress;
				_jobTitle = daoCustomers.JobTitle;
				_businessPhone = daoCustomers.BusinessPhone;
				_homePhone = daoCustomers.HomePhone;
				_mobilePhone = daoCustomers.MobilePhone;
				_faxNumber = daoCustomers.FaxNumber;
				_address = daoCustomers.Address;
				_city = daoCustomers.City;
				_stateProvince = daoCustomers.StateProvince;
				_zipPostalCode = daoCustomers.ZipPostalCode;
				_countryRegion = daoCustomers.CountryRegion;
				_webPage = daoCustomers.WebPage;
				_notes = daoCustomers.Notes;
				_attachments = daoCustomers.Attachments;
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
				daoCustomers.Company = _company;
				daoCustomers.LastName = _lastName;
				daoCustomers.FirstName = _firstName;
				daoCustomers.EmailAddress = _emailAddress;
				daoCustomers.JobTitle = _jobTitle;
				daoCustomers.BusinessPhone = _businessPhone;
				daoCustomers.HomePhone = _homePhone;
				daoCustomers.MobilePhone = _mobilePhone;
				daoCustomers.FaxNumber = _faxNumber;
				daoCustomers.Address = _address;
				daoCustomers.City = _city;
				daoCustomers.StateProvince = _stateProvince;
				daoCustomers.ZipPostalCode = _zipPostalCode;
				daoCustomers.CountryRegion = _countryRegion;
				daoCustomers.WebPage = _webPage;
				daoCustomers.Notes = _notes;
				daoCustomers.Attachments = _attachments;
				_iCustomersRepository.Insert(daoCustomers);
				CommitTransaction( _iCustomersRepository);
				Done(this);
				
				_id = daoCustomers.İd;
				_company = daoCustomers.Company;
				_lastName = daoCustomers.LastName;
				_firstName = daoCustomers.FirstName;
				_emailAddress = daoCustomers.EmailAddress;
				_jobTitle = daoCustomers.JobTitle;
				_businessPhone = daoCustomers.BusinessPhone;
				_homePhone = daoCustomers.HomePhone;
				_mobilePhone = daoCustomers.MobilePhone;
				_faxNumber = daoCustomers.FaxNumber;
				_address = daoCustomers.Address;
				_city = daoCustomers.City;
				_stateProvince = daoCustomers.StateProvince;
				_zipPostalCode = daoCustomers.ZipPostalCode;
				_countryRegion = daoCustomers.CountryRegion;
				_webPage = daoCustomers.WebPage;
				_notes = daoCustomers.Notes;
				_attachments = daoCustomers.Attachments;
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
				daoCustomers.İd = _id;
				daoCustomers.Company = _company;
				daoCustomers.LastName = _lastName;
				daoCustomers.FirstName = _firstName;
				daoCustomers.EmailAddress = _emailAddress;
				daoCustomers.JobTitle = _jobTitle;
				daoCustomers.BusinessPhone = _businessPhone;
				daoCustomers.HomePhone = _homePhone;
				daoCustomers.MobilePhone = _mobilePhone;
				daoCustomers.FaxNumber = _faxNumber;
				daoCustomers.Address = _address;
				daoCustomers.City = _city;
				daoCustomers.StateProvince = _stateProvince;
				daoCustomers.ZipPostalCode = _zipPostalCode;
				daoCustomers.CountryRegion = _countryRegion;
				daoCustomers.WebPage = _webPage;
				daoCustomers.Notes = _notes;
				daoCustomers.Attachments = _attachments;
				daoCustomers.CtrVersion = _ctrVersion;
				_iCustomersRepository.Update(daoCustomers);
				CommitTransaction(_iCustomersRepository);
				Done(this);
				
				_id = daoCustomers.İd;
				_company = daoCustomers.Company;
				_lastName = daoCustomers.LastName;
				_firstName = daoCustomers.FirstName;
				_emailAddress = daoCustomers.EmailAddress;
				_jobTitle = daoCustomers.JobTitle;
				_businessPhone = daoCustomers.BusinessPhone;
				_homePhone = daoCustomers.HomePhone;
				_mobilePhone = daoCustomers.MobilePhone;
				_faxNumber = daoCustomers.FaxNumber;
				_address = daoCustomers.Address;
				_city = daoCustomers.City;
				_stateProvince = daoCustomers.StateProvince;
				_zipPostalCode = daoCustomers.ZipPostalCode;
				_countryRegion = daoCustomers.CountryRegion;
				_webPage = daoCustomers.WebPage;
				_notes = daoCustomers.Notes;
				_attachments = daoCustomers.Attachments;
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
				daoCustomers.İd = _id;
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
				IList<IDAOOrders> daoOrdersCollection = _iOrdersRepository.SelectAllByCustomerİd(_id);
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
				daoOrders.TaxStatusİd = boOrders.TaxStatusİd;
				daoOrders.Statusİd = boOrders.Statusİd;
				daoOrders.Customerİd = _id;
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
				_iOrdersRepository.DeleteAllByCustomerİd(_id);
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
		
		public virtual string Company
		{
			get
			{
				 return _company;
			}
			set
			{
				_company = value;
				_isDirty = true;
			}
		}
		
		public virtual string LastName
		{
			get
			{
				 return _lastName;
			}
			set
			{
				_lastName = value;
				_isDirty = true;
			}
		}
		
		public virtual string FirstName
		{
			get
			{
				 return _firstName;
			}
			set
			{
				_firstName = value;
				_isDirty = true;
			}
		}
		
		public virtual string EmailAddress
		{
			get
			{
				 return _emailAddress;
			}
			set
			{
				_emailAddress = value;
				_isDirty = true;
			}
		}
		
		public virtual string JobTitle
		{
			get
			{
				 return _jobTitle;
			}
			set
			{
				_jobTitle = value;
				_isDirty = true;
			}
		}
		
		public virtual string BusinessPhone
		{
			get
			{
				 return _businessPhone;
			}
			set
			{
				_businessPhone = value;
				_isDirty = true;
			}
		}
		
		public virtual string HomePhone
		{
			get
			{
				 return _homePhone;
			}
			set
			{
				_homePhone = value;
				_isDirty = true;
			}
		}
		
		public virtual string MobilePhone
		{
			get
			{
				 return _mobilePhone;
			}
			set
			{
				_mobilePhone = value;
				_isDirty = true;
			}
		}
		
		public virtual string FaxNumber
		{
			get
			{
				 return _faxNumber;
			}
			set
			{
				_faxNumber = value;
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
		
		public virtual string StateProvince
		{
			get
			{
				 return _stateProvince;
			}
			set
			{
				_stateProvince = value;
				_isDirty = true;
			}
		}
		
		public virtual string ZipPostalCode
		{
			get
			{
				 return _zipPostalCode;
			}
			set
			{
				_zipPostalCode = value;
				_isDirty = true;
			}
		}
		
		public virtual string CountryRegion
		{
			get
			{
				 return _countryRegion;
			}
			set
			{
				_countryRegion = value;
				_isDirty = true;
			}
		}
		
		public virtual string WebPage
		{
			get
			{
				 return _webPage;
			}
			set
			{
				_webPage = value;
				_isDirty = true;
			}
		}
		
		public virtual string Notes
		{
			get
			{
				 return _notes;
			}
			set
			{
				_notes = value;
				_isDirty = true;
			}
		}
		
		public virtual byte[] Attachments
		{
			get
			{
				 return _attachments;
			}
			set
			{
				_attachments = value;
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
