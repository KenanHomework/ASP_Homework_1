using ASP_Homework_1.Interfaces;

namespace ASP_Homework_1.Services
{
    public class MessangerService
    {
        private readonly IClient _client;
        private readonly IMessageFactory _factory;

        public MessangerService(IMessageFactory factory, IClient client)
        {
            ArgumentNullException.ThrowIfNull(factory, nameof(factory));
            ArgumentNullException.ThrowIfNull(client, nameof(client));

            _factory = factory;
            _client = client;

        }

        public void SendMessage(object message)
        {
            IMessage appMessage = _factory.CreateMessage(message);
            _client.Send(appMessage);
        }
    }
}