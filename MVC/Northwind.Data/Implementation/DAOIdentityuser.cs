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
	public partial class DAOIdentityuser : zNorthwindConn_BaseData, IDAOIdentityuser
	{
		#region member variables
		protected string _userId;
		protected string _email;
		protected string _emailConfirmed;
		protected string _passwordHash;
		protected string _securityStamp;
		protected string _phoneNumber;
		protected string _phoneNumberConfirmed;
		protected string _twoFactorEnabled;
		protected string _lockoutEndDateUtc;
		protected string _lockoutEnabled;
		protected string _accessFailedCount;
		protected string _username;
		protected string _ctrVersion;
		#endregion

		#region class methods
		public DAOIdentityuser()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table identityuser based on the primary key(s)
		///</Summary>
		///<returns>
		///IDAOIdentityuser
		///</returns>
		///<parameters>
		///string userId
		///</parameters>
		public static IDAOIdentityuser SelectOne(string userId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuser_getone";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("identityuser");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new MySqlParameter("?P_USERID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)userId?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				DAOIdentityuser retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAOIdentityuser();
					retObj._userId					 = Convert.IsDBNull(dt.Rows[0]["UserId"]) ? null : (string)dt.Rows[0]["UserId"];
					retObj._email					 = Convert.IsDBNull(dt.Rows[0]["Email"]) ? null : (string)dt.Rows[0]["Email"];
					retObj._emailConfirmed					 = Convert.IsDBNull(dt.Rows[0]["EmailConfirmed"]) ? null : (string)dt.Rows[0]["EmailConfirmed"];
					retObj._passwordHash					 = Convert.IsDBNull(dt.Rows[0]["PasswordHash"]) ? null : (string)dt.Rows[0]["PasswordHash"];
					retObj._securityStamp					 = Convert.IsDBNull(dt.Rows[0]["SecurityStamp"]) ? null : (string)dt.Rows[0]["SecurityStamp"];
					retObj._phoneNumber					 = Convert.IsDBNull(dt.Rows[0]["PhoneNumber"]) ? null : (string)dt.Rows[0]["PhoneNumber"];
					retObj._phoneNumberConfirmed					 = Convert.IsDBNull(dt.Rows[0]["PhoneNumberConfirmed"]) ? null : (string)dt.Rows[0]["PhoneNumberConfirmed"];
					retObj._twoFactorEnabled					 = Convert.IsDBNull(dt.Rows[0]["TwoFactorEnabled"]) ? null : (string)dt.Rows[0]["TwoFactorEnabled"];
					retObj._lockoutEndDateUtc					 = Convert.IsDBNull(dt.Rows[0]["LockoutEndDateUtc"]) ? null : (string)dt.Rows[0]["LockoutEndDateUtc"];
					retObj._lockoutEnabled					 = Convert.IsDBNull(dt.Rows[0]["LockoutEnabled"]) ? null : (string)dt.Rows[0]["LockoutEnabled"];
					retObj._accessFailedCount					 = Convert.IsDBNull(dt.Rows[0]["AccessFailedCount"]) ? null : (string)dt.Rows[0]["AccessFailedCount"];
					retObj._username					 = Convert.IsDBNull(dt.Rows[0]["Username"]) ? null : (string)dt.Rows[0]["Username"];
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
		///this method allows the object to delete itself from the table identityuser based on its primary key
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
			command.CommandText = "ctpr_identityuser_deleteone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_USERID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)_userId?? (object)DBNull.Value));

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
		///This method saves a new object to the table identityuser
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
			command.CommandText = "ctpr_identityuser_insertone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_PASSWORDHASH", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_passwordHash?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_SECURİTYSTAMP", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_securityStamp?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_PHONENUMBER", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_phoneNumber?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_USERID", MySqlDbType.VarChar, 0, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _userId));
				command.Parameters.Add(new MySqlParameter("?P_EMAİL", MySqlDbType.VarChar, 256, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _email));
				command.Parameters.Add(new MySqlParameter("?P_EMAİLCONFİRMED", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 1, 0, "", DataRowVersion.Proposed, _emailConfirmed));
				command.Parameters.Add(new MySqlParameter("?P_PHONENUMBERCONFİRMED", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 1, 0, "", DataRowVersion.Proposed, _phoneNumberConfirmed));
				command.Parameters.Add(new MySqlParameter("?P_TWOFACTORENABLED", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 1, 0, "", DataRowVersion.Proposed, _twoFactorEnabled));
				command.Parameters.Add(new MySqlParameter("?P_LOCKOUTENDDATEUTC", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _lockoutEndDateUtc));
				command.Parameters.Add(new MySqlParameter("?P_LOCKOUTENABLED", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 1, 0, "", DataRowVersion.Proposed, _lockoutEnabled));
				command.Parameters.Add(new MySqlParameter("?P_ACCESSFAİLEDCOUNT", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _accessFailedCount));
				command.Parameters.Add(new MySqlParameter("?P_USERNAME", MySqlDbType.VarChar, 256, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _username));
				command.Parameters.Add(new MySqlParameter("?P_CTR_VERSİON", MySqlDbType.VarChar, 5, ParameterDirection.Output, true, 5, 0, "", DataRowVersion.Proposed, _ctrVersion));

				command.ExecuteNonQuery();
				Done(this);

				_userId					 = Convert.IsDBNull(command.Parameters["?P_USERID"].Value) ? null : (string)command.Parameters["?P_USERID"].Value;
				_email					 = Convert.IsDBNull(command.Parameters["?P_EMAİL"].Value) ? null : (string)command.Parameters["?P_EMAİL"].Value;
				_emailConfirmed					 = Convert.IsDBNull(command.Parameters["?P_EMAİLCONFİRMED"].Value) ? null : (string)command.Parameters["?P_EMAİLCONFİRMED"].Value;
				_phoneNumberConfirmed					 = Convert.IsDBNull(command.Parameters["?P_PHONENUMBERCONFİRMED"].Value) ? null : (string)command.Parameters["?P_PHONENUMBERCONFİRMED"].Value;
				_twoFactorEnabled					 = Convert.IsDBNull(command.Parameters["?P_TWOFACTORENABLED"].Value) ? null : (string)command.Parameters["?P_TWOFACTORENABLED"].Value;
				_lockoutEndDateUtc					 = Convert.IsDBNull(command.Parameters["?P_LOCKOUTENDDATEUTC"].Value) ? null : (string)command.Parameters["?P_LOCKOUTENDDATEUTC"].Value;
				_lockoutEnabled					 = Convert.IsDBNull(command.Parameters["?P_LOCKOUTENABLED"].Value) ? null : (string)command.Parameters["?P_LOCKOUTENABLED"].Value;
				_accessFailedCount					 = Convert.IsDBNull(command.Parameters["?P_ACCESSFAİLEDCOUNT"].Value) ? null : (string)command.Parameters["?P_ACCESSFAİLEDCOUNT"].Value;
				_username					 = Convert.IsDBNull(command.Parameters["?P_USERNAME"].Value) ? null : (string)command.Parameters["?P_USERNAME"].Value;
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
		///This method returns all data rows in the table identityuser
		///</Summary>
		///<returns>
		///List-IDAOIdentityuser.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static List<IDAOIdentityuser> SelectAll()
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuser_getall";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("identityuser");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOIdentityuser> objList = new List<IDAOIdentityuser>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOIdentityuser retObj = new DAOIdentityuser();
						retObj._userId					 = Convert.IsDBNull(row["UserId"]) ? null : (string)row["UserId"];
						retObj._email					 = Convert.IsDBNull(row["Email"]) ? null : (string)row["Email"];
						retObj._emailConfirmed					 = Convert.IsDBNull(row["EmailConfirmed"]) ? null : (string)row["EmailConfirmed"];
						retObj._passwordHash					 = Convert.IsDBNull(row["PasswordHash"]) ? null : (string)row["PasswordHash"];
						retObj._securityStamp					 = Convert.IsDBNull(row["SecurityStamp"]) ? null : (string)row["SecurityStamp"];
						retObj._phoneNumber					 = Convert.IsDBNull(row["PhoneNumber"]) ? null : (string)row["PhoneNumber"];
						retObj._phoneNumberConfirmed					 = Convert.IsDBNull(row["PhoneNumberConfirmed"]) ? null : (string)row["PhoneNumberConfirmed"];
						retObj._twoFactorEnabled					 = Convert.IsDBNull(row["TwoFactorEnabled"]) ? null : (string)row["TwoFactorEnabled"];
						retObj._lockoutEndDateUtc					 = Convert.IsDBNull(row["LockoutEndDateUtc"]) ? null : (string)row["LockoutEndDateUtc"];
						retObj._lockoutEnabled					 = Convert.IsDBNull(row["LockoutEnabled"]) ? null : (string)row["LockoutEnabled"];
						retObj._accessFailedCount					 = Convert.IsDBNull(row["AccessFailedCount"]) ? null : (string)row["AccessFailedCount"];
						retObj._username					 = Convert.IsDBNull(row["Username"]) ? null : (string)row["Username"];
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
			command.CommandText = "ctpr_identityuser_getallcount";
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
		///This method returns specific fields of all data rows in the table using criteriaquery apiidentityuser
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
			command.CommandText = "ctpr_identityuser_getbyprojection";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("identityuser");
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
						if (string.Compare(projection.Member, "Email", true) == 0) lst.Add(Convert.IsDBNull(row["Email"]) ? null : (string)row["Email"]);
						if (string.Compare(projection.Member, "EmailConfirmed", true) == 0) lst.Add(Convert.IsDBNull(row["EmailConfirmed"]) ? null : (string)row["EmailConfirmed"]);
						if (string.Compare(projection.Member, "PasswordHash", true) == 0) lst.Add(Convert.IsDBNull(row["PasswordHash"]) ? null : (string)row["PasswordHash"]);
						if (string.Compare(projection.Member, "SecurityStamp", true) == 0) lst.Add(Convert.IsDBNull(row["SecurityStamp"]) ? null : (string)row["SecurityStamp"]);
						if (string.Compare(projection.Member, "PhoneNumber", true) == 0) lst.Add(Convert.IsDBNull(row["PhoneNumber"]) ? null : (string)row["PhoneNumber"]);
						if (string.Compare(projection.Member, "PhoneNumberConfirmed", true) == 0) lst.Add(Convert.IsDBNull(row["PhoneNumberConfirmed"]) ? null : (string)row["PhoneNumberConfirmed"]);
						if (string.Compare(projection.Member, "TwoFactorEnabled", true) == 0) lst.Add(Convert.IsDBNull(row["TwoFactorEnabled"]) ? null : (string)row["TwoFactorEnabled"]);
						if (string.Compare(projection.Member, "LockoutEndDateUtc", true) == 0) lst.Add(Convert.IsDBNull(row["LockoutEndDateUtc"]) ? null : (string)row["LockoutEndDateUtc"]);
						if (string.Compare(projection.Member, "LockoutEnabled", true) == 0) lst.Add(Convert.IsDBNull(row["LockoutEnabled"]) ? null : (string)row["LockoutEnabled"]);
						if (string.Compare(projection.Member, "AccessFailedCount", true) == 0) lst.Add(Convert.IsDBNull(row["AccessFailedCount"]) ? null : (string)row["AccessFailedCount"]);
						if (string.Compare(projection.Member, "Username", true) == 0) lst.Add(Convert.IsDBNull(row["Username"]) ? null : (string)row["Username"]);
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
		///This method returns all data rows in the table using criteriaquery api identityuser
		///</Summary>
		///<returns>
		///List-IDAOIdentityuser.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static List<IDAOIdentityuser> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_identityuser_getbycriteria";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("identityuser");
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


				List<IDAOIdentityuser> objList = new List<IDAOIdentityuser>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOIdentityuser retObj = new DAOIdentityuser();
						retObj._userId					 = Convert.IsDBNull(row["UserId"]) ? null : (string)row["UserId"];
						retObj._email					 = Convert.IsDBNull(row["Email"]) ? null : (string)row["Email"];
						retObj._emailConfirmed					 = Convert.IsDBNull(row["EmailConfirmed"]) ? null : (string)row["EmailConfirmed"];
						retObj._passwordHash					 = Convert.IsDBNull(row["PasswordHash"]) ? null : (string)row["PasswordHash"];
						retObj._securityStamp					 = Convert.IsDBNull(row["SecurityStamp"]) ? null : (string)row["SecurityStamp"];
						retObj._phoneNumber					 = Convert.IsDBNull(row["PhoneNumber"]) ? null : (string)row["PhoneNumber"];
						retObj._phoneNumberConfirmed					 = Convert.IsDBNull(row["PhoneNumberConfirmed"]) ? null : (string)row["PhoneNumberConfirmed"];
						retObj._twoFactorEnabled					 = Convert.IsDBNull(row["TwoFactorEnabled"]) ? null : (string)row["TwoFactorEnabled"];
						retObj._lockoutEndDateUtc					 = Convert.IsDBNull(row["LockoutEndDateUtc"]) ? null : (string)row["LockoutEndDateUtc"];
						retObj._lockoutEnabled					 = Convert.IsDBNull(row["LockoutEnabled"]) ? null : (string)row["LockoutEnabled"];
						retObj._accessFailedCount					 = Convert.IsDBNull(row["AccessFailedCount"]) ? null : (string)row["AccessFailedCount"];
						retObj._username					 = Convert.IsDBNull(row["Username"]) ? null : (string)row["Username"];
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
		///This method returns all data rows in the table using criteriaquery api identityuser
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
			command.CommandText = "ctpr_identityuser_getbycriteriacount";
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
		///This method allows the object to update itself in the table identityuser based on its primary key(s)
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
			command.CommandText = "ctpr_identityuser_updateone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_PASSWORDHASH", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_passwordHash?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_SECURİTYSTAMP", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_securityStamp?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_PHONENUMBER", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_phoneNumber?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_USERID", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _userId));
				command.Parameters.Add(new MySqlParameter("?P_EMAİL", MySqlDbType.VarChar, 256, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _email));
				command.Parameters.Add(new MySqlParameter("?P_EMAİLCONFİRMED", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 1, 0, "", DataRowVersion.Proposed, _emailConfirmed));
				command.Parameters.Add(new MySqlParameter("?P_PHONENUMBERCONFİRMED", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 1, 0, "", DataRowVersion.Proposed, _phoneNumberConfirmed));
				command.Parameters.Add(new MySqlParameter("?P_TWOFACTORENABLED", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 1, 0, "", DataRowVersion.Proposed, _twoFactorEnabled));
				command.Parameters.Add(new MySqlParameter("?P_LOCKOUTENDDATEUTC", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _lockoutEndDateUtc));
				command.Parameters.Add(new MySqlParameter("?P_LOCKOUTENABLED", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 1, 0, "", DataRowVersion.Proposed, _lockoutEnabled));
				command.Parameters.Add(new MySqlParameter("?P_ACCESSFAİLEDCOUNT", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _accessFailedCount));
				command.Parameters.Add(new MySqlParameter("?P_USERNAME", MySqlDbType.VarChar, 256, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _username));
				command.Parameters.Add(new MySqlParameter("?P_CTR_VERSİON", MySqlDbType.VarChar, 5, ParameterDirection.InputOutput, true, 5, 0, "", DataRowVersion.Proposed, _ctrVersion));

				command.ExecuteNonQuery();
				Done(this);

				_userId					 = Convert.IsDBNull(command.Parameters["?P_USERID"].Value) ? null : (string)command.Parameters["?P_USERID"].Value;
				_email					 = Convert.IsDBNull(command.Parameters["?P_EMAİL"].Value) ? null : (string)command.Parameters["?P_EMAİL"].Value;
				_emailConfirmed					 = Convert.IsDBNull(command.Parameters["?P_EMAİLCONFİRMED"].Value) ? null : (string)command.Parameters["?P_EMAİLCONFİRMED"].Value;
				_phoneNumberConfirmed					 = Convert.IsDBNull(command.Parameters["?P_PHONENUMBERCONFİRMED"].Value) ? null : (string)command.Parameters["?P_PHONENUMBERCONFİRMED"].Value;
				_twoFactorEnabled					 = Convert.IsDBNull(command.Parameters["?P_TWOFACTORENABLED"].Value) ? null : (string)command.Parameters["?P_TWOFACTORENABLED"].Value;
				_lockoutEndDateUtc					 = Convert.IsDBNull(command.Parameters["?P_LOCKOUTENDDATEUTC"].Value) ? null : (string)command.Parameters["?P_LOCKOUTENDDATEUTC"].Value;
				_lockoutEnabled					 = Convert.IsDBNull(command.Parameters["?P_LOCKOUTENABLED"].Value) ? null : (string)command.Parameters["?P_LOCKOUTENABLED"].Value;
				_accessFailedCount					 = Convert.IsDBNull(command.Parameters["?P_ACCESSFAİLEDCOUNT"].Value) ? null : (string)command.Parameters["?P_ACCESSFAİLEDCOUNT"].Value;
				_username					 = Convert.IsDBNull(command.Parameters["?P_USERNAME"].Value) ? null : (string)command.Parameters["?P_USERNAME"].Value;
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
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				_email = value;
			}
		}
		public string EmailConfirmed
		{
			get
			{
				return _emailConfirmed;
			}
			set
			{
				_emailConfirmed = value;
			}
		}
		public string PasswordHash
		{
			get
			{
				return _passwordHash;
			}
			set
			{
				_passwordHash = value;
			}
		}
		public string SecurityStamp
		{
			get
			{
				return _securityStamp;
			}
			set
			{
				_securityStamp = value;
			}
		}
		public string PhoneNumber
		{
			get
			{
				return _phoneNumber;
			}
			set
			{
				_phoneNumber = value;
			}
		}
		public string PhoneNumberConfirmed
		{
			get
			{
				return _phoneNumberConfirmed;
			}
			set
			{
				_phoneNumberConfirmed = value;
			}
		}
		public string TwoFactorEnabled
		{
			get
			{
				return _twoFactorEnabled;
			}
			set
			{
				_twoFactorEnabled = value;
			}
		}
		public string LockoutEndDateUtc
		{
			get
			{
				return _lockoutEndDateUtc;
			}
			set
			{
				_lockoutEndDateUtc = value;
			}
		}
		public string LockoutEnabled
		{
			get
			{
				return _lockoutEnabled;
			}
			set
			{
				_lockoutEnabled = value;
			}
		}
		public string AccessFailedCount
		{
			get
			{
				return _accessFailedCount;
			}
			set
			{
				_accessFailedCount = value;
			}
		}
		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
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