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
	///This is the definition of the class BOIdentityuserprofile.
	///</Summary>
	public partial class BOIdentityuserprofile : zNorthwindConn_BaseBusiness, IBOIdentityuserprofile, IQueryableCollection, IUnitOfWorkEntity
	{
		#region member variables
		protected string _userId;
		protected string _firstName;
		protected string _lastName;
		protected string _fullName;
		protected string _ctrVersion;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected IIdentityuserprofileRepository _iIdentityuserprofileRepository;
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
		public BOIdentityuserprofile()
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
		///string userId
		///</parameters>
		public void Init(string userId)
		{
			try
			{
				IDAOIdentityuserprofile daoIdentityuserprofile = _iIdentityuserprofileRepository.SelectOne(userId);
				_userId = daoIdentityuserprofile.UserId;
				_firstName = daoIdentityuserprofile.FirstName;
				_lastName = daoIdentityuserprofile.LastName;
				_fullName = daoIdentityuserprofile.FullName;
				_ctrVersion = daoIdentityuserprofile.CtrVersion;
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
		///DAOIdentityuserprofile
		///</parameters>
		protected internal BOIdentityuserprofile(IDAOIdentityuserprofile daoIdentityuserprofile)
		{
			try
			{
				_userId = daoIdentityuserprofile.UserId;
				_firstName = daoIdentityuserprofile.FirstName;
				_lastName = daoIdentityuserprofile.LastName;
				_fullName = daoIdentityuserprofile.FullName;
				_ctrVersion = daoIdentityuserprofile.CtrVersion;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new Identityuserprofile record to the store
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
			IDAOIdentityuserprofile daoIdentityuserprofile = _iIdentityuserprofileRepository.New();
			RegisterDataObject( _iIdentityuserprofileRepository, _iIdentityuserprofileRepository.BaseData(daoIdentityuserprofile));
			BeginTransaction( _iIdentityuserprofileRepository, "savenewBOIdentityuserprofile");
			try
			{
				daoIdentityuserprofile.UserId = _userId;
				daoIdentityuserprofile.FirstName = _firstName;
				daoIdentityuserprofile.LastName = _lastName;
				daoIdentityuserprofile.FullName = _fullName;
				_iIdentityuserprofileRepository.Insert(daoIdentityuserprofile);
				CommitTransaction( _iIdentityuserprofileRepository);
				Done(this);
				
				_userId = daoIdentityuserprofile.UserId;
				_firstName = daoIdentityuserprofile.FirstName;
				_lastName = daoIdentityuserprofile.LastName;
				_fullName = daoIdentityuserprofile.FullName;
				_ctrVersion = daoIdentityuserprofile.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityuserprofileRepository, "savenewBOIdentityuserprofile");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Update
		///This method updates one Identityuserprofile record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOIdentityuserprofile
		///</parameters>
		public virtual void Update()
		{
			Doing(this);
			IDAOIdentityuserprofile daoIdentityuserprofile = _iIdentityuserprofileRepository.New();
			RegisterDataObject(_iIdentityuserprofileRepository, _iIdentityuserprofileRepository.BaseData(daoIdentityuserprofile));
			BeginTransaction(_iIdentityuserprofileRepository, "updateBOIdentityuserprofile");
			try
			{
				daoIdentityuserprofile.UserId = _userId;
				daoIdentityuserprofile.FirstName = _firstName;
				daoIdentityuserprofile.LastName = _lastName;
				daoIdentityuserprofile.FullName = _fullName;
				daoIdentityuserprofile.CtrVersion = _ctrVersion;
				_iIdentityuserprofileRepository.Update(daoIdentityuserprofile);
				CommitTransaction(_iIdentityuserprofileRepository);
				Done(this);
				
				_userId = daoIdentityuserprofile.UserId;
				_firstName = daoIdentityuserprofile.FirstName;
				_lastName = daoIdentityuserprofile.LastName;
				_fullName = daoIdentityuserprofile.FullName;
				_ctrVersion = daoIdentityuserprofile.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityuserprofileRepository, "updateBOIdentityuserprofile");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one Identityuserprofile record from the store
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
			IDAOIdentityuserprofile daoIdentityuserprofile = _iIdentityuserprofileRepository.New();
			RegisterDataObject(_iIdentityuserprofileRepository, _iIdentityuserprofileRepository.BaseData(daoIdentityuserprofile));
			BeginTransaction(_iIdentityuserprofileRepository, "deleteBOIdentityuserprofile");
			try
			{
				daoIdentityuserprofile.UserId = _userId;
				_iIdentityuserprofileRepository.Delete(daoIdentityuserprofile);
				CommitTransaction(_iIdentityuserprofileRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityuserprofileRepository, "deleteBOIdentityuserprofile");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///IdentityuserprofileCollection
		///This method returns the collection of BOIdentityuserprofile objects
		///</Summary>
		///<returns>
		///IList[IBOIdentityuserprofile]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOIdentityuserprofile> IdentityuserprofileCollection(IIdentityuserprofileRepository iIdentityuserprofileRepository)
		{
			Doing(null);
			try
			{
				IList<IBOIdentityuserprofile> boIdentityuserprofileCollection = new List<IBOIdentityuserprofile>();
				IList<IDAOIdentityuserprofile> daoIdentityuserprofileCollection = iIdentityuserprofileRepository.SelectAll();
				Done(null);
				
				foreach(IDAOIdentityuserprofile daoIdentityuserprofile in daoIdentityuserprofileCollection)
					boIdentityuserprofileCollection.Add(new BOIdentityuserprofile(daoIdentityuserprofile));
				
				return boIdentityuserprofileCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///IdentityuserprofileCollectionCount
		///This method returns the collection count of BOIdentityuserprofile objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 IdentityuserprofileCollectionCount(IIdentityuserprofileRepository iIdentityuserprofileRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iIdentityuserprofileRepository.SelectAllCount();
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
		///IdentityuserprofileCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOIdentityuserprofile>
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
				return _iIdentityuserprofileRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boIdentityuserprofileCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOIdentityuserprofile> daoIdentityuserprofileCollection = _iIdentityuserprofileRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOIdentityuserprofile resdaoIdentityuserprofile in daoIdentityuserprofileCollection)
					boIdentityuserprofileCollection.Add((T)(object)new BOIdentityuserprofile(resdaoIdentityuserprofile));
				
				return boIdentityuserprofileCollection;
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
		///This method returns the collection count of BOIdentityuserprofile objects, filtered by optional criteria
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
				List<IBOIdentityuserprofile> boIdentityuserprofileCollection = new List<IBOIdentityuserprofile>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iIdentityuserprofileRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		public virtual IIdentityuserprofileRepository IdentityuserprofileRepository
		{
			set
			{
				_iIdentityuserprofileRepository = value;
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
		
		public virtual string FullName
		{
			get
			{
				 return _fullName;
			}
			set
			{
				_fullName = value;
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
			get {	return (object) _iIdentityuserprofileRepository;	}
			set {	IdentityuserprofileRepository = (IIdentityuserprofileRepository)value;	}
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
