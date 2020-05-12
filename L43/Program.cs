using System;
using System.IO;

namespace L43
{
    class Program
    {
        public static Library[] library = new Library[100];
        public static bool[] delete = new bool[100];
        static void Main(string[] args)
        {
            PutKey.Key();
        }

    }
    class Library
    {
        private int number;
        private string author;
        private string name;
        private int pages;
        private int year;

        public int Number
        {
            get => number;
            set => number = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Pages
        {
            get => pages;
            set => pages = value;
        }
        public int Year
        {
            get => year;
            set => year = value;
        }
        public Library(int number, string author, string name, int pages, int year)
        {
            Number = number;
            Author = author;
            Name = name;
            Pages = pages;
            Year = year;
            
        }
        
    }
    
}
