using System;

namespace Pract13
{
    class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Autor { get; set; }
        public decimal Price { get; set; }

        public Course(string name, string description, string autor, decimal price)
        {
            Name = name;
            Description = description;
            Autor = autor;
            Price = price;
        }
    }
    class VideoCourse : Course
    {
        public int CountOfVideo { get; set; }
        public int TotalDurationOfVideosInSeconds { get; set; }

        public VideoCourse(string name, string description, string autor, decimal price, int count, int duration) : base(name, description, autor, price)
        {
            CountOfVideo = count;
            TotalDurationOfVideosInSeconds = duration;
            Name = name;
            Description = description;
            Autor = autor;
            Price = price;
        }
    }
    class TextCourse : Course
    {
        public int CountOfChapters { get; set; }
        public int TotalCountOfPages { get; set; }

        public TextCourse(string name, string description, string autor, decimal price, int chapters, int pages) : base(name, description, autor, price)
        {
            CountOfChapters = chapters;
            TotalCountOfPages = pages;
            Name = name;
            Description = description;
            Autor = autor;
            Price = price;
        }
    }
    class InteractiveCourse : Course
    {
        public int CountOfExercises { get; set; }
        public string VerificationSystem { get; set; }

        public InteractiveCourse(string name, string description, string autor, decimal price, int exercises, string verification) : base(name, description, autor, price)
        {
            CountOfExercises = exercises;
            VerificationSystem = verification;
            Name = name;
            Description = description;
            Autor = autor;
            Price = price;
        }
    }
}