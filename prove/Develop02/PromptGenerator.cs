public class PromptGenerator
{
    public List<string> _prompts = new List<string>(){
        "If I had one thing I could do over today, what would it be?",
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What was my favorite meal today?",
        "What did I do before heading to bed today?",
        "What valuable lesson have I learned today?",
        "What are three things I am grateful for?"
    };

    public string GetPrompt()
    {
        /// get random index values and lookup the string in _prompts
        return "ran";
    }
}