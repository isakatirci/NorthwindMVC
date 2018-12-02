//using System;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNet.Identity;
//using System.Collections.Generic;
//using Northwind.Business;
//using Northwind.Business.Interfaces;
//using Northwind.Business.Repository;
//using Northwind.Business.Repository.Interfaces;

//namespace Northwind.Business.Identity
//{
//    public class RoleStore<TRole> :
//        IQueryableRoleStore<TRole, int>,
//        IRoleStore<TRole, int>,
//        IDisposable
//        where TRole : Identityrole, new()
//    {
//        private bool _disposed;
//        private IList<IBOIdentityrole> _identityRolesCache = new List<IBOIdentityrole>();
//        private IIdentityroleRepository _identityRoleRepo;


//        public IQueryable<TRole> Roles
//        {
//            get
//            {
//                if (_identityRolesCache.Count < 1)
//                    _identityRolesCache = BOIdentityrole.IdentityroleCollection(IdentityroleRepository);
//                return _identityRolesCache.Select((x) => new TRole { Id = (int)x.Id, Name = x.Name }).ToList().AsQueryable();
//            }
//        }

//        public Task CreateAsync(TRole role)
//        {
//            BOIdentityrole newRole = new BOIdentityrole();
//            newRole.Repository = IdentityroleRepository;
//            newRole.Name = role.Name;
//            newRole.SaveNew();

//            _identityRolesCache.Add(newRole);
//            return Task.FromResult(true);
//        }

//        public Task UpdateAsync(TRole role)
//        {
//            BOIdentityrole updatedRole = new BOIdentityrole();
//            updatedRole.Repository = IdentityroleRepository;
//            updatedRole.Init(role.Id);
//            updatedRole.Name = role.Name;
//            updatedRole.Update();

//            /*remove possible stale object, an updated one will get picked up in findbynamesync method when required*/
//            var cachedObject = _identityRolesCache.SingleOrDefault(x => x.Name == updatedRole.Name);
//            if (cachedObject != null) _identityRolesCache.Remove(cachedObject);
//            _identityRolesCache.Add(updatedRole);

//            return Task.FromResult(true);
//        }

//        public Task DeleteAsync(TRole role)
//        {
//            BOIdentityrole boRole = new BOIdentityrole();
//            boRole.Repository = IdentityroleRepository;
//            boRole.Init(role.Id);
//            boRole.Name = role.Name;
//            boRole.Delete();

//            /*remove possible stale object*/
//            var cachedObject = _identityRolesCache.SingleOrDefault(x => x.Name == boRole.Name);
//            if (cachedObject != null) _identityRolesCache.Remove(cachedObject);

//            return Task.FromResult(true);
//        }

//        public Task<TRole> FindByIdAsync(int key)
//        {
//            var boIdentityrole = _identityRolesCache.SingleOrDefault(x => x.Id == key);
//            if (boIdentityrole == null)
//            {
//                boIdentityrole = new Criteria<BOIdentityrole>(IdentityroleRepository).Add(Expression.Eq("Id", key))
//                .SingleOrDefault<BOIdentityrole>();
//                if (boIdentityrole != null) _identityRolesCache.Add(boIdentityrole);
//            }

//            return Task.FromResult(LoadData(boIdentityrole));
//        }

//        public Task<TRole> FindByNameAsync(string name)
//        {
//            var boIdentityrole = _identityRolesCache.SingleOrDefault(x => string.Equals(x.Name, name, StringComparison.InvariantCultureIgnoreCase));
//            if (boIdentityrole == null)
//            {
//                boIdentityrole = new Criteria<BOIdentityrole>(IdentityroleRepository).Add(Expression.Eq("Name", name))
//                .SingleOrDefault<BOIdentityrole>();
//                if (boIdentityrole != null) _identityRolesCache.Add(boIdentityrole);
//            }

//            return Task.FromResult(LoadData(boIdentityrole));
//        }

//        private TRole LoadData(IBOIdentityrole boIdentityrole)
//        {
//            TRole role = null;
//            if (boIdentityrole != null)
//            {
//                role = new TRole();
//                role.Id = (int)boIdentityrole.Id;
//                role.Name = boIdentityrole.Name;
//            }
//            return role;
//        }

//        public void Dispose()
//        {
//            Dispose(true);
//            // Use SupressFinalize in case a subclass
//            // of this type implements a finalizer.
//            GC.SuppressFinalize(this);
//        }

//        protected virtual void Dispose(bool disposing)
//        {
//            // If you need thread safety, use a lock around these 
//            // operations, as well as in your methods that use the resource.
//            if (!_disposed)
//            {
//                if (disposing)
//                {
//                    //dispose resource if required
//                }
//                // Indicate that the instance has been disposed.
//                _disposed = true;
//            }
//        }

//        public IIdentityroleRepository IdentityroleRepository
//        {
//            get { return _identityRoleRepo ?? RF.New().IdentityroleRepository; }
//            set { _identityRoleRepo = value; }
//        }
//    }

//}
