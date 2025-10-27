using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern9ChainOfResponsability.Good
{
    internal class Validator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Validating");
            string username = request.GetUsername();
            string password = request.GetPassword();

            // Trim whitespace
            request.ValidatedUsername = username.Trim();
            request.ValidatedPassword = password.Trim();

            return username == "" || password == "";
        }
    }
}
