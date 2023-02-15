using ASP_Homework_1.Interfaces;
using System.Diagnostics;

namespace ASP_Homework_1.Models;

public class DebugClient : IClient
{
    private readonly DebugSettings _settings;

    public DebugClient(DebugSettings settings)
    {
        _settings = settings;
    }

    public void Send(IMessage message)
    {
        // Use settings propertys...
        // Example:
        //object listener = new();
        //if (!_settings.Configure(ref listener))
        //    return;

        Debug.WriteLine(message.Message());
    }
}