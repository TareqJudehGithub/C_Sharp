using Encapsulation;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter owner's name: ");
        string owner = Console.ReadLine();

        Console.Write("Enter maximum items allowed in the cart: ");
        int maxItems = Convert.ToInt32(Console.ReadLine());

        Cart cart = new Cart(owner: owner, maxItems: maxItems);

        int counter = maxItems;
        Console.Write("Enter item name: ");
        do
        {
            Console.WriteLine($"Counter = {counter}");
            if (counter == 0)
            {
                Console.WriteLine("Exit the loop");
                break;
            }
            string itemName = Console.ReadLine();
            cart.AddItem(itemName);
            counter--;

        } while (counter > 0);

        cart.DisplayItems();
    }

}