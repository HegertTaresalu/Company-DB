using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Healthcheck
    {
        

       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("Id")]
        public Guid Id { get; set; }
    }
}
