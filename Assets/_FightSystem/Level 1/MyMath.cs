using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace _2023_GC_A2_Partiel_POO.Level_1
{
    public class MyMath
    {
        // Interdictions :
        // classe Math & MathF
        public static int Abs(int input)
        {
            int inputToReturn = 0;
            if (input <= 0)
            {
                inputToReturn = (input - input) + (-input);
            }
            else
                inputToReturn = input;
            Debug.Log(inputToReturn);
            return inputToReturn;
        }

        // Interdictions :
        // classe Math & MathF
        public static int Clamp(int input, int min, int max)
        {
            if (input < max && input >min)
            {
                return input;
            }
            else if (input > max)
            {
                return max;
            }
        }

        // Interdictions :
        // classe Math & MathF
        public static int Floor(float input)
        {
            throw new NotImplementedException();
        }

        // Interdictions :
        // classe Math & MathF
        public static int Ceil(float input)
        {
            throw new NotImplementedException();
        }

        // Interdictions :
        // classe Math & MathF
        public static int Round(float input)
        {
            throw new NotImplementedException();
        }

        // Interdictions :
        // classe Math & MathF
        // LINQ & Enumerable
        public static float CalculateAverage(int[] input)
        {
            throw new NotImplementedException();
        }

    }
}
