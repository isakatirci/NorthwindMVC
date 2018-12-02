/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 01:22:23
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Northwind.Data.Interfaces;

namespace Northwind.Data
{
	public partial class DAOIdentityuserrole : zNorthwindConn_BaseData, IDAOIdentityuserrole
	{
		#region member variables
		protected string _userId;
		protected string _roleId;
		#endregion

		#region class methods
		public DAOIdentityuserrole()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table identityuserrole based on the primary key(s)
		///</Summary>
		///<returns>
		///IDAOIdentityuserrole
		///</returns>
		///<parameters>
		///string userId, string roleId
		///</parameters>
		public static IDAOIdentityuserrole SelectOne(string userId, string roleId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_getone";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("identityuserrole");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new MySqlParameter("?P_USERID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)userId?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_ROLEID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)roleId?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				DAOIdentityuserrole retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAOIdentityuserrole();
					retObj._userId					 = Convert.IsDBNull(dt.Rows[0]["UserId"]) ? null : (string)dt.Rows[0]["UserId"];
					retObj._roleId					 = Convert.IsDBNull(dt.Rows[0]["RoleId"]) ? null : (string)dt.Rows[0]["RoleId"];
				}
				return retObj;
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
		///Delete one row by primary key(s)
		///this method allows the object to delete itself from the table identityuserrole based on its primary key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Delete()
		{
			Doing(this);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_deleteone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_USERID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)_userId?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_ROLEID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)_roleId?? (object)DBNull.Value));

				command.ExecuteNonQuery();
				Done(this);


			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
			finally
			{
				command.Dispose();
			}
		}

		///<Summary>
		///Select all rows by foreign key
		///This method returns all data rows in the table identityuserrole based on a foreign key
		///</Summary>
		///<returns>
		///List-IDAOIdentityuserrole.
		///</returns>
		///<parameters>
		///string userId
		///</parameters>
		public static List<IDAOIdentityuserrole> SelectAllByUserId(string userId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_getbyuserıd";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("identityuserrole");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new MySqlParameter("?P_USERID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)userId?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOIdentityuserrole> objList = new List<IDAOIdentityuserrole>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOIdentityuserrole retObj = new DAOIdentityuserrole();
						retObj._userId					 = Convert.IsDBNull(row["UserId"]) ? null : (string)row["UserId"];
						retObj._roleId					 = Convert.IsDBNull(row["RoleId"]) ? null : (string)row["RoleId"];
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
		///string userId
		///</parameters>
		public static Int32 SelectAllByUserIdCount(string userId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_getbyuserıdcount";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_USERID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)userId?? (object)DBNull.Value));

				staticConnection.Open();
				Int32 retCount = (Int32)(Int64) command.ExecuteScalar();
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
		///Delete all by foreign key
		///This method deletes all rows in the table identityuserrole with a given foreign key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///IzNorthwindConn_TxConnectionProvider connectionProvider, string userId
		///</parameters>
		public static void DeleteAllByUserId(IzNorthwindConn_TxConnectionProvider connectionProvider, string userId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_deletebyuserıd";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = connectionProvider.Connection;
			command.Transaction = connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_USERID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)userId?? (object)DBNull.Value));

				command.ExecuteNonQuery();
				Done(null);


			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
			}
			finally
			{
				command.Dispose();
			}
		}

		///<Summary>
		///Select all rows by foreign key
		///This method returns all data rows in the table identityuserrole based on a foreign key
		///</Summary>
		///<returns>
		///List-IDAOIdentityuserrole.
		///</returns>
		///<parameters>
		///string roleId
		///</parameters>
		public static List<IDAOIdentityuserrole> SelectAllByRoleId(string roleId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_getbyroleıd";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("identityuserrole");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new MySqlParameter("?P_ROLEID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)roleId?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOIdentityuserrole> objList = new List<IDAOIdentityuserrole>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOIdentityuserrole retObj = new DAOIdentityuserrole();
						retObj._userId					 = Convert.IsDBNull(row["UserId"]) ? null : (string)row["UserId"];
						retObj._roleId					 = Convert.IsDBNull(row["RoleId"]) ? null : (string)row["RoleId"];
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
		///string roleId
		///</parameters>
		public static Int32 SelectAllByRoleIdCount(string roleId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_getbyroleıdcount";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_ROLEID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)roleId?? (object)DBNull.Value));

				staticConnection.Open();
				Int32 retCount = (Int32)(Int64) command.ExecuteScalar();
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
		///Delete all by foreign key
		///This method deletes all rows in the table identityuserrole with a given foreign key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///IzNorthwindConn_TxConnectionProvider connectionProvider, string roleId
		///</parameters>
		public static void DeleteAllByRoleId(IzNorthwindConn_TxConnectionProvider connectionProvider, string roleId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_deletebyroleıd";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = connectionProvider.Connection;
			command.Transaction = connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_ROLEID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)roleId?? (object)DBNull.Value));

				command.ExecuteNonQuery();
				Done(null);


			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
			}
			finally
			{
				command.Dispose();
			}
		}

		///<Summary>
		///Insert a new row
		///This method saves a new object to the table identityuserrole
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Insert()
		{
			Doing(this);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_insertone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_USERID", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _userId));
				command.Parameters.Add(new MySqlParameter("?P_ROLEID", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _roleId));

				command.ExecuteNonQuery();
				Done(this);

				_userId					 = Convert.IsDBNull(command.Parameters["?P_USERID"].Value) ? null : (string)command.Parameters["?P_USERID"].Value;
				_roleId					 = Convert.IsDBNull(command.Parameters["?P_ROLEID"].Value) ? null : (string)command.Parameters["?P_ROLEID"].Value;

			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
			finally
			{
				command.Dispose();
			}
		}

		///<Summary>
		///Select all rows
		///This method returns all data rows in the table identityuserrole
		///</Summary>
		///<returns>
		///List-IDAOIdentityuserrole.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static List<IDAOIdentityuserrole> SelectAll()
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_getall";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("identityuserrole");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOIdentityuserrole> objList = new List<IDAOIdentityuserrole>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOIdentityuserrole retObj = new DAOIdentityuserrole();
						retObj._userId					 = Convert.IsDBNull(row["UserId"]) ? null : (string)row["UserId"];
						retObj._roleId					 = Convert.IsDBNull(row["RoleId"]) ? null : (string)row["RoleId"];
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
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_getallcount";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{

				staticConnection.Open();
				Int32 retCount = (Int32)(Int64) command.ExecuteScalar();
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
		///This method returns specific fields of all data rows in the table using criteriaquery apiidentityuserrole
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
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_getbyprojection";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("identityuserrole");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				string fieldsField = GetProjections(listProjection);
				string whereClause = GetSelectionCriteria(listCriterion);
				string orderClause = GetSelectionOrder(listOrder);
				string skipClause = GetSelectionSkip(dataSkip);
				string takeClause = GetSelectionTake(dataTake);
				command.Parameters.Add(new MySqlParameter("?P_SKİPCLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)skipClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_TAKECLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)takeClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_FİELDSFİELD", MySqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)fieldsField?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_WHERECLAUSE", MySqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)whereClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_ORDERCLAUSE", MySqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)orderClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_SKİPCLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)skipClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_TAKECLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)takeClause?? (object)DBNull.Value));

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
						if (string.Compare(projection.Member, "UserId", true) == 0) lst.Add(Convert.IsDBNull(row["UserId"]) ? null : (string)row["UserId"]);
						if (string.Compare(projection.Member, "RoleId", true) == 0) lst.Add(Convert.IsDBNull(row["RoleId"]) ? null : (string)row["RoleId"]);
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
		///This method returns all data rows in the table using criteriaquery api identityuserrole
		///</Summary>
		///<returns>
		///List-IDAOIdentityuserrole.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static List<IDAOIdentityuserrole> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_getbycriteria";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("identityuserrole");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				string whereClause = GetSelectionCriteria(listCriterion);
				string orderClause = GetSelectionOrder(listOrder);
				string skipClause = GetSelectionSkip(dataSkip);
				string takeClause = GetSelectionTake(dataTake);
				command.Parameters.Add(new MySqlParameter("?P_SKİPCLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)skipClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_TAKECLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)takeClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_WHERECLAUSE", MySqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)whereClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_ORDERCLAUSE", MySqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)orderClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_SKİPCLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)skipClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_TAKECLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)takeClause?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOIdentityuserrole> objList = new List<IDAOIdentityuserrole>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOIdentityuserrole retObj = new DAOIdentityuserrole();
						retObj._userId					 = Convert.IsDBNull(row["UserId"]) ? null : (string)row["UserId"];
						retObj._roleId					 = Convert.IsDBNull(row["RoleId"]) ? null : (string)row["RoleId"];
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
		///This method returns all data rows in the table using criteriaquery api identityuserrole
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
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuserrole_getbycriteriacount";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				string whereClause = GetSelectionCriteria(listCriterion);
				command.Parameters.Add(new MySqlParameter("?P_WHERECLAUSE", MySqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)whereClause?? (object)DBNull.Value));

				staticConnection.Open();
				Int32 retCount = (Int32)(Int64) command.ExecuteScalar();
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
		public string UserId
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
		public string RoleId
		{
			get
			{
				return _roleId;
			}
			set
			{
				_roleId = value;
			}
		}
		#endregion
	}
}