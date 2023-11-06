using Microsoft.Extensions.Logging;
using ReactiveUI;
using System;
using System.Linq;

namespace Open.LyL.Launcher.ViewModels;

public class MainWindowViewModel : ViewModelBase, IActivatableViewModel
{
    private readonly ILogger<MainWindowViewModel> _logger;

    public string Greeting => "Welcome to Avalonia!";

    public ViewModelActivator Activator { get; } = new();

    public MainWindowViewModel(ILogger<MainWindowViewModel> logger)
    {
        _logger = logger;
        this.WhenActivated(() =>
        {
            _logger.LogInformation("MainVM greeted '{greeting}'", Greeting);
            return Enumerable.Empty<IDisposable>();
        });
    }
}
