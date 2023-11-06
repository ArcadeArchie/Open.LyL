using Avalonia;
using Microsoft.Extensions.DependencyInjection;
using Open.LyL.Launcher.ViewModels;

namespace Open.LyL.Launcher;

/// <summary>
/// Used by for the Designer as a source of generated view models
/// </summary>
public static class DesignData
{
    public static MainWindowViewModel MainWindowViewModel { get; } =
        ((App)Application.Current!).GlobalHost!.Services.GetRequiredService<MainWindowViewModel>();
}
