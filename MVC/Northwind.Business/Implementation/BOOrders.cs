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
	///This is the definition of the class BOOrders.
	///It maintains a collection of BOİnventoryTransactions,BOİnvoices,BOOrderDetails objects.
	///</Summary>
	public partial class BOOrders : zNorthwindConn_BaseBusiness, IBOOrders, IQueryableCollection, IUnitOfWorkEntity
	{
		#region member variables
		protected string _id;
		protected string _employeeİd;
		protected string _customerİd;
		protected string _orderDate;
		protected string _shippedDate;
		protected string _shipperİd;
		protected string _shipName;
		protected string _shipAddress;
		protected string _shipCity;
		protected string _shipStateProvince;
		protected string _shipZipPostalCode;
		protected string _shipCountryRegion;
		protected string _shippingFee;
		protected string _taxes;
		protected string _paymentType;
		protected string _paidDate;
		protected string _notes;
		protected double? _taxRate;
		protected string _taxStatusİd;
		protected string _statusİd;
		protected string _ctrVersion;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		List<IBOİnventoryTransactions> _boİnventoryTransactionsCollection;
		List<IBOİnvoices> _boİnvoicesCollection;
		List<IBOOrderDetails> _boOrderDetailsCollection;
		/*********************************************/
		/*repositories*********************************/
		protected IOrdersRepository _iOrdersRepository;
		protected IInventoryTransactionsRepository _iİnventoryTransactionsRepository;
		protected IInvoicesRepository _iİnvoicesRepository;
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
		public BOOrders()
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
				IDAOOrders daoOrders = _iOrdersRepository.SelectOne(id);
				_id = daoOrders.İd;
				_employeeİd = daoOrders.Employeeİd;
				_customerİd = daoOrders.Customerİd;
				_orderDate = daoOrders.OrderDate;
				_shippedDate = daoOrders.ShippedDate;
				_shipperİd = daoOrders.Shipperİd;
				_shipName = daoOrders.ShipName;
				_shipAddress = daoOrders.ShipAddress;
				_shipCity = daoOrders.ShipCity;
				_shipStateProvince = daoOrders.ShipStateProvince;
				_shipZipPostalCode = daoOrders.ShipZipPostalCode;
				_shipCountryRegion = daoOrders.ShipCountryRegion;
				_shippingFee = daoOrders.ShippingFee;
				_taxes = daoOrders.Taxes;
				_paymentType = daoOrders.PaymentType;
				_paidDate = daoOrders.PaidDate;
				_notes = daoOrders.Notes;
				_taxRate = daoOrders.TaxRate;
				_taxStatusİd = daoOrders.TaxStatusİd;
				_statusİd = daoOrders.Statusİd;
				_ctrVersion = daoOrders.CtrVersion;
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
		///DAOOrders
		///</parameters>
		protected internal BOOrders(IDAOOrders daoOrders)
		{
			try
			{
				_id = daoOrders.İd;
				_employeeİd = daoOrders.Employeeİd;
				_customerİd = daoOrders.Customerİd;
				_orderDate = daoOrders.OrderDate;
				_shippedDate = daoOrders.ShippedDate;
				_shipperİd = daoOrders.Shipperİd;
				_shipName = daoOrders.ShipName;
				_shipAddress = daoOrders.ShipAddress;
				_shipCity = daoOrders.ShipCity;
				_shipStateProvince = daoOrders.ShipStateProvince;
				_shipZipPostalCode = daoOrders.ShipZipPostalCode;
				_shipCountryRegion = daoOrders.ShipCountryRegion;
				_shippingFee = daoOrders.ShippingFee;
				_taxes = daoOrders.Taxes;
				_paymentType = daoOrders.PaymentType;
				_paidDate = daoOrders.PaidDate;
				_notes = daoOrders.Notes;
				_taxRate = daoOrders.TaxRate;
				_taxStatusİd = daoOrders.TaxStatusİd;
				_statusİd = daoOrders.Statusİd;
				_ctrVersion = daoOrders.CtrVersion;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new Orders record to the store
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
			IDAOOrders daoOrders = _iOrdersRepository.New();
			RegisterDataObject( _iOrdersRepository, _iOrdersRepository.BaseData(daoOrders));
			BeginTransaction( _iOrdersRepository, "savenewBOOrders");
			try
			{
				daoOrders.Employeeİd = _employeeİd;
				daoOrders.Customerİd = _customerİd;
				daoOrders.OrderDate = _orderDate;
				daoOrders.ShippedDate = _shippedDate;
				daoOrders.Shipperİd = _shipperİd;
				daoOrders.ShipName = _shipName;
				daoOrders.ShipAddress = _shipAddress;
				daoOrders.ShipCity = _shipCity;
				daoOrders.ShipStateProvince = _shipStateProvince;
				daoOrders.ShipZipPostalCode = _shipZipPostalCode;
				daoOrders.ShipCountryRegion = _shipCountryRegion;
				daoOrders.ShippingFee = _shippingFee;
				daoOrders.Taxes = _taxes;
				daoOrders.PaymentType = _paymentType;
				daoOrders.PaidDate = _paidDate;
				daoOrders.Notes = _notes;
				daoOrders.TaxRate = _taxRate;
				daoOrders.TaxStatusİd = _taxStatusİd;
				daoOrders.Statusİd = _statusİd;
				_iOrdersRepository.Insert(daoOrders);
				CommitTransaction( _iOrdersRepository);
				Done(this);
				
				_id = daoOrders.İd;
				_employeeİd = daoOrders.Employeeİd;
				_customerİd = daoOrders.Customerİd;
				_orderDate = daoOrders.OrderDate;
				_shippedDate = daoOrders.ShippedDate;
				_shipperİd = daoOrders.Shipperİd;
				_shipName = daoOrders.ShipName;
				_shipAddress = daoOrders.ShipAddress;
				_shipCity = daoOrders.ShipCity;
				_shipStateProvince = daoOrders.ShipStateProvince;
				_shipZipPostalCode = daoOrders.ShipZipPostalCode;
				_shipCountryRegion = daoOrders.ShipCountryRegion;
				_shippingFee = daoOrders.ShippingFee;
				_taxes = daoOrders.Taxes;
				_paymentType = daoOrders.PaymentType;
				_paidDate = daoOrders.PaidDate;
				_notes = daoOrders.Notes;
				_taxRate = daoOrders.TaxRate;
				_taxStatusİd = daoOrders.TaxStatusİd;
				_statusİd = daoOrders.Statusİd;
				_ctrVersion = daoOrders.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrdersRepository, "savenewBOOrders");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Update
		///This method updates one Orders record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrders
		///</parameters>
		public virtual void Update()
		{
			Doing(this);
			IDAOOrders daoOrders = _iOrdersRepository.New();
			RegisterDataObject(_iOrdersRepository, _iOrdersRepository.BaseData(daoOrders));
			BeginTransaction(_iOrdersRepository, "updateBOOrders");
			try
			{
				daoOrders.İd = _id;
				daoOrders.Employeeİd = _employeeİd;
				daoOrders.Customerİd = _customerİd;
				daoOrders.OrderDate = _orderDate;
				daoOrders.ShippedDate = _shippedDate;
				daoOrders.Shipperİd = _shipperİd;
				daoOrders.ShipName = _shipName;
				daoOrders.ShipAddress = _shipAddress;
				daoOrders.ShipCity = _shipCity;
				daoOrders.ShipStateProvince = _shipStateProvince;
				daoOrders.ShipZipPostalCode = _shipZipPostalCode;
				daoOrders.ShipCountryRegion = _shipCountryRegion;
				daoOrders.ShippingFee = _shippingFee;
				daoOrders.Taxes = _taxes;
				daoOrders.PaymentType = _paymentType;
				daoOrders.PaidDate = _paidDate;
				daoOrders.Notes = _notes;
				daoOrders.TaxRate = _taxRate;
				daoOrders.TaxStatusİd = _taxStatusİd;
				daoOrders.Statusİd = _statusİd;
				daoOrders.CtrVersion = _ctrVersion;
				_iOrdersRepository.Update(daoOrders);
				CommitTransaction(_iOrdersRepository);
				Done(this);
				
				_id = daoOrders.İd;
				_employeeİd = daoOrders.Employeeİd;
				_customerİd = daoOrders.Customerİd;
				_orderDate = daoOrders.OrderDate;
				_shippedDate = daoOrders.ShippedDate;
				_shipperİd = daoOrders.Shipperİd;
				_shipName = daoOrders.ShipName;
				_shipAddress = daoOrders.ShipAddress;
				_shipCity = daoOrders.ShipCity;
				_shipStateProvince = daoOrders.ShipStateProvince;
				_shipZipPostalCode = daoOrders.ShipZipPostalCode;
				_shipCountryRegion = daoOrders.ShipCountryRegion;
				_shippingFee = daoOrders.ShippingFee;
				_taxes = daoOrders.Taxes;
				_paymentType = daoOrders.PaymentType;
				_paidDate = daoOrders.PaidDate;
				_notes = daoOrders.Notes;
				_taxRate = daoOrders.TaxRate;
				_taxStatusİd = daoOrders.TaxStatusİd;
				_statusİd = daoOrders.Statusİd;
				_ctrVersion = daoOrders.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrdersRepository, "updateBOOrders");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one Orders record from the store
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
			IDAOOrders daoOrders = _iOrdersRepository.New();
			RegisterDataObject(_iOrdersRepository, _iOrdersRepository.BaseData(daoOrders));
			BeginTransaction(_iOrdersRepository, "deleteBOOrders");
			try
			{
				daoOrders.İd = _id;
				_iOrdersRepository.Delete(daoOrders);
				CommitTransaction(_iOrdersRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrdersRepository, "deleteBOOrders");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///OrdersCollection
		///This method returns the collection of BOOrders objects
		///</Summary>
		///<returns>
		///IList[IBOOrders]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOOrders> OrdersCollection(IOrdersRepository iOrdersRepository)
		{
			Doing(null);
			try
			{
				IList<IBOOrders> boOrdersCollection = new List<IBOOrders>();
				IList<IDAOOrders> daoOrdersCollection = iOrdersRepository.SelectAll();
				Done(null);
				
				foreach(IDAOOrders daoOrders in daoOrdersCollection)
					boOrdersCollection.Add(new BOOrders(daoOrders));
				
				return boOrdersCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///OrdersCollectionCount
		///This method returns the collection count of BOOrders objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 OrdersCollectionCount(IOrdersRepository iOrdersRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iOrdersRepository.SelectAllCount();
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
		///OrdersCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOOrders>
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
				return _iOrdersRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boOrdersCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOOrders> daoOrdersCollection = _iOrdersRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOOrders resdaoOrders in daoOrdersCollection)
					boOrdersCollection.Add((T)(object)new BOOrders(resdaoOrders));
				
				return boOrdersCollection;
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
		///This method returns the collection count of BOOrders objects, filtered by optional criteria
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
				List<IBOOrders> boOrdersCollection = new List<IBOOrders>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iOrdersRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		///İnventoryTransactionsCollection
		///This method returns its collection of BOİnventoryTransactions objects
		///</Summary>
		///<returns>
		///IList[IBOİnventoryTransactions]
		///</returns>
		///<parameters>
		///BOOrders
		///</parameters>
		public virtual IList<IBOİnventoryTransactions> İnventoryTransactionsCollection()
		{
			Doing(this);
			try
			{
				if(_boİnventoryTransactionsCollection == null)
					LoadİnventoryTransactionsCollection();
				return _boİnventoryTransactionsCollection.AsReadOnly();
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///İnvoicesCollection
		///This method returns its collection of BOİnvoices objects
		///</Summary>
		///<returns>
		///IList[IBOİnvoices]
		///</returns>
		///<parameters>
		///BOOrders
		///</parameters>
		public virtual IList<IBOİnvoices> İnvoicesCollection()
		{
			Doing(this);
			try
			{
				if(_boİnvoicesCollection == null)
					LoadİnvoicesCollection();
				return _boİnvoicesCollection.AsReadOnly();
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///OrderDetailsCollection
		///This method returns its collection of BOOrderDetails objects
		///</Summary>
		///<returns>
		///IList[IBOOrderDetails]
		///</returns>
		///<parameters>
		///BOOrders
		///</parameters>
		public virtual IList<IBOOrderDetails> OrderDetailsCollection()
		{
			Doing(this);
			try
			{
				if(_boOrderDetailsCollection == null)
					LoadOrderDetailsCollection();
				return _boOrderDetailsCollection.AsReadOnly();
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///LoadİnventoryTransactionsCollection
		///This method loads the internal collection of BOİnventoryTransactions objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadİnventoryTransactionsCollection()
		{
			Doing(this);
			try
			{
				_boİnventoryTransactionsCollection = new List<IBOİnventoryTransactions>();
				IList<IDAOİnventoryTransactions> daoİnventoryTransactionsCollection = _iİnventoryTransactionsRepository.SelectAllByCustomerOrderİd(_id);
				Done(this);
				
				foreach(IDAOİnventoryTransactions daoİnventoryTransactions in daoİnventoryTransactionsCollection)
					_boİnventoryTransactionsCollection.Add(new BOInventoryTransactions(daoİnventoryTransactions));
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///AddİnventoryTransactions
		///This method persists a BOİnventoryTransactions object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOİnventoryTransactions
		///</parameters>
		public virtual void AddİnventoryTransactions(IBOİnventoryTransactions boİnventoryTransactions)
		{
			Doing(this);
			IDAOİnventoryTransactions daoİnventoryTransactions = _iİnventoryTransactionsRepository.New();
			RegisterDataObject(_iİnventoryTransactionsRepository, _iİnventoryTransactionsRepository.BaseData(daoİnventoryTransactions));
			BeginTransaction(_iİnventoryTransactionsRepository, "addİnventoryTransactions");
			try
			{
				daoİnventoryTransactions.İd = boİnventoryTransactions.İd;
				daoİnventoryTransactions.TransactionType = boİnventoryTransactions.TransactionType;
				daoİnventoryTransactions.TransactionCreatedDate = boİnventoryTransactions.TransactionCreatedDate;
				daoİnventoryTransactions.TransactionModifiedDate = boİnventoryTransactions.TransactionModifiedDate;
				daoİnventoryTransactions.Productİd = boİnventoryTransactions.Productİd;
				daoİnventoryTransactions.Quantity = boİnventoryTransactions.Quantity;
				daoİnventoryTransactions.PurchaseOrderİd = boİnventoryTransactions.PurchaseOrderİd;
				daoİnventoryTransactions.Comments = boİnventoryTransactions.Comments;
				daoİnventoryTransactions.CustomerOrderİd = _id;
				_iİnventoryTransactionsRepository.Insert(daoİnventoryTransactions);
				CommitTransaction(_iİnventoryTransactionsRepository);
				Done(this);
				
				/*pick up any primary keys, computed values etc*/
				boİnventoryTransactions = new BOInventoryTransactions(daoİnventoryTransactions);
				if(_boİnventoryTransactionsCollection != null)
					_boİnventoryTransactionsCollection.Add(boİnventoryTransactions);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iİnventoryTransactionsRepository, "addİnventoryTransactions");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///DeleteAllİnventoryTransactions
		///This method deletes all BOİnventoryTransactions objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllİnventoryTransactions()
		{
			Doing(this);
			RegisterDataObject(_iİnventoryTransactionsRepository, null);
			BeginTransaction(_iİnventoryTransactionsRepository, "deleteAllİnventoryTransactions");
			try
			{
				_iİnventoryTransactionsRepository.DeleteAllByCustomerOrderİd(_id);
				CommitTransaction(_iİnventoryTransactionsRepository);
				Done(this);
				if(_boİnventoryTransactionsCollection != null)
				{
					_boİnventoryTransactionsCollection.Clear();
					_boİnventoryTransactionsCollection = null;
				}
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iİnventoryTransactionsRepository, "deleteAllİnventoryTransactions");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///LoadİnvoicesCollection
		///This method loads the internal collection of BOİnvoices objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadİnvoicesCollection()
		{
			Doing(this);
			try
			{
				_boİnvoicesCollection = new List<IBOİnvoices>();
				IList<IDAOİnvoices> daoİnvoicesCollection = _iİnvoicesRepository.SelectAllByOrderİd(_id);
				Done(this);
				
				foreach(IDAOİnvoices daoİnvoices in daoİnvoicesCollection)
					_boİnvoicesCollection.Add(new BOInvoices(daoİnvoices));
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///Addİnvoices
		///This method persists a BOİnvoices object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOİnvoices
		///</parameters>
		public virtual void Addİnvoices(IBOİnvoices boİnvoices)
		{
			Doing(this);
			IDAOİnvoices daoİnvoices = _iİnvoicesRepository.New();
			RegisterDataObject(_iİnvoicesRepository, _iİnvoicesRepository.BaseData(daoİnvoices));
			BeginTransaction(_iİnvoicesRepository, "addİnvoices");
			try
			{
				daoİnvoices.İd = boİnvoices.İd;
				daoİnvoices.İnvoiceDate = boİnvoices.İnvoiceDate;
				daoİnvoices.DueDate = boİnvoices.DueDate;
				daoİnvoices.Tax = boİnvoices.Tax;
				daoİnvoices.Shipping = boİnvoices.Shipping;
				daoİnvoices.AmountDue = boİnvoices.AmountDue;
				daoİnvoices.Orderİd = _id;
				_iİnvoicesRepository.Insert(daoİnvoices);
				CommitTransaction(_iİnvoicesRepository);
				Done(this);
				
				/*pick up any primary keys, computed values etc*/
				boİnvoices = new BOInvoices(daoİnvoices);
				if(_boİnvoicesCollection != null)
					_boİnvoicesCollection.Add(boİnvoices);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iİnvoicesRepository, "addİnvoices");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///DeleteAllİnvoices
		///This method deletes all BOİnvoices objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllİnvoices()
		{
			Doing(this);
			RegisterDataObject(_iİnvoicesRepository, null);
			BeginTransaction(_iİnvoicesRepository, "deleteAllİnvoices");
			try
			{
				_iİnvoicesRepository.DeleteAllByOrderİd(_id);
				CommitTransaction(_iİnvoicesRepository);
				Done(this);
				if(_boİnvoicesCollection != null)
				{
					_boİnvoicesCollection.Clear();
					_boİnvoicesCollection = null;
				}
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iİnvoicesRepository, "deleteAllİnvoices");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///LoadOrderDetailsCollection
		///This method loads the internal collection of BOOrderDetails objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadOrderDetailsCollection()
		{
			Doing(this);
			try
			{
				_boOrderDetailsCollection = new List<IBOOrderDetails>();
				IList<IDAOOrderDetails> daoOrderDetailsCollection = _iOrderDetailsRepository.SelectAllByOrderİd(_id);
				Done(this);
				
				foreach(IDAOOrderDetails daoOrderDetails in daoOrderDetailsCollection)
					_boOrderDetailsCollection.Add(new BOOrderDetails(daoOrderDetails));
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///AddOrderDetails
		///This method persists a BOOrderDetails object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrderDetails
		///</parameters>
		public virtual void AddOrderDetails(IBOOrderDetails boOrderDetails)
		{
			Doing(this);
			IDAOOrderDetails daoOrderDetails = _iOrderDetailsRepository.New();
			RegisterDataObject(_iOrderDetailsRepository, _iOrderDetailsRepository.BaseData(daoOrderDetails));
			BeginTransaction(_iOrderDetailsRepository, "addOrderDetails");
			try
			{
				daoOrderDetails.İd = boOrderDetails.İd;
				daoOrderDetails.Productİd = boOrderDetails.Productİd;
				daoOrderDetails.Quantity = boOrderDetails.Quantity;
				daoOrderDetails.UnitPrice = boOrderDetails.UnitPrice;
				daoOrderDetails.Discount = boOrderDetails.Discount;
				daoOrderDetails.Statusİd = boOrderDetails.Statusİd;
				daoOrderDetails.DateAllocated = boOrderDetails.DateAllocated;
				daoOrderDetails.PurchaseOrderİd = boOrderDetails.PurchaseOrderİd;
				daoOrderDetails.İnventoryİd = boOrderDetails.İnventoryİd;
				daoOrderDetails.Orderİd = _id;
				_iOrderDetailsRepository.Insert(daoOrderDetails);
				CommitTransaction(_iOrderDetailsRepository);
				Done(this);
				
				/*pick up any primary keys, computed values etc*/
				boOrderDetails = new BOOrderDetails(daoOrderDetails);
				if(_boOrderDetailsCollection != null)
					_boOrderDetailsCollection.Add(boOrderDetails);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrderDetailsRepository, "addOrderDetails");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///DeleteAllOrderDetails
		///This method deletes all BOOrderDetails objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllOrderDetails()
		{
			Doing(this);
			RegisterDataObject(_iOrderDetailsRepository, null);
			BeginTransaction(_iOrderDetailsRepository, "deleteAllOrderDetails");
			try
			{
				_iOrderDetailsRepository.DeleteAllByOrderİd(_id);
				CommitTransaction(_iOrderDetailsRepository);
				Done(this);
				if(_boOrderDetailsCollection != null)
				{
					_boOrderDetailsCollection.Clear();
					_boOrderDetailsCollection = null;
				}
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iOrderDetailsRepository, "deleteAllOrderDetails");
				Handle(this, ex);
			}
		}
		
		#endregion

		#region member properties
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IOrdersRepository OrdersRepository
		{
			set
			{
				_iOrdersRepository = value;
			}
		}
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IInventoryTransactionsRepository İnventoryTransactionsRepository
		{
			set
			{
				_iİnventoryTransactionsRepository = value;
			}
		}
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IInvoicesRepository İnvoicesRepository
		{
			set
			{
				_iİnvoicesRepository = value;
			}
		}
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IOrderDetailsRepository OrderDetailsRepository
		{
			set
			{
				_iOrderDetailsRepository = value;
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
		
		public virtual string Employeeİd
		{
			get
			{
				 return _employeeİd;
			}
			set
			{
				_employeeİd = value;
				_isDirty = true;
			}
		}
		
		public virtual string Customerİd
		{
			get
			{
				 return _customerİd;
			}
			set
			{
				_customerİd = value;
				_isDirty = true;
			}
		}
		
		public virtual string OrderDate
		{
			get
			{
				 return _orderDate;
			}
			set
			{
				_orderDate = value;
				_isDirty = true;
			}
		}
		
		public virtual string ShippedDate
		{
			get
			{
				 return _shippedDate;
			}
			set
			{
				_shippedDate = value;
				_isDirty = true;
			}
		}
		
		public virtual string Shipperİd
		{
			get
			{
				 return _shipperİd;
			}
			set
			{
				_shipperİd = value;
				_isDirty = true;
			}
		}
		
		public virtual string ShipName
		{
			get
			{
				 return _shipName;
			}
			set
			{
				_shipName = value;
				_isDirty = true;
			}
		}
		
		public virtual string ShipAddress
		{
			get
			{
				 return _shipAddress;
			}
			set
			{
				_shipAddress = value;
				_isDirty = true;
			}
		}
		
		public virtual string ShipCity
		{
			get
			{
				 return _shipCity;
			}
			set
			{
				_shipCity = value;
				_isDirty = true;
			}
		}
		
		public virtual string ShipStateProvince
		{
			get
			{
				 return _shipStateProvince;
			}
			set
			{
				_shipStateProvince = value;
				_isDirty = true;
			}
		}
		
		public virtual string ShipZipPostalCode
		{
			get
			{
				 return _shipZipPostalCode;
			}
			set
			{
				_shipZipPostalCode = value;
				_isDirty = true;
			}
		}
		
		public virtual string ShipCountryRegion
		{
			get
			{
				 return _shipCountryRegion;
			}
			set
			{
				_shipCountryRegion = value;
				_isDirty = true;
			}
		}
		
		public virtual string ShippingFee
		{
			get
			{
				 return _shippingFee;
			}
			set
			{
				_shippingFee = value;
				_isDirty = true;
			}
		}
		
		public virtual string Taxes
		{
			get
			{
				 return _taxes;
			}
			set
			{
				_taxes = value;
				_isDirty = true;
			}
		}
		
		public virtual string PaymentType
		{
			get
			{
				 return _paymentType;
			}
			set
			{
				_paymentType = value;
				_isDirty = true;
			}
		}
		
		public virtual string PaidDate
		{
			get
			{
				 return _paidDate;
			}
			set
			{
				_paidDate = value;
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
		
		public virtual double? TaxRate
		{
			get
			{
				 return _taxRate;
			}
			set
			{
				_taxRate = value;
				_isDirty = true;
			}
		}
		
		public virtual string TaxStatusİd
		{
			get
			{
				 return _taxStatusİd;
			}
			set
			{
				_taxStatusİd = value;
				_isDirty = true;
			}
		}
		
		public virtual string Statusİd
		{
			get
			{
				 return _statusİd;
			}
			set
			{
				_statusİd = value;
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
			get {	return (object) _iOrdersRepository;	}
			set {	OrdersRepository = (IOrdersRepository)value;	}
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