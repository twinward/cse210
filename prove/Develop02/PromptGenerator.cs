using System;

public class PromptGenerator
{
    private List<string> morningPrompts;
    private List<string> eveningPrompts;
    private List<string> thoughtfulPrompts;
    private Random random;

    public PromptGenerator()
    {
        random = new Random();

        morningPrompts = new List<string>
        {
            "What was the most memorable dream I had last night?",
            "What’s on my mind this morning?",
            "What am I looking forward to today?",
            // Add more morning prompts here
        };

        eveningPrompts = new List<string>
        {
            "Who did I interact with today? What were those interactions like?",
            "What were the most important events today?",
            "What was the best thing that happened today?",
            // Add more evening prompts here
        };

        thoughtfulPrompts = new List<string>
        {
            "What is a current problem or challenge I am facing? What do I need to do to overcome it?",
            "How can I creatively express gratitude, love, or appreciation for someone in my life?",
            "What goals can I set for myself this week? How can I achieve them?",
            // Add more thoughtful prompts here
        };
    }

    public string GetRandomPrompt(int category)
    {
        List<string> selectedPrompts = new List<string>();
        switch (category)
        {
            case 1:
                selectedPrompts = morningPrompts;
                break;
            case 2:
                selectedPrompts = eveningPrompts;
                break;
            case 3:
                selectedPrompts = thoughtfulPrompts;
                break;
            default:
                break;
        }

        return selectedPrompts.Count > 0 ? selectedPrompts[random.Next(selectedPrompts.Count)] : "";
    }
}