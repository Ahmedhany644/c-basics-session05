namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question_1
            // Add a private string password = "secret"; field to a Book class. Try to print it from Main
            // (outside the class). What happens, and why?

            //SOLUTION

            //class Book
            //{
            //    private string password = "secret";
            //}
            //
            //Book book = new Book();
            //Console.WriteLine(book.password); // Compile error

            // EXPECTED: compile error (CS0122: 'Book.password' is inaccessible due to its protection level).
            // WHY: private members are accessible only inside the class that declares them,
            // so Main (outside the class) can't see the field.

            #endregion

            #region question_2
            // Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
            // Why?

            //SOLUTION

            //class Book
            //{
            //    internal int copiesInStock = 5;
            //}
            //
            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock); // 5

            // EXPECTED: yes, it compiles and prints 5.
            // WHY: internal members are accessible from anywhere inside the same assembly (project).
            // Main and Book are in the same project, so access is allowed.

            #endregion

            #region question_3
            // Add a public string Title; field to Book. Set it and print it from Main.

            //SOLUTION

            //class Book
            //{
            //    public string Title;
            //}
            //
            //Book book = new Book();
            //book.Title = "Clean Code";
            //Console.WriteLine(book.Title); // Clean Code

            #endregion

            #region question_4
            // Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            // assign it Genre.Science, and print it.

            //SOLUTION

            //enum Genre { Fiction, NonFiction, Science }
            //
            //class Book
            //{
            //    public Genre Genre { get; set; }
            //}
            //
            //Book book = new Book();
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre); // Science

            #endregion

            #region question_5
            // Using the Genre enum above, print the underlying int value of
            // Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.

            //SOLUTION

            //Console.WriteLine((int)Genre.Fiction);     // 0
            //Console.WriteLine((int)Genre.NonFiction);  // 1
            //Console.WriteLine((int)Genre.Science);     // 2

            #endregion

            #region question_6
            // Given int genreNumber = 1;, cast it into a Genre value and print the result.

            //SOLUTION

            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber;
            //Console.WriteLine(genre); // NonFiction

            #endregion

            #region question_7
            // Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.

            //SOLUTION

            //Genre genre = Genre.Fiction;
            //string genreString = genre.ToString();
            //Console.WriteLine(genreString); // Fiction

            #endregion

            #region question_8
            // Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and
            // print the result.

            //SOLUTION

            //string genreText = "Science";
            //Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(genre); // Science

            #endregion

            #region question_9
            // Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to
            // attempt the conversion. Print "Unknown genre" if it fails.

            //SOLUTION

            //string genreText = "Mystery";
            //if (Enum.TryParse(genreText, out Genre genre))
            //{
            //    Console.WriteLine(genre);
            //}
            //else
            //{
            //    Console.WriteLine("Unknown genre"); // this runs
            //}

            #endregion
        }
    }
}
