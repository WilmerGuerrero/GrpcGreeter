using GrpcGreeter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter.Contracts
{
    public interface IProductsRepository: IRepository<Products>
    {
        
    }
}
