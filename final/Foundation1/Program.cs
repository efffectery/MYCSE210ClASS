using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Joe Mama", "lol this is funny");
        Comment comment2 = new Comment("Deez Trabama", "good job on the video");
        Comment comment3 = new Comment("Ben Dover", "wow I will share with my friends");
        Comment comment4 = new Comment("Hugh Blackman", "This made my day!");
        Comment comment5 = new Comment("Al Beback", "Awesome content, keep it up!");
        Comment comment6 = new Comment("Anita Bath", "Hilarious! Can't stop laughing.");
        Comment comment7 = new Comment("Sal Mon", "Great work, looking forward to more.");
        Comment comment8 = new Comment("Ivana Tinkle", "This deserves way more views!");
        Comment comment9 = new Comment("Olive Clothes", "Super entertaining, loved it!");

        List<Comment> list1 = new List<Comment> {comment1, comment2, comment3};
        List<Comment> list2 = new List<Comment> {comment4, comment5, comment6};
        List<Comment> list3 = new List<Comment> {comment7, comment8, comment9};

        Video video1 = new Video("how to dance", "joe trump", 4000, list1);
        Video video2 = new Video("how to do a handstand", "Zergling schzicenburg", 3000, list2);
        Video video3 = new Video("how to eat food", "michal jackson", 2000, list3);

        List<Video> videos = new List<Video> {video1, video2, video3};

        foreach(Video video in videos)
        {
            video.DisplayVideo();
        }






    }
}