/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:31:22
**************************************************************/

using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NorthwindTest3.DataObjects;

namespace NorthwindTest3.BusinessObjects
{
	public partial class zNorthwindTest3Conn_BaseBusiness : IDisposable
	{
		#region members
		bool _isDisposed = false;
		protected zNorthwindTest3Conn_TxConnectionProvider _txConnectionProvider;
		protected List<zNorthwindTest3Conn_BaseBusiness> _listBusObjects = new List<zNorthwindTest3Conn_BaseBusiness>();
		int _nestLevel;
		#endregion

		#region initialization
		public zNorthwindTest3Conn_BaseBusiness()
		{
			Init();
		}

		private void Init()
		{
			_nestLevel = 0;
			_txConnectionProvider = null;
		}
		
		protected virtual void RegisterDataObject(zNorthwindTest3Conn_BaseData dataObject)
		{
				if(_txConnectionProvider == null)
					_txConnectionProvider = new zNorthwindTest3Conn_TxConnectionProvider();
		
				if(dataObject != null)
					dataObject.ConnectionProvider = _txConnectionProvider;
		}

		protected virtual void RegisterBusinessObject(zNorthwindTest3Conn_BaseBusiness busObject)
		{
				if(_txConnectionProvider == null)
					_txConnectionProvider = new zNorthwindTest3Conn_TxConnectionProvider();
				busObject.ConnectionProvider = _txConnectionProvider;

				if(!_listBusObjects.Contains(busObject))
					_listBusObjects.Add(busObject);
		}
		#endregion

		#region disposable interface support
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool isDisposing)
		{
			if(!_isDisposed)
			{
				if(isDisposing)
				{
					if(_txConnectionProvider != null)
					{
						((IDisposable)_txConnectionProvider).Dispose();
						_txConnectionProvider = null;
					}
				}
			}
			_isDisposed = true;
		}
		#endregion

		#region transaction support
		public virtual void MarkSubTransaction()
		{
			_nestLevel++;
		}

		public virtual void UnMarkSubTransaction()
		{
			if (_nestLevel > 0)
				_nestLevel--;
		}

		public virtual void BeginTransaction(string trans)
		{
			if(_nestLevel == 0)
			{
				if(_txConnectionProvider == null)
					_txConnectionProvider = new zNorthwindTest3Conn_TxConnectionProvider();
				
				_txConnectionProvider.OpenConnection();
				_txConnectionProvider.BeginTransaction(trans);

				if(_listBusObjects != null)
					foreach (zNorthwindTest3Conn_BaseBusiness busObj in _listBusObjects)
						busObj.MarkSubTransaction();
			}
			_nestLevel++;
		}

		public virtual void RollbackTransaction(string trans)
		{
			if(_listBusObjects != null)
				foreach (zNorthwindTest3Conn_BaseBusiness busObj in _listBusObjects)
					busObj.UnMarkSubTransaction();
			
			if(_nestLevel > 0)
				_nestLevel--;
			
			if(_nestLevel == 0)
			{
				try
				{
					_txConnectionProvider.RollbackTransaction(trans);
					_txConnectionProvider.CloseConnection(false);
					_txConnectionProvider = null;
				}
				catch(InvalidOperationException ex2)
				{	//if transaction completed exception, swallow it
					Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
					Console.WriteLine("Message: {0}", ex2.Message);
				}
				catch
				{
					throw;
				}
			}
		}

		public virtual void CommitTransaction()
		{
			if(_listBusObjects != null)
				foreach (zNorthwindTest3Conn_BaseBusiness busObj in _listBusObjects)
					busObj.UnMarkSubTransaction();
			
			if(_nestLevel > 0)
				_nestLevel--;
			
			if(_nestLevel == 0)
			{
				_txConnectionProvider.CommitTransaction();
				_txConnectionProvider.CloseConnection(false);
				_txConnectionProvider = null;
			}
		}
		#endregion

		#region connection support
		public zNorthwindTest3Conn_TxConnectionProvider ConnectionProvider
		{
			get
			{
				return _txConnectionProvider;
			}
			set
			{
				if(value == null)
					throw new Exception("Connection provider cannot be null");
				
				_txConnectionProvider = value;
			}
		}
		#endregion
	}
}