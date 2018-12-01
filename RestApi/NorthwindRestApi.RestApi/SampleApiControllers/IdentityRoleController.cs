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
	public partial class IdentityRoleController : ApiController
	{
		protected IIdentityRoleRepository _iIdentityRoleRepository;

            // GET: api/IdentityRole
        public async Task<IHttpActionResult> GetIdentityRole(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<IdentityRoleVm> listVm = new List<IdentityRoleVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOIdentityRole>(IdentityRoleRepository);
                totalCount = criteria.Count();

                IList<BOIdentityRole> listBOs = criteria
                    .Add(new OrderBy("Id", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOIdentityRole>();

                foreach (var bo in listBOs)
                    listVm.Add(new IdentityRoleVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        // GET: api/IdentityRole/5
        [ResponseType(typeof(IdentityRoleVm))]
        public async Task<IHttpActionResult> GetIdentityRole(Int32 id)
        {
            var result = Task.Factory.StartNew(() => {

                BOIdentityRole bo = new Criteria<BOIdentityRole>(IdentityRoleRepository)
                .Add(Expression.Eq("Id", id))
                .SingleOrDefault<BOIdentityRole>();
                return bo == null ? null : new IdentityRoleVm(bo);

            });
            await result;
            if (result.Result == null)
            {
                return NotFound();
            }

            return Ok(result.Result);
        }

        // PUT: api/IdentityRole/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutIdentityRole(Int32 id, IdentityRoleVm vm)
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

                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { IdentityRoleRepository }); 
                var bo = (BOIdentityRole)vm.BOIdentityRole(IdentityRoleRepository);
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

        // POST: api/IdentityRole
        [ResponseType(typeof(IdentityRoleVm))]
        public async Task<IHttpActionResult> PostIdentityRole(IdentityRoleVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = Task.Factory.StartNew(() =>
            {
                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { IdentityRoleRepository }); 
                var bo = (BOIdentityRole)vm.BOIdentityRole(IdentityRoleRepository);
                uow.Create(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                vm = new IdentityRoleVm(bo);
                return true;
            });
            await result;
            return CreatedAtRoute("DefaultApi", new { id = vm.Id }, vm);
        }

        // DELETE: api/IdentityRole/5
        [ResponseType(typeof(IdentityRoleVm))]
        public async Task<IHttpActionResult> DeleteIdentityRole(Int32 id)
        {
            var result = Task.Factory.StartNew(() =>
            {
                 IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { IdentityRoleRepository }); 
                var bo = new BOIdentityRole();
                bo.Repository = IdentityRoleRepository;
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

        
        public IIdentityRoleRepository IdentityRoleRepository
        {
            get { return _iIdentityRoleRepository ?? (_iIdentityRoleRepository = RF.New().IdentityRoleRepository); }
            set { _iIdentityRoleRepository = value; }
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