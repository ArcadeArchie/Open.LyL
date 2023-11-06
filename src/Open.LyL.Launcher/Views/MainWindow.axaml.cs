using Avalonia.Controls;
using Avalonia.ReactiveUI;
using Open.LyL.Launcher.ViewModels;

namespace Open.LyL.Launcher.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }
}