/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 12:15:59
**************************************************************/

using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NorthwindClassLibrary.DataObjects;
using NorthwindClassLibrary.DataObjects.Interfaces;
using NorthwindClassLibrary.BusinessObjects.Interfaces;
using NorthwindClassLibrary.BusinessObjects.Repository.Interfaces;

namespace NorthwindClassLibrary.BusinessObjects
{
	public partial class zNorthwindClassLibrayConn_BaseBusiness : IzNorthwindClassLibrayConn_BaseBusiness
	{
		#region initialization
		public zNorthwindClassLibrayConn_BaseBusiness()
		{
			Init();
		}

		private void Init()
		{
		}

		protected virtual void RegisterDataObject(IRepositoryConnection repo, IzNorthwindClassLibrayConn_BaseData dataObject)
		{
				if(dataObject != null)
					dataObject.ConnectionProvider = repo.ConnectionProvider;
		}
		#endregion

		#region transaction support
		public virtual void BeginTransactions(IRepositoryConnection[] repos, string trans)
		{
			foreach(IRepositoryConnection repo in repos)
				BeginTransaction(repo, trans);
		}

		public virtual void BeginTransaction(IRepositoryConnection repo, string trans)
		{
			if(repo.ConnectionProvider.TransactionCount == 0)
			{
				repo.ConnectionProvider.OpenConnection();
				repo.ConnectionProvider.BeginTransaction(trans);
			}
			repo.ConnectionProvider.TransactionCount += 1;
		}

		public virtual void RollbackTransactions(IRepositoryConnection[] repos, string trans)
		{
			foreach(IRepositoryConnection repo in repos)
				RollbackTransaction(repo, trans);
		}

		public virtual void RollbackTransaction(IRepositoryConnection repo, string trans)
		{
			if(repo.ConnectionProvider.TransactionCount > 0)
				repo.ConnectionProvider.TransactionCount -=1;
			
			if(repo.ConnectionProvider.TransactionCount == 0)
			{
				repo.ConnectionProvider.RollbackTransaction(trans);
				repo.ConnectionProvider.CloseConnection(false);
			}
		}

		public virtual void CommitTransactions(IRepositoryConnection[] repos)
		{
			foreach(IRepositoryConnection repo in repos)
				CommitTransaction(repo);
		}

		public virtual void CommitTransaction(IRepositoryConnection repo)
		{
			if(repo.ConnectionProvider.TransactionCount > 0)
				repo.ConnectionProvider.TransactionCount -=1;
			
			if(repo.ConnectionProvider.TransactionCount == 0)
			{
				repo.ConnectionProvider.CommitTransaction();
				repo.ConnectionProvider.CloseConnection(false);
			}
		}
		#endregion

		#region logging support
		static partial void LogDoing(object o, string memberName);
		static partial void LogDone(object o, string memberName);
		static partial void LogFailed(object o, Exception ex, string memberName);
		
		static protected void Doing(object o, [CallerMemberName] string memberName = "")
		{
			LogDoing(o, memberName);
		}
		
		static protected void Done(object o, [CallerMemberName] string memberName = "")
		{
			LogDone(o, memberName);
		}
		
		static protected void Failed(object o, Exception ex, [CallerMemberName] string memberName = "")
		{
			LogFailed(o, ex, memberName);
		}
		#endregion
		
		#region exception handling support
		static partial void HandleException(object o, Exception ex, string memberName);
		
		static protected void Handle(object o, Exception ex, [CallerMemberName] string memberName = "")
		{
			HandleException(o, ex, memberName);
		}
		#endregion
	}
}