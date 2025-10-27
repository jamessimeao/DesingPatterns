using Pattern9ChainOfResponsability.Bad;
using Pattern9ChainOfResponsability.Good;

namespace Pattern9ChainOfResponsability
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
            Bad.WebServer server = new Bad.WebServer();
            HttpRequest request = new HttpRequest("danny", "123");
            server.Handle(request);
        }

        public static void Good()
        {
            Good.Validator validator = new Good.Validator();
            Good.Authenticator authenticator = new Good.Authenticator();
            Good.Logger logger = new Good.Logger();

            validator.SetNext(authenticator).SetNext(logger);

            Good.WebServer server = new Good.WebServer(validator);

            /*
            string username = "danny";
            string password = "123";
            */

            /*
            string username = "danny";
            string password = "abc";
            */

            
            string username = "";
            string password = "";
            

            HttpRequest request = new HttpRequest(username, password);
            server.Handle(request);
        }
    }
}