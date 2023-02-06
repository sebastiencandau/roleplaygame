namespace HelloWorld
{
    using Dice;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Dice dice = new Dice("caca", 0, 10);
            Console.WriteLine("le dé "+dice.getDiceName()+" retourne:");
            Console.WriteLine(dice.diceValue());
        }
    }
}