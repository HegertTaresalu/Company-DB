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

        [ForeignKey(nameof(Id))]
        public Guid Id { get; set; }

        [ForeignKey(nameof(IdentificationCode))]
        public Guid IdentificationCode { get; set; }

        [ForeignKey(nameof(Status))]
        public string Status { get; set; }


    }
}
