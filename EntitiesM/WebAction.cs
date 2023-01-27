using System;
using System.Collections.Generic;

namespace WEBAPI.EntitiesM
{
    public partial class WebAction
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
