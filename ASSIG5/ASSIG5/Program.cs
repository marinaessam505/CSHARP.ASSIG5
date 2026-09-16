namespace ASSIG5

{

    #region Question 1
    // Declare an enum Genre { Fiction, NonFiction, Science }.
    // Add a Genre property to Book, assign it Genre.Science, and print it.

    //enum Genre
    //{
    //    Fiction,
    //    NonFiction,
    //    Science
    //}

    //class Book
    //{
    //    public Genre Genre { get; set; }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Book book = new Book();

    //        book.Genre = Genre.Science;

    //        Console.WriteLine(book.Genre);
    //    }
    //}
    #endregion



    #region Question 2
    // Using the Genre enum above, print the underlying int value of
    // Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
    //enum Genre
    //{
    //    Fiction,
    //    NonFiction,
    //    Science
    //}

    //class Book
    //{
    //    public Genre Genre { get; set; }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Book book = new Book();

    //        book.Genre = Genre.Science;

    //        Console.WriteLine(book.Genre);



    //        Console.WriteLine((int)Genre.Fiction);
    //        Console.WriteLine((int)Genre.NonFiction);
    //        Console.WriteLine((int)Genre.Science);
    //    }
    //}
    #endregion




    #region Question 3
    // Given int genreNumber = 1;, cast it into a Genre value and print the result.
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    class Program
    {
        static void Main()
        {

            int genreNumber = 1;

            Console.WriteLine((Genre)genreNumber);

            
        }
    }


    #endregion

}