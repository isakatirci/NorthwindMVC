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
	public partial class DAOPrivileges : zNorthwindConn_BaseData, IDAOPrivileges
	{
		#region member variables
		protected string _id;
		protected string _privilegeName;
		protected string _ctrVersion;
		#endregion

		#region class methods
		public DAOPrivileges()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table privileges based on the primary key(s)
		///</Summary>
		///<returns>
		///IDAOPrivileges
		///</returns>
		///<parameters>
		///string id
		///</parameters>
		public static IDAOPrivileges SelectOne(string id)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_privileges_getone";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("privileges");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new MySqlParameter("?P_İD", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)id?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				DAOPrivileges retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAOPrivileges();
					retObj._id					 = Convert.IsDBNull(dt.Rows[0]["id"]) ? null : (string)dt.Rows[0]["id"];
					retObj._privilegeName					 = Convert.IsDBNull(dt.Rows[0]["privilege_name"]) ? null : (string)dt.Rows[0]["privilege_name"];
					retObj._ctrVersion					 = Convert.IsDBNull(dt.Rows[0]["ctr_version"]) ? null : (string)dt.Rows[0]["ctr_version"];
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
		///this method allows the object to delete itself from the table privileges based on its primary key
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
			command.CommandText = "ctpr_privileges_deleteone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_İD", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)_id?? (object)DBNull.Value));

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
		///Insert a new row
		///This method saves a new object to the table privileges
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
			command.CommandText = "ctpr_privileges_insertone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_İD", MySqlDbType.VarChar, 0, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _id));
				command.Parameters.Add(new MySqlParameter("?P_PRİVİLEGE_NAME", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _privilegeName));
				command.Parameters.Add(new MySqlParameter("?P_CTR_VERSİON", MySqlDbType.VarChar, 5, ParameterDirection.Output, true, 5, 0, "", DataRowVersion.Proposed, _ctrVersion));

				command.ExecuteNonQuery();
				Done(this);

				_id					 = Convert.IsDBNull(command.Parameters["?P_İD"].Value) ? null : (string)command.Parameters["?P_İD"].Value;
				_privilegeName					 = Convert.IsDBNull(command.Parameters["?P_PRİVİLEGE_NAME"].Value) ? null : (string)command.Parameters["?P_PRİVİLEGE_NAME"].Value;
				_ctrVersion					 = Convert.IsDBNull(command.Parameters["?P_CTR_VERSİON"].Value) ? null : (string)command.Parameters["?P_CTR_VERSİON"].Value;

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
		///This method returns all data rows in the table privileges
		///</Summary>
		///<returns>
		///List-IDAOPrivileges.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static List<IDAOPrivileges> SelectAll()
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_privileges_getall";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("privileges");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOPrivileges> objList = new List<IDAOPrivileges>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOPrivileges retObj = new DAOPrivileges();
						retObj._id					 = Convert.IsDBNull(row["id"]) ? null : (string)row["id"];
						retObj._privilegeName					 = Convert.IsDBNull(row["privilege_name"]) ? null : (string)row["privilege_name"];
						retObj._ctrVersion					 = Convert.IsDBNull(row["ctr_version"]) ? null : (string)row["ctr_version"];
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
			command.CommandText = "ctpr_privileges_getallcount";
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
		///This method returns specific fields of all data rows in the table using criteriaquery apiprivileges
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
			command.CommandText = "ctpr_privileges_getbyprojection";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("privileges");
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
						if (string.Compare(projection.Member, "id", true) == 0) lst.Add(Convert.IsDBNull(row["id"]) ? null : (string)row["id"]);
						if (string.Compare(projection.Member, "privilege_name", true) == 0) lst.Add(Convert.IsDBNull(row["privilege_name"]) ? null : (string)row["privilege_name"]);
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
		///This method returns all data rows in the table using criteriaquery api privileges
		///</Summary>
		///<returns>
		///List-IDAOPrivileges.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static List<IDAOPrivileges> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_privileges_getbycriteria";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("privileges");
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


				List<IDAOPrivileges> objList = new List<IDAOPrivileges>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOPrivileges retObj = new DAOPrivileges();
						retObj._id					 = Convert.IsDBNull(row["id"]) ? null : (string)row["id"];
						retObj._privilegeName					 = Convert.IsDBNull(row["privilege_name"]) ? null : (string)row["privilege_name"];
						retObj._ctrVersion					 = Convert.IsDBNull(row["ctr_version"]) ? null : (string)row["ctr_version"];
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
		///This method returns all data rows in the table using criteriaquery api privileges
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
			command.CommandText = "ctpr_privileges_getbycriteriacount";
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

		///<Summary>
		///Update one row by primary key(s)
		///This method allows the object to update itself in the table privileges based on its primary key(s)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Update()
		{
			Doing(this);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_privileges_updateone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_İD", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _id));
				command.Parameters.Add(new MySqlParameter("?P_PRİVİLEGE_NAME", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _privilegeName));
				command.Parameters.Add(new MySqlParameter("?P_CTR_VERSİON", MySqlDbType.VarChar, 5, ParameterDirection.InputOutput, true, 5, 0, "", DataRowVersion.Proposed, _ctrVersion));

				command.ExecuteNonQuery();
				Done(this);

				_id					 = Convert.IsDBNull(command.Parameters["?P_İD"].Value) ? null : (string)command.Parameters["?P_İD"].Value;
				_privilegeName					 = Convert.IsDBNull(command.Parameters["?P_PRİVİLEGE_NAME"].Value) ? null : (string)command.Parameters["?P_PRİVİLEGE_NAME"].Value;
				_ctrVersion					 = Convert.IsDBNull(command.Parameters["?P_CTR_VERSİON"].Value) ? null : (string)command.Parameters["?P_CTR_VERSİON"].Value;

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

		#endregion

		#region member properties
		public string İd
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}
		public string PrivilegeName
		{
			get
			{
				return _privilegeName;
			}
			set
			{
				_privilegeName = value;
			}
		}
		public string CtrVersion
		{
			get
			{
				return _ctrVersion;
			}
			set
			{
				_ctrVersion = value;
			}
		}

		#endregion
	}
}