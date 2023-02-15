using ASP_Homework_1.Interfaces;
using System.Diagnostics;
using System.Text;

namespace ASP_Homework_1.Models;

public class FeedbackClient : IClient
{
    private readonly FeedbackSettings _settings;

    public FeedbackClient(FeedbackSettings settings)
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

        object messageString = "";
        _settings.Configure(ref messageString);
        messageString += message.Message();
        Debug.WriteLine(messageString);
    }
}