/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:11:04
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using NorthwindTest2.Data;
using NorthwindTest2.Data.Interfaces;
using NorthwindTest2.Business.Interfaces;
using NorthwindTest2.Business.Repository.Interfaces;

namespace NorthwindTest2.Business
{
	///<Summary>
	///Class definition
	///This is the definition of the class BOCustomerCustomerDemo.
	///</Summary>
	public partial class BOCustomerCustomerDemo : zNorthwindTest2Conn_BaseBusiness, IBOCustomerCustomerDemo, IQueryableCollection
	{
		#region member variables
		protected string _customerID;
		protected string _customerTypeID;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected ICustomerCustomerDemoRepository _iCustomerCustomerDemoRepository;
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
		public BOCustomerCustomerDemo()
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
		///string customerID, string customerTypeID
		///</parameters>
		public void Init(string customerID, string customerTypeID)
		{
			try
			{
				IDAOCustomerCustomerDemo daoCustomerCustomerDemo = _iCustomerCustomerDemoRepository.SelectOne(customerID, customerTypeID);
				_customerID = daoCustomerCustomerDemo.CustomerID;
				_customerTypeID = daoCustomerCustomerDemo.CustomerTypeID;
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
		///DAOCustomerCustomerDemo
		///</parameters>
		protected internal BOCustomerCustomerDemo(IDAOCustomerCustomerDemo daoCustomerCustomerDemo)
		{
			try
			{
				_customerID = daoCustomerCustomerDemo.CustomerID;
				_customerTypeID = daoCustomerCustomerDemo.CustomerTypeID;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new CustomerCustomerDemo record to the store
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
			IDAOCustomerCustomerDemo daoCustomerCustomerDemo = _iCustomerCustomerDemoRepository.New();
			RegisterDataObject( _iCustomerCustomerDemoRepository, _iCustomerCustomerDemoRepository.BaseData(daoCustomerCustomerDemo));
			BeginTransaction( _iCustomerCustomerDemoRepository, "savenewBOCustomerCustomerDemo");
			try
			{
				daoCustomerCustomerDemo.CustomerID = _customerID;
				daoCustomerCustomerDemo.CustomerTypeID = _customerTypeID;
				_iCustomerCustomerDemoRepository.Insert(daoCustomerCustomerDemo);
				CommitTransaction( _iCustomerCustomerDemoRepository);
				Done(this);
				
				_customerID = daoCustomerCustomerDemo.CustomerID;
				_customerTypeID = daoCustomerCustomerDemo.CustomerTypeID;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iCustomerCustomerDemoRepository, "savenewBOCustomerCustomerDemo");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one CustomerCustomerDemo record from the store
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
			IDAOCustomerCustomerDemo daoCustomerCustomerDemo = _iCustomerCustomerDemoRepository.New();
			RegisterDataObject(_iCustomerCustomerDemoRepository, _iCustomerCustomerDemoRepository.BaseData(daoCustomerCustomerDemo));
			BeginTransaction(_iCustomerCustomerDemoRepository, "deleteBOCustomerCustomerDemo");
			try
			{
				daoCustomerCustomerDemo.CustomerID = _customerID;
				daoCustomerCustomerDemo.CustomerTypeID = _customerTypeID;
				_iCustomerCustomerDemoRepository.Delete(daoCustomerCustomerDemo);
				CommitTransaction(_iCustomerCustomerDemoRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iCustomerCustomerDemoRepository, "deleteBOCustomerCustomerDemo");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///CustomerCustomerDemoCollection
		///This method returns the collection of BOCustomerCustomerDemo objects
		///</Summary>
		///<returns>
		///IList[IBOCustomerCustomerDemo]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOCustomerCustomerDemo> CustomerCustomerDemoCollection(ICustomerCustomerDemoRepository iCustomerCustomerDemoRepository)
		{
			Doing(null);
			try
			{
				IList<IBOCustomerCustomerDemo> boCustomerCustomerDemoCollection = new List<IBOCustomerCustomerDemo>();
				IList<IDAOCustomerCustomerDemo> daoCustomerCustomerDemoCollection = iCustomerCustomerDemoRepository.SelectAll();
				Done(null);
				
				foreach(IDAOCustomerCustomerDemo daoCustomerCustomerDemo in daoCustomerCustomerDemoCollection)
					boCustomerCustomerDemoCollection.Add(new BOCustomerCustomerDemo(daoCustomerCustomerDemo));
				
				return boCustomerCustomerDemoCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///CustomerCustomerDemoCollectionCount
		///This method returns the collection count of BOCustomerCustomerDemo objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 CustomerCustomerDemoCollectionCount(ICustomerCustomerDemoRepository iCustomerCustomerDemoRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iCustomerCustomerDemoRepository.SelectAllCount();
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
		///CustomerCustomerDemoCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOCustomerCustomerDemo>
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
				return _iCustomerCustomerDemoRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boCustomerCustomerDemoCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOCustomerCustomerDemo> daoCustomerCustomerDemoCollection = _iCustomerCustomerDemoRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOCustomerCustomerDemo resdaoCustomerCustomerDemo in daoCustomerCustomerDemoCollection)
					boCustomerCustomerDemoCollection.Add((T)(object)new BOCustomerCustomerDemo(resdaoCustomerCustomerDemo));
				
				return boCustomerCustomerDemoCollection;
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
		///This method returns the collection count of BOCustomerCustomerDemo objects, filtered by optional criteria
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
				List<IBOCustomerCustomerDemo> boCustomerCustomerDemoCollection = new List<IBOCustomerCustomerDemo>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iCustomerCustomerDemoRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		public virtual ICustomerCustomerDemoRepository CustomerCustomerDemoRepository
		{
			set
			{
				_iCustomerCustomerDemoRepository = value;
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
		
		public virtual string CustomerTypeID
		{
			get
			{
				 return _customerTypeID;
			}
			set
			{
				_customerTypeID = value;
				_isDirty = true;
			}
		}
		
		[XmlIgnore]
		public virtual object Repository
		{
			get {	return (object) _iCustomerCustomerDemoRepository;	}
			set {	CustomerCustomerDemoRepository = (ICustomerCustomerDemoRepository)value;	}
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
