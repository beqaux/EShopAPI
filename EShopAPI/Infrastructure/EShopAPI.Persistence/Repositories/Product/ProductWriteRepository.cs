using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopAPI.Application.Repositories.Product;
using EShopAPI.Persistence.Contexts;

namespace EShopAPI.Persistence.Repositories.Product
{
    public class ProductWriteRepository : WriteRepository<Domain.Entities.Product>,IProductWriteRepository
    {
        public ProductWriteRepository(EShopAPIDbContext context) : base(context)
        {
        }
    }
}
