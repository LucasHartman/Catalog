using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Catalog.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Catalog.Repositories
{
    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item {Id= Guid.NewGuid(), Name="Potion", Price=9, CreateDate=DateTimeOffset.UtcNow},
            new Item {Id= Guid.NewGuid(), Name="Iron Sword", Price=20, CreateDate=DateTimeOffset.UtcNow},
            new Item {Id= Guid.NewGuid(), Name="Bronze Shield", Price=18, CreateDate=DateTimeOffset.UtcNow},
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }


    }
}