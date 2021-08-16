using GrpcGreeter.Contexts;
using GrpcGreeter.Contracts;
using GrpcGreeter.Models;
using GrpcGreeter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter.Implementations
{
    public class ProductsRepository:Repository<Products>, IProductsRepository
    {
        private readonly DesuperheroesvipContext _context;

        public ProductsRepository(DesuperheroesvipContext context):base(context)
        {
            _context = context;
        }
    }
}
