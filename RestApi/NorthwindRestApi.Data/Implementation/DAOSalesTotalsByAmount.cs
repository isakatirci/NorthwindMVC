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
	public partial class DAOSalesTotalsByAmount : zNorthwindRestApiConn_BaseData, IDAOSalesTotalsByAmount
	{
		#region member variables
		protected decimal? _saleAmount;
		protected Int32? _orderID;
		protected string _companyName;
		protected DateTime? _shippedDate;
		#endregion

		#region class methods
		public DAOSalesTotalsByAmount()
		{
		}
		///<Summary>
		///Select all rows
		///This method returns all data rows in the table Sales Totals by Amount
		///</Summary>
		///<returns>
		///IList-IDAOSalesTotalsByAmount.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IDAOSalesTotalsByAmount> SelectAll()
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprSalesTotalsbyAmount_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Sales Totals by Amount");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOSalesTotalsByAmount> objList = new List<IDAOSalesTotalsByAmount>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOSalesTotalsByAmount retObj = new DAOSalesTotalsByAmount();
						retObj._saleAmount					 = Convert.IsDBNull(row["SaleAmount"]) ? (decimal?)null : (decimal?)row["SaleAmount"];
						retObj._orderID					 = Convert.IsDBNull(row["OrderID"]) ? (Int32?)null : (Int32?)row["OrderID"];
						retObj._companyName					 = Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"];
						retObj._shippedDate					 = Convert.IsDBNull(row["ShippedDate"]) ? (DateTime?)null : (DateTime?)row["ShippedDate"];
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
			command.CommandText = InlineProcs.ctprSalesTotalsbyAmount_SelectAllCount;
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
		///This method returns specific fields of all data rows in the table using criteriaquery apiSales Totals by Amount
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprSalesTotalsbyAmount_SelectAllByCriteriaProjection, listProjection, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Sales Totals by Amount");
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
						if (string.Compare(projection.Member, "SaleAmount", true) == 0) lst.Add(Convert.IsDBNull(row["SaleAmount"]) ? (decimal?)null : (decimal?)row["SaleAmount"]);
						if (string.Compare(projection.Member, "OrderID", true) == 0) lst.Add(Convert.IsDBNull(row["OrderID"]) ? (Int32?)null : (Int32?)row["OrderID"]);
						if (string.Compare(projection.Member, "CompanyName", true) == 0) lst.Add(Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"]);
						if (string.Compare(projection.Member, "ShippedDate", true) == 0) lst.Add(Convert.IsDBNull(row["ShippedDate"]) ? (DateTime?)null : (DateTime?)row["ShippedDate"]);
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
		///This method returns all data rows in the table using criteriaquery api Sales Totals by Amount
		///</Summary>
		///<returns>
		///IList-IDAOSalesTotalsByAmount.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IList<IDAOSalesTotalsByAmount> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprSalesTotalsbyAmount_SelectAllByCriteria, null, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Sales Totals by Amount");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOSalesTotalsByAmount> objList = new List<IDAOSalesTotalsByAmount>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOSalesTotalsByAmount retObj = new DAOSalesTotalsByAmount();
						retObj._saleAmount					 = Convert.IsDBNull(row["SaleAmount"]) ? (decimal?)null : (decimal?)row["SaleAmount"];
						retObj._orderID					 = Convert.IsDBNull(row["OrderID"]) ? (Int32?)null : (Int32?)row["OrderID"];
						retObj._companyName					 = Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"];
						retObj._shippedDate					 = Convert.IsDBNull(row["ShippedDate"]) ? (DateTime?)null : (DateTime?)row["ShippedDate"];
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
		///This method returns all data rows in the table using criteriaquery api Sales Totals by Amount
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprSalesTotalsbyAmount_SelectAllByCriteriaCount, null, listCriterion, null);
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

		public decimal? SaleAmount
		{
			get
			{
				return _saleAmount;
			}
			set
			{
				_saleAmount = value;
			}
		}

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

		#endregion
	}
}

#region inline sql procs
namespace NorthwindRestApi.Data
{
	public partial class InlineProcs
	{
		internal static string ctprSalesTotalsbyAmount_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[SaleAmount]
			,[OrderID]
			,[CompanyName]
			,[ShippedDate]
			FROM [dbo].[Sales Totals by Amount]
			";

		internal static string ctprSalesTotalsbyAmount_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[Sales Totals by Amount]
			";

		internal static string ctprSalesTotalsbyAmount_SelectAllByCriteriaProjection = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			##STARTFIELDS##
			##ENDFIELDS##
			FROM [dbo].[Sales Totals by Amount]
			##CRITERIA##
			";

		internal static string ctprSalesTotalsbyAmount_SelectAllByCriteria = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			[SaleAmount]
			,[OrderID]
			,[CompanyName]
			,[ShippedDate]
			FROM [dbo].[Sales Totals by Amount]
			##CRITERIA##
			";

		internal static string ctprSalesTotalsbyAmount_SelectAllByCriteriaCount = @"
			
			-- selects count of all rows from the table according to criteria
			SELECT COUNT(*)
			FROM [dbo].[Sales Totals by Amount]
			##CRITERIA##
			";

	}
}
#endregion
