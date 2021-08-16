using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter.Contracts
{
    public interface IRepository<T> where T: class
    {
        Task<List<T>> GetAll();
    }
}
