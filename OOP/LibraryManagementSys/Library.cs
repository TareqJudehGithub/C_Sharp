namespace LibraryManagementSys
{
    internal class Library
    {
        #region fields
        private string _libraryName;
        public int _bookEntered;
        private int _bookCounts = 0;
        #endregion

        #region Constructors
        public Library(string name, int maxBooks)
        {
            this._libraryName = name;
            this._bookEntered = maxBooks;
            Console.WriteLine($"Library Name: {LibraryName} is created.");
        }
        #endregion

        #region Properties
        public string LibraryName
        {
            set
            {
                this._libraryName = value;
            }
            get
            {
                return this._libraryName;
            }
        }
        #endregion

        #region Methods
        public void AddBook(string bookTitle)
        {
            if (this._bookEntered > 0)
            {
                this._bookCounts++;
                Console.WriteLine($"Book count = {_bookCounts}");
                Console.WriteLine($"Book '{bookTitle}' added to the library.");
                this._bookEntered--;
                Console.WriteLine(this._bookEntered);
            }
            else
            {
                Console.WriteLine("Library is full. Cannot add more books.");
            }

        }

        public void DisplayBooks()
        {
            Console.WriteLine($"Book(s) available in the {LibraryName} are: {_bookCounts}");
        }
        #endregion
        ~Library()
        {
            Console.WriteLine($"{LibraryName} object is destroyed.");
        }
    }
}
