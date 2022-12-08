namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 10; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write(k);
                    }
                    for (int l = i - 2; l >= 1; l--)
                    {
                        Console.Write(l);
                    }
                    Console.WriteLine("\n");
                
            }
        }
    }
}
