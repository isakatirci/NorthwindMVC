///*************************************************************
//** Class generated by CodeTrigger, Version 6.1.0.7
//** This class was generated on 2.12.2018 01:22:23
//** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
//**************************************************************/
//using System;
//using System.Collections.Generic;
//using System.Xml.Serialization;
//using Northwind.Data;
//using Northwind.Data.Interfaces;
//using Northwind.Business.Interfaces;
//using Northwind.Business.Repository.Interfaces;

//namespace Northwind.Business
//{
//	///<Summary>
//	///Class definition
//	///This is the definition of the class BOIdentityuser.
//	///It maintains a collection of BOIdentityuserclaim,BOIdentityuserrole objects.
//	///</Summary>
//	public partial class BOIdentityuser : zNorthwindConn_BaseBusiness, IBOIdentityuser, IQueryableCollection, IUnitOfWorkEntity
//	{
//		#region member variables
//		protected string _userId;
//		protected string _email;
//		protected string _emailConfirmed;
//		protected string _passwordHash;
//		protected string _securityStamp;
//		protected string _phoneNumber;
//		protected string _phoneNumberConfirmed;
//		protected string _twoFactorEnabled;
//		protected string _lockoutEndDateUtc;
//		protected string _lockoutEnabled;
//		protected string _accessFailedCount;
//		protected string _username;
//		protected string _ctrVersion;
//		protected bool _isDirty = false;
//		/*collection member objects*******************/
//		List<IBOIdentityuserclaim> _boIdentityuserclaimCollection;
//		List<IBOIdentityuserrole> _boIdentityuserroleCollection;
//		/*********************************************/
//		/*repositories*********************************/
//		protected IIdentityuserRepository _iIdentityuserRepository;
//		protected IIdentityuserclaimRepository _iIdentityuserclaimRepository;
//		protected IIdentityuserroleRepository _iIdentityuserroleRepository;
//		/*********************************************/
//		#endregion

//		#region class methods
//		///<Summary>
//		///Constructor
//		///This is the default constructor
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///
//		///</parameters>
//		public BOIdentityuser()
//		{
//		}

//		///<Summary>
//		///Initializer
//		///Initializer using primary key(s)
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///string userId
//		///</parameters>
//		public void Init(string userId)
//		{
//			try
//			{
//				IDAOIdentityuser daoIdentityuser = _iIdentityuserRepository.SelectOne(userId);
//				_userId = daoIdentityuser.UserId;
//				_email = daoIdentityuser.Email;
//				_emailConfirmed = daoIdentityuser.EmailConfirmed;
//				_passwordHash = daoIdentityuser.PasswordHash;
//				_securityStamp = daoIdentityuser.SecurityStamp;
//				_phoneNumber = daoIdentityuser.PhoneNumber;
//				_phoneNumberConfirmed = daoIdentityuser.PhoneNumberConfirmed;
//				_twoFactorEnabled = daoIdentityuser.TwoFactorEnabled;
//				_lockoutEndDateUtc = daoIdentityuser.LockoutEndDateUtc;
//				_lockoutEnabled = daoIdentityuser.LockoutEnabled;
//				_accessFailedCount = daoIdentityuser.AccessFailedCount;
//				_username = daoIdentityuser.Username;
//				_ctrVersion = daoIdentityuser.CtrVersion;
//			}
//			catch
//			{
//				throw;
//			}
//		}

//		///<Summary>
//		///Constructor
//		///This constructor initializes the business object from its respective data object
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///DAOIdentityuser
//		///</parameters>
//		protected internal BOIdentityuser(IDAOIdentityuser daoIdentityuser)
//		{
//			try
//			{
//				_userId = daoIdentityuser.UserId;
//				_email = daoIdentityuser.Email;
//				_emailConfirmed = daoIdentityuser.EmailConfirmed;
//				_passwordHash = daoIdentityuser.PasswordHash;
//				_securityStamp = daoIdentityuser.SecurityStamp;
//				_phoneNumber = daoIdentityuser.PhoneNumber;
//				_phoneNumberConfirmed = daoIdentityuser.PhoneNumberConfirmed;
//				_twoFactorEnabled = daoIdentityuser.TwoFactorEnabled;
//				_lockoutEndDateUtc = daoIdentityuser.LockoutEndDateUtc;
//				_lockoutEnabled = daoIdentityuser.LockoutEnabled;
//				_accessFailedCount = daoIdentityuser.AccessFailedCount;
//				_username = daoIdentityuser.Username;
//				_ctrVersion = daoIdentityuser.CtrVersion;
//			}
//			catch
//			{
//				throw;
//			}
//		}

