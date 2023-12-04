using System;
using System.Collections.Generic;
using BookStore.Interfaces;
using BookStore.Models;

namespace BookStore
{
    class Program
    {
        static List<IProduct> ProductList = new List<IProduct>();

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
                        AddAudiobook();
                        break;
                    case "3":
                        AddLoanableBook();
                        break;
                    case "4":
                        ViewAllProducts();
                        break;
                    case "5":
                        Console.WriteLine("Closing the application..");
                        return;
                    case "6":
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
            Console.WriteLine("2. Add an audiobook");
            Console.WriteLine("3. Borrow a book");
            Console.WriteLine("4. View all products");
            Console.WriteLine("5. Exit");
        }

        static void AddBook()
        {
            Console.Write("Enter the title of the book: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author of the book: ");
            string author = Console.ReadLine();

            Console.Write("Enter the ISBN of the book: ");
            string isbn = Console.ReadLine();

            Book book = new Book { Title = title, Author = author, ISBN = isbn };
            ProductList.Add(book);

            Console.WriteLine("Book was added successfully!");
        }

        static void AddAudiobook()
        {
            Console.Write("Enter the title of the audiobook: ");
            string title = Console.ReadLine();

            Console.Write("Enter the narrator of the audiobook: ");
            string narrator = Console.ReadLine();

            Audiobook audiobook = new Audiobook { Title = title, Narrator = narrator };
            ProductList.Add(audiobook);

            Console.WriteLine("The Audiobook was added successfully!");
        }

        static void AddLoanableBook()
        {
            Console.Write("Enter the title of the book: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author of the book: ");
            string author = Console.ReadLine();

            Console.Write("Enter the ISBN of the book: ");
            string isbn = Console.ReadLine();

            Console.Write("Enter the desired loan period (in days): ");
            int loanPeriod = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your name: ");
            string borrower = Console.ReadLine();

            LoanableBook loanableBook = new LoanableBook
            {
                Title = title,
                Author = author,
                ISBN = isbn,
                LoanPeriod = loanPeriod,
                Borrower = borrower
            };

            ProductList.Add(loanableBook);

            Console.WriteLine("The book was added successfully!");
        }

        static void ViewAllProducts()
        {
            if (ProductList.Count > 0)
            {
                foreach (var product in ProductList)
                {
                    Console.WriteLine(product.DisplayInfo());
                }
            }
            else
            {
                Console.WriteLine("There are currently no products available in the store.");
            }
        }
    }
}