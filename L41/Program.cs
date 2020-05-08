using System;
using System.Security.Authentication;
namespace L41
{
    public class Student
    {
        //поля класу
        private string LastName;
        private string Group;
        private int Age;
        private int Year;
        private string Adress;
        private int Telephone;
        private int Rating;
        private string Passport;

        public Student()
        {
            //конструктор без параметрів
        }
        
        //методи get і set для полів класу
        public string passport
        {
            get
            {
                return Passport;
            }
            set
            {
                Passport = value;
            }
        }
        public int age
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            }
        }
        public int year
        {
            get
            {
                return Year;
            }
            set
            {
                Year = value;
            }
        }

        public string lastname
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        public string group
        {
            get
            {
                return Group;
            }
            set
            {
                Group = value;
            }
        }
        public string adress
        {
            get
            {
                return Adress;
            }
            set
            {
                Adress = value;
            }
        }
        public int telephone
        {
            get
            {
                return Telephone;
            }
            set
            {
                Telephone = value;
            }
        }
        public int rating
        {
            get
            {
                return Rating;
            }
            set
            {
                Rating = value;
            }
        }
        public static string StudentRating(int R)
        {
            string k = "";
            if (R > 90)
            {
                k = "Congratulations to A-student!";
            }

            else if (R>75 && R < 90 )
            {
                k = "You can study better";   
            }
            else if (R < 75)
            {
                k = "You must pay more attention to education";  
            }
            return k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Student st2 = new Student();
            Student st3 = new Student();

            st1.lastname = "Vlasenko";
            st1.group = "IT-11";
            st1.adress = "St.Bandery 2";
            st1.year = 2020;
            st1.passport = "IS-23-FK-32";
            st1.age = 17;
            st1.telephone = 193938389;
            st1.rating = 95;

            st2.lastname = "Khymych";
            st2.group = "IT-11";
            st2.adress = "Sichovy Strilci 3";
            st2.year = 2020;
            st2.passport = "IS-13-FT-38";
            st2.age = 17;
            st2.telephone = 1933567;
            st2.rating = 76;

            st3.lastname = "Babiy";
            st3.group = "IT-11";
            st3.adress = "Mazepy 56";
            st3.year = 2020;
            st3.passport = "IS-25-FY-92";
            st3.age = 17;
            st3.telephone = 35638389;
            st3.rating = 60;

            Console.WriteLine("\t\tFirst student");
            Console.WriteLine("Lastname: " + st1.lastname);
            Console.WriteLine("Group: " + st1.group);
            Console.WriteLine("Year: " + st1.year);
            Console.WriteLine("Adress: " + st1.adress);
            Console.WriteLine("Age: " + st1.age);
            Console.WriteLine("Passport: " + st1.passport);
            Console.WriteLine("Telephone: " + st1.telephone);
            Console.WriteLine("Rating: " + st1.rating);
            Console.WriteLine(Student.StudentRating(st1.rating));

            Console.WriteLine("\t\tSecond student");
            Console.WriteLine("Lastname: " + st2.lastname);
            Console.WriteLine("Group: " + st2.group);
            Console.WriteLine("Year: " + st2.year);
            Console.WriteLine("Adress: " + st2.adress);
            Console.WriteLine("Age: " + st2.age);
            Console.WriteLine("Passport: " + st2.passport);
            Console.WriteLine("Telephone: " + st2.telephone);
            Console.WriteLine("Rating: " + st2.rating);
            Console.WriteLine(Student.StudentRating(st2.rating));

            Console.WriteLine("\t\tThird student");
            Console.WriteLine("Lastname: " + st3.lastname);
            Console.WriteLine("Group: " + st3.group);
            Console.WriteLine("Year: " + st3.year);
            Console.WriteLine("Adress: " + st3.adress);
            Console.WriteLine("Age: " + st3.age);
            Console.WriteLine("Passport: " + st3.passport);
            Console.WriteLine("Telephone: " + st3.telephone);
            Console.WriteLine("Rating: " + st3.rating);
            Console.WriteLine(Student.StudentRating(st3.rating));

        }
    }
}
