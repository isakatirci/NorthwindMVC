/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:31:22
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using NorthwindTest3.DataObjects.Interfaces;

namespace NorthwindTest3.DataObjects
{
	public partial class DAOCustomerDemographics : zNorthwindTest3Conn_BaseData
	{
		#region member variables
		protected string _customerTypeID;
		protected string _customerDesc;
		#endregion

		#region class methods
		public DAOCustomerDemographics()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table CustomerDemographics based on the primary key(s)
		///</Summary>
		///<returns>
		///DAOCustomerDemographics
		///</returns>
		///<parameters>
		///string customerTypeID
		///</parameters>
		public static DAOCustomerDemographics SelectOne(string customerTypeID)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCustomerDemographics_SelectOne;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("CustomerDemographics");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@CustomerTypeID", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)customerTypeID?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				DAOCustomerDemographics retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAOCustomerDemographics();
					retObj._customerTypeID					 = Convert.IsDBNull(dt.Rows[0]["CustomerTypeID"]) ? null : (string)dt.Rows[0]["CustomerTypeID"];
					retObj._customerDesc					 = Convert.IsDBNull(dt.Rows[0]["CustomerDesc"]) ? null : (string)dt.Rows[0]["CustomerDesc"];
				}
				return retObj;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Delete one row by primary key(s)
		///this method allows the object to delete itself from the table CustomerDemographics based on its primary key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Delete()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCustomerDemographics_DeleteOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@CustomerTypeID", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)_customerTypeID?? (object)DBNull.Value));

				command.ExecuteNonQuery();

			}
			catch
			{
				throw;
			}
			finally
			{
				command.Dispose();
			}
		}

		///<Summary>
		///Insert a new row
		///This method saves a new object to the table CustomerDemographics
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Insert()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCustomerDemographics_InsertOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@CustomerDesc", SqlDbType.NText, 8000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_customerDesc?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@CustomerTypeID", SqlDbType.NChar, 10, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_customerTypeID?? (object)DBNull.Value));

				command.ExecuteNonQuery();

				_customerTypeID					 = Convert.IsDBNull(command.Parameters["@CustomerTypeID"].Value) ? null : (string)command.Parameters["@CustomerTypeID"].Value;

			}
			catch
			{
				throw;
			}
			finally
			{
				command.Dispose();
			}
		}

		///<Summary>
		///Select all rows
		///This method returns all data rows in the table CustomerDemographics
		///</Summary>
		///<returns>
		///IList-DAOCustomerDemographics.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<DAOCustomerDemographics> SelectAll()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCustomerDemographics_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("CustomerDemographics");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				List<DAOCustomerDemographics> objList = new List<DAOCustomerDemographics>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOCustomerDemographics retObj = new DAOCustomerDemographics();
						retObj._customerTypeID					 = Convert.IsDBNull(row["CustomerTypeID"]) ? null : (string)row["CustomerTypeID"];
						retObj._customerDesc					 = Convert.IsDBNull(row["CustomerDesc"]) ? null : (string)row["CustomerDesc"];
						objList.Add(retObj);
					}
				}
				return objList;
			}
			catch
			{
				throw;
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
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCustomerDemographics_SelectAllCount;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{

				staticConnection.Open();
				Int32 retCount = (Int32)command.ExecuteScalar();

				return retCount;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Select specific fields of all rows using criteriaquery api
		///This method returns specific fields of all data rows in the table using criteriaquery apiCustomerDemographics
		///</Summary>
		///<returns>
		///IDictionary-string, IList-object..
		///</returns>
		///<parameters>
		///IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprCustomerDemographics_SelectAllByCriteriaProjection, listProjection, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("CustomerDemographics");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				IDictionary<string, IList<object>> dict = new Dictionary<string, IList<object>>();
				foreach (IDataProjection projection in listProjection)
				{
					IList<object> lst = new List<object>();
					dict.Add(projection.Member, lst);
					foreach (DataRow row in dt.Rows)
					{
						if (string.Compare(projection.Member, "CustomerTypeID", true) == 0) lst.Add(Convert.IsDBNull(row["CustomerTypeID"]) ? null : (string)row["CustomerTypeID"]);
						if (string.Compare(projection.Member, "CustomerDesc", true) == 0) lst.Add(Convert.IsDBNull(row["CustomerDesc"]) ? null : (string)row["CustomerDesc"]);
					}
				}
				return dict;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Select all rows by filter criteria
		///This method returns all data rows in the table using criteriaquery api CustomerDemographics
		///</Summary>
		///<returns>
		///IList-DAOCustomerDemographics.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IList<DAOCustomerDemographics> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprCustomerDemographics_SelectAllByCriteria, null, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("CustomerDemographics");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				List<DAOCustomerDemographics> objList = new List<DAOCustomerDemographics>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOCustomerDemographics retObj = new DAOCustomerDemographics();
						retObj._customerTypeID					 = Convert.IsDBNull(row["CustomerTypeID"]) ? null : (string)row["CustomerTypeID"];
						retObj._customerDesc					 = Convert.IsDBNull(row["CustomerDesc"]) ? null : (string)row["CustomerDesc"];
						objList.Add(retObj);
					}
				}
				return objList;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Select count of all rows using criteriaquery api
		///This method returns all data rows in the table using criteriaquery api CustomerDemographics
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion
		///</parameters>
		public static Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprCustomerDemographics_SelectAllByCriteriaCount, null, listCriterion, null);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{

				staticConnection.Open();
				Int32 retCount = (Int32)command.ExecuteScalar();

				return retCount;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Update one row by primary key(s)
		///This method allows the object to update itself in the table CustomerDemographics based on its primary key(s)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Update()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCustomerDemographics_UpdateOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@CustomerDesc", SqlDbType.NText, 8000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_customerDesc?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@CustomerTypeID", SqlDbType.NChar, 10, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_customerTypeID?? (object)DBNull.Value));

				command.ExecuteNonQuery();

				_customerTypeID					 = Convert.IsDBNull(command.Parameters["@CustomerTypeID"].Value) ? null : (string)command.Parameters["@CustomerTypeID"].Value;

			}
			catch
			{
				throw;
			}
			finally
			{
				command.Dispose();
			}
		}

		#endregion

		#region member properties

		public string CustomerTypeID
		{
			get
			{
				return _customerTypeID;
			}
			set
			{
				_customerTypeID = value;
			}
		}

		public string CustomerDesc
		{
			get
			{
				return _customerDesc;
			}
			set
			{
				_customerDesc = value;
			}
		}

		#endregion
	}
}

