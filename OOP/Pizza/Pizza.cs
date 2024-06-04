namespace Pizza
{
    public class Pizza
    {
        private List<Ingredients> _ingerdients = new List<Ingredients>();

        public void AddIngredients(Ingredients ingredient) => _ingerdients.Add(ingredient);

        public string Description() => $"This is a pizza made of {string.Join(", ", _ingerdients)}";
        public string Describe() => "Pizza!!!";
    }
}
