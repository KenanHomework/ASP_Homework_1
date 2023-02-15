using ASP_Homework_1.Interfaces;

namespace ASP_Homework_1.Models
{
    public class FeedbackMessage : IMessage
    {
        public FeedbackMessage() { }

        public FeedbackMessage(User user) => User = user ?? throw new ArgumentNullException(nameof(user));


        public User User { get; set; } = new User();


        public string Message() => $"{User.Username} ~ {User.Email} : {User.Feedback}" ?? "empty  feedback";
    }

}

