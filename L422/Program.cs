using System;

namespace L422
{
    public class Library
    {
        public string Author;
        public string Name;
        public string Publish;
        public int Year;
        public int Number;
        
        public Library(string Author, string Name, string Publish, int Year, int Number)
        {
            this.Author = Author;
            this.Name = Name;
            this.Publish = Publish;
            this.Year = Year;
            this.Number = Number;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть книг: ");
            int n = int.Parse(Console.ReadLine());
            Library[] a = new Library[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + "Книга"); 
                
                Console.Write("Автор: ");
                string Author = Console.ReadLine();
                Console.Write("Назва книги: ");
                string Name = Console.ReadLine();
                Console.Write("Видавництво: ");
                string Publish = Console.ReadLine();
                Console.Write("Рiк видання: ");
                int Year = int.Parse(Console.ReadLine());
                Console.Write("Кiлькiсть книг: ");
                int Number = int.Parse(Console.ReadLine());

                a[i] = new Library(Author, Name, Publish, Year, Number);

            }
            int t;
            string k;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].Year > a[j].Year)
                    {
                        t = a[i].Year;
                        a[i].Year = a[j].Year;
                        a[j].Year = t;
                        k = a[i].Author;
                        a[i].Author = a[j].Author;
                        a[j].Author = k;
                        k = a[i].Name;
                        a[i].Name = a[j].Name;
                        a[j].Name = k;
                        k = a[i].Publish;
                        a[i].Publish = a[j].Publish;
                        a[j].Publish = k;
                        t = a[i].Number;
                        a[i].Number = a[j].Number;
                        a[j].Number = t;

                    }
                }
            }
            Console.WriteLine("Автор\t\tНазва книги\t\tВидавництво\t\tРiк\t\tКiлькiсть книг");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i].Author+ "\t\t" + a[i].Name + "\t\t" + a[i].Publish + "\t\t" + a[i].Year + "\t\t" + a[i].Number);
            }
            int s = 1, d = a[0].Year;
            int[] r = new int[n];
            for (int i = 0; i < n; i++)
            {

                if (d == a[i].Year)
                    s++;
                else
                {
                    s = 1;
                    d = a[i].Year;
                    r[i] = a[i].Year;
                }

            }
            r[0] = a[0].Year;
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                if (r[i] == 0)
                    m++;
                else
                    r[i - m] = r[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (r[i] == 0)
                {
                    m = i;
                    break;
                }
            }
            
            int suma = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (r[i] == a[j].Year)
                    {
                        suma += a[j].Number;
                    }
                }
                Console.WriteLine("Видано книг за "+ r[i] + "рік: "+suma);
                suma = 0;
            }




        }
    }
}