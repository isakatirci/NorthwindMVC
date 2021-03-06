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
	public partial class PurchaseOrderStatusController : ApiController
	{
		protected IPurchaseOrderStatusRepository _iPurchaseOrderStatusRepository;

            // GET: api/PurchaseOrderStatus
        public async Task<IHttpActionResult> GetPurchaseOrderStatus(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<PurchaseOrderStatusVm> listVm = new List<PurchaseOrderStatusVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOPurchaseOrderStatus>(PurchaseOrderStatusRepository);
                totalCount = criteria.Count();

                IList<BOPurchaseOrderStatus> listBOs = criteria
                    .Add(new OrderBy("id", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOPurchaseOrderStatus>();

                foreach (var bo in listBOs)
                    listVm.Add(new PurchaseOrderStatusVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        // GET: api/PurchaseOrderStatus/5
        [ResponseType(typeof(PurchaseOrderStatusVm))]
        public async Task<IHttpActionResult> GetPurchaseOrderStatus(string id)
        {
            var result = Task.Factory.StartNew(() => {

                BOPurchaseOrderStatus bo = new Criteria<BOPurchaseOrderStatus>(PurchaseOrderStatusRepository)
                .Add(Expression.Eq("id", id))
                .SingleOrDefault<BOPurchaseOrderStatus>();
                return bo == null ? null : new PurchaseOrderStatusVm(bo);

            });
            await result;
            if (result.Result == null)
            {
                return NotFound();
            }

            return Ok(result.Result);
        }

        // PUT: api/PurchaseOrderStatus/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPurchaseOrderStatus(string id, PurchaseOrderStatusVm vm)
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

                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { PurchaseOrderStatusRepository }); 
                var bo = (BOPurchaseOrderStatus)vm.BOPurchaseOrderStatus(PurchaseOrderStatusRepository);
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

        // POST: api/PurchaseOrderStatus
        [ResponseType(typeof(PurchaseOrderStatusVm))]
        public async Task<IHttpActionResult> PostPurchaseOrderStatus(PurchaseOrderStatusVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = Task.Factory.StartNew(() =>
            {
                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { PurchaseOrderStatusRepository }); 
                var bo = (BOPurchaseOrderStatus)vm.BOPurchaseOrderStatus(PurchaseOrderStatusRepository);
                uow.Create(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                vm = new PurchaseOrderStatusVm(bo);
                return true;
            });
            await result;
            return CreatedAtRoute("DefaultApi", new { id = vm.İd }, vm);
        }

        // DELETE: api/PurchaseOrderStatus/5
        [ResponseType(typeof(PurchaseOrderStatusVm))]
        public async Task<IHttpActionResult> DeletePurchaseOrderStatus(string id)
        {
            var result = Task.Factory.StartNew(() =>
            {
                 IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { PurchaseOrderStatusRepository }); 
                var bo = new BOPurchaseOrderStatus();
                bo.Repository = PurchaseOrderStatusRepository;
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

        
        public IPurchaseOrderStatusRepository PurchaseOrderStatusRepository
        {
            get { return _iPurchaseOrderStatusRepository ?? (_iPurchaseOrderStatusRepository = RF.New().PurchaseOrderStatusRepository); }
            set { _iPurchaseOrderStatusRepository = value; }
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
