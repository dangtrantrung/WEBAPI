using System;
using System.Collections.Generic;

namespace WEBAPI.EntitiesM
{
    public partial class Order
    {
        public int Id { get; set; }
        public string CustomerId { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public DateTime RequireDate { get; set; }
        public string Receiver { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Description { get; set; }
        public double Amount { get; set; }
    }
}
