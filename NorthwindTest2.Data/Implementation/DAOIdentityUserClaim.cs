/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:09:42
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using NorthwindTest2.Data.Interfaces;

namespace NorthwindTest2.Data
{
	public partial class DAOIdentityUserClaim : zNorthwindTest2Conn_BaseData, IDAOIdentityUserClaim
	{
		#region member variables
		protected Int32? _ıd;
		protected Int32? _userId;
		protected string _claimType;
		protected string _claimValue;
		#endregion

		#region class methods
		public DAOIdentityUserClaim()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table IdentityUserClaim based on the primary key(s)
		///</Summary>
		///<returns>
		///IDAOIdentityUserClaim
		///</returns>
		///<parameters>
		///Int32? ıd
		///</parameters>
		public static IDAOIdentityUserClaim SelectOne(Int32? ıd)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIdentityUserClaim_SelectOne;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("IdentityUserClaim");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)ıd?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				DAOIdentityUserClaim retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAOIdentityUserClaim();
					retObj._ıd					 = Convert.IsDBNull(dt.Rows[0]["Id"]) ? (Int32?)null : (Int32?)dt.Rows[0]["Id"];
					retObj._userId					 = Convert.IsDBNull(dt.Rows[0]["UserId"]) ? (Int32?)null : (Int32?)dt.Rows[0]["UserId"];
					retObj._claimType					 = Convert.IsDBNull(dt.Rows[0]["ClaimType"]) ? null : (string)dt.Rows[0]["ClaimType"];
					retObj._claimValue					 = Convert.IsDBNull(dt.Rows[0]["ClaimValue"]) ? null : (string)dt.Rows[0]["ClaimValue"];
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
		///this method allows the object to delete itself from the table IdentityUserClaim based on its primary key
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
			command.CommandText = InlineProcs.ctprIdentityUserClaim_DeleteOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)_ıd?? (object)DBNull.Value));

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
		///Select all rows by foreign key
		///This method returns all data rows in the table IdentityUserClaim based on a foreign key
		///</Summary>
		///<returns>
		///IList-IDAOIdentityUserClaim.
		///</returns>
		///<parameters>
		///Int32? userId
		///</parameters>
		public static IList<IDAOIdentityUserClaim> SelectAllByUserId(Int32? userId)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIdentityUserClaim_SelectAllByUserId;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("IdentityUserClaim");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@UserId", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)userId?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				List<IDAOIdentityUserClaim> objList = new List<IDAOIdentityUserClaim>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOIdentityUserClaim retObj = new DAOIdentityUserClaim();
						retObj._ıd					 = Convert.IsDBNull(row["Id"]) ? (Int32?)null : (Int32?)row["Id"];
						retObj._userId					 = Convert.IsDBNull(row["UserId"]) ? (Int32?)null : (Int32?)row["UserId"];
						retObj._claimType					 = Convert.IsDBNull(row["ClaimType"]) ? null : (string)row["ClaimType"];
						retObj._claimValue					 = Convert.IsDBNull(row["ClaimValue"]) ? null : (string)row["ClaimValue"];
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
		///Int32? userId
		///</parameters>
		public static Int32 SelectAllByUserIdCount(Int32? userId)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIdentityUserClaim_SelectAllByUserIdCount;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@UserId", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)userId?? (object)DBNull.Value));

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
		///Delete all by foreign key
		///This method deletes all rows in the table IdentityUserClaim with a given foreign key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///IzNorthwindTest2Conn_TxConnectionProvider connectionProvider, Int32? userId
		///</parameters>
		public static void DeleteAllByUserId(IzNorthwindTest2Conn_TxConnectionProvider connectionProvider, Int32? userId)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIdentityUserClaim_DeleteAllByUserId;
			command.CommandType = CommandType.Text;
			command.Connection = connectionProvider.Connection;
			command.Transaction = connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@UserId", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)userId?? (object)DBNull.Value));

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
		///This method saves a new object to the table IdentityUserClaim
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
			command.CommandText = InlineProcs.ctprIdentityUserClaim_InsertOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Id", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _ıd));
				command.Parameters.Add(CtSqlParameter.Get("@UserId", SqlDbType.Int, 4, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, (object)_userId?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ClaimType", SqlDbType.NVarChar, -1, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_claimType?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ClaimValue", SqlDbType.NVarChar, -1, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_claimValue?? (object)DBNull.Value));

				command.ExecuteNonQuery();

				_ıd					 = Convert.IsDBNull(command.Parameters["@Id"].Value) ? (Int32?)null : (Int32?)command.Parameters["@Id"].Value;
				_userId					 = Convert.IsDBNull(command.Parameters["@UserId"].Value) ? (Int32?)null : (Int32?)command.Parameters["@UserId"].Value;
				_claimType					 = Convert.IsDBNull(command.Parameters["@ClaimType"].Value) ? null : (string)command.Parameters["@ClaimType"].Value;
				_claimValue					 = Convert.IsDBNull(command.Parameters["@ClaimValue"].Value) ? null : (string)command.Parameters["@ClaimValue"].Value;

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
		///This method returns all data rows in the table IdentityUserClaim
		///</Summary>
		///<returns>
		///IList-IDAOIdentityUserClaim.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IDAOIdentityUserClaim> SelectAll()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIdentityUserClaim_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("IdentityUserClaim");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				List<IDAOIdentityUserClaim> objList = new List<IDAOIdentityUserClaim>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOIdentityUserClaim retObj = new DAOIdentityUserClaim();
						retObj._ıd					 = Convert.IsDBNull(row["Id"]) ? (Int32?)null : (Int32?)row["Id"];
						retObj._userId					 = Convert.IsDBNull(row["UserId"]) ? (Int32?)null : (Int32?)row["UserId"];
						retObj._claimType					 = Convert.IsDBNull(row["ClaimType"]) ? null : (string)row["ClaimType"];
						retObj._claimValue					 = Convert.IsDBNull(row["ClaimValue"]) ? null : (string)row["ClaimValue"];
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
			command.CommandText = InlineProcs.ctprIdentityUserClaim_SelectAllCount;
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
		///This method returns specific fields of all data rows in the table using criteriaquery apiIdentityUserClaim
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprIdentityUserClaim_SelectAllByCriteriaProjection, listProjection, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("IdentityUserClaim");
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
						if (string.Compare(projection.Member, "Id", true) == 0) lst.Add(Convert.IsDBNull(row["Id"]) ? (Int32?)null : (Int32?)row["Id"]);
						if (string.Compare(projection.Member, "UserId", true) == 0) lst.Add(Convert.IsDBNull(row["UserId"]) ? (Int32?)null : (Int32?)row["UserId"]);
						if (string.Compare(projection.Member, "ClaimType", true) == 0) lst.Add(Convert.IsDBNull(row["ClaimType"]) ? null : (string)row["ClaimType"]);
						if (string.Compare(projection.Member, "ClaimValue", true) == 0) lst.Add(Convert.IsDBNull(row["ClaimValue"]) ? null : (string)row["ClaimValue"]);
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
		///This method returns all data rows in the table using criteriaquery api IdentityUserClaim
		///</Summary>
		///<returns>
		///IList-IDAOIdentityUserClaim.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IList<IDAOIdentityUserClaim> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprIdentityUserClaim_SelectAllByCriteria, null, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("IdentityUserClaim");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				List<IDAOIdentityUserClaim> objList = new List<IDAOIdentityUserClaim>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOIdentityUserClaim retObj = new DAOIdentityUserClaim();
						retObj._ıd					 = Convert.IsDBNull(row["Id"]) ? (Int32?)null : (Int32?)row["Id"];
						retObj._userId					 = Convert.IsDBNull(row["UserId"]) ? (Int32?)null : (Int32?)row["UserId"];
						retObj._claimType					 = Convert.IsDBNull(row["ClaimType"]) ? null : (string)row["ClaimType"];
						retObj._claimValue					 = Convert.IsDBNull(row["ClaimValue"]) ? null : (string)row["ClaimValue"];
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
		///This method returns all data rows in the table using criteriaquery api IdentityUserClaim
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprIdentityUserClaim_SelectAllByCriteriaCount, null, listCriterion, null);
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
		///This method allows the object to update itself in the table IdentityUserClaim based on its primary key(s)
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
			command.CommandText = InlineProcs.ctprIdentityUserClaim_UpdateOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Id", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_ıd?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@UserId", SqlDbType.Int, 4, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, (object)_userId?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ClaimType", SqlDbType.NVarChar, -1, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_claimType?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ClaimValue", SqlDbType.NVarChar, -1, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_claimValue?? (object)DBNull.Value));

				command.ExecuteNonQuery();

				_ıd					 = Convert.IsDBNull(command.Parameters["@Id"].Value) ? (Int32?)null : (Int32?)command.Parameters["@Id"].Value;
				_userId					 = Convert.IsDBNull(command.Parameters["@UserId"].Value) ? (Int32?)null : (Int32?)command.Parameters["@UserId"].Value;
				_claimType					 = Convert.IsDBNull(command.Parameters["@ClaimType"].Value) ? null : (string)command.Parameters["@ClaimType"].Value;
				_claimValue					 = Convert.IsDBNull(command.Parameters["@ClaimValue"].Value) ? null : (string)command.Parameters["@ClaimValue"].Value;

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

		public Int32? Id
		{
			get
			{
				return _ıd;
			}
			set
			{
				_ıd = value;
			}
		}

		public Int32? UserId
		{
			get
			{
				return _userId;
			}
			set
			{
				_userId = value;
			}
		}

		public string ClaimType
		{
			get
			{
				return _claimType;
			}
			set
			{
				_claimType = value;
			}
		}

		public string ClaimValue
		{
			get
			{
				return _claimValue;
			}
			set
			{
				_claimValue = value;
			}
		}

		#endregion
	}
}

