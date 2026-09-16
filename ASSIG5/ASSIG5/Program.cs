namespace ASSIG5

{

    #region Question 1
    // Declare an enum Genre { Fiction, NonFiction, Science }.
    // Add a Genre property to Book, assign it Genre.Science, and print it.

    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    class Book
    {
        public Genre Genre { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Book book = new Book();

            book.Genre = Genre.Science;

            Console.WriteLine(book.Genre);
        }
    }
    #endregion



}