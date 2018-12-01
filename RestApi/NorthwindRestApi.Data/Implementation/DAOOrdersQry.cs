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
	public partial class DAOOrdersQry : zNorthwindRestApiConn_BaseData, IDAOOrdersQry
	{
		#region member variables
		protected Int32? _orderID;
		protected string _customerID;
		protected Int32? _employeeID;
		protected DateTime? _orderDate;
		protected DateTime? _requiredDate;
		protected DateTime? _shippedDate;
		protected Int32? _shipVia;
		protected decimal? _freight;
		protected string _shipName;
		protected string _shipAddress;
		protected string _shipCity;
		protected string _shipRegion;
		protected string _shipPostalCode;
		protected string _shipCountry;
		protected string _companyName;
		protected string _address;
		protected string _city;
		protected string _region;
		protected string _postalCode;
		protected string _country;
		#endregion

		#region class methods
		public DAOOrdersQry()
		{
		}
		///<Summary>
		///Select all rows
		///This method returns all data rows in the table Orders Qry
		///</Summary>
		///<returns>
		///IList-IDAOOrdersQry.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IDAOOrdersQry> SelectAll()
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprOrdersQry_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Orders Qry");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOOrdersQry> objList = new List<IDAOOrdersQry>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOOrdersQry retObj = new DAOOrdersQry();
						retObj._orderID					 = Convert.IsDBNull(row["OrderID"]) ? (Int32?)null : (Int32?)row["OrderID"];
						retObj._customerID					 = Convert.IsDBNull(row["CustomerID"]) ? null : (string)row["CustomerID"];
						retObj._employeeID					 = Convert.IsDBNull(row["EmployeeID"]) ? (Int32?)null : (Int32?)row["EmployeeID"];
						retObj._orderDate					 = Convert.IsDBNull(row["OrderDate"]) ? (DateTime?)null : (DateTime?)row["OrderDate"];
						retObj._requiredDate					 = Convert.IsDBNull(row["RequiredDate"]) ? (DateTime?)null : (DateTime?)row["RequiredDate"];
						retObj._shippedDate					 = Convert.IsDBNull(row["ShippedDate"]) ? (DateTime?)null : (DateTime?)row["ShippedDate"];
						retObj._shipVia					 = Convert.IsDBNull(row["ShipVia"]) ? (Int32?)null : (Int32?)row["ShipVia"];
						retObj._freight					 = Convert.IsDBNull(row["Freight"]) ? (decimal?)null : (decimal?)row["Freight"];
						retObj._shipName					 = Convert.IsDBNull(row["ShipName"]) ? null : (string)row["ShipName"];
						retObj._shipAddress					 = Convert.IsDBNull(row["ShipAddress"]) ? null : (string)row["ShipAddress"];
						retObj._shipCity					 = Convert.IsDBNull(row["ShipCity"]) ? null : (string)row["ShipCity"];
						retObj._shipRegion					 = Convert.IsDBNull(row["ShipRegion"]) ? null : (string)row["ShipRegion"];
						retObj._shipPostalCode					 = Convert.IsDBNull(row["ShipPostalCode"]) ? null : (string)row["ShipPostalCode"];
						retObj._shipCountry					 = Convert.IsDBNull(row["ShipCountry"]) ? null : (string)row["ShipCountry"];
						retObj._companyName					 = Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"];
						retObj._address					 = Convert.IsDBNull(row["Address"]) ? null : (string)row["Address"];
						retObj._city					 = Convert.IsDBNull(row["City"]) ? null : (string)row["City"];
						retObj._region					 = Convert.IsDBNull(row["Region"]) ? null : (string)row["Region"];
						retObj._postalCode					 = Convert.IsDBNull(row["PostalCode"]) ? null : (string)row["PostalCode"];
						retObj._country					 = Convert.IsDBNull(row["Country"]) ? null : (string)row["Country"];
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
			command.CommandText = InlineProcs.ctprOrdersQry_SelectAllCount;
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
		///This method returns specific fields of all data rows in the table using criteriaquery apiOrders Qry
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprOrdersQry_SelectAllByCriteriaProjection, listProjection, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Orders Qry");
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
						if (string.Compare(projection.Member, "OrderID", true) == 0) lst.Add(Convert.IsDBNull(row["OrderID"]) ? (Int32?)null : (Int32?)row["OrderID"]);
						if (string.Compare(projection.Member, "CustomerID", true) == 0) lst.Add(Convert.IsDBNull(row["CustomerID"]) ? null : (string)row["CustomerID"]);
						if (string.Compare(projection.Member, "EmployeeID", true) == 0) lst.Add(Convert.IsDBNull(row["EmployeeID"]) ? (Int32?)null : (Int32?)row["EmployeeID"]);
						if (string.Compare(projection.Member, "OrderDate", true) == 0) lst.Add(Convert.IsDBNull(row["OrderDate"]) ? (DateTime?)null : (DateTime?)row["OrderDate"]);
						if (string.Compare(projection.Member, "RequiredDate", true) == 0) lst.Add(Convert.IsDBNull(row["RequiredDate"]) ? (DateTime?)null : (DateTime?)row["RequiredDate"]);
						if (string.Compare(projection.Member, "ShippedDate", true) == 0) lst.Add(Convert.IsDBNull(row["ShippedDate"]) ? (DateTime?)null : (DateTime?)row["ShippedDate"]);
						if (string.Compare(projection.Member, "ShipVia", true) == 0) lst.Add(Convert.IsDBNull(row["ShipVia"]) ? (Int32?)null : (Int32?)row["ShipVia"]);
						if (string.Compare(projection.Member, "Freight", true) == 0) lst.Add(Convert.IsDBNull(row["Freight"]) ? (decimal?)null : (decimal?)row["Freight"]);
						if (string.Compare(projection.Member, "ShipName", true) == 0) lst.Add(Convert.IsDBNull(row["ShipName"]) ? null : (string)row["ShipName"]);
						if (string.Compare(projection.Member, "ShipAddress", true) == 0) lst.Add(Convert.IsDBNull(row["ShipAddress"]) ? null : (string)row["ShipAddress"]);
						if (string.Compare(projection.Member, "ShipCity", true) == 0) lst.Add(Convert.IsDBNull(row["ShipCity"]) ? null : (string)row["ShipCity"]);
						if (string.Compare(projection.Member, "ShipRegion", true) == 0) lst.Add(Convert.IsDBNull(row["ShipRegion"]) ? null : (string)row["ShipRegion"]);
						if (string.Compare(projection.Member, "ShipPostalCode", true) == 0) lst.Add(Convert.IsDBNull(row["ShipPostalCode"]) ? null : (string)row["ShipPostalCode"]);
						if (string.Compare(projection.Member, "ShipCountry", true) == 0) lst.Add(Convert.IsDBNull(row["ShipCountry"]) ? null : (string)row["ShipCountry"]);
						if (string.Compare(projection.Member, "CompanyName", true) == 0) lst.Add(Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"]);
						if (string.Compare(projection.Member, "Address", true) == 0) lst.Add(Convert.IsDBNull(row["Address"]) ? null : (string)row["Address"]);
						if (string.Compare(projection.Member, "City", true) == 0) lst.Add(Convert.IsDBNull(row["City"]) ? null : (string)row["City"]);
						if (string.Compare(projection.Member, "Region", true) == 0) lst.Add(Convert.IsDBNull(row["Region"]) ? null : (string)row["Region"]);
						if (string.Compare(projection.Member, "PostalCode", true) == 0) lst.Add(Convert.IsDBNull(row["PostalCode"]) ? null : (string)row["PostalCode"]);
						if (string.Compare(projection.Member, "Country", true) == 0) lst.Add(Convert.IsDBNull(row["Country"]) ? null : (string)row["Country"]);
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
		///This method returns all data rows in the table using criteriaquery api Orders Qry
		///</Summary>
		///<returns>
		///IList-IDAOOrdersQry.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IList<IDAOOrdersQry> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprOrdersQry_SelectAllByCriteria, null, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Orders Qry");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOOrdersQry> objList = new List<IDAOOrdersQry>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOOrdersQry retObj = new DAOOrdersQry();
						retObj._orderID					 = Convert.IsDBNull(row["OrderID"]) ? (Int32?)null : (Int32?)row["OrderID"];
						retObj._customerID					 = Convert.IsDBNull(row["CustomerID"]) ? null : (string)row["CustomerID"];
						retObj._employeeID					 = Convert.IsDBNull(row["EmployeeID"]) ? (Int32?)null : (Int32?)row["EmployeeID"];
						retObj._orderDate					 = Convert.IsDBNull(row["OrderDate"]) ? (DateTime?)null : (DateTime?)row["OrderDate"];
						retObj._requiredDate					 = Convert.IsDBNull(row["RequiredDate"]) ? (DateTime?)null : (DateTime?)row["RequiredDate"];
						retObj._shippedDate					 = Convert.IsDBNull(row["ShippedDate"]) ? (DateTime?)null : (DateTime?)row["ShippedDate"];
						retObj._shipVia					 = Convert.IsDBNull(row["ShipVia"]) ? (Int32?)null : (Int32?)row["ShipVia"];
						retObj._freight					 = Convert.IsDBNull(row["Freight"]) ? (decimal?)null : (decimal?)row["Freight"];
						retObj._shipName					 = Convert.IsDBNull(row["ShipName"]) ? null : (string)row["ShipName"];
						retObj._shipAddress					 = Convert.IsDBNull(row["ShipAddress"]) ? null : (string)row["ShipAddress"];
						retObj._shipCity					 = Convert.IsDBNull(row["ShipCity"]) ? null : (string)row["ShipCity"];
						retObj._shipRegion					 = Convert.IsDBNull(row["ShipRegion"]) ? null : (string)row["ShipRegion"];
						retObj._shipPostalCode					 = Convert.IsDBNull(row["ShipPostalCode"]) ? null : (string)row["ShipPostalCode"];
						retObj._shipCountry					 = Convert.IsDBNull(row["ShipCountry"]) ? null : (string)row["ShipCountry"];
						retObj._companyName					 = Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"];
						retObj._address					 = Convert.IsDBNull(row["Address"]) ? null : (string)row["Address"];
						retObj._city					 = Convert.IsDBNull(row["City"]) ? null : (string)row["City"];
						retObj._region					 = Convert.IsDBNull(row["Region"]) ? null : (string)row["Region"];
						retObj._postalCode					 = Convert.IsDBNull(row["PostalCode"]) ? null : (string)row["PostalCode"];
						retObj._country					 = Convert.IsDBNull(row["Country"]) ? null : (string)row["Country"];
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
		///This method returns all data rows in the table using criteriaquery api Orders Qry
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprOrdersQry_SelectAllByCriteriaCount, null, listCriterion, null);
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

		public Int32? OrderID
		{
			get
			{
				return _orderID;
			}
			set
			{
				_orderID = value;
			}
		}

		public string CustomerID
		{
			get
			{
				return _customerID;
			}
			set
			{
				_customerID = value;
			}
		}

		public Int32? EmployeeID
		{
			get
			{
				return _employeeID;
			}
			set
			{
				_employeeID = value;
			}
		}

		public DateTime? OrderDate
		{
			get
			{
				return _orderDate;
			}
			set
			{
				_orderDate = value;
			}
		}

		public DateTime? RequiredDate
		{
			get
			{
				return _requiredDate;
			}
			set
			{
				_requiredDate = value;
			}
		}

		public DateTime? ShippedDate
		{
			get
			{
				return _shippedDate;
			}
			set
			{
				_shippedDate = value;
			}
		}

		public Int32? ShipVia
		{
			get
			{
				return _shipVia;
			}
			set
			{
				_shipVia = value;
			}
		}

		public decimal? Freight
		{
			get
			{
				return _freight;
			}
			set
			{
				_freight = value;
			}
		}

		public string ShipName
		{
			get
			{
				return _shipName;
			}
			set
			{
				_shipName = value;
			}
		}

		public string ShipAddress
		{
			get
			{
				return _shipAddress;
			}
			set
			{
				_shipAddress = value;
			}
		}

		public string ShipCity
		{
			get
			{
				return _shipCity;
			}
			set
			{
				_shipCity = value;
			}
		}

		public string ShipRegion
		{
			get
			{
				return _shipRegion;
			}
			set
			{
				_shipRegion = value;
			}
		}

		public string ShipPostalCode
		{
			get
			{
				return _shipPostalCode;
			}
			set
			{
				_shipPostalCode = value;
			}
		}

		public string ShipCountry
		{
			get
			{
				return _shipCountry;
			}
			set
			{
				_shipCountry = value;
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

		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				_address = value;
			}
		}

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

		public string Region
		{
			get
			{
				return _region;
			}
			set
			{
				_region = value;
			}
		}

		public string PostalCode
		{
			get
			{
				return _postalCode;
			}
			set
			{
				_postalCode = value;
			}
		}

		public string Country
		{
			get
			{
				return _country;
			}
			set
			{
				_country = value;
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
		internal static string ctprOrdersQry_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[OrderID]
			,[CustomerID]
			,[EmployeeID]
			,[OrderDate]
			,[RequiredDate]
			,[ShippedDate]
			,[ShipVia]
			,[Freight]
			,[ShipName]
			,[ShipAddress]
			,[ShipCity]
			,[ShipRegion]
			,[ShipPostalCode]
			,[ShipCountry]
			,[CompanyName]
			,[Address]
			,[City]
			,[Region]
			,[PostalCode]
			,[Country]
			FROM [dbo].[Orders Qry]
			";

		internal static string ctprOrdersQry_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[Orders Qry]
			";

		internal static string ctprOrdersQry_SelectAllByCriteriaProjection = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			##STARTFIELDS##
			##ENDFIELDS##
			FROM [dbo].[Orders Qry]
			##CRITERIA##
			";

		internal static string ctprOrdersQry_SelectAllByCriteria = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			[OrderID]
			,[CustomerID]
			,[EmployeeID]
			,[OrderDate]
			,[RequiredDate]
			,[ShippedDate]
			,[ShipVia]
			,[Freight]
			,[ShipName]
			,[ShipAddress]
			,[ShipCity]
			,[ShipRegion]
			,[ShipPostalCode]
			,[ShipCountry]
			,[CompanyName]
			,[Address]
			,[City]
			,[Region]
			,[PostalCode]
			,[Country]
			FROM [dbo].[Orders Qry]
			##CRITERIA##
			";

		internal static string ctprOrdersQry_SelectAllByCriteriaCount = @"
			
			-- selects count of all rows from the table according to criteria
			SELECT COUNT(*)
			FROM [dbo].[Orders Qry]
			##CRITERIA##
			";

	}
}
#endregion