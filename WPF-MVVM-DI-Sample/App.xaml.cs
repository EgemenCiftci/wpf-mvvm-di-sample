﻿using DevExpress.Mvvm;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WPF_MVVM_DI_Sample.Business.Abstract;
using WPF_MVVM_DI_Sample.Business.Services;
using WPF_MVVM_DI_Sample.Data.Abstract;
using WPF_MVVM_DI_Sample.Data.Repositories;
using WPF_MVVM_DI_Sample.ViewModels;
using WPF_MVVM_DI_Sample.Views;

namespace WPF_MVVM_DI_Sample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider ServiceProvider;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ServiceCollection serviceCollection = new();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            Window mainWindow = ServiceProvider.GetRequiredService<Window>();
            MainView mainView = ServiceProvider.GetRequiredService<MainView>();
            mainView.DataContext = ServiceProvider.GetRequiredService<MainViewModel>();
            mainWindow.Content = mainView;
            mainWindow.Show();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            _ = services.AddSingleton<IItemService, ItemService>();
            _ = services.AddScoped<IItemRepository, ItemRepository>();
            _ = services.AddSingleton(typeof(MainViewModel));
            _ = services.AddSingleton(typeof(MainView));
            _ = services.AddSingleton(typeof(Window));
        }
    }
}
