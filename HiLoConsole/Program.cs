namespace HiLoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog spot = new() { Age = 12, Name = "Spot" };
            Dog larry = new() { Age = 7, Name = "Larry" };
            Dog suzie = new() { Age = 4, Name = "Suzie" };

            spot.TalkToMe();
            larry.TalkToMe();
            suzie.TalkToMe();
            Console.WriteLine();

            spot.Name = larry.Name;
            larry.TalkToMe();
            spot.TalkToMe();
            Console.WriteLine();

            spot = suzie;
            Console.WriteLine();

            suzie.TalkToMe();
            spot.TalkToMe();
            Console.WriteLine();

            suzie.Name = "babe";
            spot.TalkToMe();

        }
    }

    public class Dog()
    {
        public string Name = "";
        public int Age;

        public void TalkToMe()
        {
            Console.WriteLine($"My name is {Name} and my age is {Age}. ");
        }
    }
}
