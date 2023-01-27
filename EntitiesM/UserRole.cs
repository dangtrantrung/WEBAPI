using System;
using System.Collections.Generic;

namespace WEBAPI.EntitiesM
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public string RoleId { get; set; } = null!;
    }
}
