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
	///This is the definition of the class BOSuppliers.
	///It maintains a collection of BOProducts objects.
	///</Summary>
	public partial class BOSuppliers : zNorthwindRestApiConn_BaseBusiness, IBOSuppliers, IQueryableCollection, IUnitOfWorkEntity
	{
		#region member variables
		protected Int32? _supplierID;
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
		protected string _homePage;
		protected Int32? _ctrVersion;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		List<IBOProducts> _boProductsCollection;
		/*********************************************/
		/*repositories*********************************/
		protected ISuppliersRepository _iSuppliersRepository;
		protected IProductsRepository _iProductsRepository;
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
		public BOSuppliers()
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
		///Int32 supplierID
		///</parameters>
		public void Init(Int32 supplierID)
		{
			try
			{
				IDAOSuppliers daoSuppliers = _iSuppliersRepository.SelectOne(supplierID);
				_supplierID = daoSuppliers.SupplierID;
				_companyName = daoSuppliers.CompanyName;
				_contactName = daoSuppliers.ContactName;
				_contactTitle = daoSuppliers.ContactTitle;
				_address = daoSuppliers.Address;
				_city = daoSuppliers.City;
				_region = daoSuppliers.Region;
				_postalCode = daoSuppliers.PostalCode;
				_country = daoSuppliers.Country;
				_phone = daoSuppliers.Phone;
				_fax = daoSuppliers.Fax;
				_homePage = daoSuppliers.HomePage;
				_ctrVersion = daoSuppliers.CtrVersion;
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
		///DAOSuppliers
		///</parameters>
		protected internal BOSuppliers(IDAOSuppliers daoSuppliers)
		{
			try
			{
				_supplierID = daoSuppliers.SupplierID;
				_companyName = daoSuppliers.CompanyName;
				_contactName = daoSuppliers.ContactName;
				_contactTitle = daoSuppliers.ContactTitle;
				_address = daoSuppliers.Address;
				_city = daoSuppliers.City;
				_region = daoSuppliers.Region;
				_postalCode = daoSuppliers.PostalCode;
				_country = daoSuppliers.Country;
				_phone = daoSuppliers.Phone;
				_fax = daoSuppliers.Fax;
				_homePage = daoSuppliers.HomePage;
				_ctrVersion = daoSuppliers.CtrVersion;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new Suppliers record to the store
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
			IDAOSuppliers daoSuppliers = _iSuppliersRepository.New();
			RegisterDataObject( _iSuppliersRepository, _iSuppliersRepository.BaseData(daoSuppliers));
			BeginTransaction( _iSuppliersRepository, "savenewBOSuppliers");
			try
			{
				daoSuppliers.CompanyName = _companyName;
				daoSuppliers.ContactName = _contactName;
				daoSuppliers.ContactTitle = _contactTitle;
				daoSuppliers.Address = _address;
				daoSuppliers.City = _city;
				daoSuppliers.Region = _region;
				daoSuppliers.PostalCode = _postalCode;
				daoSuppliers.Country = _country;
				daoSuppliers.Phone = _phone;
				daoSuppliers.Fax = _fax;
				daoSuppliers.HomePage = _homePage;
				_iSuppliersRepository.Insert(daoSuppliers);
				CommitTransaction( _iSuppliersRepository);
				Done(this);
				
				_supplierID = daoSuppliers.SupplierID;
				_companyName = daoSuppliers.CompanyName;
				_contactName = daoSuppliers.ContactName;
				_contactTitle = daoSuppliers.ContactTitle;
				_address = daoSuppliers.Address;
				_city = daoSuppliers.City;
				_region = daoSuppliers.Region;
				_postalCode = daoSuppliers.PostalCode;
				_country = daoSuppliers.Country;
				_phone = daoSuppliers.Phone;
				_fax = daoSuppliers.Fax;
				_homePage = daoSuppliers.HomePage;
				_ctrVersion = daoSuppliers.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iSuppliersRepository, "savenewBOSuppliers");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Update
		///This method updates one Suppliers record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOSuppliers
		///</parameters>
		public virtual void Update()
		{
			Doing(this);
			IDAOSuppliers daoSuppliers = _iSuppliersRepository.New();
			RegisterDataObject(_iSuppliersRepository, _iSuppliersRepository.BaseData(daoSuppliers));
			BeginTransaction(_iSuppliersRepository, "updateBOSuppliers");
			try
			{
				daoSuppliers.SupplierID = _supplierID;
				daoSuppliers.CompanyName = _companyName;
				daoSuppliers.ContactName = _contactName;
				daoSuppliers.ContactTitle = _contactTitle;
				daoSuppliers.Address = _address;
				daoSuppliers.City = _city;
				daoSuppliers.Region = _region;
				daoSuppliers.PostalCode = _postalCode;
				daoSuppliers.Country = _country;
				daoSuppliers.Phone = _phone;
				daoSuppliers.Fax = _fax;
				daoSuppliers.HomePage = _homePage;
				daoSuppliers.CtrVersion = _ctrVersion;
				_iSuppliersRepository.Update(daoSuppliers);
				CommitTransaction(_iSuppliersRepository);
				Done(this);
				
				_supplierID = daoSuppliers.SupplierID;
				_companyName = daoSuppliers.CompanyName;
				_contactName = daoSuppliers.ContactName;
				_contactTitle = daoSuppliers.ContactTitle;
				_address = daoSuppliers.Address;
				_city = daoSuppliers.City;
				_region = daoSuppliers.Region;
				_postalCode = daoSuppliers.PostalCode;
				_country = daoSuppliers.Country;
				_phone = daoSuppliers.Phone;
				_fax = daoSuppliers.Fax;
				_homePage = daoSuppliers.HomePage;
				_ctrVersion = daoSuppliers.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iSuppliersRepository, "updateBOSuppliers");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one Suppliers record from the store
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
			IDAOSuppliers daoSuppliers = _iSuppliersRepository.New();
			RegisterDataObject(_iSuppliersRepository, _iSuppliersRepository.BaseData(daoSuppliers));
			BeginTransaction(_iSuppliersRepository, "deleteBOSuppliers");
			try
			{
				daoSuppliers.SupplierID = _supplierID;
				_iSuppliersRepository.Delete(daoSuppliers);
				CommitTransaction(_iSuppliersRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iSuppliersRepository, "deleteBOSuppliers");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///SuppliersCollection
		///This method returns the collection of BOSuppliers objects
		///</Summary>
		///<returns>
		///IList[IBOSuppliers]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOSuppliers> SuppliersCollection(ISuppliersRepository iSuppliersRepository)
		{
			Doing(null);
			try
			{
				IList<IBOSuppliers> boSuppliersCollection = new List<IBOSuppliers>();
				IList<IDAOSuppliers> daoSuppliersCollection = iSuppliersRepository.SelectAll();
				Done(null);
				
				foreach(IDAOSuppliers daoSuppliers in daoSuppliersCollection)
					boSuppliersCollection.Add(new BOSuppliers(daoSuppliers));
				
				return boSuppliersCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///SuppliersCollectionCount
		///This method returns the collection count of BOSuppliers objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 SuppliersCollectionCount(ISuppliersRepository iSuppliersRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iSuppliersRepository.SelectAllCount();
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
		///SuppliersCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOSuppliers>
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
				return _iSuppliersRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boSuppliersCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOSuppliers> daoSuppliersCollection = _iSuppliersRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOSuppliers resdaoSuppliers in daoSuppliersCollection)
					boSuppliersCollection.Add((T)(object)new BOSuppliers(resdaoSuppliers));
				
				return boSuppliersCollection;
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
		///This method returns the collection count of BOSuppliers objects, filtered by optional criteria
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
				List<IBOSuppliers> boSuppliersCollection = new List<IBOSuppliers>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iSuppliersRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		///ProductsCollection
		///This method returns its collection of BOProducts objects
		///</Summary>
		///<returns>
		///IList[IBOProducts]
		///</returns>
		///<parameters>
		///BOSuppliers
		///</parameters>
		public virtual IList<IBOProducts> ProductsCollection()
		{
			Doing(this);
			try
			{
				if(_boProductsCollection == null)
					LoadProductsCollection();
				return _boProductsCollection.AsReadOnly();
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///LoadProductsCollection
		///This method loads the internal collection of BOProducts objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadProductsCollection()
		{
			Doing(this);
			try
			{
				_boProductsCollection = new List<IBOProducts>();
				IList<IDAOProducts> daoProductsCollection = _iProductsRepository.SelectAllBySupplierID(_supplierID.Value);
				Done(this);
				
				foreach(IDAOProducts daoProducts in daoProductsCollection)
					_boProductsCollection.Add(new BOProducts(daoProducts));
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///AddProducts
		///This method persists a BOProducts object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOProducts
		///</parameters>
		public virtual void AddProducts(IBOProducts boProducts)
		{
			Doing(this);
			IDAOProducts daoProducts = _iProductsRepository.New();
			RegisterDataObject(_iProductsRepository, _iProductsRepository.BaseData(daoProducts));
			BeginTransaction(_iProductsRepository, "addProducts");
			try
			{
				daoProducts.ProductID = boProducts.ProductID;
				daoProducts.ProductName = boProducts.ProductName;
				daoProducts.CategoryID = boProducts.CategoryID;
				daoProducts.QuantityPerUnit = boProducts.QuantityPerUnit;
				daoProducts.UnitPrice = boProducts.UnitPrice;
				daoProducts.UnitsInStock = boProducts.UnitsInStock;
				daoProducts.UnitsOnOrder = boProducts.UnitsOnOrder;
				daoProducts.ReorderLevel = boProducts.ReorderLevel;
				daoProducts.Discontinued = boProducts.Discontinued;
				daoProducts.SupplierID = _supplierID.Value;
				_iProductsRepository.Insert(daoProducts);
				CommitTransaction(_iProductsRepository);
				Done(this);
				
				/*pick up any primary keys, computed values etc*/
				boProducts = new BOProducts(daoProducts);
				if(_boProductsCollection != null)
					_boProductsCollection.Add(boProducts);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iProductsRepository, "addProducts");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///DeleteAllProducts
		///This method deletes all BOProducts objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllProducts()
		{
			Doing(this);
			RegisterDataObject(_iProductsRepository, null);
			BeginTransaction(_iProductsRepository, "deleteAllProducts");
			try
			{
				_iProductsRepository.DeleteAllBySupplierID(_supplierID.Value);
				CommitTransaction(_iProductsRepository);
				Done(this);
				if(_boProductsCollection != null)
				{
					_boProductsCollection.Clear();
					_boProductsCollection = null;
				}
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iProductsRepository, "deleteAllProducts");
				Handle(this, ex);
			}
		}
		
		#endregion

		#region member properties
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual ISuppliersRepository SuppliersRepository
		{
			set
			{
				_iSuppliersRepository = value;
			}
		}
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IProductsRepository ProductsRepository
		{
			set
			{
				_iProductsRepository = value;
			}
		}
		
		public virtual Int32? SupplierID
		{
			get
			{
				 return _supplierID;
			}
			set
			{
				_supplierID = value;
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
		
		public virtual string HomePage
		{
			get
			{
				 return _homePage;
			}
			set
			{
				_homePage = value;
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
			get {	return (object) _iSuppliersRepository;	}
			set {	SuppliersRepository = (ISuppliersRepository)value;	}
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
