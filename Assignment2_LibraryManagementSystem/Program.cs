// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// using System;
// using LibraryManagementSystem.Models;

// namespace LibraryManagementSystem
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Library library = new Library();

//             // Adding Books
//             Book book1 = new Book("C# Programming", "John Doe", "B001", 3);
//             Book book2 = new Book("Introduction to Algorithms", "Thomas H. Cormen", "B002", 2);

//             library.AddBook(book1);
//             library.AddBook(book2);

//             // Adding Members
//             Member member1 = new Member("Alice Smith", "M001");
//             Member member2 = new Member("Bob Johnson", "M002");

//             library.AddMember(member1);
//             library.AddMember(member2);

//             // Borrow Book
//             library.BorrowBook("B001", "M001");
//             library.BorrowBook("B002", "M002");

//             // Display Books
//             library.DisplayBooks();

//             // Return Book
//             library.ReturnBook("B001");

//             // Display Books
//             library.DisplayBooks();

//             Console.WriteLine("Press any key to exit...");
//             Console.ReadKey();
//         }
//     }
// }
using System;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding Books
            Book book1 = new Book("C# Programming", "Ashmita Gurung", "B001", 3);
            Book book2 = new Book("Introduction to Algorithms", "Thomas H. Cormen", "B002", 2);

            library.AddBook(book1);
            library.AddBook(book2);

            // Adding Members
            Member member1 = new Member("Ashmita Gurung", "M001");
            Member member2 = new Member("Anupama Gurung", "M002");

            library.AddMember(member1);
            library.AddMember(member2);

            // Borrow Book
            library.BorrowBook("B001", "M001");
            library.BorrowBook("B002", "M002");

            // Display Books
            library.DisplayBooks();

            // Return Book
            library.ReturnBook("B001");

            // Display Books
            library.DisplayBooks();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
