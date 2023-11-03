using Microsoft.Extensions.Logging;

namespace Open.LyL.Launcher.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly ILogger<MainWindowViewModel> _logger;

    public string Greeting => "Welcome to Avalonia!";

    public MainWindowViewModel(ILogger<MainWindowViewModel> logger)
    {
        _logger = logger;
    }
}
