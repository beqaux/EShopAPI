using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopAPI.Application.Repositories.Order;
using EShopAPI.Persistence.Contexts;

namespace EShopAPI.Persistence.Repositories.Order
{
    public class OrderReadRepository : ReadRepository<Domain.Entities.Order>, IOrderReadRepository
    {
        public OrderReadRepository(EShopAPIDbContext context) : base(context)
        {
        }
    }
}
