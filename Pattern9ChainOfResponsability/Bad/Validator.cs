using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern9ChainOfResponsability.Bad
{
    internal class Validator
    {
        public void Validate(HttpRequest request)
        {
            string username = request.GetUsername();
            string password = request.GetPassword();

            // Trim whitespace
            request.ValidatedUsername = username.Trim();
            request.ValidatedPassword = password.Trim();
        }
    }
}