//		///<Summary>
//		///SaveNew
//		///This method persists a new Identityuser record to the store
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///
//		///</parameters>
//		public virtual void SaveNew()
//		{
//			Doing(this);
//			IDAOIdentityuser daoIdentityuser = _iIdentityuserRepository.New();
//			RegisterDataObject( _iIdentityuserRepository, _iIdentityuserRepository.BaseData(daoIdentityuser));
//			BeginTransaction( _iIdentityuserRepository, "savenewBOIdentityuser");
//			try
//			{
//				daoIdentityuser.Email = _email;
//				daoIdentityuser.EmailConfirmed = _emailConfirmed;
//				daoIdentityuser.PasswordHash = _passwordHash;
//				daoIdentityuser.SecurityStamp = _securityStamp;
//				daoIdentityuser.PhoneNumber = _phoneNumber;
//				daoIdentityuser.PhoneNumberConfirmed = _phoneNumberConfirmed;
//				daoIdentityuser.TwoFactorEnabled = _twoFactorEnabled;
//				daoIdentityuser.LockoutEndDateUtc = _lockoutEndDateUtc;
//				daoIdentityuser.LockoutEnabled = _lockoutEnabled;
//				daoIdentityuser.AccessFailedCount = _accessFailedCount;
//				daoIdentityuser.Username = _username;
//				_iIdentityuserRepository.Insert(daoIdentityuser);
//				CommitTransaction( _iIdentityuserRepository);
//				Done(this);
				
//				_userId = daoIdentityuser.UserId;
//				_email = daoIdentityuser.Email;
//				_emailConfirmed = daoIdentityuser.EmailConfirmed;
//				_passwordHash = daoIdentityuser.PasswordHash;
//				_securityStamp = daoIdentityuser.SecurityStamp;
//				_phoneNumber = daoIdentityuser.PhoneNumber;
//				_phoneNumberConfirmed = daoIdentityuser.PhoneNumberConfirmed;
//				_twoFactorEnabled = daoIdentityuser.TwoFactorEnabled;
//				_lockoutEndDateUtc = daoIdentityuser.LockoutEndDateUtc;
//				_lockoutEnabled = daoIdentityuser.LockoutEnabled;
//				_accessFailedCount = daoIdentityuser.AccessFailedCount;
//				_username = daoIdentityuser.Username;
//				_ctrVersion = daoIdentityuser.CtrVersion;
//				_isDirty = false;
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				RollbackTransaction(_iIdentityuserRepository, "savenewBOIdentityuser");
//				Handle(this, ex);
//			}
//		}
//		///<Summary>
//		///Update
//		///This method updates one Identityuser record in the store
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///BOIdentityuser
//		///</parameters>
//		public virtual void Update()
//		{
//			Doing(this);
//			IDAOIdentityuser daoIdentityuser = _iIdentityuserRepository.New();
//			RegisterDataObject(_iIdentityuserRepository, _iIdentityuserRepository.BaseData(daoIdentityuser));
//			BeginTransaction(_iIdentityuserRepository, "updateBOIdentityuser");
//			try
//			{
//				daoIdentityuser.UserId = _userId;
//				daoIdentityuser.Email = _email;
//				daoIdentityuser.EmailConfirmed = _emailConfirmed;
//				daoIdentityuser.PasswordHash = _passwordHash;
//				daoIdentityuser.SecurityStamp = _securityStamp;
//				daoIdentityuser.PhoneNumber = _phoneNumber;
//				daoIdentityuser.PhoneNumberConfirmed = _phoneNumberConfirmed;
//				daoIdentityuser.TwoFactorEnabled = _twoFactorEnabled;
//				daoIdentityuser.LockoutEndDateUtc = _lockoutEndDateUtc;
//				daoIdentityuser.LockoutEnabled = _lockoutEnabled;
//				daoIdentityuser.AccessFailedCount = _accessFailedCount;
//				daoIdentityuser.Username = _username;
//				daoIdentityuser.CtrVersion = _ctrVersion;
//				_iIdentityuserRepository.Update(daoIdentityuser);
//				CommitTransaction(_iIdentityuserRepository);
//				Done(this);
				
