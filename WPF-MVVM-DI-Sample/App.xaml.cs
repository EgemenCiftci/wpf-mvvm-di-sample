using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WPF_MVVM_DI_Sample.Business.Abstract;
using WPF_MVVM_DI_Sample.Business.Services;
using WPF_MVVM_DI_Sample.Data.Abstract;
using WPF_MVVM_DI_Sample.Data.Repositories;
using WPF_MVVM_DI_Sample.ViewModels;
using WPF_MVVM_DI_Sample.Views;

namespace WPF_MVVM_DI_Sample;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    private ServiceProvider _serviceProvider;

    private void Application_Startup(object sender, StartupEventArgs e)
    {
        ServiceCollection serviceCollection = new();
        ConfigureServices(serviceCollection);

        _serviceProvider = serviceCollection.BuildServiceProvider();

        Window mainWindow = _serviceProvider.GetRequiredService<Window>();
        MainView mainView = _serviceProvider.GetRequiredService<MainView>();
        mainView.DataContext = _serviceProvider.GetRequiredService<MainViewModel>();
        mainWindow.Content = mainView;
        mainWindow.Show();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        _ = services.AddSingleton<IItemService, ItemService>();
        _ = services.AddScoped<IItemRepository, ItemRepository>();
        _ = services.AddSingleton<MainViewModel>();
        _ = services.AddSingleton<MainView>();
        _ = services.AddSingleton<Window>();
    }
}