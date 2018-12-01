/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:26:30
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using NorthwindTest.DataObjects.Interfaces;

namespace NorthwindTest.DataObjects
{
	public partial class DAOCategories : zNorthwindTestConn_BaseData, IDAOCategories
	{
		#region member variables
		protected Int32? _categoryID;
		protected string _categoryName;
		protected string _description;
		protected byte[] _picture;
		protected Int32? _ctrVersion;
		#endregion

		#region class methods
		public DAOCategories()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table Categories based on the primary key(s)
		///</Summary>
		///<returns>
		///IDAOCategories
		///</returns>
		///<parameters>
		///Int32? categoryID
		///</parameters>
		public static IDAOCategories SelectOne(Int32? categoryID)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCategories_SelectOne;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Categories");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@CategoryID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)categoryID?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				DAOCategories retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAOCategories();
					retObj._categoryID					 = Convert.IsDBNull(dt.Rows[0]["CategoryID"]) ? (Int32?)null : (Int32?)dt.Rows[0]["CategoryID"];
					retObj._categoryName					 = Convert.IsDBNull(dt.Rows[0]["CategoryName"]) ? null : (string)dt.Rows[0]["CategoryName"];
					retObj._description					 = Convert.IsDBNull(dt.Rows[0]["Description"]) ? null : (string)dt.Rows[0]["Description"];
					retObj._picture					 = Convert.IsDBNull(dt.Rows[0]["Picture"]) ? null : (byte[])dt.Rows[0]["Picture"];
					retObj._ctrVersion					 = Convert.IsDBNull(dt.Rows[0]["ctr_version"]) ? (Int32?)null : (Int32?)dt.Rows[0]["ctr_version"];
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
		///this method allows the object to delete itself from the table Categories based on its primary key
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
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCategories_DeleteOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@CategoryID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)_categoryID?? (object)DBNull.Value));

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
		///This method saves a new object to the table Categories
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
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCategories_InsertOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Description", SqlDbType.NText, 8000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_description?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@Picture", SqlDbType.Image, 16, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_picture?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@CategoryID", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _categoryID));
				command.Parameters.Add(CtSqlParameter.Get("@CategoryName", SqlDbType.NVarChar, 15, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_categoryName?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ctr_version", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _ctrVersion));

				command.ExecuteNonQuery();
				Done(this);

				_categoryID					 = Convert.IsDBNull(command.Parameters["@CategoryID"].Value) ? (Int32?)null : (Int32?)command.Parameters["@CategoryID"].Value;
				_categoryName					 = Convert.IsDBNull(command.Parameters["@CategoryName"].Value) ? null : (string)command.Parameters["@CategoryName"].Value;
				_ctrVersion					 = Convert.IsDBNull(command.Parameters["@ctr_version"].Value) ? (Int32?)null : (Int32?)command.Parameters["@ctr_version"].Value;

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
		///This method returns all data rows in the table Categories
		///</Summary>
		///<returns>
		///IList-IDAOCategories.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IDAOCategories> SelectAll()
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCategories_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Categories");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOCategories> objList = new List<IDAOCategories>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOCategories retObj = new DAOCategories();
						retObj._categoryID					 = Convert.IsDBNull(row["CategoryID"]) ? (Int32?)null : (Int32?)row["CategoryID"];
						retObj._categoryName					 = Convert.IsDBNull(row["CategoryName"]) ? null : (string)row["CategoryName"];
						retObj._description					 = Convert.IsDBNull(row["Description"]) ? null : (string)row["Description"];
						retObj._picture					 = Convert.IsDBNull(row["Picture"]) ? null : (byte[])row["Picture"];
						retObj._ctrVersion					 = Convert.IsDBNull(row["ctr_version"]) ? (Int32?)null : (Int32?)row["ctr_version"];
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
			command.CommandText = InlineProcs.ctprCategories_SelectAllCount;
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
		///This method returns specific fields of all data rows in the table using criteriaquery apiCategories
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprCategories_SelectAllByCriteriaProjection, listProjection, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Categories");
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
						if (string.Compare(projection.Member, "CategoryID", true) == 0) lst.Add(Convert.IsDBNull(row["CategoryID"]) ? (Int32?)null : (Int32?)row["CategoryID"]);
						if (string.Compare(projection.Member, "CategoryName", true) == 0) lst.Add(Convert.IsDBNull(row["CategoryName"]) ? null : (string)row["CategoryName"]);
						if (string.Compare(projection.Member, "Description", true) == 0) lst.Add(Convert.IsDBNull(row["Description"]) ? null : (string)row["Description"]);
						if (string.Compare(projection.Member, "Picture", true) == 0) lst.Add(Convert.IsDBNull(row["Picture"]) ? null : (byte[])row["Picture"]);
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
		///This method returns all data rows in the table using criteriaquery api Categories
		///</Summary>
		///<returns>
		///IList-IDAOCategories.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IList<IDAOCategories> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprCategories_SelectAllByCriteria, null, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Categories");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOCategories> objList = new List<IDAOCategories>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOCategories retObj = new DAOCategories();
						retObj._categoryID					 = Convert.IsDBNull(row["CategoryID"]) ? (Int32?)null : (Int32?)row["CategoryID"];
						retObj._categoryName					 = Convert.IsDBNull(row["CategoryName"]) ? null : (string)row["CategoryName"];
						retObj._description					 = Convert.IsDBNull(row["Description"]) ? null : (string)row["Description"];
						retObj._picture					 = Convert.IsDBNull(row["Picture"]) ? null : (byte[])row["Picture"];
						retObj._ctrVersion					 = Convert.IsDBNull(row["ctr_version"]) ? (Int32?)null : (Int32?)row["ctr_version"];
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
		///This method returns all data rows in the table using criteriaquery api Categories
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprCategories_SelectAllByCriteriaCount, null, listCriterion, null);
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
		///Update one row by primary key(s)
		///This method allows the object to update itself in the table Categories based on its primary key(s)
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
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprCategories_UpdateOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Description", SqlDbType.NText, 8000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_description?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@Picture", SqlDbType.Image, 16, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)_picture?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@CategoryID", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_categoryID?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@CategoryName", SqlDbType.NVarChar, 15, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_categoryName?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ctr_version", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_ctrVersion?? (object)DBNull.Value));

				command.ExecuteNonQuery();
				Done(this);

				_categoryID					 = Convert.IsDBNull(command.Parameters["@CategoryID"].Value) ? (Int32?)null : (Int32?)command.Parameters["@CategoryID"].Value;
				_categoryName					 = Convert.IsDBNull(command.Parameters["@CategoryName"].Value) ? null : (string)command.Parameters["@CategoryName"].Value;
				_ctrVersion					 = Convert.IsDBNull(command.Parameters["@ctr_version"].Value) ? (Int32?)null : (Int32?)command.Parameters["@ctr_version"].Value;

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

		public Int32? CategoryID
		{
			get
			{
				return _categoryID;
			}
			set
			{
				_categoryID = value;
			}
		}

		public string CategoryName
		{
			get
			{
				return _categoryName;
			}
			set
			{
				_categoryName = value;
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}

		public byte[] Picture
		{
			get
			{
				return _picture;
			}
			set
			{
				_picture = value;
			}
		}

		public Int32? CtrVersion
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

#region inline sql procs
namespace NorthwindTest.DataObjects
{
	public partial class InlineProcs
	{
		internal static string ctprCategories_SelectOne = @"
			-- Select one row based on the primary key(s)
			-- selects all rows from the table
			SELECT 
			[CategoryID]
			,[CategoryName]
			,[Description]
			,[Picture]
			,[ctr_version]
			FROM [dbo].[Categories]
			WHERE 
			[CategoryID] = @CategoryID
			";

		internal static string ctprCategories_DeleteOne = @"
			-- Delete a row based on the primary key(s)
			-- delete all matching from the table
			DELETE [dbo].[Categories]
			WHERE 
			[CategoryID] = @CategoryID
			";

		internal static string ctprCategories_InsertOne = @"
			-- Insert a new row
			-- inserts a new row into the table
			INSERT [dbo].[Categories]
			(
			[CategoryName]
			,[Description]
			,[Picture]
			)
			VALUES
			(
			@CategoryName
			,@Description
			,@Picture
			)
			SELECT 
			@CategoryID = [CategoryID]
			,@CategoryName = [CategoryName]
			,@ctr_version = [ctr_version]
			FROM [dbo].[Categories]
			WHERE 
			[CategoryID] = SCOPE_IDENTITY()
			";

		internal static string ctprCategories_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[CategoryID]
			,[CategoryName]
			,[Description]
			,[Picture]
			,[ctr_version]
			FROM [dbo].[Categories]
			";

		internal static string ctprCategories_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[Categories]
			";

		internal static string ctprCategories_SelectAllByCriteriaProjection = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			##STARTFIELDS##
			##ENDFIELDS##
			FROM [dbo].[Categories]
			##CRITERIA##
			";

		internal static string ctprCategories_SelectAllByCriteria = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			[CategoryID]
			,[CategoryName]
			,[Description]
			,[Picture]
			,[ctr_version]
			FROM [dbo].[Categories]
			##CRITERIA##
			";

		internal static string ctprCategories_SelectAllByCriteriaCount = @"
			
			-- selects count of all rows from the table according to criteria
			SELECT COUNT(*)
			FROM [dbo].[Categories]
			##CRITERIA##
			";

		internal static string ctprCategories_UpdateOne = @"
			-- Update one row based on the primary key(s)
			-- updates a row in the table based on the primary key
			
			--data optimistic concurrency handling ----------------------------
			DECLARE @currVersion INT
			SELECT @currVersion = [ctr_version] FROM [dbo].[Categories]
			WHERE [CategoryID] = @CategoryID
			
			IF @currVersion > @ctr_version
			RAISERROR('data concurrency issue updating this record, possible stale data. %s', 16, 1, 
			'[dbo].[Categories] WHERE WHERE [CategoryID] = @CategoryID')
			
			IF @currVersion IS NULL
			RAISERROR('data concurrency issue updating this record, record not available (not found). %s', 16, 1, 
			'[dbo].[Categories] WHERE WHERE [CategoryID] = @CategoryID')
			
			SET @ctr_version = @currVersion  + 1 
			-------------------------------------------------------------------
			UPDATE [dbo].[Categories]
			SET
			[CategoryName] = @CategoryName
			,[Description] = @Description
			,[Picture] = @Picture
			,[ctr_version] = @ctr_version
			WHERE 
			[CategoryID] = @CategoryID
			SELECT 
			@CategoryID = [CategoryID]
			,@CategoryName = [CategoryName]
			,@ctr_version = [ctr_version]
			FROM [dbo].[Categories]
			WHERE 
			[CategoryID] = @CategoryID
			";

	}
}
#endregion
