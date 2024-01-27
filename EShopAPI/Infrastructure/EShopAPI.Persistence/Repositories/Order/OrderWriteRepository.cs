using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopAPI.Application.Repositories.Order;
using EShopAPI.Persistence.Contexts;

namespace EShopAPI.Persistence.Repositories.Order
{
    public class OrderWriteRepository : WriteRepository<Domain.Entities.Order>,IOrderWriteRepository
    {
        public OrderWriteRepository(EShopAPIDbContext context) : base(context)
        {
        }
    }
}
