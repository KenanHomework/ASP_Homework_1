using ASP_Homework_1.Interfaces;
using ASP_Homework_1.Services;

namespace ASP_Homework_1.Models
{
    public class FeedbackMessageFactory : IMessageFactory
    {

        public IMessage CreateMessage(object message)
        {
            ArgumentNullException.ThrowIfNull(message, nameof(message));

            return new FeedbackMessage(message as User);
        }
    }
}
