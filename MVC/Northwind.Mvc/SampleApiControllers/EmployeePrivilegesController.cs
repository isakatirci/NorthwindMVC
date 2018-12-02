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
	public partial class EmployeePrivilegesController : ApiController
	{
		protected IEmployeePrivilegesRepository _iEmployeePrivilegesRepository;

            // GET: api/EmployeePrivileges
        public async Task<IHttpActionResult> GetEmployeePrivileges(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<EmployeePrivilegesVm> listVm = new List<EmployeePrivilegesVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOEmployeePrivileges>(EmployeePrivilegesRepository);
                totalCount = criteria.Count();

                IList<BOEmployeePrivileges> listBOs = criteria
                    .Add(new OrderBy("employee_id", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOEmployeePrivileges>();

                foreach (var bo in listBOs)
                    listVm.Add(new EmployeePrivilegesVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        
        public IEmployeePrivilegesRepository EmployeePrivilegesRepository
        {
            get { return _iEmployeePrivilegesRepository ?? (_iEmployeePrivilegesRepository = RF.New().EmployeePrivilegesRepository); }
            set { _iEmployeePrivilegesRepository = value; }
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
