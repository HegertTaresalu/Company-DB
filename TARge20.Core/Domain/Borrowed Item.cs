using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Borrowed_Item
    {
        [ForeignKey("Item")]
        public string Item {get;set; }
    }
}
