namespace Bakery
{
    internal class Product
    {
        #region Properties
        internal static int counter = 0;
        internal int ID { get; set; }
        internal string Name { get; set; }
        internal string Category { get; set; }
        internal double Price { get; set; }
        #endregion
        internal static List<Product> products = new List<Product>();

        #region Methods
        internal virtual void ShowAllitems()
        {
            Console.WriteLine(products.Count);
            Console.WriteLine("Sort by ID\n");
            List<Product> listAllProducts = products.OrderBy(item => ID).ToList();
            listAllProducts.ForEach(Console.WriteLine);
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nCategory: {Category}\nPrice: {Price:C}";
        }
        #endregion
    }
}
