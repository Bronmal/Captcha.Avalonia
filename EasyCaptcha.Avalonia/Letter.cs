using Avalonia;
using Avalonia.Media;

namespace EasyCaptcha.Avalonia;

public class Letter
{
    public required FormattedText FormattedText;
    public required IBrush BrushText;
    public Matrix Matrix;
}