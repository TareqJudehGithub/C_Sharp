namespace Bakery
{
    internal class SearchProduct : Product
    {
        int _searchById;
        string _searchByName;
        string _searchByCategory;
        bool _isInt = false;

        internal void Searchitems()
        {
            Console.Clear();
            bool isInt = false;
            int userInput = 0;

            if (products.Count > 0)
            {
                while (true)
                {
                    do
                    {
                        Console.WriteLine("Search Products Menu\n");
                        Console.WriteLine("1. Search by ID");
                        Console.WriteLine("2. Search by Name");
                        Console.WriteLine("3. Search by Category");
                        Console.WriteLine("4. Main Menu");

                        isInt = int.TryParse(Console.ReadLine(), out userInput);

                        if (!isInt || userInput < 1 || userInput > 4)
                        {
                            Console.WriteLine("Invalid entry. Please enter a number between 1 - 4");
                            Console.ReadKey();
                        }
                    }
                    while (isInt == false || userInput < 1 || userInput > 4);

                    switch (userInput)
                    {
                        case 1:
                            SearchByID();
                            break;
                        case 2:
                            //"search by Name";
                            break;
                        case 3:
                            //"search by Category";
                            break;
                        case 4:
                            return;
                    }
                }
            }
            else
            {
                Console.WriteLine("No products to show. Try adding more items first.");
            }
        }
        // Search By ID
        internal void SearchByID()
        {
            do
            {
                Console.WriteLine("Enter product ID: ");
                _isInt = int.TryParse(Console.ReadLine(), out _searchById);
            }
            while (_isInt == false);

            // Search ID provided by user and return it's related product
            var searchProductByID = products.Where(item => item.ID == _searchById);
            Console.WriteLine(searchProductByID.Any()
            ? $"Matching item:\n {string.Join("\n", searchProductByID)}"
            : "No item found");
        }
        // Search By Name

        // Search By Category
    }
}
