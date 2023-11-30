using BookStore.Models;

namespace BookStore
{
    class Program
    {

        static List<Book> BookList = new List<Book>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Bookstore Application! :)");

            while (true)
            {
                DisplayMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                       ViewSpecificBook();
                        break;
                    case "3":
                        ViewAllBooks();
                        break;
                    case "4":
                        Console.WriteLine("Closing the application. Goodbye!");
                        break;
                    case "5":
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
               Console.ReadKey();
                Console.Clear();
               
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Search for a specific book");
            Console.WriteLine("3. View all books");
            Console.WriteLine("2. Exit");
           
        }

        static void AddBook ()
        {
            Console.Write("Enter the title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author: ");
            string author = Console.ReadLine();

            Console.Write("Enter the ISBN: ");
            string isbn = Console.ReadLine();

            Book newBook = new Book { Title = title, Author = author, ISBN = isbn };
            BookList.Add(newBook);

            Console.WriteLine("Book was added successfully!");
            
        }
        static void ViewSpecificBook()
        {
            Console.Write("Enter the ISBN of the book: ");
            string IsbnSearch = Console.ReadLine();

            Book book = BookList.Find(book  => book.ISBN == IsbnSearch);

            if (book != null)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"ISBN: {book.ISBN}");
            }
            else
            {
                Console.WriteLine("Book not found.");
                Console.ReadKey();
            }
        }

        static void ViewAllBooks()
        {
            if (BookList.Count > 0)
            {
                foreach (var book in BookList)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN} ");
                }
            }
            else 
            {
                Console.WriteLine("There is currently no books available in the bookstore.");
                Console.ReadKey();
            }
        }
    }
}