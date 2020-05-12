using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace L43
{
    class function
    {

        private static void Save(Library l)
        {
            StreamWriter save = new StreamWriter("library.txt", true);

            save.WriteLine(l.Number);
            save.WriteLine(l.Author);
            save.WriteLine(l.Name);
            save.WriteLine(l.Pages);
            save.WriteLine(l.Year);

            save.Close();
        }

        public static void P(string[] elements, bool save)
        {
            int counter = 0;

            while (Program.library[counter] != null)
            {
                ++counter;
            }

            for (int i = 0; i < elements.Length; i += 5)
            {
                Program.library[counter + i / 5] = new Library(int.Parse(elements[i]), elements[i + 1], elements[i + 2], int.Parse(elements[i + 3]), int.Parse(elements[i + 4]));
                if (save)
                {
                    Save(Program.library[counter + i / 5]);
                }
            }
        }
        public static string[] Read()
        {
            StreamReader fromFile = new StreamReader("library.txt");

            return fromFile.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        }

        public static void Add()
        {
            Console.WriteLine("\nEnter data:");

            string str = Console.ReadLine();

            string[] elements = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            P(elements, true);

            PutKey.Key();
        }
        public static void Remove()
        {
            Console.Write("\nAuthor: ");

            string author = Console.ReadLine();

            bool[] write = new bool[Program.library.Length];

            for (int i = 0; i < Program.library.Length; ++i)
            {
                if (Program.library[i] != null)
                {
                    if (Program.library[i].Author == author)
                    {
                        Console.WriteLine("{0,-15} {1, -15} {2, -30} {3, -30} {4, -15}", Program.library[i].Number, Program.library[i].Author, Program.library[i].Name, Program.library[i].Pages, Program.library[i].Year);

                        Console.WriteLine("Remove? (Y/N)");

                        var key = Console.ReadKey().Key;

                        if (key == ConsoleKey.Y)
                        {
                            Program.delete[i] = true;
                        }
                        else
                        {
                            Program.delete[i] = false;
                        }
                    }
                }
            }
            PutKey.Key();
        }
        public static void Edit()
        {
            Console.Write("\nAuthor: ");

            string author = Console.ReadLine();

            bool[] write = new bool[Program.library.Length];

            for (int i = 0; i < Program.library.Length; ++i)
            {
                if (Program.library[i] != null)
                {
                    if (Program.library[i].Author == author)
                    {
                        Console.WriteLine("{0,-15} {1, -15} {2, -30} {3, -30} {4, -15}", Program.library[i].Number, Program.library[i].Author, Program.library[i].Name, Program.library[i].Pages, Program.library[i].Year);

                        Console.WriteLine("Write new info: ");

                        string str = Console.ReadLine();

                        string[] elements = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                        Program.library[i] = new Library(int.Parse(elements[0]), elements[1], elements[2], int.Parse(elements[3]), int.Parse(elements[4]));
                    }
                }
            }
            PutKey.Key();
        }
        public static void Find()
        {
            Console.Write("\nAuthor: ");

            string author = Console.ReadLine();

            bool[] write = new bool[Program.library.Length];

            for (int i = 0; i < Program.library.Length; ++i)
            {
                if (Program.library[i] != null)
                {
                    if (Program.library[i].Author== author)
                    {
                        write[i] = true;
                    }
                    else
                    {
                        write[i] = false;
                    }
                }

            }

            Output.Write1(Program.library, write);

            PutKey.Key();
        }
        public static void Sort()
        {
            int index = 0;

            while (Program.library[index + 1] != null)
            {
                for (int i = 0; i < Program.library.Length - 1; ++i)
                {
                    if (Program.library[i + 1] != null)
                    {
                        if (Program.library[i].Year > Program.library[i + 1].Year)
                        {
                            string Str;
                            int Int;

                            Int = Program.library[i].Number;
                            Program.library[i].Number = Program.library[i + 1].Number;
                            Program.library[i + 1].Number = Int;

                            Str = Program.library[i].Author;
                            Program.library[i].Author = Program.library[i + 1].Author;
                            Program.library[i + 1].Author = Str;

                            Str = Program.library[i].Name;
                            Program.library[i].Name = Program.library[i + 1].Name; ;
                            Program.library[i + 1].Name = Str;

                            Int = Program.library[i].Pages;
                            Program.library[i].Pages = Program.library[i + 1].Pages;
                            Program.library[i + 1].Pages= Int;

                            Int = Program.library[i].Year;
                            Program.library[i].Year = Program.library[i + 1].Year;
                            Program.library[i + 1].Year = Int;

                        }
                    }
                }

                ++index;
            }

            Output.Write(Program.library);

            PutKey.Key();
        }

    }
    class PutKey
    {
        public static void Key()
        {
            function.P(function.Read(), false);

            Console.WriteLine("Add note: +");
            Console.WriteLine("Edit note: E");
            Console.WriteLine("Remove note: R");
            Console.WriteLine("Show notes: Enter");
            Console.WriteLine("Search notes: F");
            Console.WriteLine("Sort notes: S");
            Console.WriteLine("Exit: Esc");

            switch (Console.ReadKey().Key) 
            {
                case ConsoleKey.OemPlus:
                    function.Add();
                    break;

                case ConsoleKey.Enter:
                    Output.Write(Program.library);
                    break;

                case ConsoleKey.Escape:
                    return;

                case ConsoleKey.E:
                    function.Edit();
                    break;

                case ConsoleKey.R:
                    function.Remove();
                    break;

                case ConsoleKey.S:
                    function.Sort();
                    break;

                case ConsoleKey.F:
                    function.Find();
                    break;
            }


        }
    }
    class Output
    {
        public static void Write(Library[] l)
        {
            Console.WriteLine("Iнвентарний номер\tAвтор\t\t\tНазва\t\tКiлькiсть сторiнок\t\tРiк видання");

            for (int i = 0; i < l.Length; ++i)
            {
                if (l[i] != null)
                {
                    Console.WriteLine("{0}\t\t\t {1} \t\t{2} \t\t{3} \t\t\t{4}", Program.library[i].Number, Program.library[i].Author, Program.library[i].Name, Program.library[i].Pages, Program.library[i].Year);
                }
            }
        }

        public static void Write1(Library[] l, bool[] write)
        {
            Console.WriteLine("Iнвентарний номер\tAвтор\t\t\tНазва\t\tКiлькiсть сторiнок\t\tРiк видання");

            for (int i = 0; i < l.Length; ++i)
            {
                if ((write[i]) && (!Program.delete[i]))
                {
                    Console.WriteLine("{0} \t\t\t{1} \t\t{2} \t\t{3}\t\t {4}", Program.library[i].Number, Program.library[i].Author, Program.library[i].Name, Program.library[i].Pages, Program.library[i].Year);
                }
            }
        }
    }

}