
namespace Book
{
    using System;
    using Controllers;
    using static System.Console;
    class Program
    {
        private static void Main(string[] args)
        {
            BookControler controler = new BookControler();

            while(true)
            {
                Write("Request> ");
                string request = ReadLine();
                switch(request.ToLower())
                {
                    case "single":
                        controler.Single(1);
                        break;
                    case "create":
                        controler.Create();
                        break;
                    case "update":
                        controler.Update();
                        break;
                    case "list":
                        controler.List();
                        break;
                    default:
                       Console.WriteLine("Unknown command!");
                        break;
                }
            }
            controler.Single(0);
            ReadLine();
        }
    }
}
