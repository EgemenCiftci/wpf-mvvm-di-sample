using System.Collections.Generic;
using WPF_MVVM_DI_Sample.Data.Abstract;
using WPF_MVVM_DI_Sample.Models;

namespace WPF_MVVM_DI_Sample.Data.Repos
{
    public class ItemRepository : IItemRepository
    {
        public List<Item> GetAll()
        {
            return new()
            {
                new Item { Id = 1, Name = "Item1", Price = 100 },
                new Item { Id = 2, Name = "Item2", Price = 200 },
                new Item { Id = 3, Name = "Item3", Price = 300 },
            };
        }
    }
}
