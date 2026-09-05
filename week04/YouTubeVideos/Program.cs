using System;
using System.CollectionsGeneric;

public class Program
{
    public static void Main(string[] args)
    {
        Video video1 = new Video(
            "Learning C#",
            "John Smith",
            600
        );

        Video video2 = new Video(
            "How to Make Pizza",
            "Jane Doe"
        );

        Video video3 = new Video(
            "David",
            "I learned a lot from this video."
        );

        Video video4 = new Video(
            "Introduction to Programming",
            "Code Acedemy",
            900
        );
        // Add commets to video 1
        video1.AddComment(new Comment("Alice", "This was very helpful!"));
        video1.AddComment(new Comment("Bob", "I learned a lot from this video."));
        video1.AddComment(new Comment("Charlie", "Great explanation of C#!"));
        video1.AddComment(new Comment("Diana", "Thanks for sharing!"));

        // Add comments to video 2
        video2.AddComment(new Comment("Mike", "That pizza looks delicious!"));
        video2.AddComment(new Comment("Sarah", "I am going to try this recipe."));
        video2.AddComment(new Comment("Tom", "What kind of cheese did you use?"));
        video2.AddComment(new Comment("Emma", "Great recipe!"));

        // Add comments to video 3
        video3.AddComment(new Comment("James", "I want to visit Japan."));
        video3.AddComment(new Comment("Laura", "These destinations look amazing."));
        video3.AddComment(new Comment("Chris", "Great travel suggestions!"));
        video3.AddComment(new Comment("Sophia", "Adding these to my bucket list."));

        // Add comments to video 4
        video4.AddComment(new Comment("Daniel", "This is a great introduction."));
        video4.AddComment(new Comment("Olivia", "Programming is really interesting."));
        video4.AddComment(new Comment("William", "I finally understand the basics."));
        video4.AddComment(new Comment("Emily", "Looking forward to learning more."));

        // Put all videos into a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        // Display each video
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}