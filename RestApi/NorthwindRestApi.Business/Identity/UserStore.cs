using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using NorthwindRestApi.Business;
using NorthwindRestApi.Business.Interfaces;
using NorthwindRestApi.Business.Repository;
using NorthwindRestApi.Business.Repository.Interfaces;

namespace NorthwindRestApi.Business.Identity
{
    public class UserStore<TUser> : IUserStore<TUser, int>, IUserLoginStore<TUser, int>, IUserClaimStore<TUser, int>, IUserRoleStore<TUser, int>,
        IUserPasswordStore<TUser, int>, IUserSecurityStampStore<TUser, int>, IUserEmailStore<TUser, int>, IUserLockoutStore<TUser, int>,
        IUserTwoFactorStore<TUser, int>, IUserPhoneNumberStore<TUser, int>
        , IQueryableUserStore<TUser, int>
        where TUser : IdentityUser, new()
    {
        private bool _disposed;
        private IList<IBOIdentityUser> _identityUsersCache = new List<IBOIdentityUser>();
        private IIdentityUserRepository _identityUserRepo;
        private IIdentityRoleRepository _identityRoleRepo;
        private IIdentityUserRoleRepository _identityUserRoleRepo;
        private IIdentityUserClaimRepository _identityUserClaimRepo;
        private IIdentityUserLoginRepository _identityUserLoginRepo;

        public IQueryable<TUser> Users
        {
            get
            {
                if (_identityUsersCache.Count < 1)
                    _identityUsersCache = BOIdentityUser.IdentityUserCollection(IdentityUserRepository);
                return _identityUsersCache.Select((x) => LoadData(x)).ToList().AsQueryable();
            }
        }



        public Task CreateAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            var newUser = new BOIdentityUser();
            newUser.Repository = IdentityUserRepository;
            newUser.Username = user.UserName;
            newUser.PasswordHash = user.PasswordHash;
            newUser.SecurityStamp = user.SecurityStamp;
            newUser.Email = user.Email;
            newUser.PhoneNumber = user.PhoneNumber;
            newUser.EmailConfirmed = user.IsEmailConfirmed;
            newUser.PhoneNumberConfirmed = user.IsPhoneNumberConfirmed;
            newUser.AccessFailedCount = user.AccessFailedCount;
            newUser.LockoutEnabled = user.LockoutEnabled;
            newUser.LockoutEndDateUtc = (user.LockoutEndDate.UtcDateTime != DateTime.MinValue ? user.LockoutEndDate.UtcDateTime : newUser.LockoutEndDateUtc);
            newUser.TwoFactorEnabled = user.TwoFactorAuthEnabled;
            newUser.SaveNew();

            foreach (var role in user.Roles)
            {
                BOIdentityRole identityRole = new Criteria<BOIdentityRole>(IdentityRoleRepository).Add(Expression.Eq("Name", role))
                    .SingleOrDefault<BOIdentityRole>();

                if (identityRole != null)
                    newUser.AddIdentityUserRole(new BOIdentityUserRole() {Repository = IdentityUserRoleRepository, RoleId = identityRole.Id });
            }

            foreach (var claim in user.Claims)
                newUser.AddIdentityUserClaim(new BOIdentityUserClaim() {Repository = IdentityUserClaimRepository, ClaimType = claim.ClaimType, ClaimValue = claim.ClaimValue });

            foreach (var login in user.Logins)
                newUser.AddIdentityUserLogin(new BOIdentityUserLogin() {Repository = IdentityUserLoginRepository, LoginProvider = login.LoginProvider, ProviderKey = login.ProviderKey });

            user.Id = (int)newUser.UserId;
            _identityUsersCache.Add(newUser);

            return Task.FromResult(true);
        }

        public Task UpdateAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("null parameter for update_async operation");

            var updatedUser = new BOIdentityUser();
            updatedUser.Repository = IdentityUserRepository;
            updatedUser.IdentityUserClaimRepository = IdentityUserClaimRepository;
            updatedUser.IdentityUserLoginRepository = IdentityUserLoginRepository;
            updatedUser.IdentityUserRoleRepository = IdentityUserRoleRepository;

