public class QuoteGenerator {
    List<string> _quotes = new List<string>
    {
        "The best way to predict the future is to create it.",
        "Success is not final, failure is not fatal: It is the courage to continue that counts.",
        "In the middle of every difficulty lies opportunity.",
        "It does not matter how slowly you go as long as you do not stop.",
        "Hardships often prepare ordinary people for an extraordinary destiny.",
        "Believe you can and you're halfway there.",
        "The only way to do great work is to love what you do.",
        "Your time is limited, so don't waste it living someone else's life.",
        "The only limit to our realization of tomorrow is our doubts of today.",
        "It always seems impossible until it's done.",
        "The future belongs to those who believe in the beauty of their dreams.",
        "The only person you are destined to become is the person you decide to be.",
        "What lies behind us and what lies before us are tiny matters compared to what lies within us.",
        "The road to success and the road to failure are almost exactly the same.",
        "Don't watch the clock; do what it does. Keep going.",
        "Opportunities don't happen, you create them.",
        "Success usually comes to those who are too busy to be looking for it.",
        "Don't be pushed around by the fears in your mind. Be led by the dreams in your heart.",
        "It’s not whether you get knocked down, it’s whether you get up.",
        "We may encounter many defeats, but we must not be defeated.",
        "The only way to achieve the impossible is to believe it is possible.",
        "You are never too old to set another goal or to dream a new dream.",
        "If you can dream it, you can do it.",
        "Start where you are. Use what you have. Do what you can.",
        "Success is not how high you have climbed, but how you make a positive difference to the world.",
        "Success is walking from failure to failure with no loss of enthusiasm.",
        "Hard work beats talent when talent doesn’t work hard.",
        "A journey of a thousand miles begins with a single step.",
        "If you want to go fast, go alone. If you want to go far, go together.",
        "Success is not in what you have, but who you are."
    };

    public string ReturnQuote() {
        Random random = new Random();
        return _quotes[random.Next(_quotes.Count)];
    }

}