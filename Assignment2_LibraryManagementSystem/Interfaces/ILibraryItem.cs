// namespace LibraryManagementSystem.Interfaces
// {
//     public interface ILibraryItem
//     {
//         string Title { get; }
//         string Author { get; }
//         string LibraryId { get; }
//         int CopiesAvailable { get; }
//         void AddCopies(int count);
//         void RemoveCopies(int count);
//     }
// }
namespace LibraryManagementSystem.Interfaces
{
    public interface ILibraryItem
    {
        string Title { get; }
        string Author { get; }
        string LibraryId { get; }
        int CopiesAvailable { get; }
        void AddCopies(int count);
        void RemoveCopies(int count);
    }
}
