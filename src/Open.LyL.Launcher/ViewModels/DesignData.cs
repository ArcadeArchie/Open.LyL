using Avalonia;
using Microsoft.Extensions.DependencyInjection;
using Open.LyL.Launcher.ViewModels;

namespace Open.LyL.Launcher;

public static class DesignData
{
    public static MainWindowViewModel MainWindowViewModel { get; } =
        ((App)Application.Current!).GlobalHost!.Services.GetRequiredService<MainWindowViewModel>();
}
