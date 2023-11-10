using System.ComponentModel.Design;

namespace Array_ForExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //collection example
            int[] numbers = { 1, 2, 3, 4, 5 };
            int number = numbers[2];

            string[] names = { "ali", "zakaria", "tara" };

            for (int i = 0; i <= 2; i++)
            {

                Console.WriteLine(names[i]);

            }
            string[] cars = { "207", "volwo", "golf" };


            foreach (string item in cars)
            {
                if (cars[1] == "volwo")
                {

                    Console.WriteLine(item);

                }
                Console.WriteLine(item);

            }

            //whileExample
            Console.WriteLine("how many stars do you want to see?");
            string star = Console.ReadLine();
            int number = int.Parse(star);
            int x = 0;
            while (x < number)
            {
                ;

                Console.Write("*");
                x++;
            }


            ////whileExample with if
            int game;
            do
            {

                Console.WriteLine("Which game you want to play?");
                game = Convert.ToInt32(Console.ReadLine());

                if (game == 1)
                {

                    Console.WriteLine("game 1 is play right now");

                }
                else if (game == 2)

                {

                    Console.WriteLine("game 2 is play right now");

                }

            } while (game != 0);
            Console.ReadKey();


            //cellPhone Project
            string cellphone = null;
            while (true) 
            {
                Console.WriteLine("Pleace inter your cellphonNumber!");
                cellphone = Console.ReadLine();

                if (!string.IsNullOrEmpty(cellphone))

                {

                    break;
                
                }
            
            
            
            }
            

        }
    }
}