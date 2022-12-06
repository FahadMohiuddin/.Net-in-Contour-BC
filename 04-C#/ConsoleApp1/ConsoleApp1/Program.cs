namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a,i;
            Console.WriteLine("Enter Table Value");
            a = Convert.ToInt32(Console.ReadLine());
           

            for (i=1;i<=10;i++){

                Console.WriteLine($"{a} * {i} = {i * a}");
            }
        }
    }
}