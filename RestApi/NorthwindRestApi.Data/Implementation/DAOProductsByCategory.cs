/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:12
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using NorthwindRestApi.Data.Interfaces;

namespace NorthwindRestApi.Data
{
	public partial class DAOProductsByCategory : zNorthwindRestApiConn_BaseData, IDAOProductsByCategory
	{
		#region member variables
		protected string _categoryName;
		protected string _productName;
		protected string _quantityPerUnit;
		protected Int16? _unitsInStock;
		protected bool? _discontinued;
		#endregion

		#region class methods
		public DAOProductsByCategory()
		{
		}
		///<Summary>
		///Select all rows
		///This method returns all data rows in the table Products by Category
		///</Summary>
		///<returns>
		///IList-IDAOProductsByCategory.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IDAOProductsByCategory> SelectAll()
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprProductsbyCategory_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Products by Category");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOProductsByCategory> objList = new List<IDAOProductsByCategory>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOProductsByCategory retObj = new DAOProductsByCategory();
						retObj._categoryName					 = Convert.IsDBNull(row["CategoryName"]) ? null : (string)row["CategoryName"];
						retObj._productName					 = Convert.IsDBNull(row["ProductName"]) ? null : (string)row["ProductName"];
						retObj._quantityPerUnit					 = Convert.IsDBNull(row["QuantityPerUnit"]) ? null : (string)row["QuantityPerUnit"];
						retObj._unitsInStock					 = Convert.IsDBNull(row["UnitsInStock"]) ? (Int16?)null : (Int16?)row["UnitsInStock"];
						retObj._discontinued					 = Convert.IsDBNull(row["Discontinued"]) ? (bool?)null : (bool?)row["Discontinued"];
						objList.Add(retObj);
					}
				}
				return objList;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 SelectAllCount()
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprProductsbyCategory_SelectAllCount;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{

				staticConnection.Open();
				Int32 retCount = (Int32)command.ExecuteScalar();
				Done(null);

				return retCount;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return -1;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Select specific fields of all rows using criteriaquery api
		///This method returns specific fields of all data rows in the table using criteriaquery apiProducts by Category
		///</Summary>
		///<returns>
		///IDictionary-string, IList-object..
		///</returns>
		///<parameters>
		///IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprProductsbyCategory_SelectAllByCriteriaProjection, listProjection, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Products by Category");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				IDictionary<string, IList<object>> dict = new Dictionary<string, IList<object>>();
				foreach (IDataProjection projection in listProjection)
				{
					IList<object> lst = new List<object>();
					dict.Add(projection.Member, lst);
					foreach (DataRow row in dt.Rows)
					{
						if (string.Compare(projection.Member, "CategoryName", true) == 0) lst.Add(Convert.IsDBNull(row["CategoryName"]) ? null : (string)row["CategoryName"]);
						if (string.Compare(projection.Member, "ProductName", true) == 0) lst.Add(Convert.IsDBNull(row["ProductName"]) ? null : (string)row["ProductName"]);
						if (string.Compare(projection.Member, "QuantityPerUnit", true) == 0) lst.Add(Convert.IsDBNull(row["QuantityPerUnit"]) ? null : (string)row["QuantityPerUnit"]);
						if (string.Compare(projection.Member, "UnitsInStock", true) == 0) lst.Add(Convert.IsDBNull(row["UnitsInStock"]) ? (Int16?)null : (Int16?)row["UnitsInStock"]);
						if (string.Compare(projection.Member, "Discontinued", true) == 0) lst.Add(Convert.IsDBNull(row["Discontinued"]) ? (bool?)null : (bool?)row["Discontinued"]);
					}
				}
				return dict;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Select all rows by filter criteria
		///This method returns all data rows in the table using criteriaquery api Products by Category
		///</Summary>
		///<returns>
		///IList-IDAOProductsByCategory.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IList<IDAOProductsByCategory> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprProductsbyCategory_SelectAllByCriteria, null, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Products by Category");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOProductsByCategory> objList = new List<IDAOProductsByCategory>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOProductsByCategory retObj = new DAOProductsByCategory();
						retObj._categoryName					 = Convert.IsDBNull(row["CategoryName"]) ? null : (string)row["CategoryName"];
						retObj._productName					 = Convert.IsDBNull(row["ProductName"]) ? null : (string)row["ProductName"];
						retObj._quantityPerUnit					 = Convert.IsDBNull(row["QuantityPerUnit"]) ? null : (string)row["QuantityPerUnit"];
						retObj._unitsInStock					 = Convert.IsDBNull(row["UnitsInStock"]) ? (Int16?)null : (Int16?)row["UnitsInStock"];
						retObj._discontinued					 = Convert.IsDBNull(row["Discontinued"]) ? (bool?)null : (bool?)row["Discontinued"];
						objList.Add(retObj);
					}
				}
				return objList;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Select count of all rows using criteriaquery api
		///This method returns all data rows in the table using criteriaquery api Products by Category
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion
		///</parameters>
		public static Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprProductsbyCategory_SelectAllByCriteriaCount, null, listCriterion, null);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{

				staticConnection.Open();
				Int32 retCount = (Int32)command.ExecuteScalar();
				Done(null);

				return retCount;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return -1;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		#endregion

		#region member properties

		public string CategoryName
		{
			get
			{
				return _categoryName;
			}
			set
			{
				_categoryName = value;
			}
		}

		public string ProductName
		{
			get
			{
				return _productName;
			}
			set
			{
				_productName = value;
			}
		}

		public string QuantityPerUnit
		{
			get
			{
				return _quantityPerUnit;
			}
			set
			{
				_quantityPerUnit = value;
			}
		}

		public Int16? UnitsInStock
		{
			get
			{
				return _unitsInStock;
			}
			set
			{
				_unitsInStock = value;
			}
		}

		public bool? Discontinued
		{
			get
			{
				return _discontinued;
			}
			set
			{
				_discontinued = value;
			}
		}

		#endregion
	}
}

#region inline sql procs
namespace NorthwindRestApi.Data
{
	public partial class InlineProcs
	{
		internal static string ctprProductsbyCategory_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[CategoryName]
			,[ProductName]
			,[QuantityPerUnit]
			,[UnitsInStock]
			,[Discontinued]
			FROM [dbo].[Products by Category]
			";

		internal static string ctprProductsbyCategory_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[Products by Category]
			";

		internal static string ctprProductsbyCategory_SelectAllByCriteriaProjection = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			##STARTFIELDS##
			##ENDFIELDS##
			FROM [dbo].[Products by Category]
			##CRITERIA##
			";

		internal static string ctprProductsbyCategory_SelectAllByCriteria = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			[CategoryName]
			,[ProductName]
			,[QuantityPerUnit]
			,[UnitsInStock]
			,[Discontinued]
			FROM [dbo].[Products by Category]
			##CRITERIA##
			";

		internal static string ctprProductsbyCategory_SelectAllByCriteriaCount = @"
			
			-- selects count of all rows from the table according to criteria
			SELECT COUNT(*)
			FROM [dbo].[Products by Category]
			##CRITERIA##
			";

	}
}
#endregion
