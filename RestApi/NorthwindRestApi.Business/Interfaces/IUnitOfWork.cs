using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindRestApi.Business.Interfaces
{
    public interface IUnitOfWork
    {
        void Create(IUnitOfWorkEntity busObj);
        void Update(IUnitOfWorkEntity busObj);
        void Delete(IUnitOfWorkEntity busObj);
        bool Commit(out string message);
    }
}
