﻿using BasicCoreProgram;

namespace BasicCoreProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Program number which is to be executed \n 1. flipCoin \n 2. Exit");
            
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
                        flag = false;
                        break;
                }
            }
        }
    }
}