#region inline sql procs
namespace NorthwindTest2.Data
{
	public partial class InlineProcs
	{
		internal static string ctprIdentityUserClaim_SelectOne = @"
			-- Select one row based on the primary key(s)
			-- selects all rows from the table
			SELECT 
			[Id]
			,[UserId]
			,[ClaimType]
			,[ClaimValue]
			FROM [security].[IdentityUserClaim]
			WHERE 
			[Id] = @Id
			";

		internal static string ctprIdentityUserClaim_DeleteOne = @"
			-- Delete a row based on the primary key(s)
			-- delete all matching from the table
			DELETE [security].[IdentityUserClaim]
			WHERE 
			[Id] = @Id
			";

		internal static string ctprIdentityUserClaim_SelectAllByUserId = @"
			-- Select all rows based on a foreign key
			-- selects all rows from the table
			SELECT 
			[Id]
			,[UserId]
			,[ClaimType]
			,[ClaimValue]
			FROM [security].[IdentityUserClaim]
			WHERE 
			[UserId] = @UserId OR ([UserId] IS NULL AND @UserId IS NULL)
			";

		internal static string ctprIdentityUserClaim_SelectAllByUserIdCount = @"
			-- Get count of rows returnable by this query
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [security].[IdentityUserClaim]
			WHERE 
			[UserId] = @UserId OR ([UserId] IS NULL AND @UserId IS NULL)
			";

