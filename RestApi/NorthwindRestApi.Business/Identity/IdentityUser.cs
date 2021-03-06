using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace NorthwindRestApi.Business.Identity
{
    public partial class IdentityUser : IUser<int>
    {
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual bool IsEmailConfirmed { get; set; }
        public virtual bool IsPhoneNumberConfirmed { get; set; }
        public virtual int AccessFailedCount { get; set; }
        public virtual bool LockoutEnabled { get; set; }
        public virtual DateTimeOffset LockoutEndDate { get; set; }
        public virtual bool TwoFactorAuthEnabled { get; set; }


        protected List<string> _roles;
        protected List<IdentityUserClaim> _claims;
        protected List<UserLoginInfo> _logins;

        public IdentityUser()
        {
            _roles = new List<string>();
            _claims = new List<IdentityUserClaim>();
            _logins = new List<UserLoginInfo>();
        }

        public virtual List<string> Roles
        {
            get { return _roles; }
            set { _roles = value; }
        }

        public virtual List<IdentityUserClaim> Claims
        {
            get { return _claims; }
            set { _claims = value; }
        }

        public virtual List<UserLoginInfo> Logins
        {
            get { return _logins; }
            set { _logins = value; }
        }

    }

    public class IdentityUserClaim
    {
        public virtual int UserId { get; set; }
        public virtual string ClaimType { get; set; }
        public virtual string ClaimValue { get; set; }
    }

    public class IdentityUserRole
    {
        public virtual int RoleId { get; set; }
        public virtual int UserId { get; set; }
        public virtual string RoleName { get; set; }
    }


    public class IdentityRole : IRole<int>
    {
        public IdentityRole() { }
        public IdentityRole(string name) { Name = name; }

        public int Id { get; set; }
        public string Name { get; set; }
    }


}
