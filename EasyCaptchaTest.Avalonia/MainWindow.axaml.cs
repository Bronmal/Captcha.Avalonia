using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using EasyCaptcha.Avalonia;

namespace EasyCaptchaTest.Avalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        CaptchaAnswer.Content = "captcha answer: " + CaptchaControl.CaptchaText;
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        CaptchaControl.Generate();
        CaptchaAnswer.Content = "captcha answer: " + CaptchaControl.CaptchaText;
    }
    
    private void Button_OnClick1(object? sender, RoutedEventArgs e)
    {
        CaptchaControl.LetterOption = (Capthca.LetterOptionEnum)new Random().Next(0, 2);
        CaptchaControl.NumberOfLetters = (uint)new Random().Next(3, 8);
        CaptchaControl.Generate();
        CaptchaAnswer.Content = "captcha answer: " + CaptchaControl.CaptchaText;
    }
}