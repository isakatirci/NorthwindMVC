/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:09:42
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Linq;
using System.Collections.Generic;
using NorthwindTest2.Data;
using NorthwindTest2.Data.Interfaces;
using NorthwindTest2.Business.Repository.Interfaces;

namespace NorthwindTest2.Business.Repository
{
	public partial class RF
	{
		private IzNorthwindTest2Conn_TxConnectionProvider _connectionProvider;
		private IList<object> _repositories;
		
		public static RF New()
		{
			return new RF();
		}
		
		private RF()
		{
			_connectionProvider = new zNorthwindTest2Conn_TxConnectionProvider();
			_repositories = new List<object>();
		}
	}

	public partial class RF
	{
		public IIdentityRoleRepository IdentityRoleRepository
		{
			get
			{
				IIdentityRoleRepository repo = (IIdentityRoleRepository)_repositories.SingleOrDefault((x) => x is IIdentityRoleRepository);
				if(repo == null)
				{
					repo = new IdentityRoleRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IIdentityUserRepository IdentityUserRepository
		{
			get
			{
				IIdentityUserRepository repo = (IIdentityUserRepository)_repositories.SingleOrDefault((x) => x is IIdentityUserRepository);
				if(repo == null)
				{
					repo = new IdentityUserRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IIdentityUserClaimRepository IdentityUserClaimRepository
		{
			get
			{
				IIdentityUserClaimRepository repo = (IIdentityUserClaimRepository)_repositories.SingleOrDefault((x) => x is IIdentityUserClaimRepository);
				if(repo == null)
				{
					repo = new IdentityUserClaimRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IIdentityUserLoginRepository IdentityUserLoginRepository
		{
			get
			{
				IIdentityUserLoginRepository repo = (IIdentityUserLoginRepository)_repositories.SingleOrDefault((x) => x is IIdentityUserLoginRepository);
				if(repo == null)
				{
					repo = new IdentityUserLoginRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IIdentityUserProfileRepository IdentityUserProfileRepository
		{
			get
			{
				IIdentityUserProfileRepository repo = (IIdentityUserProfileRepository)_repositories.SingleOrDefault((x) => x is IIdentityUserProfileRepository);
				if(repo == null)
				{
					repo = new IdentityUserProfileRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IIdentityUserRoleRepository IdentityUserRoleRepository
		{
			get
			{
				IIdentityUserRoleRepository repo = (IIdentityUserRoleRepository)_repositories.SingleOrDefault((x) => x is IIdentityUserRoleRepository);
				if(repo == null)
				{
					repo = new IdentityUserRoleRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public ICategoriesRepository CategoriesRepository
		{
			get
			{
				ICategoriesRepository repo = (ICategoriesRepository)_repositories.SingleOrDefault((x) => x is ICategoriesRepository);
				if(repo == null)
				{
					repo = new CategoriesRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public ICustomerCustomerDemoRepository CustomerCustomerDemoRepository
		{
			get
			{
				ICustomerCustomerDemoRepository repo = (ICustomerCustomerDemoRepository)_repositories.SingleOrDefault((x) => x is ICustomerCustomerDemoRepository);
				if(repo == null)
				{
					repo = new CustomerCustomerDemoRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public ICustomerDemographicsRepository CustomerDemographicsRepository
		{
			get
			{
				ICustomerDemographicsRepository repo = (ICustomerDemographicsRepository)_repositories.SingleOrDefault((x) => x is ICustomerDemographicsRepository);
				if(repo == null)
				{
					repo = new CustomerDemographicsRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public ICustomersRepository CustomersRepository
		{
			get
			{
				ICustomersRepository repo = (ICustomersRepository)_repositories.SingleOrDefault((x) => x is ICustomersRepository);
				if(repo == null)
				{
					repo = new CustomersRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IEmployeesRepository EmployeesRepository
		{
			get
			{
				IEmployeesRepository repo = (IEmployeesRepository)_repositories.SingleOrDefault((x) => x is IEmployeesRepository);
				if(repo == null)
				{
					repo = new EmployeesRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IEmployeeTerritoriesRepository EmployeeTerritoriesRepository
		{
			get
			{
				IEmployeeTerritoriesRepository repo = (IEmployeeTerritoriesRepository)_repositories.SingleOrDefault((x) => x is IEmployeeTerritoriesRepository);
				if(repo == null)
				{
					repo = new EmployeeTerritoriesRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IOrderDetailsRepository OrderDetailsRepository
		{
			get
			{
				IOrderDetailsRepository repo = (IOrderDetailsRepository)_repositories.SingleOrDefault((x) => x is IOrderDetailsRepository);
				if(repo == null)
				{
					repo = new OrderDetailsRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IOrdersRepository OrdersRepository
		{
			get
			{
				IOrdersRepository repo = (IOrdersRepository)_repositories.SingleOrDefault((x) => x is IOrdersRepository);
				if(repo == null)
				{
					repo = new OrdersRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IProductsRepository ProductsRepository
		{
			get
			{
				IProductsRepository repo = (IProductsRepository)_repositories.SingleOrDefault((x) => x is IProductsRepository);
				if(repo == null)
				{
					repo = new ProductsRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IRegionRepository RegionRepository
		{
			get
			{
				IRegionRepository repo = (IRegionRepository)_repositories.SingleOrDefault((x) => x is IRegionRepository);
				if(repo == null)
				{
					repo = new RegionRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public IShippersRepository ShippersRepository
		{
			get
			{
				IShippersRepository repo = (IShippersRepository)_repositories.SingleOrDefault((x) => x is IShippersRepository);
				if(repo == null)
				{
					repo = new ShippersRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public ISuppliersRepository SuppliersRepository
		{
			get
			{
				ISuppliersRepository repo = (ISuppliersRepository)_repositories.SingleOrDefault((x) => x is ISuppliersRepository);
				if(repo == null)
				{
					repo = new SuppliersRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public ITerritoriesRepository TerritoriesRepository
		{
			get
			{
				ITerritoriesRepository repo = (ITerritoriesRepository)_repositories.SingleOrDefault((x) => x is ITerritoriesRepository);
				if(repo == null)
				{
					repo = new TerritoriesRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		

	public partial class RF
	{
		public ISalesByCategoryRepository SalesByCategoryRepository
		{
			get
			{
				ISalesByCategoryRepository repo = (ISalesByCategoryRepository)_repositories.SingleOrDefault((x) => x is ISalesByCategoryRepository);
				if(repo == null)
				{
					repo = new SalesByCategoryRepository();
					repo.ConnectionProvider = _connectionProvider;
					_repositories.Add(repo);
				}
				return repo;
			}
		}
	}
		
}
