using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
   public class Access
    {
        [Key]
        public Guid Id { get; set; }

        public string JobTitle { get; set; }

    }
}
