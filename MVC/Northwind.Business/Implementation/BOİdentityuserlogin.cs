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
	///This is the definition of the class BOIdentityuserlogin.
	///</Summary>
	public partial class BOIdentityuserlogin : zNorthwindConn_BaseBusiness, IBOIdentityuserlogin, IQueryableCollection
	{
		#region member variables
		protected string _loginProvider;
		protected string _providerKey;
		protected string _userId;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected IIdentityuserloginRepository _iIdentityuserloginRepository;
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
		public BOIdentityuserlogin()
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
		///string loginProvider, string providerKey, string userId
		///</parameters>
		public void Init(string loginProvider, string providerKey, string userId)
		{
			try
			{
				IDAOIdentityuserlogin daoIdentityuserlogin = _iIdentityuserloginRepository.SelectOne(loginProvider, providerKey, userId);
				_loginProvider = daoIdentityuserlogin.LoginProvider;
				_providerKey = daoIdentityuserlogin.ProviderKey;
				_userId = daoIdentityuserlogin.UserId;
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
		///DAOIdentityuserlogin
		///</parameters>
		protected internal BOIdentityuserlogin(IDAOIdentityuserlogin daoIdentityuserlogin)
		{
			try
			{
				_loginProvider = daoIdentityuserlogin.LoginProvider;
				_providerKey = daoIdentityuserlogin.ProviderKey;
				_userId = daoIdentityuserlogin.UserId;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new Identityuserlogin record to the store
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
			IDAOIdentityuserlogin daoIdentityuserlogin = _iIdentityuserloginRepository.New();
			RegisterDataObject( _iIdentityuserloginRepository, _iIdentityuserloginRepository.BaseData(daoIdentityuserlogin));
			BeginTransaction( _iIdentityuserloginRepository, "savenewBOIdentityuserlogin");
			try
			{
				daoIdentityuserlogin.LoginProvider = _loginProvider;
				daoIdentityuserlogin.ProviderKey = _providerKey;
				daoIdentityuserlogin.UserId = _userId;
				_iIdentityuserloginRepository.Insert(daoIdentityuserlogin);
				CommitTransaction( _iIdentityuserloginRepository);
				Done(this);
				
				_loginProvider = daoIdentityuserlogin.LoginProvider;
				_providerKey = daoIdentityuserlogin.ProviderKey;
				_userId = daoIdentityuserlogin.UserId;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityuserloginRepository, "savenewBOIdentityuserlogin");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one Identityuserlogin record from the store
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
			IDAOIdentityuserlogin daoIdentityuserlogin = _iIdentityuserloginRepository.New();
			RegisterDataObject(_iIdentityuserloginRepository, _iIdentityuserloginRepository.BaseData(daoIdentityuserlogin));
			BeginTransaction(_iIdentityuserloginRepository, "deleteBOIdentityuserlogin");
			try
			{
				daoIdentityuserlogin.LoginProvider = _loginProvider;
				daoIdentityuserlogin.ProviderKey = _providerKey;
				daoIdentityuserlogin.UserId = _userId;
				_iIdentityuserloginRepository.Delete(daoIdentityuserlogin);
				CommitTransaction(_iIdentityuserloginRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityuserloginRepository, "deleteBOIdentityuserlogin");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///IdentityuserloginCollection
		///This method returns the collection of BOIdentityuserlogin objects
		///</Summary>
		///<returns>
		///IList[IBOIdentityuserlogin]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOIdentityuserlogin> IdentityuserloginCollection(IIdentityuserloginRepository iIdentityuserloginRepository)
		{
			Doing(null);
			try
			{
				IList<IBOIdentityuserlogin> boIdentityuserloginCollection = new List<IBOIdentityuserlogin>();
				IList<IDAOIdentityuserlogin> daoIdentityuserloginCollection = iIdentityuserloginRepository.SelectAll();
				Done(null);
				
				foreach(IDAOIdentityuserlogin daoIdentityuserlogin in daoIdentityuserloginCollection)
					boIdentityuserloginCollection.Add(new BOIdentityuserlogin(daoIdentityuserlogin));
				
				return boIdentityuserloginCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///IdentityuserloginCollectionCount
		///This method returns the collection count of BOIdentityuserlogin objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 IdentityuserloginCollectionCount(IIdentityuserloginRepository iIdentityuserloginRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iIdentityuserloginRepository.SelectAllCount();
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
		///IdentityuserloginCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOIdentityuserlogin>
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
				return _iIdentityuserloginRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boIdentityuserloginCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOIdentityuserlogin> daoIdentityuserloginCollection = _iIdentityuserloginRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOIdentityuserlogin resdaoIdentityuserlogin in daoIdentityuserloginCollection)
					boIdentityuserloginCollection.Add((T)(object)new BOIdentityuserlogin(resdaoIdentityuserlogin));
				
				return boIdentityuserloginCollection;
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
		///This method returns the collection count of BOIdentityuserlogin objects, filtered by optional criteria
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
				List<IBOIdentityuserlogin> boIdentityuserloginCollection = new List<IBOIdentityuserlogin>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iIdentityuserloginRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		public virtual IIdentityuserloginRepository IdentityuserloginRepository
		{
			set
			{
				_iIdentityuserloginRepository = value;
			}
		}
		
		public virtual string LoginProvider
		{
			get
			{
				 return _loginProvider;
			}
			set
			{
				_loginProvider = value;
				_isDirty = true;
			}
		}
		
		public virtual string ProviderKey
		{
			get
			{
				 return _providerKey;
			}
			set
			{
				_providerKey = value;
				_isDirty = true;
			}
		}
		
		public virtual string UserId
		{
			get
			{
				 return _userId;
			}
			set
			{
				_userId = value;
				_isDirty = true;
			}
		}
		
		[XmlIgnore]
		public virtual object Repository
		{
			get {	return (object) _iIdentityuserloginRepository;	}
			set {	IdentityuserloginRepository = (IIdentityuserloginRepository)value;	}
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
