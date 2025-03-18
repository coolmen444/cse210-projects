using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("How to get rich quick!", "TheRichGuy", 460);
        Video vid2 = new Video("Cooking 101", "ChefMaster", 300);
        Video vid3 = new Video("Travelling to China!", "WanderingJohn", 720);
        Video vid4 = new Video("Tech Reviews", "GadgetGuru", 540);

        List<Video> videoList = new List<Video>
        {
            vid1, vid2, vid3, vid4
        };

        vid1.AddComment("Jon", "This video is lame!");
        vid1.AddComment("bilbo34", "I want to get rich");
        vid1.AddComment("Sara-Kara", "Wow! That's so easy! :D :D loll");
        // These comments generated with AI to save time:
        vid1.AddComment("richieRich", "Great tips, thanks!");
        vid2.AddComment("foodie123", "This recipe is amazing!");
        vid2.AddComment("chefMike", "I love your cooking style.");
        vid2.AddComment("homeCook", "Can't wait to try this.");
        vid3.AddComment("traveler", "China looks beautiful!");
        vid3.AddComment("adventureSeeker", "Adding this to my bucket list.");
        vid3.AddComment("globetrotter", "Great travel tips!");
        vid4.AddComment("techFan", "Love your reviews!");
        vid4.AddComment("gadgetLover", "Very informative.");
        vid4.AddComment("techie", "Can't wait to buy this gadget.");
        
        foreach (Video video in videoList)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}