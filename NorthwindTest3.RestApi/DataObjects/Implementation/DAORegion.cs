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
	public partial class DAORegion : zNorthwindTest3Conn_BaseData
	{
		#region member variables
		protected Int32? _regionID;
		protected string _regionDescription;
		#endregion

		#region class methods
		public DAORegion()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table Region based on the primary key(s)
		///</Summary>
		///<returns>
		///DAORegion
		///</returns>
		///<parameters>
		///Int32? regionID
		///</parameters>
		public static DAORegion SelectOne(Int32? regionID)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprRegion_SelectOne;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Region");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@RegionID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)regionID?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				DAORegion retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAORegion();
					retObj._regionID					 = Convert.IsDBNull(dt.Rows[0]["RegionID"]) ? (Int32?)null : (Int32?)dt.Rows[0]["RegionID"];
					retObj._regionDescription					 = Convert.IsDBNull(dt.Rows[0]["RegionDescription"]) ? null : (string)dt.Rows[0]["RegionDescription"];
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
		///this method allows the object to delete itself from the table Region based on its primary key
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
			command.CommandText = InlineProcs.ctprRegion_DeleteOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@RegionID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)_regionID?? (object)DBNull.Value));

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
		///This method saves a new object to the table Region
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
			command.CommandText = InlineProcs.ctprRegion_InsertOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@RegionID", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_regionID?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@RegionDescription", SqlDbType.NChar, 50, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_regionDescription?? (object)DBNull.Value));

				command.ExecuteNonQuery();

				_regionID					 = Convert.IsDBNull(command.Parameters["@RegionID"].Value) ? (Int32?)null : (Int32?)command.Parameters["@RegionID"].Value;
				_regionDescription					 = Convert.IsDBNull(command.Parameters["@RegionDescription"].Value) ? null : (string)command.Parameters["@RegionDescription"].Value;

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
		///This method returns all data rows in the table Region
		///</Summary>
		///<returns>
		///IList-DAORegion.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<DAORegion> SelectAll()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprRegion_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Region");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				List<DAORegion> objList = new List<DAORegion>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAORegion retObj = new DAORegion();
						retObj._regionID					 = Convert.IsDBNull(row["RegionID"]) ? (Int32?)null : (Int32?)row["RegionID"];
						retObj._regionDescription					 = Convert.IsDBNull(row["RegionDescription"]) ? null : (string)row["RegionDescription"];
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
			command.CommandText = InlineProcs.ctprRegion_SelectAllCount;
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
		///This method returns specific fields of all data rows in the table using criteriaquery apiRegion
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprRegion_SelectAllByCriteriaProjection, listProjection, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Region");
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
						if (string.Compare(projection.Member, "RegionID", true) == 0) lst.Add(Convert.IsDBNull(row["RegionID"]) ? (Int32?)null : (Int32?)row["RegionID"]);
						if (string.Compare(projection.Member, "RegionDescription", true) == 0) lst.Add(Convert.IsDBNull(row["RegionDescription"]) ? null : (string)row["RegionDescription"]);
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
		///This method returns all data rows in the table using criteriaquery api Region
		///</Summary>
		///<returns>
		///IList-DAORegion.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IList<DAORegion> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprRegion_SelectAllByCriteria, null, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Region");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				List<DAORegion> objList = new List<DAORegion>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAORegion retObj = new DAORegion();
						retObj._regionID					 = Convert.IsDBNull(row["RegionID"]) ? (Int32?)null : (Int32?)row["RegionID"];
						retObj._regionDescription					 = Convert.IsDBNull(row["RegionDescription"]) ? null : (string)row["RegionDescription"];
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
		///This method returns all data rows in the table using criteriaquery api Region
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprRegion_SelectAllByCriteriaCount, null, listCriterion, null);
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
		///This method allows the object to update itself in the table Region based on its primary key(s)
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
			command.CommandText = InlineProcs.ctprRegion_UpdateOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@RegionID", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_regionID?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@RegionDescription", SqlDbType.NChar, 50, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_regionDescription?? (object)DBNull.Value));

				command.ExecuteNonQuery();

				_regionID					 = Convert.IsDBNull(command.Parameters["@RegionID"].Value) ? (Int32?)null : (Int32?)command.Parameters["@RegionID"].Value;
				_regionDescription					 = Convert.IsDBNull(command.Parameters["@RegionDescription"].Value) ? null : (string)command.Parameters["@RegionDescription"].Value;

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

		public Int32? RegionID
		{
			get
			{
				return _regionID;
			}
			set
			{
				_regionID = value;
			}
		}

		public string RegionDescription
		{
			get
			{
				return _regionDescription;
			}
			set
			{
				_regionDescription = value;
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
		internal static string ctprRegion_SelectOne = @"
			-- Select one row based on the primary key(s)
			-- selects all rows from the table
			SELECT 
			[RegionID]
			,[RegionDescription]
			FROM [dbo].[Region]
			WHERE 
			[RegionID] = @RegionID
			";

		internal static string ctprRegion_DeleteOne = @"
			-- Delete a row based on the primary key(s)
			-- delete all matching from the table
			DELETE [dbo].[Region]
			WHERE 
			[RegionID] = @RegionID
			";

		internal static string ctprRegion_InsertOne = @"
			-- Insert a new row
			-- inserts a new row into the table
			INSERT [dbo].[Region]
			(
			[RegionID]
			,[RegionDescription]
			)
			VALUES
			(
			@RegionID
			,@RegionDescription
			)
			SELECT 
			@RegionID = [RegionID]
			,@RegionDescription = [RegionDescription]
			FROM [dbo].[Region]
			WHERE 
			[RegionID] = @RegionID
			";

		internal static string ctprRegion_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[RegionID]
			,[RegionDescription]
			FROM [dbo].[Region]
			";

		internal static string ctprRegion_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[Region]
			";

		internal static string ctprRegion_SelectAllByCriteriaProjection = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			##STARTFIELDS##
			##ENDFIELDS##
			FROM [dbo].[Region]
			##CRITERIA##
			";

		internal static string ctprRegion_SelectAllByCriteria = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			[RegionID]
			,[RegionDescription]
			FROM [dbo].[Region]
			##CRITERIA##
			";

		internal static string ctprRegion_SelectAllByCriteriaCount = @"
			
			-- selects count of all rows from the table according to criteria
			SELECT COUNT(*)
			FROM [dbo].[Region]
			##CRITERIA##
			";

		internal static string ctprRegion_UpdateOne = @"
			-- Update one row based on the primary key(s)
			-- updates a row in the table based on the primary key
			
			UPDATE [dbo].[Region]
			SET
			[RegionDescription] = @RegionDescription
			WHERE 
			[RegionID] = @RegionID
			SELECT 
			@RegionID = [RegionID]
			,@RegionDescription = [RegionDescription]
			FROM [dbo].[Region]
			WHERE 
			[RegionID] = @RegionID
			";

	}
}
#endregion