//				_userId = daoIdentityuser.UserId;
//				_email = daoIdentityuser.Email;
//				_emailConfirmed = daoIdentityuser.EmailConfirmed;
//				_passwordHash = daoIdentityuser.PasswordHash;
//				_securityStamp = daoIdentityuser.SecurityStamp;
//				_phoneNumber = daoIdentityuser.PhoneNumber;
//				_phoneNumberConfirmed = daoIdentityuser.PhoneNumberConfirmed;
//				_twoFactorEnabled = daoIdentityuser.TwoFactorEnabled;
//				_lockoutEndDateUtc = daoIdentityuser.LockoutEndDateUtc;
//				_lockoutEnabled = daoIdentityuser.LockoutEnabled;
//				_accessFailedCount = daoIdentityuser.AccessFailedCount;
//				_username = daoIdentityuser.Username;
//				_ctrVersion = daoIdentityuser.CtrVersion;
//				_isDirty = false;
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				RollbackTransaction(_iIdentityuserRepository, "updateBOIdentityuser");
//				Handle(this, ex);
//			}
//		}
//		///<Summary>
//		///Delete
//		///This method deletes one Identityuser record from the store
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///
//		///</parameters>
//		public virtual void Delete()
//		{
//			Doing(this);
//			IDAOIdentityuser daoIdentityuser = _iIdentityuserRepository.New();
//			RegisterDataObject(_iIdentityuserRepository, _iIdentityuserRepository.BaseData(daoIdentityuser));
//			BeginTransaction(_iIdentityuserRepository, "deleteBOIdentityuser");
//			try
//			{
//				daoIdentityuser.UserId = _userId;
//				_iIdentityuserRepository.Delete(daoIdentityuser);
//				CommitTransaction(_iIdentityuserRepository);
//				Done(this);
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				RollbackTransaction(_iIdentityuserRepository, "deleteBOIdentityuser");
//				Handle(this, ex);
//			}
//		}
		
//		///<Summary>
//		///IdentityuserCollection
//		///This method returns the collection of BOIdentityuser objects
//		///</Summary>
//		///<returns>
//		///IList[IBOIdentityuser]
//		///</returns>
//		///<parameters>
//		///
//		///</parameters>
//		public static IList<IBOIdentityuser> IdentityuserCollection(IIdentityuserRepository iIdentityuserRepository)
//		{
//			Doing(null);
//			try
//			{
//				IList<IBOIdentityuser> boIdentityuserCollection = new List<IBOIdentityuser>();
//				IList<IDAOIdentityuser> daoIdentityuserCollection = iIdentityuserRepository.SelectAll();
//				Done(null);
				
//				foreach(IDAOIdentityuser daoIdentityuser in daoIdentityuserCollection)
//					boIdentityuserCollection.Add(new BOIdentityuser(daoIdentityuser));
				
//				return boIdentityuserCollection;
//			}
//			catch(Exception ex)
//			{
//				Failed(null, ex);
//				Handle(null, ex);
//				return null;
//			}
//		}
		
		
//		///<Summary>
//		///IdentityuserCollectionCount
//		///This method returns the collection count of BOIdentityuser objects
//		///</Summary>
//		///<returns>
//		///Int32
//		///</returns>
//		///<parameters>
//		///
//		///</parameters>
//		public static Int32 IdentityuserCollectionCount(IIdentityuserRepository iIdentityuserRepository)
//		{
//			Doing(null);
//			try
//			{
//				Int32 objCount = iIdentityuserRepository.SelectAllCount();
//				return objCount;
//			}
//			catch(Exception ex)
//			{
//				Failed(null, ex);
//				Handle(null, ex);
//				return -1;
//			}
//		}
		
		
//		///<Summary>
//		///IdentityuserCollectionFromCriteria
//		///This method returns the collection of projections, ordered and filtered by optional criteria
//		///</Summary>
//		///<returns>
//		///IList<IBOIdentityuser>
//		///</returns>
//		///<parameters>
//		///ICriteria icriteria
//		///</parameters>
//		public virtual IDictionary<string, IList<object>> Projections(object o)
//		{
//			Doing(this);
//			try
//			{
//				ICriteria icriteria = (ICriteria)o;
//				IList<IDataProjection> lstDataProjection = (icriteria == null) ? null : icriteria.ListDataProjection();
//				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
//				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
//				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
//				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
//				return _iIdentityuserRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				Handle(this, ex);
//				return null;
//			}
//		}
		
