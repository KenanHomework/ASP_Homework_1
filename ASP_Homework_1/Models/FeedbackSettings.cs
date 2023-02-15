using ASP_Homework_1.Interfaces;
using System.Text;

namespace ASP_Homework_1.Models;

public class FeedbackSettings : IClientSettings
{

    public enum FeedbackType { Thanks, Suggestion, Problem }

    public enum FeedbackProblemLevel { UI, Logical, Functional, Fatal }

    public enum FeedbackPriority { Low, Nominal, Middle, High, Fatal }


    public FeedbackType Type { get; set; } = FeedbackType.Thanks;

    public FeedbackProblemLevel? ProblemLevel { get; set; } = null;

    FeedbackPriority _priority;

    public bool Configure(ref object message)
    {
        if (message is not string) return false;

        var builder = new StringBuilder();

        if (Type == FeedbackType.Problem && ProblemLevel is null)
            throw new ArgumentNullException(nameof(ProblemLevel));

        int priorityIndex = 0;

        priorityIndex += (int)Type;

        priorityIndex += (int)(ProblemLevel ?? 0);

        if (priorityIndex > 4)
            priorityIndex = 4;

        switch (priorityIndex)
        {
            case 0:
                _priority = FeedbackPriority.Low; break;

            case 1:
                _priority = FeedbackPriority.Nominal; break;

            case 2:
                _priority = FeedbackPriority.Middle; break;


            case 3:
                _priority = FeedbackPriority.High; break;


            case 4:
                _priority = FeedbackPriority.Fatal; break;
            default:
                break;
        }

        builder.Append($"{Type}");



        builder.Append($" ~ {_priority} ~ ");


        if (ProblemLevel is not null)
            builder.Append($"~ {ProblemLevel} ~ ");

        message = builder.ToString();

        return true;
    }
}
