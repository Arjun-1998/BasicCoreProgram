using BasicCoreProgram;

namespace BasicCoreProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Program number which is to be executed \n 1. flipCoin \n 2. Leapyear \n 3. PowofTwo \n 4. Harmonic\n 5. prime factor\n 6. Swappingnumber\n 7. Quotient\n 8. Exit");
            
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        BasicPrograms programs = new BasicCoreProgram.BasicPrograms();
                        programs.FlipCoin();
                        break;
                        case 2:
                        BasicPrograms check = new BasicPrograms();
                        check.LeapYear();
                        break;
                    case 3:
                        BasicPrograms res = new BasicPrograms();
                        res.PowerOfTwo();
                        break;
                    case 4:
                        BasicPrograms sum = new BasicPrograms();
                        sum.Harmonic();
                        break;
                    case 5:
                        BasicPrograms basicPrograms = new BasicPrograms();
                        basicPrograms.Prime();
                        break;
                    case 6:
                        BasicPrograms swap = new BasicPrograms();
                        swap.SwappingNumber();
                        break;
                    case 7:
                        BasicPrograms quotient = new BasicPrograms();
                        quotient.Division();
                        break;


                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}