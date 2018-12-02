
/*UnitOfWork Implementation - UnitOfWorkImp.cs*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Business;
using Northwind.Business.Interfaces;
using Northwind.Business.Repository.Interfaces;


namespace Northwind.Mvc.SampleApiControllers
{
    public class UnitOfWorkImp : zNorthwindConn_BaseBusiness, IUnitOfWork
    {
        private enum OpType
        { Create, Update, Delete };

        IRepositoryConnection[] _repositories = null;
        List<Tuple<IUnitOfWorkEntity, OpType>> _opList = new List<Tuple<IUnitOfWorkEntity, OpType>>();

        public UnitOfWorkImp()
        {
        }

        public UnitOfWorkImp(IRepositoryConnection[] repositories)
        {
            _repositories = repositories;
        }
        public void Create(IUnitOfWorkEntity busObj)
        {
            _opList.Add(new Tuple<IUnitOfWorkEntity, OpType>(busObj, OpType.Create));
        }
        public void Update(IUnitOfWorkEntity busObj)
        {
            _opList.Add(new Tuple<IUnitOfWorkEntity, OpType>(busObj, OpType.Update));
        }
        public void Delete(IUnitOfWorkEntity busObj)
        {
            _opList.Add(new Tuple<IUnitOfWorkEntity, OpType>(busObj, OpType.Delete));
        }
        public bool Commit(out string message)
        {
            message = "SUCCESS";
            string transName = GetTransactionName();

            this.BeginTransactions(_repositories, transName);
            try
            {
                foreach (var op in _opList)
                {
                    switch (op.Item2)
                    {
                        case OpType.Create:
                            op.Item1.SaveNew();
                            break;
                        case OpType.Update:
                            op.Item1.Update();
                            break;
                        case OpType.Delete:
                            op.Item1.Delete();
                            break;
                    }
                }
                CommitTransactions(_repositories);
                return true;
            }
            catch (Exception ex)
            {
                base.RollbackTransactions(_repositories, transName);
                message = ex.Message;
                return false;
            }
        }

        private string GetTransactionName()
        {
            return "tr" + DateTime.Now.TimeOfDay.Ticks.ToString();
        }
    }

    public class UnitOfWorkForwarder : zNorthwindConn_BaseBusiness, IUnitOfWorkEntity
    {
        Action _saveFn; Action _updateFn; Action _deleteFn;

        public UnitOfWorkForwarder(Action saveFn, Action updateFn, Action deleteFn)
        {    _saveFn = saveFn; _updateFn = updateFn;  _deleteFn = deleteFn;   }

        public void SaveNew() { if (_saveFn != null) _saveFn(); }
        public void Update() { if (_updateFn != null) _updateFn(); }
        public void Delete() { if (_deleteFn != null) _deleteFn(); }
    }
}
