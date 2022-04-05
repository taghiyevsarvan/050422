using System;

namespace _050422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book()
            {
                Name = "Pich dad poor dad",
                AuthorName = "Robert Kiyosaki",
                Genre = (Genre)4,
                Price = 9.75
            };
            Book book2 = new Book()
            {
                Name = "Ivanhoe by Walter Scott",
                AuthorName = "Graham Tulloch",
                Genre = (Genre)3,
                Price = 11.99,
            };

            Book book3 = new Book()
            {
                Name = "The Other City",
                AuthorName = "Michal Ajvaz",
                Genre = (Genre)1,
                Price = 15
            };

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

        menu:
            Console.WriteLine("========MENU========");
            Console.WriteLine("1-Filter by price\n2-Filter by genre\n3-Find book by No\n4-Quit");
            Console.Write("\nYour choice: ");
            string choise = Console.ReadLine();
            bool quit = false;
            do
            {
                switch (choise)
                {
                    case "1":
                        Console.Write("Min Price: ");
                        double minPrice = (Convert.ToDouble(Console.ReadLine()));
                        Console.Write("Max Price: ");
                        double maxPrice = (Convert.ToDouble(Console.ReadLine()));
                        foreach (var book in library.FilterByPrice(minPrice, maxPrice))
                        {
                            Console.WriteLine(book.ShowInfo());
                        }
                        goto menu;
                    case "2":
                        Console.WriteLine("==Genre==");
                        Console.WriteLine("0-Fantacy\n1-Mystery\n2-Advanture\n3-Business");
                        int genre = int.Parse(Console.ReadLine()); 
                        Console.Write("Genre: ");
                        foreach (var item in library.FilterByGenre((Genre)genre))
                        {
                            Console.WriteLine(item.ShowInfo());
                        }
                        goto menu;
                    case "3":
                        Console.Write("Book No: ");
                        int bookNo =  int.Parse((Console.ReadLine()));
                        Console.WriteLine(library.FindBookByNo(bookNo).ShowInfo());
                        goto menu;
                    case "4":
                        quit = true;
                        Console.WriteLine("Prosses ended...");
                        break;
                    default:
                        Console.WriteLine("Choose between 1 and 4");
                        break;
                }
            } while (!quit);
        }
    }
}
