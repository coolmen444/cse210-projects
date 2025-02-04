using System;

public class PromptGenerator 
{
    List<string> _prompts = new List<string>
{
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What is something new I learned today?",
    "Describe a small moment today that made you smile.",
    "What is something I accomplished today that I’m proud of?",
    "Did I step outside my comfort zone today? How?",
    "What is a challenge I faced today, and how did I handle it?",
    "Who is someone I am grateful for today, and why?",
    "What is a goal I want to set for tomorrow?",
    "What is something funny that happened today?",
    "What song, movie, or book impacted me today?",
    "If today had a theme or a title, what would it be and why?",
    "How did I show kindness to someone today?",
    "What is something I wish I had done differently today?",
    "What do I want to remember about today five years from now?",
    "What was the most peaceful moment of my day?",
    "If I could give advice to myself from this morning, what would it be?"
    
    //Credit: prompts generate by ChatGPT
};

    public string ReturnPrompt() {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}