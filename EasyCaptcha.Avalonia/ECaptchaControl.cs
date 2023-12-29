using Avalonia.Controls;
using Avalonia.Media;

namespace EasyCaptcha.Avalonia;

public class ECaptchaControl : Control
{
    private Capthca _capthca = new();
    public Capthca.LetterOptionEnum LetterOption = Capthca.LetterOptionEnum.Alphanumeric;

    public uint NumberOfLetters
    {
        get => _capthca.NumberOfLetters;
        set => _capthca.NumberOfLetters = value;
    }

    public ECaptchaControl()
    {
        _capthca.GenerateNew(LetterOption, NumberOfLetters);
    }
    
    public sealed override void Render(DrawingContext context)
    {
        _capthca.DrawCaptcha(context, Bounds);
        base.Render(context);
    }

    public string CaptchaText
    {
        get => _capthca.CaptchaText;
    }

    public void Generate()
    {
        _capthca.GenerateNew(LetterOption, NumberOfLetters);
        InvalidateVisual();
    }
}