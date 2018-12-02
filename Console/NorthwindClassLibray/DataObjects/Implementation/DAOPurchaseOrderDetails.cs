/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 12:15:59
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using NorthwindClassLibrary.DataObjects.Interfaces;

namespace NorthwindClassLibrary.DataObjects
{
	public partial class DAOPurchaseOrderDetails : zNorthwindClassLibrayConn_BaseData, IDAOPurchaseOrderDetails
	{
		#region member variables
		protected string _id;
		protected string _purchaseOrderId;
		protected string _productId;
		protected string _quantity;
		protected string _unitCost;
		protected string _dateReceived;
		protected string _postedToInventory;
		protected string _inventoryId;
		protected string _ctrVersion;
		#endregion

		#region class methods
		public DAOPurchaseOrderDetails()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table purchase_order_details based on the primary key(s)
		///</Summary>
		///<returns>
		///IDAOPurchaseOrderDetails
		///</returns>
		///<parameters>
		///string id
		///</parameters>
		public static IDAOPurchaseOrderDetails SelectOne(string id)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_getone";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("purchase_order_details");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new MySqlParameter("?P_ID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)id?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				DAOPurchaseOrderDetails retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAOPurchaseOrderDetails();
					retObj._id					 = Convert.IsDBNull(dt.Rows[0]["id"]) ? null : (string)dt.Rows[0]["id"];
					retObj._purchaseOrderId					 = Convert.IsDBNull(dt.Rows[0]["purchase_order_id"]) ? null : (string)dt.Rows[0]["purchase_order_id"];
					retObj._productId					 = Convert.IsDBNull(dt.Rows[0]["product_id"]) ? null : (string)dt.Rows[0]["product_id"];
					retObj._quantity					 = Convert.IsDBNull(dt.Rows[0]["quantity"]) ? null : (string)dt.Rows[0]["quantity"];
					retObj._unitCost					 = Convert.IsDBNull(dt.Rows[0]["unit_cost"]) ? null : (string)dt.Rows[0]["unit_cost"];
					retObj._dateReceived					 = Convert.IsDBNull(dt.Rows[0]["date_received"]) ? null : (string)dt.Rows[0]["date_received"];
					retObj._postedToInventory					 = Convert.IsDBNull(dt.Rows[0]["posted_to_inventory"]) ? null : (string)dt.Rows[0]["posted_to_inventory"];
					retObj._inventoryId					 = Convert.IsDBNull(dt.Rows[0]["inventory_id"]) ? null : (string)dt.Rows[0]["inventory_id"];
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
		///this method allows the object to delete itself from the table purchase_order_details based on its primary key
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
			command.CommandText = "ctpr_purchase_order_details_deleteone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_ID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)_id?? (object)DBNull.Value));

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
		///This method returns all data rows in the table purchase_order_details based on a foreign key
		///</Summary>
		///<returns>
		///List-IDAOPurchaseOrderDetails.
		///</returns>
		///<parameters>
		///string purchaseOrderId
		///</parameters>
		public static List<IDAOPurchaseOrderDetails> SelectAllByPurchaseOrderId(string purchaseOrderId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_getbypurchaseorderid";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("purchase_order_details");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new MySqlParameter("?P_PURCHASE_ORDER_ID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)purchaseOrderId?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOPurchaseOrderDetails> objList = new List<IDAOPurchaseOrderDetails>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOPurchaseOrderDetails retObj = new DAOPurchaseOrderDetails();
						retObj._id					 = Convert.IsDBNull(row["id"]) ? null : (string)row["id"];
						retObj._purchaseOrderId					 = Convert.IsDBNull(row["purchase_order_id"]) ? null : (string)row["purchase_order_id"];
						retObj._productId					 = Convert.IsDBNull(row["product_id"]) ? null : (string)row["product_id"];
						retObj._quantity					 = Convert.IsDBNull(row["quantity"]) ? null : (string)row["quantity"];
						retObj._unitCost					 = Convert.IsDBNull(row["unit_cost"]) ? null : (string)row["unit_cost"];
						retObj._dateReceived					 = Convert.IsDBNull(row["date_received"]) ? null : (string)row["date_received"];
						retObj._postedToInventory					 = Convert.IsDBNull(row["posted_to_inventory"]) ? null : (string)row["posted_to_inventory"];
						retObj._inventoryId					 = Convert.IsDBNull(row["inventory_id"]) ? null : (string)row["inventory_id"];
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
		///string purchaseOrderId
		///</parameters>
		public static Int32 SelectAllByPurchaseOrderIdCount(string purchaseOrderId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_getbypurchaseorderidcount";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_PURCHASE_ORDER_ID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)purchaseOrderId?? (object)DBNull.Value));

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
		///This method deletes all rows in the table purchase_order_details with a given foreign key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///IzNorthwindClassLibrayConn_TxConnectionProvider connectionProvider, string purchaseOrderId
		///</parameters>
		public static void DeleteAllByPurchaseOrderId(IzNorthwindClassLibrayConn_TxConnectionProvider connectionProvider, string purchaseOrderId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_deletebypurchaseorderid";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = connectionProvider.Connection;
			command.Transaction = connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_PURCHASE_ORDER_ID", MySqlDbType.VarChar, 0, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)purchaseOrderId?? (object)DBNull.Value));

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
		///This method returns all data rows in the table purchase_order_details based on a foreign key
		///</Summary>
		///<returns>
		///List-IDAOPurchaseOrderDetails.
		///</returns>
		///<parameters>
		///string productId
		///</parameters>
		public static List<IDAOPurchaseOrderDetails> SelectAllByProductId(string productId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_getbyproductid";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("purchase_order_details");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new MySqlParameter("?P_PRODUCT_ID", MySqlDbType.VarChar, 0, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)productId?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOPurchaseOrderDetails> objList = new List<IDAOPurchaseOrderDetails>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOPurchaseOrderDetails retObj = new DAOPurchaseOrderDetails();
						retObj._id					 = Convert.IsDBNull(row["id"]) ? null : (string)row["id"];
						retObj._purchaseOrderId					 = Convert.IsDBNull(row["purchase_order_id"]) ? null : (string)row["purchase_order_id"];
						retObj._productId					 = Convert.IsDBNull(row["product_id"]) ? null : (string)row["product_id"];
						retObj._quantity					 = Convert.IsDBNull(row["quantity"]) ? null : (string)row["quantity"];
						retObj._unitCost					 = Convert.IsDBNull(row["unit_cost"]) ? null : (string)row["unit_cost"];
						retObj._dateReceived					 = Convert.IsDBNull(row["date_received"]) ? null : (string)row["date_received"];
						retObj._postedToInventory					 = Convert.IsDBNull(row["posted_to_inventory"]) ? null : (string)row["posted_to_inventory"];
						retObj._inventoryId					 = Convert.IsDBNull(row["inventory_id"]) ? null : (string)row["inventory_id"];
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
		///string productId
		///</parameters>
		public static Int32 SelectAllByProductIdCount(string productId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_getbyproductidcount";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_PRODUCT_ID", MySqlDbType.VarChar, 0, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)productId?? (object)DBNull.Value));

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
		///This method deletes all rows in the table purchase_order_details with a given foreign key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///IzNorthwindClassLibrayConn_TxConnectionProvider connectionProvider, string productId
		///</parameters>
		public static void DeleteAllByProductId(IzNorthwindClassLibrayConn_TxConnectionProvider connectionProvider, string productId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_deletebyproductid";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = connectionProvider.Connection;
			command.Transaction = connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_PRODUCT_ID", MySqlDbType.VarChar, 0, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)productId?? (object)DBNull.Value));

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
		///This method returns all data rows in the table purchase_order_details based on a foreign key
		///</Summary>
		///<returns>
		///List-IDAOPurchaseOrderDetails.
		///</returns>
		///<parameters>
		///string inventoryId
		///</parameters>
		public static List<IDAOPurchaseOrderDetails> SelectAllByInventoryId(string inventoryId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_getbyinventoryid";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("purchase_order_details");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new MySqlParameter("?P_INVENTORY_ID", MySqlDbType.VarChar, 0, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)inventoryId?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOPurchaseOrderDetails> objList = new List<IDAOPurchaseOrderDetails>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOPurchaseOrderDetails retObj = new DAOPurchaseOrderDetails();
						retObj._id					 = Convert.IsDBNull(row["id"]) ? null : (string)row["id"];
						retObj._purchaseOrderId					 = Convert.IsDBNull(row["purchase_order_id"]) ? null : (string)row["purchase_order_id"];
						retObj._productId					 = Convert.IsDBNull(row["product_id"]) ? null : (string)row["product_id"];
						retObj._quantity					 = Convert.IsDBNull(row["quantity"]) ? null : (string)row["quantity"];
						retObj._unitCost					 = Convert.IsDBNull(row["unit_cost"]) ? null : (string)row["unit_cost"];
						retObj._dateReceived					 = Convert.IsDBNull(row["date_received"]) ? null : (string)row["date_received"];
						retObj._postedToInventory					 = Convert.IsDBNull(row["posted_to_inventory"]) ? null : (string)row["posted_to_inventory"];
						retObj._inventoryId					 = Convert.IsDBNull(row["inventory_id"]) ? null : (string)row["inventory_id"];
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
		///string inventoryId
		///</parameters>
		public static Int32 SelectAllByInventoryIdCount(string inventoryId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_getbyinventoryidcount";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_INVENTORY_ID", MySqlDbType.VarChar, 0, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)inventoryId?? (object)DBNull.Value));

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
		///This method deletes all rows in the table purchase_order_details with a given foreign key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///IzNorthwindClassLibrayConn_TxConnectionProvider connectionProvider, string inventoryId
		///</parameters>
		public static void DeleteAllByInventoryId(IzNorthwindClassLibrayConn_TxConnectionProvider connectionProvider, string inventoryId)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_deletebyinventoryid";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = connectionProvider.Connection;
			command.Transaction = connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_INVENTORY_ID", MySqlDbType.VarChar, 0, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)inventoryId?? (object)DBNull.Value));

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
		///This method saves a new object to the table purchase_order_details
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
			command.CommandText = "ctpr_purchase_order_details_insertone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_ID", MySqlDbType.VarChar, 0, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _id));
				command.Parameters.Add(new MySqlParameter("?P_PURCHASE_ORDER_ID", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _purchaseOrderId));
				command.Parameters.Add(new MySqlParameter("?P_PRODUCT_ID", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _productId));
				command.Parameters.Add(new MySqlParameter("?P_QUANTITY", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 18, 4, "", DataRowVersion.Proposed, _quantity));
				command.Parameters.Add(new MySqlParameter("?P_UNIT_COST", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 19, 4, "", DataRowVersion.Proposed, _unitCost));
				command.Parameters.Add(new MySqlParameter("?P_DATE_RECEIVED", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _dateReceived));
				command.Parameters.Add(new MySqlParameter("?P_POSTED_TO_INVENTORY", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 3, 0, "", DataRowVersion.Proposed, _postedToInventory));
				command.Parameters.Add(new MySqlParameter("?P_INVENTORY_ID", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _inventoryId));
				command.Parameters.Add(new MySqlParameter("?P_CTR_VERSION", MySqlDbType.VarChar, 5, ParameterDirection.Output, true, 5, 0, "", DataRowVersion.Proposed, _ctrVersion));

				command.ExecuteNonQuery();
				Done(this);

				_id					 = Convert.IsDBNull(command.Parameters["?P_ID"].Value) ? null : (string)command.Parameters["?P_ID"].Value;
				_purchaseOrderId					 = Convert.IsDBNull(command.Parameters["?P_PURCHASE_ORDER_ID"].Value) ? null : (string)command.Parameters["?P_PURCHASE_ORDER_ID"].Value;
				_productId					 = Convert.IsDBNull(command.Parameters["?P_PRODUCT_ID"].Value) ? null : (string)command.Parameters["?P_PRODUCT_ID"].Value;
				_quantity					 = Convert.IsDBNull(command.Parameters["?P_QUANTITY"].Value) ? null : (string)command.Parameters["?P_QUANTITY"].Value;
				_unitCost					 = Convert.IsDBNull(command.Parameters["?P_UNIT_COST"].Value) ? null : (string)command.Parameters["?P_UNIT_COST"].Value;
				_dateReceived					 = Convert.IsDBNull(command.Parameters["?P_DATE_RECEIVED"].Value) ? null : (string)command.Parameters["?P_DATE_RECEIVED"].Value;
				_postedToInventory					 = Convert.IsDBNull(command.Parameters["?P_POSTED_TO_INVENTORY"].Value) ? null : (string)command.Parameters["?P_POSTED_TO_INVENTORY"].Value;
				_inventoryId					 = Convert.IsDBNull(command.Parameters["?P_INVENTORY_ID"].Value) ? null : (string)command.Parameters["?P_INVENTORY_ID"].Value;
				_ctrVersion					 = Convert.IsDBNull(command.Parameters["?P_CTR_VERSION"].Value) ? null : (string)command.Parameters["?P_CTR_VERSION"].Value;

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
		///This method returns all data rows in the table purchase_order_details
		///</Summary>
		///<returns>
		///List-IDAOPurchaseOrderDetails.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static List<IDAOPurchaseOrderDetails> SelectAll()
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_getall";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("purchase_order_details");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOPurchaseOrderDetails> objList = new List<IDAOPurchaseOrderDetails>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOPurchaseOrderDetails retObj = new DAOPurchaseOrderDetails();
						retObj._id					 = Convert.IsDBNull(row["id"]) ? null : (string)row["id"];
						retObj._purchaseOrderId					 = Convert.IsDBNull(row["purchase_order_id"]) ? null : (string)row["purchase_order_id"];
						retObj._productId					 = Convert.IsDBNull(row["product_id"]) ? null : (string)row["product_id"];
						retObj._quantity					 = Convert.IsDBNull(row["quantity"]) ? null : (string)row["quantity"];
						retObj._unitCost					 = Convert.IsDBNull(row["unit_cost"]) ? null : (string)row["unit_cost"];
						retObj._dateReceived					 = Convert.IsDBNull(row["date_received"]) ? null : (string)row["date_received"];
						retObj._postedToInventory					 = Convert.IsDBNull(row["posted_to_inventory"]) ? null : (string)row["posted_to_inventory"];
						retObj._inventoryId					 = Convert.IsDBNull(row["inventory_id"]) ? null : (string)row["inventory_id"];
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
			command.CommandText = "ctpr_purchase_order_details_getallcount";
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
		///This method returns specific fields of all data rows in the table using criteriaquery apipurchase_order_details
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
			command.CommandText = "ctpr_purchase_order_details_getbyprojection";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("purchase_order_details");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				string fieldsField = GetProjections(listProjection);
				string whereClause = GetSelectionCriteria(listCriterion);
				string orderClause = GetSelectionOrder(listOrder);
				string skipClause = GetSelectionSkip(dataSkip);
				string takeClause = GetSelectionTake(dataTake);
				command.Parameters.Add(new MySqlParameter("?P_SKIPCLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)skipClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_TAKECLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)takeClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_FIELDSFIELD", MySqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)fieldsField?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_WHERECLAUSE", MySqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)whereClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_ORDERCLAUSE", MySqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)orderClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_SKIPCLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)skipClause?? (object)DBNull.Value));
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
						if (string.Compare(projection.Member, "purchase_order_id", true) == 0) lst.Add(Convert.IsDBNull(row["purchase_order_id"]) ? null : (string)row["purchase_order_id"]);
						if (string.Compare(projection.Member, "product_id", true) == 0) lst.Add(Convert.IsDBNull(row["product_id"]) ? null : (string)row["product_id"]);
						if (string.Compare(projection.Member, "quantity", true) == 0) lst.Add(Convert.IsDBNull(row["quantity"]) ? null : (string)row["quantity"]);
						if (string.Compare(projection.Member, "unit_cost", true) == 0) lst.Add(Convert.IsDBNull(row["unit_cost"]) ? null : (string)row["unit_cost"]);
						if (string.Compare(projection.Member, "date_received", true) == 0) lst.Add(Convert.IsDBNull(row["date_received"]) ? null : (string)row["date_received"]);
						if (string.Compare(projection.Member, "posted_to_inventory", true) == 0) lst.Add(Convert.IsDBNull(row["posted_to_inventory"]) ? null : (string)row["posted_to_inventory"]);
						if (string.Compare(projection.Member, "inventory_id", true) == 0) lst.Add(Convert.IsDBNull(row["inventory_id"]) ? null : (string)row["inventory_id"]);
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
		///This method returns all data rows in the table using criteriaquery api purchase_order_details
		///</Summary>
		///<returns>
		///List-IDAOPurchaseOrderDetails.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static List<IDAOPurchaseOrderDetails> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			MySqlCommand	command = new MySqlCommand();
			command.CommandText = "ctpr_purchase_order_details_getbycriteria";
			command.CommandType = CommandType.StoredProcedure;
			MySqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("purchase_order_details");
			MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(command);
			try
			{
				string whereClause = GetSelectionCriteria(listCriterion);
				string orderClause = GetSelectionOrder(listOrder);
				string skipClause = GetSelectionSkip(dataSkip);
				string takeClause = GetSelectionTake(dataTake);
				command.Parameters.Add(new MySqlParameter("?P_SKIPCLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)skipClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_TAKECLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)takeClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_WHERECLAUSE", MySqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)whereClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_ORDERCLAUSE", MySqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)orderClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_SKIPCLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)skipClause?? (object)DBNull.Value));
				command.Parameters.Add(new MySqlParameter("?P_TAKECLAUSE", MySqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)takeClause?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);


				List<IDAOPurchaseOrderDetails> objList = new List<IDAOPurchaseOrderDetails>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOPurchaseOrderDetails retObj = new DAOPurchaseOrderDetails();
						retObj._id					 = Convert.IsDBNull(row["id"]) ? null : (string)row["id"];
						retObj._purchaseOrderId					 = Convert.IsDBNull(row["purchase_order_id"]) ? null : (string)row["purchase_order_id"];
						retObj._productId					 = Convert.IsDBNull(row["product_id"]) ? null : (string)row["product_id"];
						retObj._quantity					 = Convert.IsDBNull(row["quantity"]) ? null : (string)row["quantity"];
						retObj._unitCost					 = Convert.IsDBNull(row["unit_cost"]) ? null : (string)row["unit_cost"];
						retObj._dateReceived					 = Convert.IsDBNull(row["date_received"]) ? null : (string)row["date_received"];
						retObj._postedToInventory					 = Convert.IsDBNull(row["posted_to_inventory"]) ? null : (string)row["posted_to_inventory"];
						retObj._inventoryId					 = Convert.IsDBNull(row["inventory_id"]) ? null : (string)row["inventory_id"];
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
		///This method returns all data rows in the table using criteriaquery api purchase_order_details
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
			command.CommandText = "ctpr_purchase_order_details_getbycriteriacount";
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
		///This method allows the object to update itself in the table purchase_order_details based on its primary key(s)
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
			command.CommandText = "ctpr_purchase_order_details_updateone";
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = _connectionProvider.Connection;

			try
			{
				command.Parameters.Add(new MySqlParameter("?P_ID", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _id));
				command.Parameters.Add(new MySqlParameter("?P_PURCHASE_ORDER_ID", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _purchaseOrderId));
				command.Parameters.Add(new MySqlParameter("?P_PRODUCT_ID", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _productId));
				command.Parameters.Add(new MySqlParameter("?P_QUANTITY", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 18, 4, "", DataRowVersion.Proposed, _quantity));
				command.Parameters.Add(new MySqlParameter("?P_UNIT_COST", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 19, 4, "", DataRowVersion.Proposed, _unitCost));
				command.Parameters.Add(new MySqlParameter("?P_DATE_RECEIVED", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, _dateReceived));
				command.Parameters.Add(new MySqlParameter("?P_POSTED_TO_INVENTORY", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 3, 0, "", DataRowVersion.Proposed, _postedToInventory));
				command.Parameters.Add(new MySqlParameter("?P_INVENTORY_ID", MySqlDbType.VarChar, 0, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, _inventoryId));
				command.Parameters.Add(new MySqlParameter("?P_CTR_VERSION", MySqlDbType.VarChar, 5, ParameterDirection.InputOutput, true, 5, 0, "", DataRowVersion.Proposed, _ctrVersion));

				command.ExecuteNonQuery();
				Done(this);

				_id					 = Convert.IsDBNull(command.Parameters["?P_ID"].Value) ? null : (string)command.Parameters["?P_ID"].Value;
				_purchaseOrderId					 = Convert.IsDBNull(command.Parameters["?P_PURCHASE_ORDER_ID"].Value) ? null : (string)command.Parameters["?P_PURCHASE_ORDER_ID"].Value;
				_productId					 = Convert.IsDBNull(command.Parameters["?P_PRODUCT_ID"].Value) ? null : (string)command.Parameters["?P_PRODUCT_ID"].Value;
				_quantity					 = Convert.IsDBNull(command.Parameters["?P_QUANTITY"].Value) ? null : (string)command.Parameters["?P_QUANTITY"].Value;
				_unitCost					 = Convert.IsDBNull(command.Parameters["?P_UNIT_COST"].Value) ? null : (string)command.Parameters["?P_UNIT_COST"].Value;
				_dateReceived					 = Convert.IsDBNull(command.Parameters["?P_DATE_RECEIVED"].Value) ? null : (string)command.Parameters["?P_DATE_RECEIVED"].Value;
				_postedToInventory					 = Convert.IsDBNull(command.Parameters["?P_POSTED_TO_INVENTORY"].Value) ? null : (string)command.Parameters["?P_POSTED_TO_INVENTORY"].Value;
				_inventoryId					 = Convert.IsDBNull(command.Parameters["?P_INVENTORY_ID"].Value) ? null : (string)command.Parameters["?P_INVENTORY_ID"].Value;
				_ctrVersion					 = Convert.IsDBNull(command.Parameters["?P_CTR_VERSION"].Value) ? null : (string)command.Parameters["?P_CTR_VERSION"].Value;

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
		public string Id
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
		public string PurchaseOrderId
		{
			get
			{
				return _purchaseOrderId;
			}
			set
			{
				_purchaseOrderId = value;
			}
		}
		public string ProductId
		{
			get
			{
				return _productId;
			}
			set
			{
				_productId = value;
			}
		}
		public string Quantity
		{
			get
			{
				return _quantity;
			}
			set
			{
				_quantity = value;
			}
		}
		public string UnitCost
		{
			get
			{
				return _unitCost;
			}
			set
			{
				_unitCost = value;
			}
		}
		public string DateReceived
		{
			get
			{
				return _dateReceived;
			}
			set
			{
				_dateReceived = value;
			}
		}
		public string PostedToInventory
		{
			get
			{
				return _postedToInventory;
			}
			set
			{
				_postedToInventory = value;
			}
		}
		public string InventoryId
		{
			get
			{
				return _inventoryId;
			}
			set
			{
				_inventoryId = value;
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