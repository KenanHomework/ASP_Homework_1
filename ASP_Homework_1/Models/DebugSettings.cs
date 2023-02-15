using ASP_Homework_1.Interfaces;
namespace ASP_Homework_1.Models;

public class DebugSettings : IClientSettings
{
    public int Port { get; set; }
    public string Host { get; set; }

    public bool Configure(ref object param)
    {
        // configure something..
        //  Example TcpListener ))

        return true;
    }
}
