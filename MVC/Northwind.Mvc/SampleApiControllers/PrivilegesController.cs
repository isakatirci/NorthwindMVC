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
	public partial class PrivilegesController : ApiController
	{
		protected IPrivilegesRepository _iPrivilegesRepository;

            // GET: api/Privileges
        public async Task<IHttpActionResult> GetPrivileges(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<PrivilegesVm> listVm = new List<PrivilegesVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOPrivileges>(PrivilegesRepository);
                totalCount = criteria.Count();

                IList<BOPrivileges> listBOs = criteria
                    .Add(new OrderBy("id", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOPrivileges>();

                foreach (var bo in listBOs)
                    listVm.Add(new PrivilegesVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        // GET: api/Privileges/5
        [ResponseType(typeof(PrivilegesVm))]
        public async Task<IHttpActionResult> GetPrivileges(string id)
        {
            var result = Task.Factory.StartNew(() => {

                BOPrivileges bo = new Criteria<BOPrivileges>(PrivilegesRepository)
                .Add(Expression.Eq("id", id))
                .SingleOrDefault<BOPrivileges>();
                return bo == null ? null : new PrivilegesVm(bo);

            });
            await result;
            if (result.Result == null)
            {
                return NotFound();
            }

            return Ok(result.Result);
        }

        // PUT: api/Privileges/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPrivileges(string id, PrivilegesVm vm)
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

                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { PrivilegesRepository }); 
                var bo = (BOPrivileges)vm.BOPrivileges(PrivilegesRepository);
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

        // POST: api/Privileges
        [ResponseType(typeof(PrivilegesVm))]
        public async Task<IHttpActionResult> PostPrivileges(PrivilegesVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = Task.Factory.StartNew(() =>
            {
                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { PrivilegesRepository }); 
                var bo = (BOPrivileges)vm.BOPrivileges(PrivilegesRepository);
                uow.Create(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                vm = new PrivilegesVm(bo);
                return true;
            });
            await result;
            return CreatedAtRoute("DefaultApi", new { id = vm.İd }, vm);
        }

        // DELETE: api/Privileges/5
        [ResponseType(typeof(PrivilegesVm))]
        public async Task<IHttpActionResult> DeletePrivileges(string id)
        {
            var result = Task.Factory.StartNew(() =>
            {
                 IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { PrivilegesRepository }); 
                var bo = new BOPrivileges();
                bo.Repository = PrivilegesRepository;
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

        
        public IPrivilegesRepository PrivilegesRepository
        {
            get { return _iPrivilegesRepository ?? (_iPrivilegesRepository = RF.New().PrivilegesRepository); }
            set { _iPrivilegesRepository = value; }
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
