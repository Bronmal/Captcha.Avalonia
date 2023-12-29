# Captcha.Avalonia

Nuget Install:
>Install-Package Capthca.Avalonia

Declair in Xaml:
```C#
    xmlns:capthca="clr-namespace:Captcha.Avalonia;assembly=Captcha.Avalonia"
    <capthca:CaptchaAvalonia Width="200" Height="50" Name="MyCaptcha"/>
````

Methods:
```C#
    public void Generate() // generate new captha
````

Properties:
```C#
    public uint NumberOfLetters
    public string CaptchaText
        
    public enum LetterOption
    {
        Number,
        Alphabet,
        Alphanumeric,
    }
````