namespace Lab2_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.GetData().Wait();

        }
    }
}
