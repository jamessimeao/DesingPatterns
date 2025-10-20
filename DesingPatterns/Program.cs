using DesingPatterns.Patterns;

namespace DesingPatterns
{
    public class Program
    {
        public static void Main()
        {
            Editor editor = new Editor();
            editor.Title = "title";
            editor.Content = "content";

            History history = new History(editor);
            history.Backup();
        }
    }
}