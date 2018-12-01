/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:31:22
**************************************************************/

using System;
using System.Linq;
using System.Collections.Generic;
using NorthwindTest3.DataObjects;
using NorthwindTest3.DataObjects.Interfaces;
using NorthwindTest3.BusinessObjects.Interfaces;

namespace NorthwindTest3.BusinessObjects
{
	#region implementation

	public partial class Projection : IProjection
	{
		public Projection(string member) { Member = member; }
		public IDataProjection DataProjection() { return new DataProjection() { Member = this.Member }; }
		public string Member { get; set; }
	}

	public partial class Criteria<T> : ICriteria where T : IQueryableCollection, new()
	{
		List<IProjection> _listProjection = new List<IProjection>();
		List<ICriterion> _listCriterion = new List<ICriterion>();
		List<IOrderBy> _listOrderBy = new List<IOrderBy>();
		ITake _take = null;
		ISkip _skip = null;
		object _repository = null;

		public Criteria() { }

		public Criteria(object repository)
		{
			_repository = repository;
		}

		public Criteria(ICriterion criterion)
		{
			_listCriterion.Add(criterion);
		}

		public ICriteria Add(ICriterion criterion)
		{
			_listCriterion.Add(criterion);
			return this;
		}

		public ICriteria Add(IOrderBy orderBy)
		{
			_listOrderBy.Add(orderBy);
			return this;
		}

		public ICriteria Add(IProjection projection)
		{
			_listProjection.Add(projection);
			return this;
		}

		public ICriteria Skip(int val)
		{
			_skip = new Skip(val);
			return this;
		}

		public ICriteria Take(int val)
		{
			_take = new Take(val);
			return this;
		}

		public ICriterion Criterion(int pos)
		{
			return _listCriterion[pos];
		}

		public IList<IDataProjection> ListDataProjection()
		{
			List<IDataProjection> lst = new List<IDataProjection>();
			foreach (IProjection val in _listProjection)
				lst.Add(val.DataProjection());
			return lst.AsReadOnly();
		}

		public IList<IDataCriterion> ListDataCriteria()
		{
			List<IDataCriterion> lst = new List<IDataCriterion>();
			foreach (ICriterion val in _listCriterion)
				lst.Add(val.DataCriterion());
			return lst.AsReadOnly();
		}

		public IList<IDataOrderBy> ListDataOrder()
		{
			List<IDataOrderBy> lst = new List<IDataOrderBy>();
			foreach (IOrderBy val in _listOrderBy)
				lst.Add(val.DataOrderBy());
			return lst.AsReadOnly();
		}

		public IDataSkip DataSkip()
		{
			if (_skip != null)
				return _skip.DataSkip();
			return null;
		}

		public IDataTake DataTake()
		{
			if (_take != null)
				return _take.DataTake();
			return null;
		}

		public void EvaluateSubQueries()
		{
			for (int k = 0; k < _listCriterion.Count; k++)
			{
				if (_listCriterion[k] is InSubQueryCriterion)
				{
					InSubQueryCriterion sub = (InSubQueryCriterion)_listCriterion[k];
					ICriteria subQuery = (ICriteria)sub.PropertyValue;
					Func<object, string> formatter = (Func<object, string>)sub.Formatter;
					IList<IList<object>> listObjs = subQuery.List<IList<object>>();
					string[] strValsArr = listObjs[0].Select((Func<object, string>)formatter ?? (Func<object, string>)((i) => i.ToString())).ToArray();
					string strVals = strValsArr.Length > 0 ? String.Join(", ", strValsArr) : "NULL";
					_listCriterion.RemoveAt(k);
					_listCriterion.Add(new InCriterion() { PropertyName = sub.PropertyName, PropertyValue = strVals});
				}
			}
		}

		public IList<U> List<U>()
		{
			if ((_listProjection.Count == 0) &&
				!(typeof(T) == typeof(U)) &&
				!typeof(T).IsSubclassOf(typeof(U)) &&
				(typeof(T).GetInterface(typeof(U).Name) == null))
				throw new Exception("Collection type requested is not the same type as criteria root");

			if ((_listProjection.Count > 0) && (typeof(U) != typeof(IList<object>)))
				throw new Exception("IList<object> is the only currently supported projection collection type.");

			T t = new T();
			t.Repository = _repository;

			/*evaluate any sub querys*************************************************/
			EvaluateSubQueries();
			/*************************************************************************/
			
			IList<U> outList = null;
			/*evaluate projections****************************************************/
			if (_listProjection.Count > 0)
			{
				IDictionary<string, IList<object>> dict = t.Projections(this);
				outList = new List<U>();
				foreach (var item in dict.Values)
				outList.Add((U)item);
				return outList;
			}
			/*************************************************************************/
			outList = t.Collection<U>(this);
			return outList;
		}

		public Int32 Count()
		{
			T t = new T();
			t.Repository = _repository;
			/*evaluate any sub querys*************************************************/
			EvaluateSubQueries();
			/************************************************************************/
			return t.CollectionCount(this);
		}

		public U Single<U>()
		{
			return List<U>().Single();
		}

		public U SingleOrDefault<U>()
		{
			return List<U>().SingleOrDefault();
		}

