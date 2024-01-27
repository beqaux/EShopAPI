using EShopAPI.Application.Repositories.Customer;
using EShopAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopAPI.Persistence.Repositories.Customer
{
    public class CustomerWriteRepository : WriteRepository<Domain.Entities.Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(EShopAPIDbContext context) : base(context)
        {
        }
    }
}
