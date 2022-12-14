// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

namespace Support.CSharp.Commands;

public class ButtonClickCommand : CommandBase
{
    public ButtonClickCommand(Action<string> callback)
        => _callback = callback;

    private readonly Action<string>? _callback;

    public override void Execute(object? parameter)
        => _callback?.Invoke(parameter as string ?? string.Empty);
}