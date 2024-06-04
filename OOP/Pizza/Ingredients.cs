namespace Pizza
{
    public class Ingredients
    {
        #region Fields      
        public int Id;
        public string IngName { get; init; }
        public virtual string Name { get; set; } = "Default ingredient - Base Class";
        #endregion

        public string PublicMethod() =>
            "This method is public in the Ingredients class.";

        protected string ProtectedMethod() =>
            "This method is protected and can only be accessible in the derived class.";

        private string PrivateMethod() =>
            "This method is private and can only be accessed in the derived class. - This is the base.";
    }
    public class Cheddar : Ingredients
    {
        public override string Name => "Cheddar Cheese - Derived Class";
        public Cheddar(string ingredientName = "Cheddar ingredient - Constructor default param")
        {
            this.IngName = ingredientName;
        }
        public int AgedForMonths { get; }

        protected new string ProtectedMethod() => $"This is the ProtectedMethod in the derived class";



    }
    public class TomatoSauce : Ingredients
    {
        public override string Name => "Tomato Sauce - Derived Class";
        public int TomatosIn100Grams { get; }
    }
    public class Mozarella : Ingredients
    {
        public string Name => "Mozarella - Derived Class";  // override was not used, base class value will be used
        public bool isLight { get; }
    }
}
