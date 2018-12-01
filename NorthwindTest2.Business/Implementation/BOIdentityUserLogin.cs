/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:09:42
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindTest2.Data;
using NorthwindTest2.Data.Interfaces;
using NorthwindTest2.Business.Interfaces;
using NorthwindTest2.Business.Repository.Interfaces;

namespace NorthwindTest2.Business
{
	///<Summary>
	///Class definition
	///This is the definition of the class BOIdentityUserLogin.
	///</Summary>
	public partial class BOIdentityUserLogin : zNorthwindTest2Conn_BaseBusiness, IBOIdentityUserLogin, IQueryableCollection
	{
		#region member variables
		protected string _loginProvider;
		protected string _providerKey;
		protected Int32? _userId;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected IIdentityUserLoginRepository _iIdentityUserLoginRepository;
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
		public BOIdentityUserLogin()
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
		///string loginProvider, string providerKey, Int32 userId
		///</parameters>
		public void Init(string loginProvider, string providerKey, Int32 userId)
		{
			try
			{
				IDAOIdentityUserLogin daoIdentityUserLogin = _iIdentityUserLoginRepository.SelectOne(loginProvider, providerKey, userId);
				_loginProvider = daoIdentityUserLogin.LoginProvider;
				_providerKey = daoIdentityUserLogin.ProviderKey;
				_userId = daoIdentityUserLogin.UserId;
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
		///DAOIdentityUserLogin
		///</parameters>
		protected internal BOIdentityUserLogin(IDAOIdentityUserLogin daoIdentityUserLogin)
		{
			try
			{
				_loginProvider = daoIdentityUserLogin.LoginProvider;
				_providerKey = daoIdentityUserLogin.ProviderKey;
				_userId = daoIdentityUserLogin.UserId;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new IdentityUserLogin record to the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void SaveNew()
		{
			IDAOIdentityUserLogin daoIdentityUserLogin = _iIdentityUserLoginRepository.New();
			RegisterDataObject( _iIdentityUserLoginRepository, _iIdentityUserLoginRepository.BaseData(daoIdentityUserLogin));
			BeginTransaction( _iIdentityUserLoginRepository, "savenewBOIdentityUserLogin");
			try
			{
				daoIdentityUserLogin.LoginProvider = _loginProvider;
				daoIdentityUserLogin.ProviderKey = _providerKey;
				daoIdentityUserLogin.UserId = _userId;
				_iIdentityUserLoginRepository.Insert(daoIdentityUserLogin);
				CommitTransaction( _iIdentityUserLoginRepository);
				
				_loginProvider = daoIdentityUserLogin.LoginProvider;
				_providerKey = daoIdentityUserLogin.ProviderKey;
				_userId = daoIdentityUserLogin.UserId;
				_isDirty = false;
			}
			catch
			{
				RollbackTransaction(_iIdentityUserLoginRepository, "savenewBOIdentityUserLogin");
				throw;
			}
		}
		///<Summary>
		///Delete
		///This method deletes one IdentityUserLogin record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Delete()
		{
			IDAOIdentityUserLogin daoIdentityUserLogin = _iIdentityUserLoginRepository.New();
			RegisterDataObject(_iIdentityUserLoginRepository, _iIdentityUserLoginRepository.BaseData(daoIdentityUserLogin));
			BeginTransaction(_iIdentityUserLoginRepository, "deleteBOIdentityUserLogin");
			try
			{
				daoIdentityUserLogin.LoginProvider = _loginProvider;
				daoIdentityUserLogin.ProviderKey = _providerKey;
				daoIdentityUserLogin.UserId = _userId;
				_iIdentityUserLoginRepository.Delete(daoIdentityUserLogin);
				CommitTransaction(_iIdentityUserLoginRepository);
			}
			catch
			{
				RollbackTransaction(_iIdentityUserLoginRepository, "deleteBOIdentityUserLogin");
				throw;
			}
		}
		
		///<Summary>
		///IdentityUserLoginCollection
		///This method returns the collection of BOIdentityUserLogin objects
		///</Summary>
		///<returns>
		///IList[IBOIdentityUserLogin]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOIdentityUserLogin> IdentityUserLoginCollection(IIdentityUserLoginRepository iIdentityUserLoginRepository)
		{
			try
			{
				IList<IBOIdentityUserLogin> boIdentityUserLoginCollection = new List<IBOIdentityUserLogin>();
				IList<IDAOIdentityUserLogin> daoIdentityUserLoginCollection = iIdentityUserLoginRepository.SelectAll();
				
				foreach(IDAOIdentityUserLogin daoIdentityUserLogin in daoIdentityUserLoginCollection)
					boIdentityUserLoginCollection.Add(new BOIdentityUserLogin(daoIdentityUserLogin));
				
				return boIdentityUserLoginCollection;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///IdentityUserLoginCollectionCount
		///This method returns the collection count of BOIdentityUserLogin objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 IdentityUserLoginCollectionCount(IIdentityUserLoginRepository iIdentityUserLoginRepository)
		{
			try
			{
				Int32 objCount = iIdentityUserLoginRepository.SelectAllCount();
				return objCount;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///IdentityUserLoginCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOIdentityUserLogin>
		///</returns>
		///<parameters>
		///ICriteria icriteria
		///</parameters>
		public virtual IDictionary<string, IList<object>> Projections(object o)
		{
			try
			{
				ICriteria icriteria = (ICriteria)o;
				IList<IDataProjection> lstDataProjection = (icriteria == null) ? null : icriteria.ListDataProjection();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				return _iIdentityUserLoginRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
			}
			catch
			{
				throw;
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
			try
			{
				ICriteria icriteria = (ICriteria)o;
				IList<T> boIdentityUserLoginCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOIdentityUserLogin> daoIdentityUserLoginCollection = _iIdentityUserLoginRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOIdentityUserLogin resdaoIdentityUserLogin in daoIdentityUserLoginCollection)
					boIdentityUserLoginCollection.Add((T)(object)new BOIdentityUserLogin(resdaoIdentityUserLogin));
				
				return boIdentityUserLoginCollection;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///CollectionCount
		///This method returns the collection count of BOIdentityUserLogin objects, filtered by optional criteria
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///ICriteria icriteria
		///</parameters>
		public virtual Int32 CollectionCount(object o)
		{
			try
			{
				ICriteria icriteria = (ICriteria)o;
				List<IBOIdentityUserLogin> boIdentityUserLoginCollection = new List<IBOIdentityUserLogin>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iIdentityUserLoginRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
				return objCount;
			}
			catch
			{
				throw;
			}
		}
		
		#endregion

		#region member properties
		
		[InjectionPoint]
		public virtual IIdentityUserLoginRepository IdentityUserLoginRepository
		{
			set
			{
				_iIdentityUserLoginRepository = value;
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
		
		public virtual Int32? UserId
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
		
		public virtual object Repository
		{
			get {	return (object) _iIdentityUserLoginRepository;	}
			set {	IdentityUserLoginRepository = (IIdentityUserLoginRepository)value;	}
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
