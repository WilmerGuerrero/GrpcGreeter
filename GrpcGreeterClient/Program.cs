using ConsoleTables;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Empty empty = new Empty();
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var product = new Producs.ProducsClient(channel);
            var reply = await product.GetProductsAsync(empty);

            var table = new ConsoleTable("Id", "StockId", "Name", "Price");
            for(int i=0; i< reply.Products.Count; i++)
            {
                table.AddRow(reply.Products[i].Id, reply.Products[i].StockId, reply.Products[i].Name, reply.Products[i].Price);
            }
            table.Write();
            Console.WriteLine();
            Console.WriteLine($"Press any key to exit...");
            Console.ReadKey();

        }
    }
}
