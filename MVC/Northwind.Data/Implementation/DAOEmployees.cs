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
	public partial class DAOEmployees : zNorthwindConn_BaseData, IDAOEmployees
	{
		#region member variables
		protected string _id;
		protected string _company;
		protected string _lastName;
		protected string _firstName;
		protected string _emailAddress;
		protected string _jobTitle;
		protected string _businessPhone;
		protected string _homePhone;
		protected string _mobilePhone;
		protected string _faxNumber;
		protected string _address;
		protected string _city;
		protected string _stateProvince;
		protected string _zipPostalCode;
		protected string _countryRegion;
		protected string _webPage;
		protected string _notes;
		protected byte[] _attachments;
		protected string _ctrVersion;
		#endregion

		#region class methods
		public DAOEmployees()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table employees based on the primary key(s)
		///</Summary>
		///<returns>
		///IDAOEmployees
		///</returns>
		///<parameters>
		///string id
		///</parameters>
		public static IDAOEmployees SelectOne(string id)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_employees_getone";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("employees");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new MySqlParameter("?P_İD", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)id?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				DAOEmployees retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAOEmployees();
					retObj._id					 = Convert.IsDBNull(dt.Rows[0]["id"]) ? null : (string)dt.Rows[0]["id"];
					retObj._company					 = Convert.IsDBNull(dt.Rows[0]["company"]) ? null : (string)dt.Rows[0]["company"];
					retObj._lastName					 = Convert.IsDBNull(dt.Rows[0]["last_name"]) ? null : (string)dt.Rows[0]["last_name"];
					retObj._firstName					 = Convert.IsDBNull(dt.Rows[0]["first_name"]) ? null : (string)dt.Rows[0]["first_name"];
					retObj._emailAddress					 = Convert.IsDBNull(dt.Rows[0]["email_address"]) ? null : (string)dt.Rows[0]["email_address"];
					retObj._jobTitle					 = Convert.IsDBNull(dt.Rows[0]["job_title"]) ? null : (string)dt.Rows[0]["job_title"];
					retObj._businessPhone					 = Convert.IsDBNull(dt.Rows[0]["business_phone"]) ? null : (string)dt.Rows[0]["business_phone"];
					retObj._homePhone					 = Convert.IsDBNull(dt.Rows[0]["home_phone"]) ? null : (string)dt.Rows[0]["home_phone"];
					retObj._mobilePhone					 = Convert.IsDBNull(dt.Rows[0]["mobile_phone"]) ? null : (string)dt.Rows[0]["mobile_phone"];
					retObj._faxNumber					 = Convert.IsDBNull(dt.Rows[0]["fax_number"]) ? null : (string)dt.Rows[0]["fax_number"];
					retObj._address					 = Convert.IsDBNull(dt.Rows[0]["address"]) ? null : (string)dt.Rows[0]["address"];
					retObj._city					 = Convert.IsDBNull(dt.Rows[0]["city"]) ? null : (string)dt.Rows[0]["city"];
					retObj._stateProvince					 = Convert.IsDBNull(dt.Rows[0]["state_province"]) ? null : (string)dt.Rows[0]["state_province"];
					retObj._zipPostalCode					 = Convert.IsDBNull(dt.Rows[0]["zip_postal_code"]) ? null : (string)dt.Rows[0]["zip_postal_code"];
					retObj._countryRegion					 = Convert.IsDBNull(dt.Rows[0]["country_region"]) ? null : (string)dt.Rows[0]["country_region"];
					retObj._webPage					 = Convert.IsDBNull(dt.Rows[0]["web_page"]) ? null : (string)dt.Rows[0]["web_page"];
					retObj._notes					 = Convert.IsDBNull(dt.Rows[0]["notes"]) ? null : (string)dt.Rows[0]["notes"];
					retObj._attachments					 = Convert.IsDBNull(dt.Rows[0]["attachments"]) ? null : (byte[])dt.Rows[0]["attachments"];
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
		///this method allows the object to delete itself from the table employees based on its primary key
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
			command.CommandText = "ctpr_employees_deleteone";
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
		///This method saves a new object to the table employees
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
			command.CommandText = "ctpr_employees_insertone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_ADDRESS", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_address?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_WEB_PAGE", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_webPage?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_NOTES", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_notes?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_İD", MySqlDbType.VarChar, 0, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _id));
				command.Parameters.Add(new MySqlParameter("?P_COMPANY", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _company));
				command.Parameters.Add(new MySqlParameter("?P_LAST_NAME", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _lastName));
				command.Parameters.Add(new MySqlParameter("?P_FİRST_NAME", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _firstName));
				command.Parameters.Add(new MySqlParameter("?P_EMAİL_ADDRESS", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _emailAddress));
				command.Parameters.Add(new MySqlParameter("?P_JOB_TİTLE", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _jobTitle));
				command.Parameters.Add(new MySqlParameter("?P_BUSİNESS_PHONE", MySqlDbType.VarChar, 75, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _businessPhone));
				command.Parameters.Add(new MySqlParameter("?P_HOME_PHONE", MySqlDbType.VarChar, 75, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _homePhone));
				command.Parameters.Add(new MySqlParameter("?P_MOBİLE_PHONE", MySqlDbType.VarChar, 75, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _mobilePhone));
				command.Parameters.Add(new MySqlParameter("?P_FAX_NUMBER", MySqlDbType.VarChar, 75, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _faxNumber));
				command.Parameters.Add(new MySqlParameter("?P_CİTY", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _city));
				command.Parameters.Add(new MySqlParameter("?P_STATE_PROVİNCE", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _stateProvince));
				command.Parameters.Add(new MySqlParameter("?P_ZİP_POSTAL_CODE", MySqlDbType.VarChar, 45, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _zipPostalCode));
				command.Parameters.Add(new MySqlParameter("?P_COUNTRY_REGİON", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _countryRegion));
				command.Parameters.Add(new MySqlParameter("?P_ATTACHMENTS", MySqlDbType.LongBlob, -1, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _attachments));
				command.Parameters.Add(new MySqlParameter("?P_CTR_VERSİON", MySqlDbType.VarChar, 5, ParameterDirection.Output, true, 5, 0, "", DataRowVersion.Proposed, _ctrVersion));

				command.ExecuteNonQuery();
				Done(this);

				_id					 = Convert.IsDBNull(command.Parameters["?P_İD"].Value) ? null : (string)command.Parameters["?P_İD"].Value;
				_company					 = Convert.IsDBNull(command.Parameters["?P_COMPANY"].Value) ? null : (string)command.Parameters["?P_COMPANY"].Value;
				_lastName					 = Convert.IsDBNull(command.Parameters["?P_LAST_NAME"].Value) ? null : (string)command.Parameters["?P_LAST_NAME"].Value;
				_firstName					 = Convert.IsDBNull(command.Parameters["?P_FİRST_NAME"].Value) ? null : (string)command.Parameters["?P_FİRST_NAME"].Value;
				_emailAddress					 = Convert.IsDBNull(command.Parameters["?P_EMAİL_ADDRESS"].Value) ? null : (string)command.Parameters["?P_EMAİL_ADDRESS"].Value;
				_jobTitle					 = Convert.IsDBNull(command.Parameters["?P_JOB_TİTLE"].Value) ? null : (string)command.Parameters["?P_JOB_TİTLE"].Value;
				_businessPhone					 = Convert.IsDBNull(command.Parameters["?P_BUSİNESS_PHONE"].Value) ? null : (string)command.Parameters["?P_BUSİNESS_PHONE"].Value;
				_homePhone					 = Convert.IsDBNull(command.Parameters["?P_HOME_PHONE"].Value) ? null : (string)command.Parameters["?P_HOME_PHONE"].Value;
				_mobilePhone					 = Convert.IsDBNull(command.Parameters["?P_MOBİLE_PHONE"].Value) ? null : (string)command.Parameters["?P_MOBİLE_PHONE"].Value;
				_faxNumber					 = Convert.IsDBNull(command.Parameters["?P_FAX_NUMBER"].Value) ? null : (string)command.Parameters["?P_FAX_NUMBER"].Value;
				_city					 = Convert.IsDBNull(command.Parameters["?P_CİTY"].Value) ? null : (string)command.Parameters["?P_CİTY"].Value;
				_stateProvince					 = Convert.IsDBNull(command.Parameters["?P_STATE_PROVİNCE"].Value) ? null : (string)command.Parameters["?P_STATE_PROVİNCE"].Value;
				_zipPostalCode					 = Convert.IsDBNull(command.Parameters["?P_ZİP_POSTAL_CODE"].Value) ? null : (string)command.Parameters["?P_ZİP_POSTAL_CODE"].Value;
				_countryRegion					 = Convert.IsDBNull(command.Parameters["?P_COUNTRY_REGİON"].Value) ? null : (string)command.Parameters["?P_COUNTRY_REGİON"].Value;
				_attachments					 = Convert.IsDBNull(command.Parameters["?P_ATTACHMENTS"].Value) ? null : (byte[])command.Parameters["?P_ATTACHMENTS"].Value;
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
		///This method returns all data rows in the table employees
		///</Summary>
		///<returns>
		///List-IDAOEmployees.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static List<IDAOEmployees> SelectAll()
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_employees_getall";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("employees");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOEmployees> objList = new List<IDAOEmployees>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOEmployees retObj = new DAOEmployees();
						retObj._id					 = Convert.IsDBNull(row["id"]) ? null : (string)row["id"];
						retObj._company					 = Convert.IsDBNull(row["company"]) ? null : (string)row["company"];
						retObj._lastName					 = Convert.IsDBNull(row["last_name"]) ? null : (string)row["last_name"];
						retObj._firstName					 = Convert.IsDBNull(row["first_name"]) ? null : (string)row["first_name"];
						retObj._emailAddress					 = Convert.IsDBNull(row["email_address"]) ? null : (string)row["email_address"];
						retObj._jobTitle					 = Convert.IsDBNull(row["job_title"]) ? null : (string)row["job_title"];
						retObj._businessPhone					 = Convert.IsDBNull(row["business_phone"]) ? null : (string)row["business_phone"];
						retObj._homePhone					 = Convert.IsDBNull(row["home_phone"]) ? null : (string)row["home_phone"];
						retObj._mobilePhone					 = Convert.IsDBNull(row["mobile_phone"]) ? null : (string)row["mobile_phone"];
						retObj._faxNumber					 = Convert.IsDBNull(row["fax_number"]) ? null : (string)row["fax_number"];
						retObj._address					 = Convert.IsDBNull(row["address"]) ? null : (string)row["address"];
						retObj._city					 = Convert.IsDBNull(row["city"]) ? null : (string)row["city"];
						retObj._stateProvince					 = Convert.IsDBNull(row["state_province"]) ? null : (string)row["state_province"];
						retObj._zipPostalCode					 = Convert.IsDBNull(row["zip_postal_code"]) ? null : (string)row["zip_postal_code"];
						retObj._countryRegion					 = Convert.IsDBNull(row["country_region"]) ? null : (string)row["country_region"];
						retObj._webPage					 = Convert.IsDBNull(row["web_page"]) ? null : (string)row["web_page"];
						retObj._notes					 = Convert.IsDBNull(row["notes"]) ? null : (string)row["notes"];
						retObj._attachments					 = Convert.IsDBNull(row["attachments"]) ? null : (byte[])row["attachments"];
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
			command.CommandText = "ctpr_employees_getallcount";
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
		///This method returns specific fields of all data rows in the table using criteriaquery apiemployees
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
			command.CommandText = "ctpr_employees_getbyprojection";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("employees");
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
						if (string.Compare(projection.Member, "company", true) == 0) lst.Add(Convert.IsDBNull(row["company"]) ? null : (string)row["company"]);
						if (string.Compare(projection.Member, "last_name", true) == 0) lst.Add(Convert.IsDBNull(row["last_name"]) ? null : (string)row["last_name"]);
						if (string.Compare(projection.Member, "first_name", true) == 0) lst.Add(Convert.IsDBNull(row["first_name"]) ? null : (string)row["first_name"]);
						if (string.Compare(projection.Member, "email_address", true) == 0) lst.Add(Convert.IsDBNull(row["email_address"]) ? null : (string)row["email_address"]);
						if (string.Compare(projection.Member, "job_title", true) == 0) lst.Add(Convert.IsDBNull(row["job_title"]) ? null : (string)row["job_title"]);
						if (string.Compare(projection.Member, "business_phone", true) == 0) lst.Add(Convert.IsDBNull(row["business_phone"]) ? null : (string)row["business_phone"]);
						if (string.Compare(projection.Member, "home_phone", true) == 0) lst.Add(Convert.IsDBNull(row["home_phone"]) ? null : (string)row["home_phone"]);
						if (string.Compare(projection.Member, "mobile_phone", true) == 0) lst.Add(Convert.IsDBNull(row["mobile_phone"]) ? null : (string)row["mobile_phone"]);
						if (string.Compare(projection.Member, "fax_number", true) == 0) lst.Add(Convert.IsDBNull(row["fax_number"]) ? null : (string)row["fax_number"]);
						if (string.Compare(projection.Member, "address", true) == 0) lst.Add(Convert.IsDBNull(row["address"]) ? null : (string)row["address"]);
						if (string.Compare(projection.Member, "city", true) == 0) lst.Add(Convert.IsDBNull(row["city"]) ? null : (string)row["city"]);
						if (string.Compare(projection.Member, "state_province", true) == 0) lst.Add(Convert.IsDBNull(row["state_province"]) ? null : (string)row["state_province"]);
						if (string.Compare(projection.Member, "zip_postal_code", true) == 0) lst.Add(Convert.IsDBNull(row["zip_postal_code"]) ? null : (string)row["zip_postal_code"]);
						if (string.Compare(projection.Member, "country_region", true) == 0) lst.Add(Convert.IsDBNull(row["country_region"]) ? null : (string)row["country_region"]);
						if (string.Compare(projection.Member, "web_page", true) == 0) lst.Add(Convert.IsDBNull(row["web_page"]) ? null : (string)row["web_page"]);
						if (string.Compare(projection.Member, "notes", true) == 0) lst.Add(Convert.IsDBNull(row["notes"]) ? null : (string)row["notes"]);
						if (string.Compare(projection.Member, "attachments", true) == 0) lst.Add(Convert.IsDBNull(row["attachments"]) ? null : (byte[])row["attachments"]);
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
		///This method returns all data rows in the table using criteriaquery api employees
		///</Summary>
		///<returns>
		///List-IDAOEmployees.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static List<IDAOEmployees> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_employees_getbycriteria";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("employees");
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


				List<IDAOEmployees> objList = new List<IDAOEmployees>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOEmployees retObj = new DAOEmployees();
						retObj._id					 = Convert.IsDBNull(row["id"]) ? null : (string)row["id"];
						retObj._company					 = Convert.IsDBNull(row["company"]) ? null : (string)row["company"];
						retObj._lastName					 = Convert.IsDBNull(row["last_name"]) ? null : (string)row["last_name"];
						retObj._firstName					 = Convert.IsDBNull(row["first_name"]) ? null : (string)row["first_name"];
						retObj._emailAddress					 = Convert.IsDBNull(row["email_address"]) ? null : (string)row["email_address"];
						retObj._jobTitle					 = Convert.IsDBNull(row["job_title"]) ? null : (string)row["job_title"];
						retObj._businessPhone					 = Convert.IsDBNull(row["business_phone"]) ? null : (string)row["business_phone"];
						retObj._homePhone					 = Convert.IsDBNull(row["home_phone"]) ? null : (string)row["home_phone"];
						retObj._mobilePhone					 = Convert.IsDBNull(row["mobile_phone"]) ? null : (string)row["mobile_phone"];
						retObj._faxNumber					 = Convert.IsDBNull(row["fax_number"]) ? null : (string)row["fax_number"];
						retObj._address					 = Convert.IsDBNull(row["address"]) ? null : (string)row["address"];
						retObj._city					 = Convert.IsDBNull(row["city"]) ? null : (string)row["city"];
						retObj._stateProvince					 = Convert.IsDBNull(row["state_province"]) ? null : (string)row["state_province"];
						retObj._zipPostalCode					 = Convert.IsDBNull(row["zip_postal_code"]) ? null : (string)row["zip_postal_code"];
						retObj._countryRegion					 = Convert.IsDBNull(row["country_region"]) ? null : (string)row["country_region"];
						retObj._webPage					 = Convert.IsDBNull(row["web_page"]) ? null : (string)row["web_page"];
						retObj._notes					 = Convert.IsDBNull(row["notes"]) ? null : (string)row["notes"];
						retObj._attachments					 = Convert.IsDBNull(row["attachments"]) ? null : (byte[])row["attachments"];
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
		///This method returns all data rows in the table using criteriaquery api employees
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
			command.CommandText = "ctpr_employees_getbycriteriacount";
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
		///This method allows the object to update itself in the table employees based on its primary key(s)
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
			command.CommandText = "ctpr_employees_updateone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_ADDRESS", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_address?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_WEB_PAGE", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_webPage?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_NOTES", MySqlDbType.LongText, -1, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_notes?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_İD", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _id));
				command.Parameters.Add(new MySqlParameter("?P_COMPANY", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _company));
				command.Parameters.Add(new MySqlParameter("?P_LAST_NAME", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _lastName));
				command.Parameters.Add(new MySqlParameter("?P_FİRST_NAME", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _firstName));
				command.Parameters.Add(new MySqlParameter("?P_EMAİL_ADDRESS", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _emailAddress));
				command.Parameters.Add(new MySqlParameter("?P_JOB_TİTLE", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _jobTitle));
				command.Parameters.Add(new MySqlParameter("?P_BUSİNESS_PHONE", MySqlDbType.VarChar, 75, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _businessPhone));
				command.Parameters.Add(new MySqlParameter("?P_HOME_PHONE", MySqlDbType.VarChar, 75, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _homePhone));
				command.Parameters.Add(new MySqlParameter("?P_MOBİLE_PHONE", MySqlDbType.VarChar, 75, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _mobilePhone));
				command.Parameters.Add(new MySqlParameter("?P_FAX_NUMBER", MySqlDbType.VarChar, 75, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _faxNumber));
				command.Parameters.Add(new MySqlParameter("?P_CİTY", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _city));
				command.Parameters.Add(new MySqlParameter("?P_STATE_PROVİNCE", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _stateProvince));
				command.Parameters.Add(new MySqlParameter("?P_ZİP_POSTAL_CODE", MySqlDbType.VarChar, 45, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _zipPostalCode));
				command.Parameters.Add(new MySqlParameter("?P_COUNTRY_REGİON", MySqlDbType.VarChar, 150, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _countryRegion));
				command.Parameters.Add(new MySqlParameter("?P_ATTACHMENTS", MySqlDbType.LongBlob, -1, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _attachments));
				command.Parameters.Add(new MySqlParameter("?P_CTR_VERSİON", MySqlDbType.VarChar, 5, ParameterDirection.InputOutput, true, 5, 0, "", DataRowVersion.Proposed, _ctrVersion));

				command.ExecuteNonQuery();
				Done(this);

				_id					 = Convert.IsDBNull(command.Parameters["?P_İD"].Value) ? null : (string)command.Parameters["?P_İD"].Value;
				_company					 = Convert.IsDBNull(command.Parameters["?P_COMPANY"].Value) ? null : (string)command.Parameters["?P_COMPANY"].Value;
				_lastName					 = Convert.IsDBNull(command.Parameters["?P_LAST_NAME"].Value) ? null : (string)command.Parameters["?P_LAST_NAME"].Value;
				_firstName					 = Convert.IsDBNull(command.Parameters["?P_FİRST_NAME"].Value) ? null : (string)command.Parameters["?P_FİRST_NAME"].Value;
				_emailAddress					 = Convert.IsDBNull(command.Parameters["?P_EMAİL_ADDRESS"].Value) ? null : (string)command.Parameters["?P_EMAİL_ADDRESS"].Value;
				_jobTitle					 = Convert.IsDBNull(command.Parameters["?P_JOB_TİTLE"].Value) ? null : (string)command.Parameters["?P_JOB_TİTLE"].Value;
				_businessPhone					 = Convert.IsDBNull(command.Parameters["?P_BUSİNESS_PHONE"].Value) ? null : (string)command.Parameters["?P_BUSİNESS_PHONE"].Value;
				_homePhone					 = Convert.IsDBNull(command.Parameters["?P_HOME_PHONE"].Value) ? null : (string)command.Parameters["?P_HOME_PHONE"].Value;
				_mobilePhone					 = Convert.IsDBNull(command.Parameters["?P_MOBİLE_PHONE"].Value) ? null : (string)command.Parameters["?P_MOBİLE_PHONE"].Value;
				_faxNumber					 = Convert.IsDBNull(command.Parameters["?P_FAX_NUMBER"].Value) ? null : (string)command.Parameters["?P_FAX_NUMBER"].Value;
				_city					 = Convert.IsDBNull(command.Parameters["?P_CİTY"].Value) ? null : (string)command.Parameters["?P_CİTY"].Value;
				_stateProvince					 = Convert.IsDBNull(command.Parameters["?P_STATE_PROVİNCE"].Value) ? null : (string)command.Parameters["?P_STATE_PROVİNCE"].Value;
				_zipPostalCode					 = Convert.IsDBNull(command.Parameters["?P_ZİP_POSTAL_CODE"].Value) ? null : (string)command.Parameters["?P_ZİP_POSTAL_CODE"].Value;
				_countryRegion					 = Convert.IsDBNull(command.Parameters["?P_COUNTRY_REGİON"].Value) ? null : (string)command.Parameters["?P_COUNTRY_REGİON"].Value;
				_attachments					 = Convert.IsDBNull(command.Parameters["?P_ATTACHMENTS"].Value) ? null : (byte[])command.Parameters["?P_ATTACHMENTS"].Value;
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
		public string Company
		{
			get
			{
				return _company;
			}
			set
			{
				_company = value;
			}
		}
		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				_lastName = value;
			}
		}
		public string FirstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				_firstName = value;
			}
		}
		public string EmailAddress
		{
			get
			{
				return _emailAddress;
			}
			set
			{
				_emailAddress = value;
			}
		}
		public string JobTitle
		{
			get
			{
				return _jobTitle;
			}
			set
			{
				_jobTitle = value;
			}
		}
		public string BusinessPhone
		{
			get
			{
				return _businessPhone;
			}
			set
			{
				_businessPhone = value;
			}
		}
		public string HomePhone
		{
			get
			{
				return _homePhone;
			}
			set
			{
				_homePhone = value;
			}
		}
		public string MobilePhone
		{
			get
			{
				return _mobilePhone;
			}
			set
			{
				_mobilePhone = value;
			}
		}
		public string FaxNumber
		{
			get
			{
				return _faxNumber;
			}
			set
			{
				_faxNumber = value;
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
		public string StateProvince
		{
			get
			{
				return _stateProvince;
			}
			set
			{
				_stateProvince = value;
			}
		}
		public string ZipPostalCode
		{
			get
			{
				return _zipPostalCode;
			}
			set
			{
				_zipPostalCode = value;
			}
		}
		public string CountryRegion
		{
			get
			{
				return _countryRegion;
			}
			set
			{
				_countryRegion = value;
			}
		}
		public string WebPage
		{
			get
			{
				return _webPage;
			}
			set
			{
				_webPage = value;
			}
		}
		public string Notes
		{
			get
			{
				return _notes;
			}
			set
			{
				_notes = value;
			}
		}
		public byte[] Attachments
		{
			get
			{
				return _attachments;
			}
			set
			{
				_attachments = value;
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
