using Pattern2State;
using Pattern2State.Bad;
using Pattern2State.Good;

namespace Patter2State
{
    internal class Program
    {
        public static void Main()
        {
            //BadExample();
            GoodExample();
        }

        public static void BadExample()
        {
            BadDocument document = new BadDocument();
            document.State = DocumentStates.Moderation;
            document.CurrentUserRole = UserRoles.Editor;

            Console.WriteLine(document.State);
            document.Publish();
            Console.WriteLine(document.State);
        }

        public static void GoodExample()
        {
            Document document = new Document(UserRoles.Admin);
            Console.WriteLine(document.State);

            document.Publish();
            Console.WriteLine(document.State);

            document.Publish();
            Console.WriteLine(document.State);
        }
    }
}