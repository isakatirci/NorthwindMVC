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
	///This is the definition of the class BOProductsByCategory.
	///</Summary>
	public partial class BOProductsByCategory : zNorthwindRestApiConn_BaseBusiness, IBOProductsByCategory, IQueryableCollection
	{
		#region member variables
		protected string _categoryName;
		protected string _productName;
		protected string _quantityPerUnit;
		protected Int16? _unitsInStock;
		protected bool? _discontinued;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected IProductsByCategoryRepository _iProductsByCategoryRepository;
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
		public BOProductsByCategory()
		{
		}

		///<Summary>
		///Constructor
		///This constructor initializes the business object from its respective data object
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///DAOProductsByCategory
		///</parameters>
		protected internal BOProductsByCategory(IDAOProductsByCategory daoProductsByCategory)
		{
			try
			{
				_categoryName = daoProductsByCategory.CategoryName;
				_productName = daoProductsByCategory.ProductName;
				_quantityPerUnit = daoProductsByCategory.QuantityPerUnit;
				_unitsInStock = daoProductsByCategory.UnitsInStock;
				_discontinued = daoProductsByCategory.Discontinued;
			}
			catch
			{
				throw;
			}
		}

		
		///<Summary>
		///ProductsByCategoryCollection
		///This method returns the collection of BOProductsByCategory objects
		///</Summary>
		///<returns>
		///IList[IBOProductsByCategory]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOProductsByCategory> ProductsByCategoryCollection(IProductsByCategoryRepository iProductsByCategoryRepository)
		{
			Doing(null);
			try
			{
				IList<IBOProductsByCategory> boProductsByCategoryCollection = new List<IBOProductsByCategory>();
				IList<IDAOProductsByCategory> daoProductsByCategoryCollection = iProductsByCategoryRepository.SelectAll();
				Done(null);
				
				foreach(IDAOProductsByCategory daoProductsByCategory in daoProductsByCategoryCollection)
					boProductsByCategoryCollection.Add(new BOProductsByCategory(daoProductsByCategory));
				
				return boProductsByCategoryCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///ProductsByCategoryCollectionCount
		///This method returns the collection count of BOProductsByCategory objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 ProductsByCategoryCollectionCount(IProductsByCategoryRepository iProductsByCategoryRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iProductsByCategoryRepository.SelectAllCount();
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
		///ProductsByCategoryCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOProductsByCategory>
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
				return _iProductsByCategoryRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boProductsByCategoryCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOProductsByCategory> daoProductsByCategoryCollection = _iProductsByCategoryRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOProductsByCategory resdaoProductsByCategory in daoProductsByCategoryCollection)
					boProductsByCategoryCollection.Add((T)(object)new BOProductsByCategory(resdaoProductsByCategory));
				
				return boProductsByCategoryCollection;
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
		///This method returns the collection count of BOProductsByCategory objects, filtered by optional criteria
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
				List<IBOProductsByCategory> boProductsByCategoryCollection = new List<IBOProductsByCategory>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iProductsByCategoryRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		public virtual IProductsByCategoryRepository ProductsByCategoryRepository
		{
			set
			{
				_iProductsByCategoryRepository = value;
			}
		}
		
		public virtual string CategoryName
		{
			get
			{
				 return _categoryName;
			}
			set
			{
				_categoryName = value;
				_isDirty = true;
			}
		}
		
		public virtual string ProductName
		{
			get
			{
				 return _productName;
			}
			set
			{
				_productName = value;
				_isDirty = true;
			}
		}
		
		public virtual string QuantityPerUnit
		{
			get
			{
				 return _quantityPerUnit;
			}
			set
			{
				_quantityPerUnit = value;
				_isDirty = true;
			}
		}
		
		public virtual Int16? UnitsInStock
		{
			get
			{
				 return _unitsInStock;
			}
			set
			{
				_unitsInStock = value;
				_isDirty = true;
			}
		}
		
		public virtual bool? Discontinued
		{
			get
			{
				 return _discontinued;
			}
			set
			{
				_discontinued = value;
				_isDirty = true;
			}
		}
		
		[XmlIgnore]
		public virtual object Repository
		{
			get {	return (object) _iProductsByCategoryRepository;	}
			set {	ProductsByCategoryRepository = (IProductsByCategoryRepository)value;	}
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
