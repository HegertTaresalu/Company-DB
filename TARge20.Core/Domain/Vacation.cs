using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Vacation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        public Guid Id { get; set; }

        [ForeignKey("IdentificationCode")]
        public Guid IdentificationCode { get; set; }

        [ForeignKey("Status")]
        public string Status { get; set; }


    }
}
