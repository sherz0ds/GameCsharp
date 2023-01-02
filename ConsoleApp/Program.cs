using System;
namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMode();
        }
        
        static void GameMode()
        {
              start: 
                Console.WriteLine("Choose level:\n1)Low\n2)Medium\n3)High\n4)Hard\n5)Expert");

                var input = Console.ReadLine();        
                       
            try
            {
                //integer
                var finally_input = Convert.ToInt32(input);
                switch (finally_input)
                {
                    case 1:
                      
                        LowGame();
                        break;
                    case 2:
                       
                        MediumGame();
                        break;
                    case 3:
                        
                        HighGame();
                        break;
                    case 4:
                      
                        HardGame();
                        break;

                    case 5:
                      
                        ExpertGame();
                        break;

                    default:
                        System.Console.Clear();
                        Console.Error.WriteLine("We did not find such a case");

                        goto start;
                }
            } catch
            {
                // string

                switch (input)
                {
                    case "Low":
                       
                        LowGame();
                        break;
                    case "Medium":
                      
                        MediumGame();
                        break;
                    case "High":
                       
                        HighGame();
                        break;
                    case "Hard":
                       
                        HardGame();
                        break;
                    case "Expert":
                       
                        ExpertGame();
                        break;
                    default:
                        System.Console.Clear();
                        Console.Error.WriteLine("We did not find such a case");

                        goto start;

                }
            }

            Console.ReadKey();
        }
        
    public static void LowGame()
        {
            System.Console.Clear();
         
            Console.WriteLine("********************* Game started (Low) ****************************\n");
            Level lvl = Level.Low;
            int score = (int)lvl;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for (int i = 1; i <=5; i++)
            {
                Random ran = new Random();
                int a = ran.Next(0, 5);
                int b = ran.Next(0, 5);
                Console.Write($"{a}+{b}=");
                var answer = Console.ReadLine();
                if (Convert.ToInt32(answer) == a + b)
                {
                    score++;
                }
            }
            watch.Stop();
            double percent = score*100/5;
            Console.WriteLine($"Your result is :{percent}%\nTime={Math.Round(watch.Elapsed.TotalSeconds,2)} seconds");
            switch (percent)
            {
                case double x when x < 33 && x>0:
                    Console.WriteLine("Better luck next time\n");
                    break;
                case double x when x >= 33 && x < 66:
                    Console.WriteLine("Good result\n");
                    break;
                case double x when x >= 66 && x<=99:
                    Console.WriteLine("Very cool\n");
                    break;
                default:
                    Console.WriteLine("You have achieved a result that no one else has achieved\n");
                    break;
       
            }
            Console.WriteLine("********************* Game ended (Low) ****************************\n\n");
            Console.WriteLine("Do you want to play again?(yes/no)");
            var yn = Console.ReadLine();
            if (yn == "yes" || yn =="Yes"||yn=="Ha"||yn=="ha")
            {
                GameMode();
            }
            else
            {
                System.Console.Clear();
                Console.WriteLine("Good Bye!");
                
            }

        }
        public static void MediumGame()
        {
            System.Console.Clear();
            Console.WriteLine("********************* Game started (Medium) **************************\n");
            Level lvl = Level.Medium;
            int score = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for (int i = 1; i <= (int)lvl * 10 + (int)lvl; i++)
            {
                Random ran = new Random();
                int a = ran.Next(0, (int)lvl * 10 + (int)lvl);
                int b = ran.Next(0, (int)lvl * 10 + (int)lvl);
                Console.Write($"{a}+{b}=");
                var answer = Console.ReadLine();
                if (Convert.ToInt32(answer) == a + b)
                {
                    score++;
                }
            }
            watch.Stop();
            double percent = score * 100 / ((int)lvl * 10 + (int)lvl);
            Console.WriteLine($"Your result is :{percent}%\nTime={Math.Round(watch.Elapsed.TotalSeconds, 2)} seconds");
            switch (percent)
            {
                case double x when x < 33 && x > 0:
                    Console.WriteLine("Better luck next time\n");
                    break;
                case double x when x >= 33 && x < 66:
                    Console.WriteLine("Good result\n");
                    break;
                case double x when x >= 66 && x <= 99:
                    Console.WriteLine("Very cool\n");
                    break;
                default:
                    Console.WriteLine("You have achieved a result that no one else has achieved\n");
                    break;

            }
            Console.WriteLine("********************* Game ended (Medium) **************************\n\n");
            Console.WriteLine("Do you want to play again?(yes/no)");
            var yn = Console.ReadLine();
            if (yn == "yes" || yn == "Yes" || yn == "Ha" || yn == "ha")
            {
                GameMode();
            }
            else
            {
                System.Console.Clear();
                Console.WriteLine("Good Bye!");

            }
        }
        public static void HighGame()
        {
            System.Console.Clear();
            Console.WriteLine("********************* Game started (High) ****************************\n");
            Level lvl = Level.High;
            int score = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for (int i = 1; i <= (int)lvl * 10 + (int)lvl; i++)
            {
                Random ran = new Random();
                int a = ran.Next(0, (int)lvl * 10 + (int)lvl);
                int b = ran.Next(0, (int)lvl * 10 + (int)lvl);
                Console.Write($"{a}+{b}=");
                var answer = Console.ReadLine();
                if (Convert.ToInt32(answer) == a + b)
                {
                    score++;
                }
            }
            watch.Stop();
            double percent = score * 100 / ((int)lvl * 10 + (int)lvl);
            Console.WriteLine($"Your result is :{percent}%\nTime={Math.Round(watch.Elapsed.TotalSeconds, 2)} seconds");
            switch (percent)
            {
                case double x when x < 33 && x > 0:
                    Console.WriteLine("Better luck next time\n");
                    break;
                case double x when x >= 33 && x < 66:
                    Console.WriteLine("Good result\n");
                    break;
                case double x when x >= 66 && x <= 99:
                    Console.WriteLine("Very cool\n");
                    break;
                default:
                    Console.WriteLine("You have achieved a result that no one else has achieved\n");
                    break;

            }
            Console.WriteLine("********************* Game ended (High) ****************************\n\n");
            Console.WriteLine("Do you want to play again?(yes/no)");
            var yn = Console.ReadLine();
            if (yn == "yes" || yn == "Yes" || yn == "Ha" || yn == "ha")
            {
                GameMode();
            }
            else
            {
                System.Console.Clear();
                Console.WriteLine("Good Bye!");

            }
        }
        public static void HardGame()
        {

            System.Console.Clear();
            Console.WriteLine("********************* Game started (Hard) ****************************\n");
            Level lvl = Level.Hard;
            int score = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for (int i = 1; i <= (int)lvl * 10 + (int)lvl; i++)
            {
                Random ran = new Random();
                int a = ran.Next(0, (int)lvl * 10 + (int)lvl);
                int b = ran.Next(0, (int)lvl * 10 + (int)lvl);
                Console.Write($"{a}+{b}=");
                var answer = Console.ReadLine();
                if (Convert.ToInt32(answer) == a + b)
                {
                    score++;
                }
            }
            watch.Stop();
            double percent = score * 100 / ((int)lvl * 10 + (int)lvl);
            Console.WriteLine($"Your result is :{percent}%\nTime={Math.Round(watch.Elapsed.TotalSeconds, 2)} seconds");
            switch (percent)
            {
                case double x when x < 33 && x > 0:
                    Console.WriteLine("Better luck next time\n");
                    break;
                case double x when x >= 33 && x < 66:
                    Console.WriteLine("Good result\n");
                    break;
                case double x when x >= 66 && x <= 99:
                    Console.WriteLine("Very cool\n");
                    break;
                default:
                    Console.WriteLine("You have achieved a result that no one else has achieved\n");
                    break;

            }
            Console.WriteLine("********************* Game ended (Hard) ****************************\n\n");
            Console.WriteLine("Do you want to play again?(yes/no)");
            var yn = Console.ReadLine();
            if (yn == "yes" || yn == "Yes" || yn == "Ha" || yn == "ha")
            {
                GameMode();
            }
            else
            {
                System.Console.Clear();
                Console.WriteLine("Good Bye!");

            }
        }
        public static void ExpertGame()
        {

            System.Console.Clear();
            Console.WriteLine("********************* Game started (Expert) **************************\n");
            Level lvl = Level.Expert;
            int score = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for (int i = 1; i <= (int)lvl * 10 + (int)lvl; i++)
            {
                Random ran = new Random();
                int a = ran.Next(0, (int)lvl * 10 + (int)lvl);
                int b = ran.Next(0, (int)lvl * 10 + (int)lvl);
                Console.Write($"{a}+{b}=");
                var answer = Console.ReadLine();
                if (Convert.ToInt32(answer) == a + b)
                {
                    score++;
                }
            }
            watch.Stop();
            double percent = score * 100 / ((int)lvl * 10 + (int)lvl);
            Console.WriteLine($"Your result is :{percent}%\nTime={Math.Round(watch.Elapsed.TotalSeconds, 2)} seconds");
            switch (percent)
            {
                case double x when x < 33 && x > 0:
                    Console.WriteLine("Better luck next time\n");
                    break;
                case double x when x >= 33 && x < 66:
                    Console.WriteLine("Good result\n");
                    break;
                case double x when x >= 66 && x <= 99:
                    Console.WriteLine("Very cool\n");
                    break;
                default:
                    Console.WriteLine("You have achieved a result that no one else has achieved\n");
                    break;

            }
            Console.WriteLine("********************* Game ended (Expert) **************************\n\n");
            Console.WriteLine("Do you want to play again?(yes/no)");
            var yn = Console.ReadLine();
            if (yn == "yes" || yn == "Yes" || yn == "Ha" || yn == "ha")
            {
                GameMode();
            }
            else
            {
                System.Console.Clear();
                Console.WriteLine("Good Bye!");

            }

        }
            
        enum Level
        {
            Low,
            Medium,
            High,
            Hard,
            Expert
        }
    }
}
