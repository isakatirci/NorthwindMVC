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
	///This is the definition of the class BOShippers.
	///It maintains a collection of BOOrders objects.
	///</Summary>
	public partial class BOShippers : zNorthwindConn_BaseBusiness, IBOShippers, IQueryableCollection, IUnitOfWorkEntity
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
		protected IShippersRepository _iShippersRepository;
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
		public BOShippers()
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
				IDAOShippers daoShippers = _iShippersRepository.SelectOne(id);
				_id = daoShippers.İd;
				_company = daoShippers.Company;
				_lastName = daoShippers.LastName;
				_firstName = daoShippers.FirstName;
				_emailAddress = daoShippers.EmailAddress;
				_jobTitle = daoShippers.JobTitle;
				_businessPhone = daoShippers.BusinessPhone;
				_homePhone = daoShippers.HomePhone;
				_mobilePhone = daoShippers.MobilePhone;
				_faxNumber = daoShippers.FaxNumber;
				_address = daoShippers.Address;
				_city = daoShippers.City;
				_stateProvince = daoShippers.StateProvince;
				_zipPostalCode = daoShippers.ZipPostalCode;
				_countryRegion = daoShippers.CountryRegion;
				_webPage = daoShippers.WebPage;
				_notes = daoShippers.Notes;
				_attachments = daoShippers.Attachments;
				_ctrVersion = daoShippers.CtrVersion;
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
		///DAOShippers
		///</parameters>
		protected internal BOShippers(IDAOShippers daoShippers)
		{
			try
			{
				_id = daoShippers.İd;
				_company = daoShippers.Company;
				_lastName = daoShippers.LastName;
				_firstName = daoShippers.FirstName;
				_emailAddress = daoShippers.EmailAddress;
				_jobTitle = daoShippers.JobTitle;
				_businessPhone = daoShippers.BusinessPhone;
				_homePhone = daoShippers.HomePhone;
				_mobilePhone = daoShippers.MobilePhone;
				_faxNumber = daoShippers.FaxNumber;
				_address = daoShippers.Address;
				_city = daoShippers.City;
				_stateProvince = daoShippers.StateProvince;
				_zipPostalCode = daoShippers.ZipPostalCode;
				_countryRegion = daoShippers.CountryRegion;
				_webPage = daoShippers.WebPage;
				_notes = daoShippers.Notes;
				_attachments = daoShippers.Attachments;
				_ctrVersion = daoShippers.CtrVersion;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new Shippers record to the store
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
			IDAOShippers daoShippers = _iShippersRepository.New();
			RegisterDataObject( _iShippersRepository, _iShippersRepository.BaseData(daoShippers));
			BeginTransaction( _iShippersRepository, "savenewBOShippers");
			try
			{
				daoShippers.Company = _company;
				daoShippers.LastName = _lastName;
				daoShippers.FirstName = _firstName;
				daoShippers.EmailAddress = _emailAddress;
				daoShippers.JobTitle = _jobTitle;
				daoShippers.BusinessPhone = _businessPhone;
				daoShippers.HomePhone = _homePhone;
				daoShippers.MobilePhone = _mobilePhone;
				daoShippers.FaxNumber = _faxNumber;
				daoShippers.Address = _address;
				daoShippers.City = _city;
				daoShippers.StateProvince = _stateProvince;
				daoShippers.ZipPostalCode = _zipPostalCode;
				daoShippers.CountryRegion = _countryRegion;
				daoShippers.WebPage = _webPage;
				daoShippers.Notes = _notes;
				daoShippers.Attachments = _attachments;
				_iShippersRepository.Insert(daoShippers);
				CommitTransaction( _iShippersRepository);
				Done(this);
				
				_id = daoShippers.İd;
				_company = daoShippers.Company;
				_lastName = daoShippers.LastName;
				_firstName = daoShippers.FirstName;
				_emailAddress = daoShippers.EmailAddress;
				_jobTitle = daoShippers.JobTitle;
				_businessPhone = daoShippers.BusinessPhone;
				_homePhone = daoShippers.HomePhone;
				_mobilePhone = daoShippers.MobilePhone;
				_faxNumber = daoShippers.FaxNumber;
				_address = daoShippers.Address;
				_city = daoShippers.City;
				_stateProvince = daoShippers.StateProvince;
				_zipPostalCode = daoShippers.ZipPostalCode;
				_countryRegion = daoShippers.CountryRegion;
				_webPage = daoShippers.WebPage;
				_notes = daoShippers.Notes;
				_attachments = daoShippers.Attachments;
				_ctrVersion = daoShippers.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iShippersRepository, "savenewBOShippers");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Update
		///This method updates one Shippers record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOShippers
		///</parameters>
		public virtual void Update()
		{
			Doing(this);
			IDAOShippers daoShippers = _iShippersRepository.New();
			RegisterDataObject(_iShippersRepository, _iShippersRepository.BaseData(daoShippers));
			BeginTransaction(_iShippersRepository, "updateBOShippers");
			try
			{
				daoShippers.İd = _id;
				daoShippers.Company = _company;
				daoShippers.LastName = _lastName;
				daoShippers.FirstName = _firstName;
				daoShippers.EmailAddress = _emailAddress;
				daoShippers.JobTitle = _jobTitle;
				daoShippers.BusinessPhone = _businessPhone;
				daoShippers.HomePhone = _homePhone;
				daoShippers.MobilePhone = _mobilePhone;
				daoShippers.FaxNumber = _faxNumber;
				daoShippers.Address = _address;
				daoShippers.City = _city;
				daoShippers.StateProvince = _stateProvince;
				daoShippers.ZipPostalCode = _zipPostalCode;
				daoShippers.CountryRegion = _countryRegion;
				daoShippers.WebPage = _webPage;
				daoShippers.Notes = _notes;
				daoShippers.Attachments = _attachments;
				daoShippers.CtrVersion = _ctrVersion;
				_iShippersRepository.Update(daoShippers);
				CommitTransaction(_iShippersRepository);
				Done(this);
				
				_id = daoShippers.İd;
				_company = daoShippers.Company;
				_lastName = daoShippers.LastName;
				_firstName = daoShippers.FirstName;
				_emailAddress = daoShippers.EmailAddress;
				_jobTitle = daoShippers.JobTitle;
				_businessPhone = daoShippers.BusinessPhone;
				_homePhone = daoShippers.HomePhone;
				_mobilePhone = daoShippers.MobilePhone;
				_faxNumber = daoShippers.FaxNumber;
				_address = daoShippers.Address;
				_city = daoShippers.City;
				_stateProvince = daoShippers.StateProvince;
				_zipPostalCode = daoShippers.ZipPostalCode;
				_countryRegion = daoShippers.CountryRegion;
				_webPage = daoShippers.WebPage;
				_notes = daoShippers.Notes;
				_attachments = daoShippers.Attachments;
				_ctrVersion = daoShippers.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iShippersRepository, "updateBOShippers");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one Shippers record from the store
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
			IDAOShippers daoShippers = _iShippersRepository.New();
			RegisterDataObject(_iShippersRepository, _iShippersRepository.BaseData(daoShippers));
			BeginTransaction(_iShippersRepository, "deleteBOShippers");
			try
			{
				daoShippers.İd = _id;
				_iShippersRepository.Delete(daoShippers);
				CommitTransaction(_iShippersRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iShippersRepository, "deleteBOShippers");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///ShippersCollection
		///This method returns the collection of BOShippers objects
		///</Summary>
		///<returns>
		///IList[IBOShippers]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOShippers> ShippersCollection(IShippersRepository iShippersRepository)
		{
			Doing(null);
			try
			{
				IList<IBOShippers> boShippersCollection = new List<IBOShippers>();
				IList<IDAOShippers> daoShippersCollection = iShippersRepository.SelectAll();
				Done(null);
				
				foreach(IDAOShippers daoShippers in daoShippersCollection)
					boShippersCollection.Add(new BOShippers(daoShippers));
				
				return boShippersCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///ShippersCollectionCount
		///This method returns the collection count of BOShippers objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 ShippersCollectionCount(IShippersRepository iShippersRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iShippersRepository.SelectAllCount();
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
		///ShippersCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOShippers>
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
				return _iShippersRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boShippersCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOShippers> daoShippersCollection = _iShippersRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOShippers resdaoShippers in daoShippersCollection)
					boShippersCollection.Add((T)(object)new BOShippers(resdaoShippers));
				
				return boShippersCollection;
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
		///This method returns the collection count of BOShippers objects, filtered by optional criteria
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
				List<IBOShippers> boShippersCollection = new List<IBOShippers>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iShippersRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		///BOShippers
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
				IList<IDAOOrders> daoOrdersCollection = _iOrdersRepository.SelectAllByShipperİd(_id);
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
				daoOrders.Shipperİd = _id;
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
				_iOrdersRepository.DeleteAllByShipperİd(_id);
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
		public virtual IShippersRepository ShippersRepository
		{
			set
			{
				_iShippersRepository = value;
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
			get {	return (object) _iShippersRepository;	}
			set {	ShippersRepository = (IShippersRepository)value;	}
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
