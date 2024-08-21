// using System;
// using System.Collections.Generic;

// namespace LibraryManagementSystem.Models
// {
//     public class Library
//     {
//         private List<Book> books;
//         private List<Member> members;

//         public Library()
//         {
//             books = new List<Book>();
//             members = new List<Member>();
//         }

//         public void AddBook(Book book)
//         {
//             books.Add(book);
//         }

//         public void AddMember(Member member)
//         {
//             members.Add(member);
//         }

//         public Book FindBook(string libraryId)
//         {
//             return books.Find(book => book.LibraryId == libraryId);
//         }

//         public Member FindMember(string memberId)
//         {
//             return members.Find(member => member.MemberId == memberId);
//         }

//         public void BorrowBook(string libraryId, string memberId)
//         {
//             Book book = FindBook(libraryId);
//             Member member = FindMember(memberId);

//             if (book != null && member != null)
//             {
//                 book.Borrow(member.Name);
//             }
//         }

//         public void ReturnBook(string libraryId)
//         {
//             Book book = FindBook(libraryId);

//             if (book != null)
//             {
//                 book.Return();
//             }
//         }

//         public void DisplayBooks()
//         {
//             foreach (var book in books)
//             {
//                 Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.CopiesAvailable}");
//             }
//         }
//     }
// }

using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models
{
    public class Library
    {
        private List<Book> books;
        private List<Member> members;

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public Book FindBook(string libraryId)
        {
            return books.Find(book => book.LibraryId == libraryId);
        }

        public Member FindMember(string memberId)
        {
            return members.Find(member => member.MemberId == memberId);
        }

        public void BorrowBook(string libraryId, string memberId)
        {
            Book book = FindBook(libraryId);
            Member member = FindMember(memberId);

            if (book != null && member != null)
            {
                book.Borrow(member.Name);
            }
        }

        public void ReturnBook(string libraryId)
        {
            Book book = FindBook(libraryId);

            if (book != null)
            {
                book.Return();
            }
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.CopiesAvailable}");
            }
        }
    }
}
