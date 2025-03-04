using System;

public class Write()
{
    private List<string> prompts = new List<string>
        
        {
            "How did you start your day today? Any interesting plans?",
            "Did you experience any unexpected challenges at work or school?",
            "What's something new or exciting that happened today?",
            "Have you interacted with anyone new today? How did that go?",
            "Did you take any breaks today? What did you do during them?",
            "How did you manage your time today? Did you stay on track?",
            "What was the best part of your day so far?",
            "Did you learn something new today? What was it?",
            "Have you tried anything different today compared to your usual routine?",
            "Did you have any meaningful conversations today?",
            "What are you looking forward to this evening?",
            "Did something funny or unexpected happen today?",
            "What was one positive thing that happened today?",
            "Did you face any challenges today, and how did you overcome them?",
            "What was your main focus or goal today, and did you achieve it?",
            "Is there something that made you feel grateful today?",
            "Did you discover a new hobby or interest today?",
            "What did you do to unwind after a busy part of your day?",
            "What was the highlight of your work or study day?",
            "Was there a moment today that made you smile or laugh?"
        };

    public void displayPrompt()
    {
        Console.WriteLine(prompts);
    }
    
}