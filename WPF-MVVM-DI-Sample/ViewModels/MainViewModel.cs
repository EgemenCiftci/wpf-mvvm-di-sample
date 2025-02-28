using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using WPF_MVVM_DI_Sample.Business.Abstract;
using WPF_MVVM_DI_Sample.Models;

namespace WPF_MVVM_DI_Sample.ViewModels;

public class MainViewModel(IItemService itemService) : ObservableObject
{
    private ObservableCollection<Item> items = new(itemService.All());

    public ObservableCollection<Item> Items
    {
        get => items;
        set => SetProperty(ref items, value);
    }

    private string text = "Hello World!";

    public string Text
    {
        get => text;
        set => SetProperty(ref text, value);
    }
}