            updatedUser.Init(user.Id);
            updatedUser.Username = user.UserName;
            updatedUser.PasswordHash = user.PasswordHash;
            updatedUser.SecurityStamp = user.SecurityStamp;
            updatedUser.Email = user.Email;
            updatedUser.PhoneNumber = user.PhoneNumber;
            updatedUser.EmailConfirmed = user.IsEmailConfirmed;
            updatedUser.PhoneNumberConfirmed = user.IsPhoneNumberConfirmed;

            updatedUser.AccessFailedCount = user.AccessFailedCount;
            updatedUser.LockoutEnabled = user.LockoutEnabled;

            updatedUser.LockoutEndDateUtc = (user.LockoutEndDate.UtcDateTime != DateTime.MinValue ? user.LockoutEndDate.UtcDateTime : updatedUser.LockoutEndDateUtc);
            updatedUser.TwoFactorEnabled = user.TwoFactorAuthEnabled;
            updatedUser.Update();

            updatedUser.DeleteAllIdentityUserClaim();
            updatedUser.DeleteAllIdentityUserLogin();
            updatedUser.DeleteAllIdentityUserRole();

            foreach (var role in user.Roles)
            {
                BOIdentityRole identityRole = new Criteria<BOIdentityRole>(IdentityRoleRepository).Add(Expression.Eq("Name", role))
                    .SingleOrDefault<BOIdentityRole>();

                if (identityRole != null)
                    updatedUser.AddIdentityUserRole(new BOIdentityUserRole() { Repository = IdentityUserRoleRepository, RoleId = identityRole.Id });
            }

            foreach (var claim in user.Claims)
                updatedUser.AddIdentityUserClaim(new BOIdentityUserClaim() { Repository = IdentityUserClaimRepository, ClaimType = claim.ClaimType, ClaimValue = claim.ClaimValue });

            foreach (var login in user.Logins)
                updatedUser.AddIdentityUserLogin(new BOIdentityUserLogin() { Repository = IdentityUserLoginRepository, LoginProvider = login.LoginProvider, ProviderKey = login.ProviderKey });


            /*remove possible stale object, an updated one will get picked up in findbyidasync method when required*/
            var cachedObject = _identityUsersCache.SingleOrDefault(x => x.UserId == updatedUser.UserId);
            if (cachedObject != null) _identityUsersCache.Remove(cachedObject);
            _identityUsersCache.Add(updatedUser);

