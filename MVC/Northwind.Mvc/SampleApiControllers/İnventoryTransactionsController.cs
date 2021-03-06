/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 2.12.2018 01:22:24
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Threading.Tasks;
using Northwind.Mvc.SampleViewModels;
using Northwind.Business;
using Northwind.Business.Interfaces;
using Northwind.Business.Repository;
using Northwind.Business.Repository.Interfaces;

namespace Northwind.Mvc.SampleApiControllers
{
	public partial class İnventoryTransactionsController : ApiController
	{
		protected IInventoryTransactionsRepository _iİnventoryTransactionsRepository;

            // GET: api/İnventoryTransactions
        public async Task<IHttpActionResult> GetİnventoryTransactions(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<İnventoryTransactionsVm> listVm = new List<İnventoryTransactionsVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOInventoryTransactions>(İnventoryTransactionsRepository);
                totalCount = criteria.Count();

                IList<BOInventoryTransactions> listBOs = criteria
                    .Add(new OrderBy("id", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOInventoryTransactions>();

                foreach (var bo in listBOs)
                    listVm.Add(new İnventoryTransactionsVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        // GET: api/İnventoryTransactions/5
        [ResponseType(typeof(İnventoryTransactionsVm))]
        public async Task<IHttpActionResult> GetİnventoryTransactions(string id)
        {
            var result = Task.Factory.StartNew(() => {

                BOInventoryTransactions bo = new Criteria<BOInventoryTransactions>(İnventoryTransactionsRepository)
                .Add(Expression.Eq("id", id))
                .SingleOrDefault<BOInventoryTransactions>();
                return bo == null ? null : new İnventoryTransactionsVm(bo);

            });
            await result;
            if (result.Result == null)
            {
                return NotFound();
            }

            return Ok(result.Result);
        }

        // PUT: api/İnventoryTransactions/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutİnventoryTransactions(string id, İnventoryTransactionsVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vm.İd)
            {
                return BadRequest();
            }

            var result = Task.Factory.StartNew(() => {

                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { İnventoryTransactionsRepository }); 
                var bo = (BOInventoryTransactions)vm.BOİnventoryTransactions(İnventoryTransactionsRepository);
                uow.Update(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                return true;
            });
            await result;
            if (!result.Result)
                return NotFound();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/İnventoryTransactions
        [ResponseType(typeof(İnventoryTransactionsVm))]
        public async Task<IHttpActionResult> PostİnventoryTransactions(İnventoryTransactionsVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = Task.Factory.StartNew(() =>
            {
                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { İnventoryTransactionsRepository }); 
                var bo = (BOInventoryTransactions)vm.BOİnventoryTransactions(İnventoryTransactionsRepository);
                uow.Create(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                vm = new İnventoryTransactionsVm(bo);
                return true;
            });
            await result;
            return CreatedAtRoute("DefaultApi", new { id = vm.İd }, vm);
        }

        // DELETE: api/İnventoryTransactions/5
        [ResponseType(typeof(İnventoryTransactionsVm))]
        public async Task<IHttpActionResult> DeleteİnventoryTransactions(string id)
        {
            var result = Task.Factory.StartNew(() =>
            {
                 IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { İnventoryTransactionsRepository }); 
                var bo = new BOInventoryTransactions();
                bo.Repository = İnventoryTransactionsRepository;
                bo.Init(id);
                
                uow.Delete(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                return true;
            });
            await result;
            if (!result.Result)
                return NotFound();

            return Ok(result.Result);
        }

        
        public IInventoryTransactionsRepository İnventoryTransactionsRepository
        {
            get { return _iİnventoryTransactionsRepository ?? (_iİnventoryTransactionsRepository = RF.New().İnventoryTransactionsRepository); }
            set { _iİnventoryTransactionsRepository = value; }
        }
        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
	}
}