#region inline sql procs
namespace NorthwindTest3.DataObjects
{
	public partial class InlineProcs
	{
		internal static string ctprCustomerDemographics_SelectOne = @"
			-- Select one row based on the primary key(s)
			-- selects all rows from the table
			SELECT 
			[CustomerTypeID]
			,[CustomerDesc]
			FROM [dbo].[CustomerDemographics]
			WHERE 
			[CustomerTypeID] = @CustomerTypeID
			";

		internal static string ctprCustomerDemographics_DeleteOne = @"
			-- Delete a row based on the primary key(s)
			-- delete all matching from the table
			DELETE [dbo].[CustomerDemographics]
			WHERE 
			[CustomerTypeID] = @CustomerTypeID
			";

		internal static string ctprCustomerDemographics_InsertOne = @"
			-- Insert a new row
			-- inserts a new row into the table
			INSERT [dbo].[CustomerDemographics]
			(
			[CustomerTypeID]
			,[CustomerDesc]
			)
			VALUES
			(
			@CustomerTypeID
			,@CustomerDesc
			)
			SELECT 
			@CustomerTypeID = [CustomerTypeID]
			FROM [dbo].[CustomerDemographics]
			WHERE 
			[CustomerTypeID] = @CustomerTypeID
			";

		internal static string ctprCustomerDemographics_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[CustomerTypeID]
			,[CustomerDesc]
			FROM [dbo].[CustomerDemographics]
			";

		internal static string ctprCustomerDemographics_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[CustomerDemographics]
			";

		internal static string ctprCustomerDemographics_SelectAllByCriteriaProjection = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			##STARTFIELDS##
			##ENDFIELDS##
			FROM [dbo].[CustomerDemographics]
			##CRITERIA##
			";

		internal static string ctprCustomerDemographics_SelectAllByCriteria = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			[CustomerTypeID]
			,[CustomerDesc]
			FROM [dbo].[CustomerDemographics]
			##CRITERIA##
			";

		internal static string ctprCustomerDemographics_SelectAllByCriteriaCount = @"
			
			-- selects count of all rows from the table according to criteria
			SELECT COUNT(*)
			FROM [dbo].[CustomerDemographics]
			##CRITERIA##
			";

		internal static string ctprCustomerDemographics_UpdateOne = @"
			-- Update one row based on the primary key(s)
			-- updates a row in the table based on the primary key
			
			UPDATE [dbo].[CustomerDemographics]
			SET
			[CustomerDesc] = @CustomerDesc
			WHERE 
			[CustomerTypeID] = @CustomerTypeID
			SELECT 
			@CustomerTypeID = [CustomerTypeID]
			FROM [dbo].[CustomerDemographics]
			WHERE 
			[CustomerTypeID] = @CustomerTypeID
			";

	}
}
#endregion
