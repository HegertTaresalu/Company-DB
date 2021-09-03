using System;
using System.Collections.Generic;
using System.Text;

namespace TARge20.Core.Domain
{
    class Requests
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Request { get; set; }
        
        public Guid Id { get; set; }
    }
}
