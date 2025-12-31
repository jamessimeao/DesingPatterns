namespace Pattern11Interpreter
{
    internal class Program
    {
        public static void Main()
        {
            const string input = "1 + 2 * 3";
            Context context = new Context();
            Interpreter interpreter = new Interpreter(context);
            int result = interpreter.Interpret(input);
            Console.WriteLine($"Result = {result}");
        }
    }
}