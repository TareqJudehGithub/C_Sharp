using LibraryManagementSys;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Library Management System\n");

        Console.Write("Enter library name: ");
        string libraryName = Console.ReadLine();

        Console.Write("Enter max number of books in the library: ");
        int maxBooks = Convert.ToInt32(Console.ReadLine());

        Library library1 = new Library(name: libraryName, maxBooks: maxBooks);
        Console.Write("Enter a book title: ");

        do
        {
            string bookTitle = Console.ReadLine();
            library1.AddBook(bookTitle: bookTitle);
            maxBooks--;


        }
        while (maxBooks >= 0);

        //  library1.DisplayBooks();
        /*
         * 
       "History of the Ancient World"
       "Introduction to Computer Science"
       "Shadows Rising"
       "The Solar System"
       "Rise of the Horde"

        */
        library1.DisplayBooks();
        Console.WriteLine("Good bye");

        Console.ReadKey();
    }
}

