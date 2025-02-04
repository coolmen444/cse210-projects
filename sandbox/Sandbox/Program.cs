using System;

class Program
{
    static void Main(string[] args)
    {
        Movie favoriteMovie = new Movie();
        favoriteMovie._title = "Star Wars";
        favoriteMovie._year = 1977;
        favoriteMovie._rating = "G";
        favoriteMovie._runtime = 150;

        Movie otherMovie = new Movie();
        otherMovie._title = "Avatar";
        otherMovie._year = 2009;
        otherMovie._rating = "PG-13";
        otherMovie._runtime = 162;

        // Console.Write(favoriteMovie._title);
        DisplayMovie(favoriteMovie);
        DisplayMovie(otherMovie);

        favoriteMovie.Display();
    }

    static void DisplayMovie(Movie aMovie) 
    {
        Console.WriteLine($"{aMovie._title} - {aMovie._year}");
    }









































    static int Multiply(int number1, int number2)
    {
        int product = number1 * number2;
        return product;
    }
    static string GetAdjective() 
    {
        List<string> words = new List<string>();

        words.Add("blue");
        words.Add("yellow");
        words.Add("big");
        words.Add("small");

        string adjective = words[2];

        return adjective;
    }

    static string GetNoun()
    {
        string noun = "camel";

        return noun;
    }

}


 //     // This is a comment
    //     string adjective = GetAdjective();
    //     string noun = GetNoun();
    //     int number = Multiply(3,4);

    //     Console.WriteLine($"I looked out the window and saw {number} {adjective} {noun}s.");
    //     Console.ForegroundColor = ConsoleColor.Magenta;
    //     Console.WriteLine(@"
    //               ,,__
    //     ..  ..   / o._)                   .---.
    //    /--'/--\  \-'||        .----.    .'     '.
    //   /        \_/ / |      .'      '..'         '-.
    // .'\  \__\  __.'.'     .'          i-._
    //   )\ |  )\ |      _.'
    //  // \\ // \\
    // ||_  \\|_  \\_
    // '--' '--'' '--'
    //     ");
    //     Console.ResetColor();