// using System;
// using LibraryManagementSystem.Interfaces;

// namespace LibraryManagementSystem.Models
// {
//     public class Book : ILibraryItem, IBorrowable
//     {
//         public string Title { get; private set; }
//         public string Author { get; private set; }
//         public string LibraryId { get; private set; }
//         public int CopiesAvailable { get; private set; }

//         public string Borrower { get; private set; }
//         public DateTime BorrowDate { get; private set; }
//         public DateTime DueDate { get; private set; }

//         public Book(string title, string author, string libraryId, int copies)
//         {
//             Title = title;
//             Author = author;
//             LibraryId = libraryId;
//             CopiesAvailable = copies;
//         }

//         public void AddCopies(int count)
//         {
//             CopiesAvailable += count;
//         }

//         public void RemoveCopies(int count)
//         {
//             if (CopiesAvailable >= count)
//             {
//                 CopiesAvailable -= count;
//             }
//         }

//         public void Borrow(string borrower)
//         {
//             if (CopiesAvailable > 0)
//             {
//                 Borrower = borrower;
//                 BorrowDate = DateTime.Now;
//                 DueDate = BorrowDate.AddDays(14); // 2 weeks borrowing period
//                 CopiesAvailable--;
//             }
//         }

//         public void Return()
//         {
//             if (Borrower != null)
//             {
//                 Borrower = null;
//                 CopiesAvailable++;
//             }
//         }
//     }
// }
using System;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Models
{
    public class Book : ILibraryItem, IBorrowable
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string LibraryId { get; private set; }
        public int CopiesAvailable { get; private set; }

        public string Borrower { get; private set; }
        public DateTime BorrowDate { get; private set; }
        public DateTime DueDate { get; private set; }

        public Book(string title, string author, string libraryId, int copies)
        {
            Title = title;
            Author = author;
            LibraryId = libraryId;
            CopiesAvailable = copies;
        }

        public void AddCopies(int count)
        {
            CopiesAvailable += count;
        }

        public void RemoveCopies(int count)
        {
            if (CopiesAvailable >= count)
            {
                CopiesAvailable -= count;
            }
        }

        public void Borrow(string borrower)
        {
            if (CopiesAvailable > 0)
            {
                Borrower = borrower;
                BorrowDate = DateTime.Now;
                DueDate = BorrowDate.AddDays(14); // 2 weeks borrowing period
                CopiesAvailable--;
            }
        }

        public void Return()
        {
            if (Borrower != null)
            {
                Borrower = null;
                CopiesAvailable++;
            }
        }
    }
}
