using System;

namespace Pract13
{
    class LibraryItem
    {
        public string Name { get; set; }
        public string Autor { get; set; }
        public int PublicationYear { get; set; }
        public bool IsAvailable { get; set; }

        public LibraryItem(string name, string autor, int year, bool available)
        {
            Name = name;
            Autor = autor;
            PublicationYear = year;
            IsAvailable = available;
        }
    }
    class Book : LibraryItem
    {
        public int Pages { get; set; }
        public string ISBN { get; set; }

        public Book(string name, string autor, int year, bool available, int pages, string isbn) : base (name, autor, year, available)
        {
            Pages = pages;
            ISBN = isbn;
            Name = name;
            Autor = autor;
            PublicationYear = year;
            IsAvailable = available;
        }
    }
    class Magazine : LibraryItem
    {
        public int ReleaseNumber { get; set; }
        public int PeriodicityInDays { get; set; }

        public Magazine(string name, string autor, int year, bool available, int releaseNumber, int periodicityInDays) : base(name, autor, year, available)
        {
            ReleaseNumber = releaseNumber;
            PeriodicityInDays = periodicityInDays;
            Name = name;
            Autor = autor;
            PublicationYear = year;
            IsAvailable = available;
        }
    }
    class DVD : LibraryItem
    {
        public float DurationInSeconds { get; set; }
        public int Rating { get; set; }

        public DVD(string name, string autor, int year, bool available, float duration, int rating) : base(name, autor, year, available)
        {
            DurationInSeconds = duration;
            Rating = rating;
            Name = name;
            Autor = autor;
            PublicationYear = year;
            IsAvailable = available;
        }
    }
    class AudioBook : LibraryItem
    {
        public float DurationInSeconds { get; set; }
        public string Announcer { get; set; }

        public AudioBook(string name, string autor, int year, bool available, float duration, string announcer) : base(name, autor, year, available)
        {
            DurationInSeconds = duration;
            Announcer = announcer;
            Name = name;
            Autor = autor;
            PublicationYear = year;
            IsAvailable = available;
        }
    }
}