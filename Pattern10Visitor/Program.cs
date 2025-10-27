namespace Pattern10Visitor
{
    internal class Program
    {
        public static void Main()
        {
            List<Client> clients = new List<Client>()
            {
                new RetailClient("Debinhams", "team@debimhams.co.uk"),
                new RestaurantClient("Frankie and Bennies", "frank@fandb.com"),
                new LawClient("Hamlin McGil Law Firm", "howard@handm.com"),
            };

            foreach(Client client in clients)
            {
                //client.Accept(new EmailVisitor());
                client.Accept(new PDFExportVisitor());
            }
        }
    }
}