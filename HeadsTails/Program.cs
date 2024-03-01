namespace HeadsTails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating new HeadsTailsGenerator instance
            HeadsTailsGenerator coinFlip = new HeadsTailsGenerator();

            //flipping the coin 5 times
            coinFlip.HeadsOrTails(5);

            Console.ReadLine();
        }
    }
}