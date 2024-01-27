using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopAPI.Application.Repositories.Customer;
using EShopAPI.Persistence.Contexts;

namespace EShopAPI.Persistence.Repositories.Customer
{
    public class CustomerReadRepository : ReadRepository<Domain.Entities.Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(EShopAPIDbContext context) : base(context)
        {
        }
    }
}