            return Task.FromResult(true);
        }

        public Task DeleteAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            var boIdentityUser = new BOIdentityUser();
            boIdentityUser.Repository = IdentityUserRepository;
            boIdentityUser.Init(user.Id);
            boIdentityUser.Delete();

            /*remove possible stale object*/
            var cachedObject = _identityUsersCache.SingleOrDefault(x => x.UserId == boIdentityUser.UserId);
            if (cachedObject != null) _identityUsersCache.Remove(cachedObject);

            return Task.FromResult(true);

        }

        #region search functions
        public Task<TUser> FindByEmailAsync(string email)
        {
            if (email == null)
                throw new ArgumentNullException("parameter not valid for find_by_email_async operation");

            var boIdentityUser = _identityUsersCache.SingleOrDefault(x => string.Equals(x.Email, email, StringComparison.InvariantCultureIgnoreCase));
            if (boIdentityUser == null)
            {
                boIdentityUser = new Criteria<BOIdentityUser>(IdentityUserRepository).Add(Expression.Eq("Email", email))
                .SingleOrDefault<BOIdentityUser>();
                if (boIdentityUser != null) _identityUsersCache.Add(boIdentityUser);
            }
            return Task.FromResult(LoadData(boIdentityUser));

        }

        public Task<TUser> FindByIdAsync(int userID)
        {
            var boIdentityUser = _identityUsersCache.SingleOrDefault(x => x.UserId == userID);
            if (boIdentityUser == null)
            {
                boIdentityUser = new BOIdentityUser();
                ((BOIdentityUser)boIdentityUser).Repository = IdentityUserRepository;
                ((BOIdentityUser)boIdentityUser).Init(userID);
                _identityUsersCache.Add(boIdentityUser);
            }
            return Task.FromResult(LoadData(boIdentityUser));
        }

        public Task<TUser> FindByNameAsync(string username)
        {
            var boIdentityUser = _identityUsersCache.SingleOrDefault(x => string.Equals(x.Username, username, StringComparison.InvariantCultureIgnoreCase));
            if (boIdentityUser == null)
            {
                boIdentityUser = new Criteria<BOIdentityUser>(IdentityUserRepository).Add(Expression.Eq("Username", username))
               .SingleOrDefault<BOIdentityUser>();
                if (boIdentityUser != null) _identityUsersCache.Add(boIdentityUser);
            }

            return Task.FromResult(LoadData(boIdentityUser));
        }
        #endregion

        private TUser LoadData(IBOIdentityUser userObj)
        {
            TUser user = null;
            if (userObj == null)
                return user;

            user = new TUser();
            user.Id = (int)userObj.UserId;
            user.UserName = userObj.Username;
            user.PasswordHash = userObj.PasswordHash;
            user.SecurityStamp = userObj.SecurityStamp;
            user.Email = userObj.Email;
            user.PhoneNumber = userObj.PhoneNumber;
            user.IsEmailConfirmed = userObj.EmailConfirmed != null ? (bool)userObj.EmailConfirmed : default(bool);
            user.IsPhoneNumberConfirmed = userObj.PhoneNumberConfirmed != null ? (bool)userObj.PhoneNumberConfirmed : default(bool);
            user.AccessFailedCount = userObj.AccessFailedCount != null ? (int)userObj.AccessFailedCount : default(int);
            user.LockoutEnabled = userObj.LockoutEnabled != null ? (bool)userObj.LockoutEnabled : default(bool);
            user.LockoutEndDate = userObj.LockoutEndDateUtc != null ? (DateTime)userObj.LockoutEndDateUtc : DateTime.SpecifyKind(default(DateTime), DateTimeKind.Utc);
            user.TwoFactorAuthEnabled = userObj.TwoFactorEnabled != null ? (bool)userObj.TwoFactorEnabled : default(bool);

            userObj.IdentityUserRoleRepository = IdentityUserRoleRepository;
            userObj.IdentityUserClaimRepository = IdentityUserClaimRepository;
            userObj.IdentityUserLoginRepository = IdentityUserLoginRepository;

            foreach (var userRole in userObj.IdentityUserRoleCollection())
            {
                var identityRole = new BOIdentityRole();
                identityRole.Repository = IdentityRoleRepository;
                identityRole.Init((int)userRole.RoleId);
                user.Roles.Add(identityRole.Name);
            }

            user.Claims = userObj.IdentityUserClaimCollection().Select(c => new IdentityUserClaim { UserId = user.Id, ClaimType = c.ClaimType, ClaimValue = c.ClaimValue }).ToList();
            user.Logins = userObj.IdentityUserLoginCollection().Select(c => new UserLoginInfo(c.LoginProvider, c.ProviderKey)).ToList();
            return user;
        }


        public Task AddLoginAsync(TUser user, UserLoginInfo login)
        {
            if ((user == null) || (login == null))
                throw new ArgumentNullException("parameter not valid for remove_login_async operation");

            int count = new Criteria<BOIdentityUserLogin>(IdentityUserLoginRepository)
                    .Add(Expression.Eq("LoginProvider", login.LoginProvider))
                    .Add(Expression.Eq("ProviderKey", login.ProviderKey))
                    .Count();

            if (count < 1)
            {
                user.Logins.Add(login);

                BOIdentityUserLogin boLogin = new BOIdentityUserLogin();
                boLogin.Repository = IdentityUserLoginRepository;
                boLogin.LoginProvider = login.LoginProvider;
                boLogin.ProviderKey = login.ProviderKey;
                boLogin.UserId = user.Id;
                boLogin.SaveNew();
            }

            return Task.FromResult(true);
        }

        public Task RemoveLoginAsync(TUser user, UserLoginInfo login)
        {
            if ((user == null) || (login == null))
                throw new ArgumentNullException("parameter not valid for remove_login_async operation");

            var boLogin = new Criteria<BOIdentityUserLogin>(IdentityUserLoginRepository)
                    .Add(Expression.Eq("LoginProvider", login.LoginProvider))
                    .Add(Expression.Eq("ProviderKey", login.ProviderKey))
                    .Add(Expression.Eq("UserId", user.Id))
                    .SingleOrDefault<BOIdentityUserLogin>();

            if (boLogin != null)
                boLogin.Delete();

            user.Logins.RemoveAll(x => x.LoginProvider == login.LoginProvider && x.ProviderKey == login.ProviderKey);

            return Task.FromResult(0);
        }

        public Task<IList<UserLoginInfo>> GetLoginsAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_logins_async operation");

            return Task.FromResult((IList<UserLoginInfo>)user.Logins);
        }

        public Task<TUser> FindAsync(UserLoginInfo login)
        {
            if (login == null)
                throw new ArgumentNullException("parameter not valid for find_async operation");

            int? userID = new Criteria<BOIdentityUserLogin>(IdentityUserLoginRepository)
                    .Add(Expression.Eq("LoginProvider", login.LoginProvider))
                    .Add(Expression.Eq("ProviderKey", login.ProviderKey))
                    .Add(new Projection("UserId"))
                    .List<IList<object>>()[0].Select((x) => (int?)x)
                    .SingleOrDefault();

            TUser user = null;
            if (userID.HasValue)
            {
                var identityUser = new BOIdentityUser();
                identityUser.Repository = IdentityUserRepository;
                identityUser.Init((int)userID);
                user = LoadData(identityUser);
            }


            return Task.FromResult(user);
        }

        public Task<IList<Claim>> GetClaimsAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_claim_async operation");

            IList<Claim> result = user.Claims.Select(c => new Claim(c.ClaimType, c.ClaimValue)).ToList();
            return Task.FromResult(result);
        }

        public Task AddClaimAsync(TUser user, Claim claim)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for add_claim_async operation");

            if (user.Claims.Find(x => x.ClaimType == claim.Type && x.ClaimValue == claim.Value) == null)
                user.Claims.Add(new IdentityUserClaim { ClaimType = claim.Type, ClaimValue = claim.Value });

            return Task.FromResult(0);
        }

        public Task RemoveClaimAsync(TUser user, Claim claim)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for remove_claim_async operation");

            user.Claims.RemoveAll(x => x.ClaimType == claim.Type && x.ClaimValue == claim.Value);
            return Task.FromResult(0);
        }

        public Task RemoveFromRoleAsync(TUser user, string role)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for remove_from_role_async operation");

            user.Roles.RemoveAll(r => String.Equals(r, role, StringComparison.InvariantCultureIgnoreCase));

            return Task.FromResult(0);
        }

        public Task AddToRoleAsync(TUser user, string role)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for add_to_role_async operation");

            if (!user.Roles.Contains(role, StringComparer.InvariantCultureIgnoreCase))
                user.Roles.Add(role);

            return Task.FromResult(0);
        }

        public Task<IList<string>> GetRolesAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_roles_async_async operation");

            return Task.FromResult<IList<string>>(user.Roles);
        }

        public Task<bool> IsInRoleAsync(TUser user, string role)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for is_in_role_async operation");

            return Task.FromResult(user.Roles.Contains(role, StringComparer.InvariantCultureIgnoreCase));
        }

        public Task<bool> HasPasswordAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for has_password_hash_async operation");

            return Task.FromResult(!string.IsNullOrEmpty(user.PasswordHash));
        }

        public Task<string> GetPasswordHashAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_password_hash_async operation");

            return Task.FromResult(user.PasswordHash);
        }

        public Task SetPasswordHashAsync(TUser user, string passwordHash)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for set_password_hash_async operation");

            user.PasswordHash = passwordHash;
            return Task.FromResult(0);
        }

        public Task<string> GetSecurityStampAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_security_stamp_async operation");

            return Task.FromResult(user.SecurityStamp);
        }

        public Task SetSecurityStampAsync(TUser user, string stamp)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for set_security_stamp_async operation");

            user.SecurityStamp = stamp;
            return Task.FromResult(0);
        }

        public Task<string> GetEmailAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_email_async operation");

            return Task.FromResult(user.Email);
        }

        public Task<bool> GetEmailConfirmedAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_email_confirmed_async operation");

            return Task.FromResult(user.IsEmailConfirmed);
        }

        public Task SetEmailAsync(TUser user, string email)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for set_email_async operation");

            user.Email = email;
            return Task.FromResult(0);
        }
        public Task SetEmailConfirmedAsync(TUser user, bool confirmed)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for set_email_confirmed_async operation");

            user.IsEmailConfirmed = confirmed;
            return Task.FromResult(0);
        }



        public Task<DateTimeOffset> GetLockoutEndDateAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_lockout_end_date_async operation");

            return Task.FromResult(user.LockoutEndDate);
        }

        public Task SetLockoutEndDateAsync(TUser user, DateTimeOffset lockoutEnd)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for set_lockout_end_date_async operation");

            user.LockoutEndDate = lockoutEnd;
            return Task.FromResult(0);
        }

        public Task<int> IncrementAccessFailedCountAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for increment_access_failed_count_async operation");

            user.AccessFailedCount++;
            return Task.FromResult(user.AccessFailedCount);
        }

        public Task ResetAccessFailedCountAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for reset_access_failed_count_async operation");

            user.AccessFailedCount = 0;
            return Task.FromResult(0);
        }

        public Task<int> GetAccessFailedCountAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_access_failed_count_async operation");

            return Task.FromResult(user.AccessFailedCount);
        }

        public Task<bool> GetLockoutEnabledAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_lockout_enabled_async operation");

            return Task.FromResult(user.LockoutEnabled);
        }

        public Task SetLockoutEnabledAsync(TUser user, bool enabled)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for set_lockout_enabled_async operation");

            user.LockoutEnabled = enabled;
            return Task.FromResult(0);
        }


        public Task<bool> GetTwoFactorEnabledAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_two_factor_enabled_async operation");

            return Task.FromResult(user.TwoFactorAuthEnabled);
        }

        public Task SetTwoFactorEnabledAsync(TUser user, bool enabled)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_two_factor_enabled_async operation");

            user.TwoFactorAuthEnabled = enabled;
            return Task.FromResult(0);
        }

        public Task SetPhoneNumberAsync(TUser user, string phoneNumber)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for set_phone_number_async operation");

            user.PhoneNumber = phoneNumber;
            return Task.FromResult(0);
        }

        public Task SetPhoneNumberConfirmedAsync(TUser user, bool confirmed)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for set_phone_number_confirmed_async operation");

            user.IsPhoneNumberConfirmed = confirmed;
            return Task.FromResult(0);
        }

        public Task<string> GetPhoneNumberAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_phone_number_async operation");

            return Task.FromResult(user.PhoneNumber);
        }

        public Task<bool> GetPhoneNumberConfirmedAsync(TUser user)
        {
            if (user == null)
                throw new ArgumentNullException("parameter not valid for get_phone_number_confirmed_async operation");

            return Task.FromResult(user.IsPhoneNumberConfirmed);
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

        public IIdentityUserRepository IdentityUserRepository
        {
            get { return _identityUserRepo ?? RF.New().IdentityUserRepository;}
            set { _identityUserRepo = value; }
        }

        public IIdentityRoleRepository IdentityRoleRepository
        {
            get { return _identityRoleRepo ?? RF.New().IdentityRoleRepository;}
            set { _identityRoleRepo = value; }
        }

        public IIdentityUserRoleRepository IdentityUserRoleRepository
        {
            get { return _identityUserRoleRepo ?? RF.New().IdentityUserRoleRepository;}
            set { _identityUserRoleRepo = value; }
        }

        public IIdentityUserClaimRepository IdentityUserClaimRepository
        {
            get { return _identityUserClaimRepo ?? RF.New().IdentityUserClaimRepository;}
            set { _identityUserClaimRepo = value; }
        }

        public IIdentityUserLoginRepository IdentityUserLoginRepository
        {
            get { return _identityUserLoginRepo ?? RF.New().IdentityUserLoginRepository;}
            set { _identityUserLoginRepo = value; }
        }
    }
}
