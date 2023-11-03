using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Open.LyL.Launcher.ViewModels;
using Open.LyL.Launcher.Views;
using System;

namespace Open.LyL.Launcher;

public partial class App : Application
{
    public IHost? GlobalHost { get; private set; }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override async void OnFrameworkInitializationCompleted()
    {
        GlobalHost = CreateHostBuilder().Build();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = GlobalHost.Services.GetRequiredService<MainWindowViewModel>(),
            };
            desktop.Exit += (_, _) =>
            {
                GlobalHost.StopAsync().GetAwaiter().GetResult();
                GlobalHost.Dispose();
                GlobalHost = null;
            };
        }
        DataTemplates.Add(GlobalHost.Services.GetRequiredService<ViewLocator>());

        base.OnFrameworkInitializationCompleted();

        await GlobalHost.StartAsync();
    }



    static HostApplicationBuilder CreateHostBuilder()
    {
        var builder = Host.CreateApplicationBuilder(Environment.GetCommandLineArgs());

        builder.Services.AddTransient<ViewLocator>();
        builder.Services.AddTransient<MainWindowViewModel>();

        return builder;
    }
        
}