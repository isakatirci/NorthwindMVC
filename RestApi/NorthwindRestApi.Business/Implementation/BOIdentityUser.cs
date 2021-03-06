/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:13
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
	///This is the definition of the class BOIdentityUser.
	///It maintains a collection of BOIdentityUserClaim,BOIdentityUserLogin,BOIdentityUserProfile,BOIdentityUserRole objects.
	///</Summary>
	public partial class BOIdentityUser : zNorthwindRestApiConn_BaseBusiness, IBOIdentityUser, IQueryableCollection, IUnitOfWorkEntity
	{
		#region member variables
		protected Int32? _userId;
		protected string _email;
		protected bool? _emailConfirmed;
		protected string _passwordHash;
		protected string _securityStamp;
		protected string _phoneNumber;
		protected bool? _phoneNumberConfirmed;
		protected bool? _twoFactorEnabled;
		protected DateTime? _lockoutEndDateUtc;
		protected bool? _lockoutEnabled;
		protected Int32? _accessFailedCount;
		protected string _username;
		protected Int32? _ctrVersion;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		List<IBOIdentityUserClaim> _boIdentityUserClaimCollection;
		List<IBOIdentityUserLogin> _boIdentityUserLoginCollection;
		List<IBOIdentityUserProfile> _boIdentityUserProfileCollection;
		List<IBOIdentityUserRole> _boIdentityUserRoleCollection;
		/*********************************************/
		/*repositories*********************************/
		protected IIdentityUserRepository _iIdentityUserRepository;
		protected IIdentityUserClaimRepository _iIdentityUserClaimRepository;
		protected IIdentityUserLoginRepository _iIdentityUserLoginRepository;
		protected IIdentityUserProfileRepository _iIdentityUserProfileRepository;
		protected IIdentityUserRoleRepository _iIdentityUserRoleRepository;
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
		public BOIdentityUser()
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
		///Int32 userId
		///</parameters>
		public void Init(Int32 userId)
		{
			try
			{
				IDAOIdentityUser daoIdentityUser = _iIdentityUserRepository.SelectOne(userId);
				_userId = daoIdentityUser.UserId;
				_email = daoIdentityUser.Email;
				_emailConfirmed = daoIdentityUser.EmailConfirmed;
				_passwordHash = daoIdentityUser.PasswordHash;
				_securityStamp = daoIdentityUser.SecurityStamp;
				_phoneNumber = daoIdentityUser.PhoneNumber;
				_phoneNumberConfirmed = daoIdentityUser.PhoneNumberConfirmed;
				_twoFactorEnabled = daoIdentityUser.TwoFactorEnabled;
				_lockoutEndDateUtc = daoIdentityUser.LockoutEndDateUtc;
				_lockoutEnabled = daoIdentityUser.LockoutEnabled;
				_accessFailedCount = daoIdentityUser.AccessFailedCount;
				_username = daoIdentityUser.Username;
				_ctrVersion = daoIdentityUser.CtrVersion;
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
		///DAOIdentityUser
		///</parameters>
		protected internal BOIdentityUser(IDAOIdentityUser daoIdentityUser)
		{
			try
			{
				_userId = daoIdentityUser.UserId;
				_email = daoIdentityUser.Email;
				_emailConfirmed = daoIdentityUser.EmailConfirmed;
				_passwordHash = daoIdentityUser.PasswordHash;
				_securityStamp = daoIdentityUser.SecurityStamp;
				_phoneNumber = daoIdentityUser.PhoneNumber;
				_phoneNumberConfirmed = daoIdentityUser.PhoneNumberConfirmed;
				_twoFactorEnabled = daoIdentityUser.TwoFactorEnabled;
				_lockoutEndDateUtc = daoIdentityUser.LockoutEndDateUtc;
				_lockoutEnabled = daoIdentityUser.LockoutEnabled;
				_accessFailedCount = daoIdentityUser.AccessFailedCount;
				_username = daoIdentityUser.Username;
				_ctrVersion = daoIdentityUser.CtrVersion;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new IdentityUser record to the store
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
			IDAOIdentityUser daoIdentityUser = _iIdentityUserRepository.New();
			RegisterDataObject( _iIdentityUserRepository, _iIdentityUserRepository.BaseData(daoIdentityUser));
			BeginTransaction( _iIdentityUserRepository, "savenewBOIdentityUser");
			try
			{
				daoIdentityUser.Email = _email;
				daoIdentityUser.EmailConfirmed = _emailConfirmed;
				daoIdentityUser.PasswordHash = _passwordHash;
				daoIdentityUser.SecurityStamp = _securityStamp;
				daoIdentityUser.PhoneNumber = _phoneNumber;
				daoIdentityUser.PhoneNumberConfirmed = _phoneNumberConfirmed;
				daoIdentityUser.TwoFactorEnabled = _twoFactorEnabled;
				daoIdentityUser.LockoutEndDateUtc = _lockoutEndDateUtc;
				daoIdentityUser.LockoutEnabled = _lockoutEnabled;
				daoIdentityUser.AccessFailedCount = _accessFailedCount;
				daoIdentityUser.Username = _username;
				_iIdentityUserRepository.Insert(daoIdentityUser);
				CommitTransaction( _iIdentityUserRepository);
				Done(this);
				
				_userId = daoIdentityUser.UserId;
				_email = daoIdentityUser.Email;
				_emailConfirmed = daoIdentityUser.EmailConfirmed;
				_passwordHash = daoIdentityUser.PasswordHash;
				_securityStamp = daoIdentityUser.SecurityStamp;
				_phoneNumber = daoIdentityUser.PhoneNumber;
				_phoneNumberConfirmed = daoIdentityUser.PhoneNumberConfirmed;
				_twoFactorEnabled = daoIdentityUser.TwoFactorEnabled;
				_lockoutEndDateUtc = daoIdentityUser.LockoutEndDateUtc;
				_lockoutEnabled = daoIdentityUser.LockoutEnabled;
				_accessFailedCount = daoIdentityUser.AccessFailedCount;
				_username = daoIdentityUser.Username;
				_ctrVersion = daoIdentityUser.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityUserRepository, "savenewBOIdentityUser");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Update
		///This method updates one IdentityUser record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOIdentityUser
		///</parameters>
		public virtual void Update()
		{
			Doing(this);
			IDAOIdentityUser daoIdentityUser = _iIdentityUserRepository.New();
			RegisterDataObject(_iIdentityUserRepository, _iIdentityUserRepository.BaseData(daoIdentityUser));
			BeginTransaction(_iIdentityUserRepository, "updateBOIdentityUser");
			try
			{
				daoIdentityUser.UserId = _userId;
				daoIdentityUser.Email = _email;
				daoIdentityUser.EmailConfirmed = _emailConfirmed;
				daoIdentityUser.PasswordHash = _passwordHash;
				daoIdentityUser.SecurityStamp = _securityStamp;
				daoIdentityUser.PhoneNumber = _phoneNumber;
				daoIdentityUser.PhoneNumberConfirmed = _phoneNumberConfirmed;
				daoIdentityUser.TwoFactorEnabled = _twoFactorEnabled;
				daoIdentityUser.LockoutEndDateUtc = _lockoutEndDateUtc;
				daoIdentityUser.LockoutEnabled = _lockoutEnabled;
				daoIdentityUser.AccessFailedCount = _accessFailedCount;
				daoIdentityUser.Username = _username;
				daoIdentityUser.CtrVersion = _ctrVersion;
				_iIdentityUserRepository.Update(daoIdentityUser);
				CommitTransaction(_iIdentityUserRepository);
				Done(this);
				
				_userId = daoIdentityUser.UserId;
				_email = daoIdentityUser.Email;
				_emailConfirmed = daoIdentityUser.EmailConfirmed;
				_passwordHash = daoIdentityUser.PasswordHash;
				_securityStamp = daoIdentityUser.SecurityStamp;
				_phoneNumber = daoIdentityUser.PhoneNumber;
				_phoneNumberConfirmed = daoIdentityUser.PhoneNumberConfirmed;
				_twoFactorEnabled = daoIdentityUser.TwoFactorEnabled;
				_lockoutEndDateUtc = daoIdentityUser.LockoutEndDateUtc;
				_lockoutEnabled = daoIdentityUser.LockoutEnabled;
				_accessFailedCount = daoIdentityUser.AccessFailedCount;
				_username = daoIdentityUser.Username;
				_ctrVersion = daoIdentityUser.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityUserRepository, "updateBOIdentityUser");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one IdentityUser record from the store
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
			IDAOIdentityUser daoIdentityUser = _iIdentityUserRepository.New();
			RegisterDataObject(_iIdentityUserRepository, _iIdentityUserRepository.BaseData(daoIdentityUser));
			BeginTransaction(_iIdentityUserRepository, "deleteBOIdentityUser");
			try
			{
				daoIdentityUser.UserId = _userId;
				_iIdentityUserRepository.Delete(daoIdentityUser);
				CommitTransaction(_iIdentityUserRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityUserRepository, "deleteBOIdentityUser");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///IdentityUserCollection
		///This method returns the collection of BOIdentityUser objects
		///</Summary>
		///<returns>
		///IList[IBOIdentityUser]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOIdentityUser> IdentityUserCollection(IIdentityUserRepository iIdentityUserRepository)
		{
			Doing(null);
			try
			{
				IList<IBOIdentityUser> boIdentityUserCollection = new List<IBOIdentityUser>();
				IList<IDAOIdentityUser> daoIdentityUserCollection = iIdentityUserRepository.SelectAll();
				Done(null);
				
				foreach(IDAOIdentityUser daoIdentityUser in daoIdentityUserCollection)
					boIdentityUserCollection.Add(new BOIdentityUser(daoIdentityUser));
				
				return boIdentityUserCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///IdentityUserCollectionCount
		///This method returns the collection count of BOIdentityUser objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 IdentityUserCollectionCount(IIdentityUserRepository iIdentityUserRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iIdentityUserRepository.SelectAllCount();
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
		///IdentityUserCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOIdentityUser>
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
				return _iIdentityUserRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boIdentityUserCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOIdentityUser> daoIdentityUserCollection = _iIdentityUserRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOIdentityUser resdaoIdentityUser in daoIdentityUserCollection)
					boIdentityUserCollection.Add((T)(object)new BOIdentityUser(resdaoIdentityUser));
				
				return boIdentityUserCollection;
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
		///This method returns the collection count of BOIdentityUser objects, filtered by optional criteria
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
				List<IBOIdentityUser> boIdentityUserCollection = new List<IBOIdentityUser>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iIdentityUserRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		///IdentityUserClaimCollection
		///This method returns its collection of BOIdentityUserClaim objects
		///</Summary>
		///<returns>
		///IList[IBOIdentityUserClaim]
		///</returns>
		///<parameters>
		///BOIdentityUser
		///</parameters>
		public virtual IList<IBOIdentityUserClaim> IdentityUserClaimCollection()
		{
			Doing(this);
			try
			{
				if(_boIdentityUserClaimCollection == null)
					LoadIdentityUserClaimCollection();
				return _boIdentityUserClaimCollection.AsReadOnly();
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///IdentityUserLoginCollection
		///This method returns its collection of BOIdentityUserLogin objects
		///</Summary>
		///<returns>
		///IList[IBOIdentityUserLogin]
		///</returns>
		///<parameters>
		///BOIdentityUser
		///</parameters>
		public virtual IList<IBOIdentityUserLogin> IdentityUserLoginCollection()
		{
			Doing(this);
			try
			{
				if(_boIdentityUserLoginCollection == null)
					LoadIdentityUserLoginCollection();
				return _boIdentityUserLoginCollection.AsReadOnly();
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///IdentityUserProfileCollection
		///This method returns its collection of BOIdentityUserProfile objects
		///</Summary>
		///<returns>
		///IList[IBOIdentityUserProfile]
		///</returns>
		///<parameters>
		///BOIdentityUser
		///</parameters>
		public virtual IList<IBOIdentityUserProfile> IdentityUserProfileCollection()
		{
			Doing(this);
			try
			{
				if(_boIdentityUserProfileCollection == null)
					LoadIdentityUserProfileCollection();
				return _boIdentityUserProfileCollection.AsReadOnly();
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///IdentityUserRoleCollection
		///This method returns its collection of BOIdentityUserRole objects
		///</Summary>
		///<returns>
		///IList[IBOIdentityUserRole]
		///</returns>
		///<parameters>
		///BOIdentityUser
		///</parameters>
		public virtual IList<IBOIdentityUserRole> IdentityUserRoleCollection()
		{
			Doing(this);
			try
			{
				if(_boIdentityUserRoleCollection == null)
					LoadIdentityUserRoleCollection();
				return _boIdentityUserRoleCollection.AsReadOnly();
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///LoadIdentityUserClaimCollection
		///This method loads the internal collection of BOIdentityUserClaim objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadIdentityUserClaimCollection()
		{
			Doing(this);
			try
			{
				_boIdentityUserClaimCollection = new List<IBOIdentityUserClaim>();
				IList<IDAOIdentityUserClaim> daoIdentityUserClaimCollection = _iIdentityUserClaimRepository.SelectAllByUserId(_userId.Value);
				Done(this);
				
				foreach(IDAOIdentityUserClaim daoIdentityUserClaim in daoIdentityUserClaimCollection)
					_boIdentityUserClaimCollection.Add(new BOIdentityUserClaim(daoIdentityUserClaim));
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///AddIdentityUserClaim
		///This method persists a BOIdentityUserClaim object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOIdentityUserClaim
		///</parameters>
		public virtual void AddIdentityUserClaim(IBOIdentityUserClaim boIdentityUserClaim)
		{
			Doing(this);
			IDAOIdentityUserClaim daoIdentityUserClaim = _iIdentityUserClaimRepository.New();
			RegisterDataObject(_iIdentityUserClaimRepository, _iIdentityUserClaimRepository.BaseData(daoIdentityUserClaim));
			BeginTransaction(_iIdentityUserClaimRepository, "addIdentityUserClaim");
			try
			{
				daoIdentityUserClaim.Id = boIdentityUserClaim.Id;
				daoIdentityUserClaim.ClaimType = boIdentityUserClaim.ClaimType;
				daoIdentityUserClaim.ClaimValue = boIdentityUserClaim.ClaimValue;
				daoIdentityUserClaim.UserId = _userId.Value;
				_iIdentityUserClaimRepository.Insert(daoIdentityUserClaim);
				CommitTransaction(_iIdentityUserClaimRepository);
				Done(this);
				
				/*pick up any primary keys, computed values etc*/
				boIdentityUserClaim = new BOIdentityUserClaim(daoIdentityUserClaim);
				if(_boIdentityUserClaimCollection != null)
					_boIdentityUserClaimCollection.Add(boIdentityUserClaim);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityUserClaimRepository, "addIdentityUserClaim");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///DeleteAllIdentityUserClaim
		///This method deletes all BOIdentityUserClaim objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllIdentityUserClaim()
		{
			Doing(this);
			RegisterDataObject(_iIdentityUserClaimRepository, null);
			BeginTransaction(_iIdentityUserClaimRepository, "deleteAllIdentityUserClaim");
			try
			{
				_iIdentityUserClaimRepository.DeleteAllByUserId(_userId.Value);
				CommitTransaction(_iIdentityUserClaimRepository);
				Done(this);
				if(_boIdentityUserClaimCollection != null)
				{
					_boIdentityUserClaimCollection.Clear();
					_boIdentityUserClaimCollection = null;
				}
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityUserClaimRepository, "deleteAllIdentityUserClaim");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///LoadIdentityUserLoginCollection
		///This method loads the internal collection of BOIdentityUserLogin objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadIdentityUserLoginCollection()
		{
			Doing(this);
			try
			{
				_boIdentityUserLoginCollection = new List<IBOIdentityUserLogin>();
				IList<IDAOIdentityUserLogin> daoIdentityUserLoginCollection = _iIdentityUserLoginRepository.SelectAllByUserId(_userId.Value);
				Done(this);
				
				foreach(IDAOIdentityUserLogin daoIdentityUserLogin in daoIdentityUserLoginCollection)
					_boIdentityUserLoginCollection.Add(new BOIdentityUserLogin(daoIdentityUserLogin));
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///AddIdentityUserLogin
		///This method persists a BOIdentityUserLogin object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOIdentityUserLogin
		///</parameters>
		public virtual void AddIdentityUserLogin(IBOIdentityUserLogin boIdentityUserLogin)
		{
			Doing(this);
			IDAOIdentityUserLogin daoIdentityUserLogin = _iIdentityUserLoginRepository.New();
			RegisterDataObject(_iIdentityUserLoginRepository, _iIdentityUserLoginRepository.BaseData(daoIdentityUserLogin));
			BeginTransaction(_iIdentityUserLoginRepository, "addIdentityUserLogin");
			try
			{
				daoIdentityUserLogin.LoginProvider = boIdentityUserLogin.LoginProvider;
				daoIdentityUserLogin.ProviderKey = boIdentityUserLogin.ProviderKey;
				daoIdentityUserLogin.UserId = _userId.Value;
				_iIdentityUserLoginRepository.Insert(daoIdentityUserLogin);
				CommitTransaction(_iIdentityUserLoginRepository);
				Done(this);
				
				/*pick up any primary keys, computed values etc*/
				boIdentityUserLogin = new BOIdentityUserLogin(daoIdentityUserLogin);
				if(_boIdentityUserLoginCollection != null)
					_boIdentityUserLoginCollection.Add(boIdentityUserLogin);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityUserLoginRepository, "addIdentityUserLogin");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///DeleteAllIdentityUserLogin
		///This method deletes all BOIdentityUserLogin objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllIdentityUserLogin()
		{
			Doing(this);
			RegisterDataObject(_iIdentityUserLoginRepository, null);
			BeginTransaction(_iIdentityUserLoginRepository, "deleteAllIdentityUserLogin");
			try
			{
				_iIdentityUserLoginRepository.DeleteAllByUserId(_userId.Value);
				CommitTransaction(_iIdentityUserLoginRepository);
				Done(this);
				if(_boIdentityUserLoginCollection != null)
				{
					_boIdentityUserLoginCollection.Clear();
					_boIdentityUserLoginCollection = null;
				}
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityUserLoginRepository, "deleteAllIdentityUserLogin");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///LoadIdentityUserProfileCollection
		///This method loads the internal collection of BOIdentityUserProfile objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadIdentityUserProfileCollection()
		{
			Doing(this);
			try
			{
				_boIdentityUserProfileCollection = new List<IBOIdentityUserProfile>();
				IList<IDAOIdentityUserProfile> daoIdentityUserProfileCollection = _iIdentityUserProfileRepository.SelectAllByUserId(_userId.Value);
				Done(this);
				
				foreach(IDAOIdentityUserProfile daoIdentityUserProfile in daoIdentityUserProfileCollection)
					_boIdentityUserProfileCollection.Add(new BOIdentityUserProfile(daoIdentityUserProfile));
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///AddIdentityUserProfile
		///This method persists a BOIdentityUserProfile object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOIdentityUserProfile
		///</parameters>
		public virtual void AddIdentityUserProfile(IBOIdentityUserProfile boIdentityUserProfile)
		{
			Doing(this);
			IDAOIdentityUserProfile daoIdentityUserProfile = _iIdentityUserProfileRepository.New();
			RegisterDataObject(_iIdentityUserProfileRepository, _iIdentityUserProfileRepository.BaseData(daoIdentityUserProfile));
			BeginTransaction(_iIdentityUserProfileRepository, "addIdentityUserProfile");
			try
			{
				daoIdentityUserProfile.FirstName = boIdentityUserProfile.FirstName;
				daoIdentityUserProfile.LastName = boIdentityUserProfile.LastName;
				daoIdentityUserProfile.FullName = boIdentityUserProfile.FullName;
				daoIdentityUserProfile.UserId = _userId.Value;
				_iIdentityUserProfileRepository.Insert(daoIdentityUserProfile);
				CommitTransaction(_iIdentityUserProfileRepository);
				Done(this);
				
				/*pick up any primary keys, computed values etc*/
				boIdentityUserProfile = new BOIdentityUserProfile(daoIdentityUserProfile);
				if(_boIdentityUserProfileCollection != null)
					_boIdentityUserProfileCollection.Add(boIdentityUserProfile);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityUserProfileRepository, "addIdentityUserProfile");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///DeleteAllIdentityUserProfile
		///This method deletes all BOIdentityUserProfile objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllIdentityUserProfile()
		{
			Doing(this);
			RegisterDataObject(_iIdentityUserProfileRepository, null);
			BeginTransaction(_iIdentityUserProfileRepository, "deleteAllIdentityUserProfile");
			try
			{
				_iIdentityUserProfileRepository.DeleteAllByUserId(_userId.Value);
				CommitTransaction(_iIdentityUserProfileRepository);
				Done(this);
				if(_boIdentityUserProfileCollection != null)
				{
					_boIdentityUserProfileCollection.Clear();
					_boIdentityUserProfileCollection = null;
				}
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityUserProfileRepository, "deleteAllIdentityUserProfile");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///LoadIdentityUserRoleCollection
		///This method loads the internal collection of BOIdentityUserRole objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadIdentityUserRoleCollection()
		{
			Doing(this);
			try
			{
				_boIdentityUserRoleCollection = new List<IBOIdentityUserRole>();
				IList<IDAOIdentityUserRole> daoIdentityUserRoleCollection = _iIdentityUserRoleRepository.SelectAllByUserId(_userId.Value);
				Done(this);
				
				foreach(IDAOIdentityUserRole daoIdentityUserRole in daoIdentityUserRoleCollection)
					_boIdentityUserRoleCollection.Add(new BOIdentityUserRole(daoIdentityUserRole));
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///AddIdentityUserRole
		///This method persists a BOIdentityUserRole object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOIdentityUserRole
		///</parameters>
		public virtual void AddIdentityUserRole(IBOIdentityUserRole boIdentityUserRole)
		{
			Doing(this);
			IDAOIdentityUserRole daoIdentityUserRole = _iIdentityUserRoleRepository.New();
			RegisterDataObject(_iIdentityUserRoleRepository, _iIdentityUserRoleRepository.BaseData(daoIdentityUserRole));
			BeginTransaction(_iIdentityUserRoleRepository, "addIdentityUserRole");
			try
			{
				daoIdentityUserRole.RoleId = boIdentityUserRole.RoleId;
				daoIdentityUserRole.UserId = _userId.Value;
				_iIdentityUserRoleRepository.Insert(daoIdentityUserRole);
				CommitTransaction(_iIdentityUserRoleRepository);
				Done(this);
				
				/*pick up any primary keys, computed values etc*/
				boIdentityUserRole = new BOIdentityUserRole(daoIdentityUserRole);
				if(_boIdentityUserRoleCollection != null)
					_boIdentityUserRoleCollection.Add(boIdentityUserRole);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityUserRoleRepository, "addIdentityUserRole");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///DeleteAllIdentityUserRole
		///This method deletes all BOIdentityUserRole objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllIdentityUserRole()
		{
			Doing(this);
			RegisterDataObject(_iIdentityUserRoleRepository, null);
			BeginTransaction(_iIdentityUserRoleRepository, "deleteAllIdentityUserRole");
			try
			{
				_iIdentityUserRoleRepository.DeleteAllByUserId(_userId.Value);
				CommitTransaction(_iIdentityUserRoleRepository);
				Done(this);
				if(_boIdentityUserRoleCollection != null)
				{
					_boIdentityUserRoleCollection.Clear();
					_boIdentityUserRoleCollection = null;
				}
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityUserRoleRepository, "deleteAllIdentityUserRole");
				Handle(this, ex);
			}
		}
		
		#endregion

		#region member properties
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IIdentityUserRepository IdentityUserRepository
		{
			set
			{
				_iIdentityUserRepository = value;
			}
		}
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IIdentityUserClaimRepository IdentityUserClaimRepository
		{
			set
			{
				_iIdentityUserClaimRepository = value;
			}
		}
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IIdentityUserLoginRepository IdentityUserLoginRepository
		{
			set
			{
				_iIdentityUserLoginRepository = value;
			}
		}
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IIdentityUserProfileRepository IdentityUserProfileRepository
		{
			set
			{
				_iIdentityUserProfileRepository = value;
			}
		}
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IIdentityUserRoleRepository IdentityUserRoleRepository
		{
			set
			{
				_iIdentityUserRoleRepository = value;
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
		
		public virtual string Email
		{
			get
			{
				 return _email;
			}
			set
			{
				_email = value;
				_isDirty = true;
			}
		}
		
		public virtual bool? EmailConfirmed
		{
			get
			{
				 return _emailConfirmed;
			}
			set
			{
				_emailConfirmed = value;
				_isDirty = true;
			}
		}
		
		public virtual string PasswordHash
		{
			get
			{
				 return _passwordHash;
			}
			set
			{
				_passwordHash = value;
				_isDirty = true;
			}
		}
		
		public virtual string SecurityStamp
		{
			get
			{
				 return _securityStamp;
			}
			set
			{
				_securityStamp = value;
				_isDirty = true;
			}
		}
		
		public virtual string PhoneNumber
		{
			get
			{
				 return _phoneNumber;
			}
			set
			{
				_phoneNumber = value;
				_isDirty = true;
			}
		}
		
		public virtual bool? PhoneNumberConfirmed
		{
			get
			{
				 return _phoneNumberConfirmed;
			}
			set
			{
				_phoneNumberConfirmed = value;
				_isDirty = true;
			}
		}
		
		public virtual bool? TwoFactorEnabled
		{
			get
			{
				 return _twoFactorEnabled;
			}
			set
			{
				_twoFactorEnabled = value;
				_isDirty = true;
			}
		}
		
		public virtual DateTime? LockoutEndDateUtc
		{
			get
			{
				 return _lockoutEndDateUtc;
			}
			set
			{
				_lockoutEndDateUtc = value;
				_isDirty = true;
			}
		}
		
		public virtual bool? LockoutEnabled
		{
			get
			{
				 return _lockoutEnabled;
			}
			set
			{
				_lockoutEnabled = value;
				_isDirty = true;
			}
		}
		
		public virtual Int32? AccessFailedCount
		{
			get
			{
				 return _accessFailedCount;
			}
			set
			{
				_accessFailedCount = value;
				_isDirty = true;
			}
		}
		
		public virtual string Username
		{
			get
			{
				 return _username;
			}
			set
			{
				_username = value;
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
			get {	return (object) _iIdentityUserRepository;	}
			set {	IdentityUserRepository = (IIdentityUserRepository)value;	}
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
