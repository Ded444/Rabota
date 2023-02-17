namespace _123
{
    internal class Program
     {
        static void Main()
        {
            int a;
            Console.WriteLine("Vvedite a ");
            a = Convert.ToInt32(Console.ReadLine());
            if((a % 3 == 0)&&(a % 5 == 0))
            {
                Console.WriteLine("fezzbuzz");
            }
            else if(a % 3 == 0) {
                Console.WriteLine("fizz");
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
        }
    }
}