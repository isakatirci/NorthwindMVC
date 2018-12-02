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
	///This is the definition of the class BOIdentityuserrole.
	///</Summary>
	public partial class BOIdentityuserrole : zNorthwindConn_BaseBusiness, IBOIdentityuserrole, IQueryableCollection
	{
		#region member variables
		protected string _userId;
		protected string _roleId;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected IIdentityuserroleRepository _iIdentityuserroleRepository;
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
		public BOIdentityuserrole()
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
		///string userId, string roleId
		///</parameters>
		public void Init(string userId, string roleId)
		{
			try
			{
				IDAOIdentityuserrole daoIdentityuserrole = _iIdentityuserroleRepository.SelectOne(userId, roleId);
				_userId = daoIdentityuserrole.UserId;
				_roleId = daoIdentityuserrole.RoleId;
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
		///DAOIdentityuserrole
		///</parameters>
		protected internal BOIdentityuserrole(IDAOIdentityuserrole daoIdentityuserrole)
		{
			try
			{
				_userId = daoIdentityuserrole.UserId;
				_roleId = daoIdentityuserrole.RoleId;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new Identityuserrole record to the store
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
			IDAOIdentityuserrole daoIdentityuserrole = _iIdentityuserroleRepository.New();
			RegisterDataObject( _iIdentityuserroleRepository, _iIdentityuserroleRepository.BaseData(daoIdentityuserrole));
			BeginTransaction( _iIdentityuserroleRepository, "savenewBOIdentityuserrole");
			try
			{
				daoIdentityuserrole.UserId = _userId;
				daoIdentityuserrole.RoleId = _roleId;
				_iIdentityuserroleRepository.Insert(daoIdentityuserrole);
				CommitTransaction( _iIdentityuserroleRepository);
				Done(this);
				
				_userId = daoIdentityuserrole.UserId;
				_roleId = daoIdentityuserrole.RoleId;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityuserroleRepository, "savenewBOIdentityuserrole");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one Identityuserrole record from the store
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
			IDAOIdentityuserrole daoIdentityuserrole = _iIdentityuserroleRepository.New();
			RegisterDataObject(_iIdentityuserroleRepository, _iIdentityuserroleRepository.BaseData(daoIdentityuserrole));
			BeginTransaction(_iIdentityuserroleRepository, "deleteBOIdentityuserrole");
			try
			{
				daoIdentityuserrole.UserId = _userId;
				daoIdentityuserrole.RoleId = _roleId;
				_iIdentityuserroleRepository.Delete(daoIdentityuserrole);
				CommitTransaction(_iIdentityuserroleRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iIdentityuserroleRepository, "deleteBOIdentityuserrole");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///IdentityuserroleCollection
		///This method returns the collection of BOIdentityuserrole objects
		///</Summary>
		///<returns>
		///IList[IBOIdentityuserrole]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOIdentityuserrole> IdentityuserroleCollection(IIdentityuserroleRepository iIdentityuserroleRepository)
		{
			Doing(null);
			try
			{
				IList<IBOIdentityuserrole> boIdentityuserroleCollection = new List<IBOIdentityuserrole>();
				IList<IDAOIdentityuserrole> daoIdentityuserroleCollection = iIdentityuserroleRepository.SelectAll();
				Done(null);
				
				foreach(IDAOIdentityuserrole daoIdentityuserrole in daoIdentityuserroleCollection)
					boIdentityuserroleCollection.Add(new BOIdentityuserrole(daoIdentityuserrole));
				
				return boIdentityuserroleCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///IdentityuserroleCollectionCount
		///This method returns the collection count of BOIdentityuserrole objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 IdentityuserroleCollectionCount(IIdentityuserroleRepository iIdentityuserroleRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iIdentityuserroleRepository.SelectAllCount();
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
		///IdentityuserroleCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOIdentityuserrole>
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
				return _iIdentityuserroleRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boIdentityuserroleCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOIdentityuserrole> daoIdentityuserroleCollection = _iIdentityuserroleRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOIdentityuserrole resdaoIdentityuserrole in daoIdentityuserroleCollection)
					boIdentityuserroleCollection.Add((T)(object)new BOIdentityuserrole(resdaoIdentityuserrole));
				
				return boIdentityuserroleCollection;
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
		///This method returns the collection count of BOIdentityuserrole objects, filtered by optional criteria
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
				List<IBOIdentityuserrole> boIdentityuserroleCollection = new List<IBOIdentityuserrole>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iIdentityuserroleRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		public virtual IIdentityuserroleRepository IdentityuserroleRepository
		{
			set
			{
				_iIdentityuserroleRepository = value;
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
		
		public virtual string RoleId
		{
			get
			{
				 return _roleId;
			}
			set
			{
				_roleId = value;
				_isDirty = true;
			}
		}
		
		[XmlIgnore]
		public virtual object Repository
		{
			get {	return (object) _iIdentityuserroleRepository;	}
			set {	IdentityuserroleRepository = (IIdentityuserroleRepository)value;	}
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
