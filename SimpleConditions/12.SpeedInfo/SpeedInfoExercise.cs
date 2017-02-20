﻿using System;

namespace _12.SpeedInfo
{
    class SpeedInfoExercise
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(
                Console.ReadLine());

            if (speed <= 10.00)
            {
                Console.WriteLine("slow");
            }
            else if (10 < speed &&
                    speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (50 < speed &&
                    speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (150 < speed &&
                    speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
