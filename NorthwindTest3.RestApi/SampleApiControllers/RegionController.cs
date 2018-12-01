/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:31:23
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
using NorthwindTest3.RestApi.SampleViewModels;
using NorthwindTest3.BusinessObjects;
using NorthwindTest3.BusinessObjects.Interfaces;

namespace NorthwindTest3.RestApi.SampleApiControllers
{
	public partial class RegionController : ApiController
	{

            // GET: api/Region
        public async Task<IHttpActionResult> GetRegion(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<RegionVm> listVm = new List<RegionVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BORegion>();
                totalCount = criteria.Count();

                IList<BORegion> listBOs = criteria
                    .Add(new OrderBy("RegionID", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BORegion>();

                foreach (var bo in listBOs)
                    listVm.Add(new RegionVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        // GET: api/Region/5
        [ResponseType(typeof(RegionVm))]
        public async Task<IHttpActionResult> GetRegion(Int32 id)
        {
            var result = Task.Factory.StartNew(() => {

                BORegion bo = new Criteria<BORegion>()
                .Add(Expression.Eq("RegionID", id))
                .SingleOrDefault<BORegion>();
                return bo == null ? null : new RegionVm(bo);

            });
            await result;
            if (result.Result == null)
            {
                return NotFound();
            }

            return Ok(result.Result);
        }

        // PUT: api/Region/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRegion(Int32 id, RegionVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vm.RegionID)
            {
                return BadRequest();
            }

            var result = Task.Factory.StartNew(() => {

                IUnitOfWork uow = new UnitOfWorkImp(); 
                var bo = vm.BORegion();
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

        // POST: api/Region
        [ResponseType(typeof(RegionVm))]
        public async Task<IHttpActionResult> PostRegion(RegionVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = Task.Factory.StartNew(() =>
            {
                IUnitOfWork uow = new UnitOfWorkImp(); 
                var bo = vm.BORegion();
                uow.Create(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                vm = new RegionVm(bo);
                return true;
            });
            await result;
            return CreatedAtRoute("DefaultApi", new { id = vm.RegionID }, vm);
        }

        // DELETE: api/Region/5
        [ResponseType(typeof(RegionVm))]
        public async Task<IHttpActionResult> DeleteRegion(Int32 id)
        {
            var result = Task.Factory.StartNew(() =>
            {
                 IUnitOfWork uow = new UnitOfWorkImp(); 
                var bo = new BORegion(id);
                
                
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

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
	}
}
