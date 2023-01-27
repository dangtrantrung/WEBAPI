using System;
using System.Collections.Generic;

namespace WEBAPI.EntitiesM
{
    public partial class Customer
    {
        public string Id { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Photo { get; set; } = null!;
        public bool Activated { get; set; }
    }
}
