using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        videoList.Add(new Video("How to draw Mangá", "Mangá Maker", 220));
        videoList.Add(new Video("The Future Mark Zuckerberg Is Trying To Build", "Cleo Abram", 2820));
        videoList.Add(new Video("Linkin Park - Lofi Jazz", "Retroera", 3120));

        videoList[0].AddComment("Artur", "Nice video!!");
        videoList[0].AddComment("John", "Wooow! I learned a lot!");
        videoList[0].AddComment("Milla", "I think this is preety good");

        videoList[1].AddComment("JayFriedrichs", "1st podcast episode being Mark Zuckerberg?!! Wow Cleo!");
        videoList[1].AddComment("Ak__4285", "So glad Cleo is making time for smaller YouTubers and giving them a platform to speak , you go girl ♥");
        videoList[1].AddComment("ColinandSamir", "Huge.");

        videoList[2].AddComment("denimforeve", "I'VE BECOME SO chill");
        videoList[2].AddComment("noavemusic", "I would love to sit in this cafe all day and just listening to Linkin park and talking to other fans about how amazing LP is");
        videoList[2].AddComment("rgperez3254", "The fan service I never knew I needed");

        foreach (Video video in videoList)
        {
            video.DisplayVideos();
        }



    }
}