//		///<Summary>
//		///Collection<T>
//		///This method returns the collection of T objects, ordered and filtered by optional criteria
//		///</Summary>
//		///<returns>
//		///IList<T>
//		///</returns>
//		///<parameters>
//		///object o (ICriteria)
//		///</parameters>
//		public virtual IList<T> Collection<T>(object o)
//		{
//			Doing(this);
//			try
//			{
//				ICriteria icriteria = (ICriteria)o;
//				IList<T> boIdentityuserCollection = new List<T>();
//				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
//				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
//				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
//				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
//				IList<IDAOIdentityuser> daoIdentityuserCollection = _iIdentityuserRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
//				foreach(IDAOIdentityuser resdaoIdentityuser in daoIdentityuserCollection)
//					boIdentityuserCollection.Add((T)(object)new BOIdentityuser(resdaoIdentityuser));
				
//				return boIdentityuserCollection;
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				Handle(this, ex);
//				return null;
//			}
//		}
		
		
//		///<Summary>
//		///CollectionCount
//		///This method returns the collection count of BOIdentityuser objects, filtered by optional criteria
//		///</Summary>
//		///<returns>
//		///Int32
//		///</returns>
//		///<parameters>
//		///ICriteria icriteria
//		///</parameters>
//		public virtual Int32 CollectionCount(object o)
//		{
//			Doing(this);
//			try
//			{
//				ICriteria icriteria = (ICriteria)o;
//				List<IBOIdentityuser> boIdentityuserCollection = new List<IBOIdentityuser>();
//				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
//				Int32 objCount = _iIdentityuserRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
//				return objCount;
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				Handle(this, ex);
//				return -1;
//			}
//		}
		
//		///<Summary>
//		///IdentityuserclaimCollection
//		///This method returns its collection of BOIdentityuserclaim objects
//		///</Summary>
//		///<returns>
//		///IList[IBOIdentityuserclaim]
//		///</returns>
//		///<parameters>
//		///BOIdentityuser
//		///</parameters>
//		public virtual IList<IBOIdentityuserclaim> IdentityuserclaimCollection()
//		{
//			Doing(this);
//			try
//			{
//				if(_boIdentityuserclaimCollection == null)
//					LoadIdentityuserclaimCollection();
//				return _boIdentityuserclaimCollection.AsReadOnly();
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				Handle(this, ex);
//				return null;
//			}
//		}
		
//		///<Summary>
//		///IdentityuserroleCollection
//		///This method returns its collection of BOIdentityuserrole objects
//		///</Summary>
//		///<returns>
//		///IList[IBOIdentityuserrole]
//		///</returns>
//		///<parameters>
//		///BOIdentityuser
//		///</parameters>
//		public virtual IList<IBOIdentityuserrole> IdentityuserroleCollection()
//		{
//			Doing(this);
//			try
//			{
//				if(_boIdentityuserroleCollection == null)
//					LoadIdentityuserroleCollection();
//				return _boIdentityuserroleCollection.AsReadOnly();
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				Handle(this, ex);
//				return null;
//			}
//		}
		
//		///<Summary>
//		///LoadIdentityuserclaimCollection
//		///This method loads the internal collection of BOIdentityuserclaim objects from storage. 
//		///Call this if you need to ensure the collection is up-to-date (concurrency)
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///
//		///</parameters>
//		public virtual void LoadIdentityuserclaimCollection()
//		{
//			Doing(this);
//			try
//			{
//				_boIdentityuserclaimCollection = new List<IBOIdentityuserclaim>();
//				IList<IDAOIdentityuserclaim> daoIdentityuserclaimCollection = _iIdentityuserclaimRepository.SelectAllByUserId(_userId);
//				Done(this);
				
//				foreach(IDAOIdentityuserclaim daoIdentityuserclaim in daoIdentityuserclaimCollection)
//					_boIdentityuserclaimCollection.Add(new BOIdentityuserclaim(daoIdentityuserclaim));
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				Handle(this, ex);
//			}
//		}
		