		internal static string ctprIdentityUserClaim_DeleteAllByUserId = @"
			
			-- delete all matching from the table
			DELETE [security].[IdentityUserClaim]
			WHERE 
			[UserId] = @UserId OR ([UserId] IS NULL AND @UserId IS NULL)
			";

		internal static string ctprIdentityUserClaim_InsertOne = @"
			-- Insert a new row
			-- inserts a new row into the table
			INSERT [security].[IdentityUserClaim]
			(
			[UserId]
			,[ClaimType]
			,[ClaimValue]
			)
			VALUES
			(
			@UserId
			,@ClaimType
			,@ClaimValue
			)
			SELECT 
			@Id = [Id]
			,@UserId = [UserId]
			,@ClaimType = [ClaimType]
			,@ClaimValue = [ClaimValue]
			FROM [security].[IdentityUserClaim]
			WHERE 
			[Id] = SCOPE_IDENTITY()
			";

		internal static string ctprIdentityUserClaim_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[Id]
			,[UserId]
			,[ClaimType]
			,[ClaimValue]
			FROM [security].[IdentityUserClaim]
			";

		internal static string ctprIdentityUserClaim_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [security].[IdentityUserClaim]
			";

		internal static string ctprIdentityUserClaim_SelectAllByCriteriaProjection = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			##STARTFIELDS##
			##ENDFIELDS##
			FROM [security].[IdentityUserClaim]
			##CRITERIA##
			";

		internal static string ctprIdentityUserClaim_SelectAllByCriteria = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			[Id]
			,[UserId]
			,[ClaimType]
			,[ClaimValue]
			FROM [security].[IdentityUserClaim]
			##CRITERIA##
			";

		internal static string ctprIdentityUserClaim_SelectAllByCriteriaCount = @"
			
			-- selects count of all rows from the table according to criteria
			SELECT COUNT(*)
			FROM [security].[IdentityUserClaim]
			##CRITERIA##
			";

		internal static string ctprIdentityUserClaim_UpdateOne = @"
			-- Update one row based on the primary key(s)
			-- updates a row in the table based on the primary key
			
			UPDATE [security].[IdentityUserClaim]
			SET
			[UserId] = @UserId
			,[ClaimType] = @ClaimType
			,[ClaimValue] = @ClaimValue
			WHERE 
			[Id] = @Id
			SELECT 
			@Id = [Id]
			,@UserId = [UserId]
			,@ClaimType = [ClaimType]
			,@ClaimValue = [ClaimValue]
			FROM [security].[IdentityUserClaim]
			WHERE 
			[Id] = @Id
			";

	}
}
#endregion