namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            for(int i=1; i<=100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            #endregion

            #region Task2

            int number = 95;

            if(number >=0 && number < 65)
            {
                Console.WriteLine("Kesildin");
            }else if(number >= 65 && number < 85)
            {
                Console.WriteLine("Adi Diplom");
            }else if(number >= 85 && number < 95)
            {
                Console.WriteLine("Seref Diplomu");
            }else if(number >= 95 && number <= 100)
            {
                Console.WriteLine("Yuksek Seref Diplomu");
            }
            else
            {
                Console.WriteLine("Bele bir bal yoxdur");
            }
            #endregion
        }
    }
}
