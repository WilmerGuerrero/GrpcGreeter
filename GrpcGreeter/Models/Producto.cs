using System;
using System.Collections.Generic;

#nullable disable

namespace GrpcGreeter.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public int? Stockid { get; set; }
        public string Nombre { get; set; }
        public decimal? Precio { get; set; }
    }
}
