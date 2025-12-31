namespace Pattern12Composite
{
    internal class Program()
    {
        public static void Main()
        {
            Box package = new Box();

            Box box1 = new Box();
            box1.Add(new Microphone());

            Box box2 = new Box();

            Box box3 = new Box();
            box3.Add(new Mouse());

            Box box4 = new Box();
            box4.Add(new Keyboard());

            box2.Add(box3);
            box2.Add(box4);

            package.Add(box1);
            package.Add(box2);

            Console.WriteLine($"Price = {package.GetPrice()}");
        }
    }
}