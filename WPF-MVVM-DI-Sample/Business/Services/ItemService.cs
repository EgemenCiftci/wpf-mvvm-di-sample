using System.Collections.Generic;
using WPF_MVVM_DI_Sample.Business.Abstract;
using WPF_MVVM_DI_Sample.Data.Abstract;
using WPF_MVVM_DI_Sample.Models;

namespace WPF_MVVM_DI_Sample.Business.Services;

public class ItemService(IItemRepository itemRepository) : IItemService
{
    public List<Item> All()
    {
        return itemRepository.GetAll();
    }
}