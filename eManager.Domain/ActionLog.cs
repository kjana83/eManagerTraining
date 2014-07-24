using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager.Domain
{
    public class ActionLog
    {
        public int Id { get; set; }

        public string Controller { get; set; }
        public string Action { get; set; }
        public DateTime DateTime { get; set; }

    }
}
