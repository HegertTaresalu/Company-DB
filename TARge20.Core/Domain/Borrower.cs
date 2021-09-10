using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Borrower
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("Id")]
        public Guid Id { get; set; }
        
        public ICollection<Borrowed_Item> Borrowed_Items { get; set; }
        public ICollection<Things_to_borrow> Things_To_Borrows { get; set; }

    }
}
