namespace SumNumbersInSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sumNumber = Console.ReadLine();
            sumSequence(sumNumber);
            Console.WriteLine(sumSequence(sumNumber));
            
    
             int sumSequence(string num)
            {

                int sum = 0;

                for (int i = 0; i < num.Length; i++)
                {
                    sum += int.Parse(num.Substring(i, 1));

                    
                }
                
                return sum;
            }
        }
    }
}
 