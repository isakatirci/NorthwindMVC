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
	public partial class OrderSubtotalsController : ApiController
	{
		protected IOrderSubtotalsRepository _iOrderSubtotalsRepository;

            // GET: api/OrderSubtotals
        public async Task<IHttpActionResult> GetOrderSubtotals(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<OrderSubtotalsVm> listVm = new List<OrderSubtotalsVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOOrderSubtotals>(OrderSubtotalsRepository);
                totalCount = criteria.Count();

                IList<BOOrderSubtotals> listBOs = criteria
                    .Add(new OrderBy("OrderID", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOOrderSubtotals>();

                foreach (var bo in listBOs)
                    listVm.Add(new OrderSubtotalsVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        
        public IOrderSubtotalsRepository OrderSubtotalsRepository
        {
            get { return _iOrderSubtotalsRepository ?? (_iOrderSubtotalsRepository = RF.New().OrderSubtotalsRepository); }
            set { _iOrderSubtotalsRepository = value; }
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
