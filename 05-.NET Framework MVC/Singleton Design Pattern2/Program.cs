namespace Singleton_Design_Pattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myClass1 = Singleton.GetInstance();
            Console.WriteLine(myClass1.myNumber);


            myClass1.myNumber = 10;
            var myClass2 = Singleton.GetInstance();
            Console.WriteLine(myClass2.myNumber);

        }
    }
}