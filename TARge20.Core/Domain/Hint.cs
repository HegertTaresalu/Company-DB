using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Hint
    {
        [Key]
        public string hint { get; set; }
    }
}
