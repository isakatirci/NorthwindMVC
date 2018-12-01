/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:31:22
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindTest3.DataObjects;
using NorthwindTest3.DataObjects.Interfaces;
using NorthwindTest3.BusinessObjects.Interfaces;

namespace NorthwindTest3.BusinessObjects
{
	///<Summary>
	///Class definition
	///This is the definition of the class BOEmployeeTerritories.
	///</Summary>
	public partial class BOEmployeeTerritories : zNorthwindTest3Conn_BaseBusiness, IQueryableCollection
	{
		#region member variables
		protected Int32? _employeeID;
		protected string _territoryID;
		protected bool _isDirty = false;
		/*collection member objects*******************/
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
		public BOEmployeeTerritories()
		{
		}

		///<Summary>
		///Constructor
		///Constructor using primary key(s)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///Int32 employeeID, string territoryID
		///</parameters>
		public BOEmployeeTerritories(Int32 employeeID, string territoryID)
		{
			try
			{
				DAOEmployeeTerritories daoEmployeeTerritories = DAOEmployeeTerritories.SelectOne(employeeID, territoryID);
				_employeeID = daoEmployeeTerritories.EmployeeID;
				_territoryID = daoEmployeeTerritories.TerritoryID;
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
		///DAOEmployeeTerritories
		///</parameters>
		protected internal BOEmployeeTerritories(DAOEmployeeTerritories daoEmployeeTerritories)
		{
			try
			{
				_employeeID = daoEmployeeTerritories.EmployeeID;
				_territoryID = daoEmployeeTerritories.TerritoryID;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new EmployeeTerritories record to the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void SaveNew()
		{
			DAOEmployeeTerritories daoEmployeeTerritories = new DAOEmployeeTerritories();
			RegisterDataObject(daoEmployeeTerritories);
			BeginTransaction("savenewBOEmployeeTerritories");
			try
			{
				daoEmployeeTerritories.EmployeeID = _employeeID;
				daoEmployeeTerritories.TerritoryID = _territoryID;
				daoEmployeeTerritories.Insert();
				CommitTransaction();
				
				_employeeID = daoEmployeeTerritories.EmployeeID;
				_territoryID = daoEmployeeTerritories.TerritoryID;
				_isDirty = false;
			}
			catch
			{
				RollbackTransaction("savenewBOEmployeeTerritories");
				throw;
			}
		}
		
		///<Summary>
		///Delete
		///This method deletes one EmployeeTerritories record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Delete()
		{
			DAOEmployeeTerritories daoEmployeeTerritories = new DAOEmployeeTerritories();
			RegisterDataObject(daoEmployeeTerritories);
			BeginTransaction("deleteBOEmployeeTerritories");
			try
			{
				daoEmployeeTerritories.EmployeeID = _employeeID;
				daoEmployeeTerritories.TerritoryID = _territoryID;
				daoEmployeeTerritories.Delete();
				CommitTransaction();
			}
			catch
			{
				RollbackTransaction("deleteBOEmployeeTerritories");
				throw;
			}
		}
		
		///<Summary>
		///EmployeeTerritoriesCollection
		///This method returns the collection of BOEmployeeTerritories objects
		///</Summary>
		///<returns>
		///List[BOEmployeeTerritories]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<BOEmployeeTerritories> EmployeeTerritoriesCollection()
		{
			try
			{
				IList<BOEmployeeTerritories> boEmployeeTerritoriesCollection = new List<BOEmployeeTerritories>();
				IList<DAOEmployeeTerritories> daoEmployeeTerritoriesCollection = DAOEmployeeTerritories.SelectAll();
			
				foreach(DAOEmployeeTerritories daoEmployeeTerritories in daoEmployeeTerritoriesCollection)
					boEmployeeTerritoriesCollection.Add(new BOEmployeeTerritories(daoEmployeeTerritories));
			
				return boEmployeeTerritoriesCollection;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///EmployeeTerritoriesCollectionCount
		///This method returns the collection count of BOEmployeeTerritories objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 EmployeeTerritoriesCollectionCount()
		{
			try
			{
				Int32 objCount = DAOEmployeeTerritories.SelectAllCount();
				return objCount;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///Projections
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///List<BOEmployeeTerritories>
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
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDictionary<string, IList<object>> retObj = DAOEmployeeTerritories.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				return retObj;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///EmployeeTerritoriesCollection<T>
		///This method implements the IQueryable Collection<T> method, returning a collection of BOEmployeeTerritories objects, filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<T>
		///</returns>
		///<parameters>
		///object o
		///</parameters>
		public virtual IList<T> Collection<T>(object o)
		{
			try
			{
				ICriteria icriteria = (ICriteria)o;
				IList<T> boEmployeeTerritoriesCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IList<DAOEmployeeTerritories> daoEmployeeTerritoriesCollection = DAOEmployeeTerritories.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
			
				foreach(DAOEmployeeTerritories resdaoEmployeeTerritories in daoEmployeeTerritoriesCollection)
					boEmployeeTerritoriesCollection.Add((T)(object)new BOEmployeeTerritories(resdaoEmployeeTerritories));
			
				return boEmployeeTerritoriesCollection;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///EmployeeTerritoriesCollectionCount
		///This method implements the IQueryable CollectionCount method, returning a collection count of BOEmployeeTerritories objects, filtered by optional criteria
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///object o
		///</parameters>
		public virtual Int32 CollectionCount(object o)
		{
			try
			{
				ICriteria icriteria = (ICriteria)o;
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = DAOEmployeeTerritories.SelectAllByCriteriaCount(lstDataCriteria);
				return objCount;
			}
			catch
			{
				throw;
			}
		}
		
		#endregion

		#region member properties
		
		public virtual Int32? EmployeeID
		{
			get
			{
				 return _employeeID;
			}
			set
			{
				_employeeID = value;
				_isDirty = true;
			}
		}
		
		public virtual string TerritoryID
		{
			get
			{
				 return _territoryID;
			}
			set
			{
				_territoryID = value;
				_isDirty = true;
			}
		}
		
		public virtual object Repository
		{
			get {	return null;	}
			set	{	}
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