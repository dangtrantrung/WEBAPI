using System;
using System.Collections.Generic;

namespace WEBAPI.EntitiesM
{
    public partial class Supplier
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
