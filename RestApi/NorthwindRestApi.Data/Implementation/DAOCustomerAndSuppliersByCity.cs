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
	public partial class DAOCustomerAndSuppliersByCity : zNorthwindRestApiConn_BaseData, IDAOCustomerAndSuppliersByCity
	{
		#region member variables
		protected string _city;
		protected string _companyName;
		protected string _contactName;
		protected string _relationship;
		#endregion

		#region class methods
		public DAOCustomerAndSuppliersByCity()
		{
		}
		///<Summary>
		///Select all rows
		///This method returns all data rows in the table Customer and Suppliers by City
		///</Summary>
		///<returns>
		///IList-IDAOCustomerAndSuppliersByCity.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IDAOCustomerAndSuppliersByCity> SelectAll()
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCustomerandSuppliersbyCity_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Customer and Suppliers by City");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOCustomerAndSuppliersByCity> objList = new List<IDAOCustomerAndSuppliersByCity>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOCustomerAndSuppliersByCity retObj = new DAOCustomerAndSuppliersByCity();
						retObj._city					 = Convert.IsDBNull(row["City"]) ? null : (string)row["City"];
						retObj._companyName					 = Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"];
						retObj._contactName					 = Convert.IsDBNull(row["ContactName"]) ? null : (string)row["ContactName"];
						retObj._relationship					 = Convert.IsDBNull(row["Relationship"]) ? null : (string)row["Relationship"];
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
			command.CommandText = InlineProcs.ctprCustomerandSuppliersbyCity_SelectAllCount;
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
		///This method returns specific fields of all data rows in the table using criteriaquery apiCustomer and Suppliers by City
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprCustomerandSuppliersbyCity_SelectAllByCriteriaProjection, listProjection, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Customer and Suppliers by City");
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
						if (string.Compare(projection.Member, "City", true) == 0) lst.Add(Convert.IsDBNull(row["City"]) ? null : (string)row["City"]);
						if (string.Compare(projection.Member, "CompanyName", true) == 0) lst.Add(Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"]);
						if (string.Compare(projection.Member, "ContactName", true) == 0) lst.Add(Convert.IsDBNull(row["ContactName"]) ? null : (string)row["ContactName"]);
						if (string.Compare(projection.Member, "Relationship", true) == 0) lst.Add(Convert.IsDBNull(row["Relationship"]) ? null : (string)row["Relationship"]);
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
		///This method returns all data rows in the table using criteriaquery api Customer and Suppliers by City
		///</Summary>
		///<returns>
		///IList-IDAOCustomerAndSuppliersByCity.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IList<IDAOCustomerAndSuppliersByCity> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprCustomerandSuppliersbyCity_SelectAllByCriteria, null, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Customer and Suppliers by City");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOCustomerAndSuppliersByCity> objList = new List<IDAOCustomerAndSuppliersByCity>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOCustomerAndSuppliersByCity retObj = new DAOCustomerAndSuppliersByCity();
						retObj._city					 = Convert.IsDBNull(row["City"]) ? null : (string)row["City"];
						retObj._companyName					 = Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"];
						retObj._contactName					 = Convert.IsDBNull(row["ContactName"]) ? null : (string)row["ContactName"];
						retObj._relationship					 = Convert.IsDBNull(row["Relationship"]) ? null : (string)row["Relationship"];
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
		///This method returns all data rows in the table using criteriaquery api Customer and Suppliers by City
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprCustomerandSuppliersbyCity_SelectAllByCriteriaCount, null, listCriterion, null);
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

		public string City
		{
			get
			{
				return _city;
			}
			set
			{
				_city = value;
			}
		}

		public string CompanyName
		{
			get
			{
				return _companyName;
			}
			set
			{
				_companyName = value;
			}
		}

		public string ContactName
		{
			get
			{
				return _contactName;
			}
			set
			{
				_contactName = value;
			}
		}

		public string Relationship
		{
			get
			{
				return _relationship;
			}
			set
			{
				_relationship = value;
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
		internal static string ctprCustomerandSuppliersbyCity_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[City]
			,[CompanyName]
			,[ContactName]
			,[Relationship]
			FROM [dbo].[Customer and Suppliers by City]
			";

		internal static string ctprCustomerandSuppliersbyCity_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[Customer and Suppliers by City]
			";

		internal static string ctprCustomerandSuppliersbyCity_SelectAllByCriteriaProjection = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			##STARTFIELDS##
			##ENDFIELDS##
			FROM [dbo].[Customer and Suppliers by City]
			##CRITERIA##
			";

		internal static string ctprCustomerandSuppliersbyCity_SelectAllByCriteria = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			[City]
			,[CompanyName]
			,[ContactName]
			,[Relationship]
			FROM [dbo].[Customer and Suppliers by City]
			##CRITERIA##
			";

		internal static string ctprCustomerandSuppliersbyCity_SelectAllByCriteriaCount = @"
			
			-- selects count of all rows from the table according to criteria
			SELECT COUNT(*)
			FROM [dbo].[Customer and Suppliers by City]
			##CRITERIA##
			";

	}
}
#endregion
