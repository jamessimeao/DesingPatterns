namespace Pattern4Iterator
{
    internal class Program
    {
        public static void Main()
        {
            //Bad();
            Good();
        }

        public static void Bad()
        {
            BadShoppingList list = new BadShoppingList();
            list.Push("Milk");
            list.Push("Bread");
            list.Push("Steak");
            List<string> strings = list.GetList();
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
        }

        public static void Good()
        {
            ShoppingList list = new ShoppingList();
            list.Push("Milk");
            list.Push("Bread");
            list.Push("Steak");

            IIterator<string> iterator = list.CreateIterator();

            while(iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }
        }
    }
}