		public U First<U>()
		{
			return List<U>().First();
		}

		public U FirstOrDefault<U>()
		{
			return List<U>().FirstOrDefault();
		}

		public object Repository
		{
			set { _repository = value; }
		}

	}

	public class OrderBy : IOrderBy
	{
		protected string _propertyName;
		protected OrderDirection _direction;
		public enum OrderDirection { Ascending = 1, Descending }
		public OrderBy(string propertyName, OrderDirection orderDirection)
		{
			_propertyName = propertyName;
			_direction = orderDirection;
		}
		public virtual string PropertyName
		{
			get { return _propertyName; }
			set { _propertyName = value; }
		}
		public virtual OrderDirection Direction
		{
			get { return _direction; }
			set { _direction = value; }
		}
		public static OrderBy Asc(string propertyName) { return new OrderBy(propertyName, OrderDirection.Ascending); }
		public static OrderBy Desc(string propertyName) { return new OrderBy(propertyName, OrderDirection.Descending); }
		public object Clone() { return new OrderBy(this.PropertyName, this.Direction); }
		public IDataOrderBy DataOrderBy() { return new DataOrderBy(this.PropertyName, this.Direction == OrderDirection.Ascending ? "ASC" : "DESC");} 
	}

	public class Skip : ISkip
	{
		protected int _val;
		public Skip(int val) { _val = val; }
		public virtual int Value
		{
			get { return _val; }
			set { _val = value; }
		}
		public object Clone() { return new Skip(this.Value); }
		public IDataSkip DataSkip() { return new DataSkip(_val); }
	}

	public class Take : ITake
	{
		protected int _val;
		public Take(int val) { _val = val; }
		public virtual int Value
		{
			get { return _val; }
			set { _val = value; }
		}
		public object Clone() { return new Take(this.Value); }
		public IDataTake DataTake() { return new DataTake(_val); }
	}

	public abstract class Criterion : ICriterion
	{
		public virtual string PropertyName { get; set; }
		public virtual object PropertyValue { get; set; }
		public virtual Func<object, string> Formatter { get; set; }
		public abstract IDataCriterion DataCriterion();
		public abstract object Clone();
	}

	public abstract class DuplexCriterion : ICriterion
	{
		public virtual string PropertyName { get; set; }
		public virtual object PropertyValue1 { get; set; }
		public virtual object PropertyValue2 { get; set; }
		public virtual Func<object, string> Formatter { get; set; }
		public abstract IDataCriterion DataCriterion();
		public abstract object Clone();
	}

	public abstract class MultiCriterion : ICriterion
	{
		public virtual List<ICriterion> Restrictions { get; set; }
		public abstract IDataCriterion DataCriterion();
		public abstract object Clone();
	}

	public class EqCriterion : Criterion
	{
		public override object Clone()
		{
			return new EqCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionEq() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class NotEqCriterion : Criterion
	{
		public override object Clone()
		{
			return new NotEqCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionNotEq() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class LtCriterion : Criterion
	{
		public override object Clone()
		{
			return new LtCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionLt() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class LteCriterion : Criterion
	{
		public override object Clone()
		{
			return new LteCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionLte() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class GtCriterion : Criterion
	{
		public override object Clone()
		{
			return new GtCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionGt() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class GteCriterion : Criterion
	{
		public override object Clone()
		{
			return new GteCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionGte() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class InCriterion : Criterion
	{
		public override object Clone()
		{
			return new InCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionIn() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public partial class InSqlSubQueryCriterion : Criterion
	{
		
		public override object Clone()
		{
			return new InSqlSubQueryCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
		
		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionInSqlSubQuery() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public partial class InSubQueryCriterion : Criterion
	{
		
		public override object Clone()
		{
			return new InSubQueryCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
		
		public override IDataCriterion DataCriterion()
		{
			return null;
		}
	}

	public class NullCriterion : Criterion
	{
		public override object Clone()
		{
			return new NullCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionNull() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class NotNullCriterion : Criterion
	{
		public override object Clone()
		{
			return new NotNullCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionNotNull() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class LikeCriterion : Criterion
	{
		public override object Clone()
		{
			return new LikeCriterion() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionLike() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class OrCriterion : MultiCriterion
	{
		public override object Clone()
		{
			return new OrCriterion() { Restrictions = this.Restrictions };
		}

		public override IDataCriterion DataCriterion()
		{
			List<IDataCriterion> lst = new List<IDataCriterion>();
			foreach (Criterion criterion in this.Restrictions)
				lst.Add(criterion.DataCriterion());

			return (IDataCriterion)new DataCriterionOr() { List = lst };
		}
	}

	public class BetweenCriterion : DuplexCriterion
	{
		public override object Clone()
		{
			return new BetweenCriterion() { PropertyName = this.PropertyName, PropertyValue1 = this.PropertyValue1, PropertyValue2 = this.PropertyValue2, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionBetween() { PropertyName = this.PropertyName, PropertyValue1 = this.PropertyValue1, PropertyValue2 = this.PropertyValue2, Formatter = this.Formatter };
		}
	}

	#endregion

}
