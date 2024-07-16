using Bakery;

internal class Program
{
    static void Main(string[] args)
    {
        // Objects
        Product product = new Product();
        AddItem addItem = new AddItem();
        SortProduct sortProducts = new SortProduct();
        SearchProduct searchProducts = new SearchProduct();

        bool isInt = false;
        int userChoice = default;

        while (true)
        {
            do
            {
                Console.WriteLine("Welcome to Leen's Bakery!\n");
                Console.WriteLine("What are we going to do today? :)");
                Console.WriteLine("1. Add a new product");
                Console.WriteLine($"2. List Products - {Product.products.Count}");
                Console.WriteLine("3. Search products");
                Console.WriteLine("4. Leave the bakery\n");
                Console.Write("Choose an optoin (1-4): ");

                // User input validation
                isInt = int.TryParse(Console.ReadLine(), out userChoice);

                if (isInt == false && userChoice < 1 && userChoice > 4)
                {
                    Console.WriteLine("Invalid entry, please enter a number from 1 - 4");
                }
                // Call the appropiate method based on user input
                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        addItem.AddItems();
                        break;
                    case 2:
                        Console.Clear();
                        sortProducts.ChooseItemSort();
                        break;
                    case 3:
                        Console.Clear();
                        searchProducts.Searchitems();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Good Bye!");
                        return;
                    default:
                        if (isInt == false || userChoice < 1 || userChoice > 4)
                        {
                            Console.WriteLine("Invalid entry, please enter a number from 1 - 4");
                        }
                        break;
                }
            }
            while (userChoice < 1 || userChoice > 4);
        }
    }
}