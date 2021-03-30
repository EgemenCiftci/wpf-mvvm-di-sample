using System.Collections.Generic;
using WPF_MVVM_DI_Sample.Models;

namespace WPF_MVVM_DI_Sample.Business.Abstract
{
    public interface IItemService
    {
        List<Item> All();
    }
}