//		///<Summary>
//		///AddIdentityuserclaim
//		///This method persists a BOIdentityuserclaim object to the database collection
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///BOIdentityuserclaim
//		///</parameters>
//		public virtual void AddIdentityuserclaim(IBOIdentityuserclaim boIdentityuserclaim)
//		{
//			Doing(this);
//			IDAOIdentityuserclaim daoIdentityuserclaim = _iIdentityuserclaimRepository.New();
//			RegisterDataObject(_iIdentityuserclaimRepository, _iIdentityuserclaimRepository.BaseData(daoIdentityuserclaim));
//			BeginTransaction(_iIdentityuserclaimRepository, "addIdentityuserclaim");
//			try
//			{
//				daoIdentityuserclaim.Id = boIdentityuserclaim.Id;
//				daoIdentityuserclaim.ClaimType = boIdentityuserclaim.ClaimType;
//				daoIdentityuserclaim.ClaimValue = boIdentityuserclaim.ClaimValue;
//				daoIdentityuserclaim.UserId = _userId;
//				_iIdentityuserclaimRepository.Insert(daoIdentityuserclaim);
//				CommitTransaction(_iIdentityuserclaimRepository);
//				Done(this);
				
//				/*pick up any primary keys, computed values etc*/
//				boIdentityuserclaim = new BOIdentityuserclaim(daoIdentityuserclaim);
//				if(_boIdentityuserclaimCollection != null)
//					_boIdentityuserclaimCollection.Add(boIdentityuserclaim);
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				RollbackTransaction(_iIdentityuserclaimRepository, "addIdentityuserclaim");
//				Handle(this, ex);
//			}
//		}
		
//		///<Summary>
//		///DeleteAllIdentityuserclaim
//		///This method deletes all BOIdentityuserclaim objects from its collection
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///
//		///</parameters>
//		public virtual void DeleteAllIdentityuserclaim()
//		{
//			Doing(this);
//			RegisterDataObject(_iIdentityuserclaimRepository, null);
//			BeginTransaction(_iIdentityuserclaimRepository, "deleteAllIdentityuserclaim");
//			try
//			{
//				_iIdentityuserclaimRepository.DeleteAllByUserId(_userId);
//				CommitTransaction(_iIdentityuserclaimRepository);
//				Done(this);
//				if(_boIdentityuserclaimCollection != null)
//				{
//					_boIdentityuserclaimCollection.Clear();
//					_boIdentityuserclaimCollection = null;
//				}
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				RollbackTransaction(_iIdentityuserclaimRepository, "deleteAllIdentityuserclaim");
//				Handle(this, ex);
//			}
//		}
		
//		///<Summary>
//		///LoadIdentityuserroleCollection
//		///This method loads the internal collection of BOIdentityuserrole objects from storage. 
//		///Call this if you need to ensure the collection is up-to-date (concurrency)
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///
//		///</parameters>
//		public virtual void LoadIdentityuserroleCollection()
//		{
//			Doing(this);
//			try
//			{
//				_boIdentityuserroleCollection = new List<IBOIdentityuserrole>();
//				IList<IDAOIdentityuserrole> daoIdentityuserroleCollection = _iIdentityuserroleRepository.SelectAllByUserId(_userId);
//				Done(this);
				
//				foreach(IDAOIdentityuserrole daoIdentityuserrole in daoIdentityuserroleCollection)
//					_boIdentityuserroleCollection.Add(new BOIdentityuserrole(daoIdentityuserrole));
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				Handle(this, ex);
//			}
//		}
		
//		///<Summary>
//		///AddIdentityuserrole
//		///This method persists a BOIdentityuserrole object to the database collection
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///BOIdentityuserrole
//		///</parameters>
//		public virtual void AddIdentityuserrole(IBOIdentityuserrole boIdentityuserrole)
//		{
//			Doing(this);
//			IDAOIdentityuserrole daoIdentityuserrole = _iIdentityuserroleRepository.New();
//			RegisterDataObject(_iIdentityuserroleRepository, _iIdentityuserroleRepository.BaseData(daoIdentityuserrole));
//			BeginTransaction(_iIdentityuserroleRepository, "addIdentityuserrole");
//			try
//			{
//				daoIdentityuserrole.RoleId = boIdentityuserrole.RoleId;
//				daoIdentityuserrole.UserId = _userId;
//				_iIdentityuserroleRepository.Insert(daoIdentityuserrole);
//				CommitTransaction(_iIdentityuserroleRepository);
//				Done(this);
				
//				/*pick up any primary keys, computed values etc*/
//				boIdentityuserrole = new BOIdentityuserrole(daoIdentityuserrole);
//				if(_boIdentityuserroleCollection != null)
//					_boIdentityuserroleCollection.Add(boIdentityuserrole);
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				RollbackTransaction(_iIdentityuserroleRepository, "addIdentityuserrole");
//				Handle(this, ex);
//			}
//		}
		
