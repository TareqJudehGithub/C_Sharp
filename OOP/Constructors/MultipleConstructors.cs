namespace Constructors
{
    internal class MultipleConstructors
    {

        public class Dog
        {
            #region Fields
            private string _name;
            private string _breed;
            private int _weight;
            #endregion

            // TODO
            public Dog(string name, string breed, int weight)
            {
                this._name = name;
                this._breed = breed;
                this._weight = weight;
            }

            // Here below, to prevent code duplication, we use the 'this' keyword, which in this case refers to the Dog
            // constructor. 
            public Dog(string name, int weight) : this(name, "mixed-breed", weight)
            {
            }

            public string Describe()
            {
                return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {dogSize()} dog.";
            }

            public string dogSize()
            {
                string dogSize = string.Empty;
                if (_weight < 5)
                {
                    dogSize = "tiny";
                }
                else if (_weight >= 5 && _weight < 30)
                {
                    dogSize = "medium";
                }
                else
                {
                    dogSize = "large";
                }
                return dogSize;
            }
        }
    }
}
