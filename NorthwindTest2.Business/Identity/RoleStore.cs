using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using NorthwindTest2.Business;
using NorthwindTest2.Business.Interfaces;
using NorthwindTest2.Business.Repository;
using NorthwindTest2.Business.Repository.Interfaces;

namespace NorthwindTest2.Business.Identity
{
    public class RoleStore<TRole> :
        IQueryableRoleStore<TRole, int>,
        IRoleStore<TRole, int>,
        IDisposable
        where TRole : IdentityRole, new()
    {
        private bool _disposed;
        private IList<IBOIdentityRole> _identityRolesCache = new List<IBOIdentityRole>();
        private IIdentityRoleRepository _identityRoleRepo;


        public IQueryable<TRole> Roles
        {
            get
            {
                if (_identityRolesCache.Count < 1)
                    _identityRolesCache = BOIdentityRole.IdentityRoleCollection(IdentityRoleRepository);
                return _identityRolesCache.Select((x) => new TRole { Id = (int)x.Id, Name = x.Name }).ToList().AsQueryable();
            }
        }

        public Task CreateAsync(TRole role)
        {
            BOIdentityRole newRole = new BOIdentityRole();
            newRole.Repository = IdentityRoleRepository;
            newRole.Name = role.Name;
            newRole.SaveNew();

            _identityRolesCache.Add(newRole);
            return Task.FromResult(true);
        }

        public Task UpdateAsync(TRole role)
        {
            BOIdentityRole updatedRole = new BOIdentityRole();
            updatedRole.Repository = IdentityRoleRepository;
            updatedRole.Init(role.Id);
            updatedRole.Name = role.Name;
            updatedRole.Update();

            /*remove possible stale object, an updated one will get picked up in findbynamesync method when required*/
            var cachedObject = _identityRolesCache.SingleOrDefault(x => x.Name == updatedRole.Name);
            if (cachedObject != null) _identityRolesCache.Remove(cachedObject);
            _identityRolesCache.Add(updatedRole);

            return Task.FromResult(true);
        }

        public Task DeleteAsync(TRole role)
        {
            BOIdentityRole boRole = new BOIdentityRole();
            boRole.Repository = IdentityRoleRepository;
            boRole.Init(role.Id);
            boRole.Name = role.Name;
            boRole.Delete();

            /*remove possible stale object*/
            var cachedObject = _identityRolesCache.SingleOrDefault(x => x.Name == boRole.Name);
            if (cachedObject != null) _identityRolesCache.Remove(cachedObject);

            return Task.FromResult(true);
        }

        public Task<TRole> FindByIdAsync(int key)
        {
            var boIdentityRole = _identityRolesCache.SingleOrDefault(x => x.Id == key);
            if (boIdentityRole == null)
            {
                boIdentityRole = new Criteria<BOIdentityRole>(IdentityRoleRepository).Add(Expression.Eq("Id", key))
                .SingleOrDefault<BOIdentityRole>();
                if (boIdentityRole != null) _identityRolesCache.Add(boIdentityRole);
            }

            return Task.FromResult(LoadData(boIdentityRole));
        }

        public Task<TRole> FindByNameAsync(string name)
        {
            var boIdentityRole = _identityRolesCache.SingleOrDefault(x => string.Equals(x.Name, name, StringComparison.InvariantCultureIgnoreCase));
            if (boIdentityRole == null)
            {
                boIdentityRole = new Criteria<BOIdentityRole>(IdentityRoleRepository).Add(Expression.Eq("Name", name))
                .SingleOrDefault<BOIdentityRole>();
                if (boIdentityRole != null) _identityRolesCache.Add(boIdentityRole);
            }

            return Task.FromResult(LoadData(boIdentityRole));
        }

        private TRole LoadData(IBOIdentityRole boIdentityRole)
        {
            TRole role = null;
            if (boIdentityRole != null)
            {
                role = new TRole();
                role.Id = (int)boIdentityRole.Id;
                role.Name = boIdentityRole.Name;
            }
            return role;
        }

        public void Dispose()
        {
            Dispose(true);
            // Use SupressFinalize in case a subclass
            // of this type implements a finalizer.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // If you need thread safety, use a lock around these 
            // operations, as well as in your methods that use the resource.
            if (!_disposed)
            {
                if (disposing)
                {
                    //dispose resource if required
                }
                // Indicate that the instance has been disposed.
                _disposed = true;
            }
        }

        public IIdentityRoleRepository IdentityRoleRepository
        {
            get { return _identityRoleRepo ?? RF.New().IdentityRoleRepository; }
            set { _identityRoleRepo = value; }
        }
    }

}
