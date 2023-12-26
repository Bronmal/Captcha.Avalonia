using Avalonia.Controls;
using Avalonia.Interactivity;
using EasyCaptcha.Avalonia;

namespace EasyCaptchaTest.Avalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        CaptchaControl.Generate();
    }
}