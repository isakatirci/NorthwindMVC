/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:13
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
using NorthwindRestApi.RestApi.SampleViewModels;
using NorthwindRestApi.Business;
using NorthwindRestApi.Business.Interfaces;
using NorthwindRestApi.Business.Repository;
using NorthwindRestApi.Business.Repository.Interfaces;

namespace NorthwindRestApi.RestApi.SampleApiControllers
{
	public partial class IdentityUserClaimController : ApiController
	{
		protected IIdentityUserClaimRepository _iIdentityUserClaimRepository;

            // GET: api/IdentityUserClaim
        public async Task<IHttpActionResult> GetIdentityUserClaim(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<IdentityUserClaimVm> listVm = new List<IdentityUserClaimVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOIdentityUserClaim>(IdentityUserClaimRepository);
                totalCount = criteria.Count();

                IList<BOIdentityUserClaim> listBOs = criteria
                    .Add(new OrderBy("Id", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOIdentityUserClaim>();

                foreach (var bo in listBOs)
                    listVm.Add(new IdentityUserClaimVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        // GET: api/IdentityUserClaim/5
        [ResponseType(typeof(IdentityUserClaimVm))]
        public async Task<IHttpActionResult> GetIdentityUserClaim(Int32 id)
        {
            var result = Task.Factory.StartNew(() => {

                BOIdentityUserClaim bo = new Criteria<BOIdentityUserClaim>(IdentityUserClaimRepository)
                .Add(Expression.Eq("Id", id))
                .SingleOrDefault<BOIdentityUserClaim>();
                return bo == null ? null : new IdentityUserClaimVm(bo);

            });
            await result;
            if (result.Result == null)
            {
                return NotFound();
            }

            return Ok(result.Result);
        }

        // PUT: api/IdentityUserClaim/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutIdentityUserClaim(Int32 id, IdentityUserClaimVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vm.Id)
            {
                return BadRequest();
            }

            var result = Task.Factory.StartNew(() => {

                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { IdentityUserClaimRepository }); 
                var bo = (BOIdentityUserClaim)vm.BOIdentityUserClaim(IdentityUserClaimRepository);
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

        // POST: api/IdentityUserClaim
        [ResponseType(typeof(IdentityUserClaimVm))]
        public async Task<IHttpActionResult> PostIdentityUserClaim(IdentityUserClaimVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = Task.Factory.StartNew(() =>
            {
                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { IdentityUserClaimRepository }); 
                var bo = (BOIdentityUserClaim)vm.BOIdentityUserClaim(IdentityUserClaimRepository);
                uow.Create(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                vm = new IdentityUserClaimVm(bo);
                return true;
            });
            await result;
            return CreatedAtRoute("DefaultApi", new { id = vm.Id }, vm);
        }

        // DELETE: api/IdentityUserClaim/5
        [ResponseType(typeof(IdentityUserClaimVm))]
        public async Task<IHttpActionResult> DeleteIdentityUserClaim(Int32 id)
        {
            var result = Task.Factory.StartNew(() =>
            {
                 IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { IdentityUserClaimRepository }); 
                var bo = new BOIdentityUserClaim();
                bo.Repository = IdentityUserClaimRepository;
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

        
        public IIdentityUserClaimRepository IdentityUserClaimRepository
        {
            get { return _iIdentityUserClaimRepository ?? (_iIdentityUserClaimRepository = RF.New().IdentityUserClaimRepository); }
            set { _iIdentityUserClaimRepository = value; }
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