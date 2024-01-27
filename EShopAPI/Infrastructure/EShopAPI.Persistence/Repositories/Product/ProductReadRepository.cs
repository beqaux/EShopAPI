using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopAPI.Application.Repositories.Product;
using EShopAPI.Persistence.Contexts;

namespace EShopAPI.Persistence.Repositories.Product
{
    public class ProductReadRepository : ReadRepository<Domain.Entities.Product>,IProductReadRepository
    {
        public ProductReadRepository(EShopAPIDbContext context) : base(context)
        {
        }
    }
}
