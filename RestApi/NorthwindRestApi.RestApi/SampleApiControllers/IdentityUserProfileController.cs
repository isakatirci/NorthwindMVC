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
	public partial class IdentityUserProfileController : ApiController
	{
		protected IIdentityUserProfileRepository _iIdentityUserProfileRepository;

            // GET: api/IdentityUserProfile
        public async Task<IHttpActionResult> GetIdentityUserProfile(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<IdentityUserProfileVm> listVm = new List<IdentityUserProfileVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOIdentityUserProfile>(IdentityUserProfileRepository);
                totalCount = criteria.Count();

                IList<BOIdentityUserProfile> listBOs = criteria
                    .Add(new OrderBy("UserId", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOIdentityUserProfile>();

                foreach (var bo in listBOs)
                    listVm.Add(new IdentityUserProfileVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        // GET: api/IdentityUserProfile/5
        [ResponseType(typeof(IdentityUserProfileVm))]
        public async Task<IHttpActionResult> GetIdentityUserProfile(Int32 id)
        {
            var result = Task.Factory.StartNew(() => {

                BOIdentityUserProfile bo = new Criteria<BOIdentityUserProfile>(IdentityUserProfileRepository)
                .Add(Expression.Eq("UserId", id))
                .SingleOrDefault<BOIdentityUserProfile>();
                return bo == null ? null : new IdentityUserProfileVm(bo);

            });
            await result;
            if (result.Result == null)
            {
                return NotFound();
            }

            return Ok(result.Result);
        }

        // PUT: api/IdentityUserProfile/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutIdentityUserProfile(Int32 id, IdentityUserProfileVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vm.UserId)
            {
                return BadRequest();
            }

            var result = Task.Factory.StartNew(() => {

                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { IdentityUserProfileRepository }); 
                var bo = (BOIdentityUserProfile)vm.BOIdentityUserProfile(IdentityUserProfileRepository);
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

        // POST: api/IdentityUserProfile
        [ResponseType(typeof(IdentityUserProfileVm))]
        public async Task<IHttpActionResult> PostIdentityUserProfile(IdentityUserProfileVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = Task.Factory.StartNew(() =>
            {
                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { IdentityUserProfileRepository }); 
                var bo = (BOIdentityUserProfile)vm.BOIdentityUserProfile(IdentityUserProfileRepository);
                uow.Create(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                vm = new IdentityUserProfileVm(bo);
                return true;
            });
            await result;
            return CreatedAtRoute("DefaultApi", new { id = vm.UserId }, vm);
        }

        // DELETE: api/IdentityUserProfile/5
        [ResponseType(typeof(IdentityUserProfileVm))]
        public async Task<IHttpActionResult> DeleteIdentityUserProfile(Int32 id)
        {
            var result = Task.Factory.StartNew(() =>
            {
                 IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { IdentityUserProfileRepository }); 
                var bo = new BOIdentityUserProfile();
                bo.Repository = IdentityUserProfileRepository;
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

        
        public IIdentityUserProfileRepository IdentityUserProfileRepository
        {
            get { return _iIdentityUserProfileRepository ?? (_iIdentityUserProfileRepository = RF.New().IdentityUserProfileRepository); }
            set { _iIdentityUserProfileRepository = value; }
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
