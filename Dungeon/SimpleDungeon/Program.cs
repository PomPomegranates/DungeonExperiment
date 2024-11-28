namespace SimpleDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuous = true;
            while (continuous)
            {
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        MoveUp()
                }
            }
        }

    }
}
