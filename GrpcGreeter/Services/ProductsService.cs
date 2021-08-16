using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcGreeter.Contracts;
using GrpcGreeter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter.Services
{
    public class ProductsService : Producs.ProducsBase
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public override async Task<ProductResponseList> GetProducts(Empty request, ServerCallContext context)
        {
            var result = await _productsRepository.GetAll().ContinueWith(x => x
                                 .Result.Select(y => new ProductResponse { Id = y.Id, Name = y.Nombre, Price = (double)y.Precio, StockId = (int)y.Stockid }).ToList());

            var response = new ProductResponseList();
            response.Products.Add(result);
            return await Task.FromResult(response);
        }
    }
}
