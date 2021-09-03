using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    class Borrower
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("Id")]
        public Guid Id { get; set; }

    }
}
