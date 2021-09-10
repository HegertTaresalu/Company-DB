using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Requests
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("Jobtitle")]
        public string JobTitle { get; set; }
        public string Request { get; set; }
        
        public Guid Id { get; set; }
    }
}