//		///<Summary>
//		///DeleteAllIdentityuserrole
//		///This method deletes all BOIdentityuserrole objects from its collection
//		///</Summary>
//		///<returns>
//		///void
//		///</returns>
//		///<parameters>
//		///
//		///</parameters>
//		public virtual void DeleteAllIdentityuserrole()
//		{
//			Doing(this);
//			RegisterDataObject(_iIdentityuserroleRepository, null);
//			BeginTransaction(_iIdentityuserroleRepository, "deleteAllIdentityuserrole");
//			try
//			{
//				_iIdentityuserroleRepository.DeleteAllByUserId(_userId);
//				CommitTransaction(_iIdentityuserroleRepository);
//				Done(this);
//				if(_boIdentityuserroleCollection != null)
//				{
//					_boIdentityuserroleCollection.Clear();
//					_boIdentityuserroleCollection = null;
//				}
//			}
//			catch(Exception ex)
//			{
//				Failed(this, ex);
//				RollbackTransaction(_iIdentityuserroleRepository, "deleteAllIdentityuserrole");
//				Handle(this, ex);
//			}
//		}
		
//		#endregion

//		#region member properties
		
//		[InjectionPoint]
//		[XmlIgnore]
//		public virtual IIdentityuserRepository IdentityuserRepository
//		{
//			set
//			{
//				_iIdentityuserRepository = value;
//			}
//		}
		
//		[InjectionPoint]
//		[XmlIgnore]
//		public virtual IIdentityuserclaimRepository IdentityuserclaimRepository
//		{
//			set
//			{
//				_iIdentityuserclaimRepository = value;
//			}
//		}
		
//		[InjectionPoint]
//		[XmlIgnore]
//		public virtual IIdentityuserroleRepository IdentityuserroleRepository
//		{
//			set
//			{
//				_iIdentityuserroleRepository = value;
//			}
//		}
		
//		public virtual string UserId
//		{
//			get
//			{
//				 return _userId;
//			}
//			set
//			{
//				_userId = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string Email
//		{
//			get
//			{
//				 return _email;
//			}
//			set
//			{
//				_email = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string EmailConfirmed
//		{
//			get
//			{
//				 return _emailConfirmed;
//			}
//			set
//			{
//				_emailConfirmed = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string PasswordHash
//		{
//			get
//			{
//				 return _passwordHash;
//			}
//			set
//			{
//				_passwordHash = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string SecurityStamp
//		{
//			get
//			{
//				 return _securityStamp;
//			}
//			set
//			{
//				_securityStamp = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string PhoneNumber
//		{
//			get
//			{
//				 return _phoneNumber;
//			}
//			set
//			{
//				_phoneNumber = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string PhoneNumberConfirmed
//		{
//			get
//			{
//				 return _phoneNumberConfirmed;
//			}
//			set
//			{
//				_phoneNumberConfirmed = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string TwoFactorEnabled
//		{
//			get
//			{
//				 return _twoFactorEnabled;
//			}
//			set
//			{
//				_twoFactorEnabled = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string LockoutEndDateUtc
//		{
//			get
//			{
//				 return _lockoutEndDateUtc;
//			}
//			set
//			{
//				_lockoutEndDateUtc = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string LockoutEnabled
//		{
//			get
//			{
//				 return _lockoutEnabled;
//			}
//			set
//			{
//				_lockoutEnabled = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string AccessFailedCount
//		{
//			get
//			{
//				 return _accessFailedCount;
//			}
//			set
//			{
//				_accessFailedCount = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string Username
//		{
//			get
//			{
//				 return _username;
//			}
//			set
//			{
//				_username = value;
//				_isDirty = true;
//			}
//		}
		
//		public virtual string CtrVersion
//		{
//			get
//			{
//				 return _ctrVersion;
//			}
//			set
//			{
//				_ctrVersion = value;
//			}
//		}
		
//		[XmlIgnore]
//		public virtual object Repository
//		{
//			get {	return (object) _iIdentityuserRepository;	}
//			set {	IdentityuserRepository = (IIdentityuserRepository)value;	}
//		}
		
//		public virtual bool IsDirty
//		{
//			get
//			{
//				 return _isDirty;
//			}
//			set
//			{
//				_isDirty = value;
//			}
//		}
//		#endregion
//	}
//}
