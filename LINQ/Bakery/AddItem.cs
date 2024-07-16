namespace Bakery
{
    internal class AddItem : Product
    {
        #region Methods
        internal virtual List<Product> AddItems()
        {

            counter++;
            int id = counter;
            string name;
            string category;
            double price = 0;
            bool isDouble = false;
            string userAnswer = string.Empty;

            // User inputs
            Console.WriteLine("New product Menu\n");
            Console.Write("Product name: ");
            name = Console.ReadLine();
            Console.Write("Product category: ");
            category = Console.ReadLine();

            do
            {
                Console.Write("Product Price: ");
                isDouble = double.TryParse(Console.ReadLine(), out price);
            }
            while (isDouble == false);


            products.Add
                    (
                    new Product
                    {
                        ID = id,
                        Name = name,
                        Category = category,
                        Price = price
                    }
                    );
            if (products.Count > 0)
            {
                Console.WriteLine("Item added succesfully.");
            }
            return products;
        }
        internal override void ShowAllitems()
        {
            // Console.WriteLine("Show me some items.");
            base.ShowAllitems();
        }
        internal void ShowItemByID()
        {
            List<Product> listByPrice = products.OrderBy(item => item.Price).ToList();
            listByPrice.ForEach(Console.WriteLine);
        }
        #endregion
    }
}
