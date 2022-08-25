using System.Collections.Generic;
using WPF_MVVM_DI_Sample.Models;

namespace WPF_MVVM_DI_Sample.Data.Abstract;

public interface IItemRepository
{
    List<Item> GetAll();
}