// namespace LibraryManagementSystem.Interfaces
// {
//     public interface IBorrowable
//     {
//         void Borrow(string borrower);
//         void Return();
//         string Borrower { get; }
//         DateTime BorrowDate { get; }
//         DateTime DueDate { get; }
//     }
// }
namespace LibraryManagementSystem.Interfaces
{
    public interface IBorrowable
    {
        void Borrow(string borrower);
        void Return();
        string Borrower { get; }
        DateTime BorrowDate { get; }
        DateTime DueDate { get; }
    }
}

