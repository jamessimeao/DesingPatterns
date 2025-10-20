namespace Pattern1Memento
{
    public class Program
    {
        public static void Main()
        {
            Editor editor = new Editor();
            History history = new History(editor);
            history.Backup();
            editor.Title = "title";
            editor.Content = "content";
            history.Backup();
            editor.Title = "another title";
            history.Backup();
            editor.Content = "Hello";
            history.Backup();
            editor.Title = "The life of a dev: my mementos";

            history.ShowHistory();

            Console.WriteLine($"Title: {editor.Title}");
            Console.WriteLine($"Content: {editor.Content}");

            history.Undo();

            Console.WriteLine($"Title: {editor.Title}");
            Console.WriteLine($"Content: {editor.Content}");

            history.Undo();

            Console.WriteLine($"Title: {editor.Title}");
            Console.WriteLine($"Content: {editor.Content}");

        }
    }
}