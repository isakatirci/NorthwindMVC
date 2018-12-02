using NorthwindClassLibrary.BusinessObjects;
using NorthwindClassLibrary.BusinessObjects.Interfaces;
using NorthwindClassLibrary.BusinessObjects.Repository;
using NorthwindClassLibrary.BusinessObjects.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICriteria criteria = new Criteria<BOProducts>(ProductsRepository);
            var  totalCount = criteria.Count();
            var page = 0;
            var pageSize = 100;
            IList<BOProducts> listBOs = criteria
                .Add(new OrderBy("supplier_ids", OrderBy.OrderDirection.Ascending))
                .Skip(page * pageSize)
                .Take(pageSize)
                .List<BOProducts>();
        }
        static IProductsRepository ProductsRepository
        {
            get { return _iProductsRepository ?? (_iProductsRepository = RF.New().ProductsRepository); }
            set { _iProductsRepository = value; }
        }
        static IProductsRepository _iProductsRepository;

    }
}
