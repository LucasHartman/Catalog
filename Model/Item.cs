using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Model
{
    public record Item
    {
        public Guid Id {get; init;}
        public string Name {get; init;}
        public decimal Price {get; init;}
        public DateTimeOffset CreateDate {get; init;}
        
    }
}