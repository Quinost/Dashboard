using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Shared
{
    public class LockoutUserModel
    {
        public int? Id { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
    }
}
