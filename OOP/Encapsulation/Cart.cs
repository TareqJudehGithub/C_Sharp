namespace Encapsulation
{
    internal class Cart
    {
        #region Fields
        private string _cartOwner;
        private int _maxItems;
        private int _itemCount = 0;
        #endregion

        #region Constructors
        internal Cart(string owner, int maxItems)
        {
            this._cartOwner = owner;
            this._maxItems = maxItems;
        }
        #endregion

        #region Properties
        internal string CartOwner { get; set; }
        #endregion

        #region Method
        internal void AddItem(string itemName)
        {
            if (_maxItems > 0)
            {
                Console.WriteLine($"{itemName} has been added to the cart.");
                _itemCount++;
                Console.WriteLine($"Item count now = {_itemCount}");

                _maxItems--;
                Console.WriteLine($"Max item count after = {_maxItems}");
            }
            else
            {
                Console.WriteLine("Cannot add anymore item. Cart is full!");
            }
        }
        internal void DisplayItems()
        {
            Console.WriteLine($"There are {_itemCount} items inside {CartOwner}.");
        }
        ~Cart()
        {
            Console.WriteLine($" Cart has been destroyed.");
        }

        #endregion

    }
}
