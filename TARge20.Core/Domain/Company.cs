using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    class Company
    {
        [ForeignKey("Employees")]
        public string Employees { get; set; }

        public string Management { get; set; }
    }
}
