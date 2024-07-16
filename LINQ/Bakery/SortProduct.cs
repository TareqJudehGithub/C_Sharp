namespace Bakery
{
    internal class SortProduct : Product
    {
        #region Methods
        internal override void ShowAllitems()
        {
            base.ShowAllitems();
        }
        internal void ShowItemByPrice()
        {
            Console.WriteLine("List Products By Price Menu\n");
            List<Product> listByPrice = products.OrderBy(item => item.Price).ToList();
            listByPrice.ForEach(Console.WriteLine);
        }
        internal void ShowItemByName()
        {
            List<Product> listByPrice = products.OrderBy(item => item.Name).ToList();
            listByPrice.ForEach(Console.WriteLine);
        }
        internal void ChooseItemSort()
        {
            bool isInt = false;
            int userInput = default;

            if (products.Count > 0)
            {
                while (true)
                {
                    do
                    {

                        Console.WriteLine("How would u like to sort your products? ");
                        Console.WriteLine("1. By ID");
                        Console.WriteLine("2. By Name");
                        Console.WriteLine("3. By Price");
                        Console.WriteLine("4. Main Menu");
                        Console.Write("Choose an option (1-4): ");

                        isInt = int.TryParse(Console.ReadLine(), out userInput);

                        if (isInt == false)
                        {
                            Console.WriteLine("Invalid entry. Please enter a number between 1 - 4");
                        }
                        else if (userInput < 1 || userInput > 4)
                        {
                            Console.WriteLine("Invalid entry. Choose a an option between 1 - 4 only.");
                        }

                        switch (userInput)
                        {
                            case 1:
                                ShowAllitems();
                                break;
                            case 2:
                                ShowItemByName();
                                break;
                            case 3:
                                ShowItemByPrice();
                                break;
                            case 4:
                                return;
                            default:
                                if (isInt == false)
                                {
                                    Console.WriteLine("Invalid entry. Please enter a number between 1 - 4");
                                }
                                else if (userInput < 1 || userInput > 4)
                                {
                                    Console.WriteLine("Invalid entry. Choose a an option between 1 - 4 only.");
                                }
                                break;
                        }
                    }
                    while (isInt == false || userInput < 1 || userInput > 4);
                }
            }
            else
            {
                Console.WriteLine("No products to show. Try adding more items first.");
            }
        }
        #endregion
    }
}
