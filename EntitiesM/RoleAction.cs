using System;
using System.Collections.Generic;

namespace WEBAPI.EntitiesM
{
    public partial class RoleAction
    {
        public int Id { get; set; }
        public string RoleId { get; set; } = null!;
        public int WebActionId { get; set; }
    }
}
