using ASP_Homework_1.Interfaces;

namespace ASP_Homework_1.Models
{
    public class DebugMessage : IMessage
    {
        public DebugMessage() { }

        public DebugMessage(User user) => User = user ?? throw new ArgumentNullException(nameof(user));


        public User User { get; set; } = new User();


        public string Message() => $"{User.Username} ~ {User.Email} : {User.Feedback}" ?? "empty  feedback";
    }

}

