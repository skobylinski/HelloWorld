using System;

namespace HelloWorld
{
    //Przy tworzeniu nowej metody maksymalnie jedna linia odstępu
    //Nowy plik powinien zawierać maksymalnie jedną klasę, dla kolejnych nowe pliki
    //Warto dodawać modyfikator dostępu "public" przed elementami w celu ułatwienia przeszukiwania kodu

    //PascalCase - sposób nazewnictwa dla nazw klas, plików, namespace, metod
    public class Program
    {
        public static void Main(string[] args)
        {
            //camelCase - sposób nazewnictwa dla lokalnych zmiennych i prywatnych elemntów programów (niepublicznych)
            string firstAndLastName = "Sebastian";

            //UPPER_CASE - sposób nazewnictwa 
            const double PI_NUMBER = 3.14;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Nazywam się Sebastian Kobyliński");
            Console.WriteLine("Cześć Wam");
            if (PI_NUMBER >2)
            {
            }
        }
    }
}
