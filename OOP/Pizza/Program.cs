namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objects

            // Pizza
            Pizza pizza = new Pizza();
            Console.WriteLine(pizza.Description());

            // Cheddar
            Cheddar cheddar = new Cheddar();
            Console.WriteLine($"Ingredient name is: {cheddar.Name}");
            // sole.WriteLine($"Pizza name is {cheddar.Name}"); // prop not initialized


            // Tomato Sauce
            TomatoSauce tomatoSauce = new TomatoSauce();
            Console.WriteLine($"Ingredient name is: {tomatoSauce.Name}");

            // Mozarella
            Mozarella mozarella = new Mozarella();
            Console.WriteLine($"Ingredient name is: {mozarella.Name}");

            // Ingredients
            Ingredients ingredient = new Cheddar();
            int ingredientID = ingredient.Id;             // field/prop is from the Ingredient class
            string ingName = ingredient.IngName;    // Name prop is in derived but not in base.
            ingName = "Changed ing name";            // IngName will not ber overriten due to get; init;
            Console.WriteLine(cheddar.IngName);


            var ingredients = new List<Ingredients>
            {
                cheddar,
                tomatoSauce,
                mozarella
            };

            Console.WriteLine("\nPizza ingredients list:");
            foreach (Ingredients item in ingredients)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}




