namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int val = Convert.ToInt32(Console.ReadLine());

            //for (int  i = 0; i <= val ; i++)
            // {
            //     for (int j = 0; j <= val-i; j++) {
            //         Console.Write(" ");
            //     }
            //     for (int b = 1; b <= i; b++)
            //     {
            //         Console.Write(b);
            //     }

            //     for (int c = i-1; c >= 1; c--)
            //     {
            //         Console.Write(c);
            //     }

            //     Console.WriteLine("\n");
            // }




            //int n = Convert.ToInt32(Console.ReadLine());

            //int a = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        a++;
            //    }
            //}
            //if (a == 2)
            //{
            //    Console.WriteLine(a);
            //    Console.WriteLine("{0} is a Prime Number", n);
            //}
            //else
            //{
            //    Console.WriteLine("Not a Prime Number");
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();



            string[] names = {"Fahad", "Asad","Hassan","Ammar" };

            var disName = from name in names where name.Length > 4 select name.Length; 
            foreach(var dis in disName)
            {
                Console.WriteLine(dis); 
            }

        }
    }
}