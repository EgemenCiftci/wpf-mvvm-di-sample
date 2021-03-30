using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using WPF_MVVM_DI_Sample.Business.Abstract;
using WPF_MVVM_DI_Sample.Models;

namespace WPF_MVVM_DI_Sample.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
#pragma warning disable IDE0052 // Remove unread private members
        private readonly IItemService itemService;
#pragma warning restore IDE0052 // Remove unread private members

        public ObservableCollection<Item> Items
        {
            get => GetProperty(() => Items);
            set => SetProperty(() => Items, value);
        }

        public string Text
        {
            get => GetProperty(() => Text);
            set => SetProperty(() => Text, value);
        }

        public MainViewModel(IItemService itemService)
        {
            this.itemService = itemService;
            Items = new ObservableCollection<Item>(itemService.All());
            Text = "Hello World!";
        }
    }
}
