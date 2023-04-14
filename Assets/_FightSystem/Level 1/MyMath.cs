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
            if (input > max)
            {
                return max;
            }
            else if (input < min)
            {
                return min;
            }
            return input;
        }

        // Interdictions :
        // classe Math & MathF
        public static int Floor(float input)
        {
            return (int) input;
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
            int intToReturn = 0;
            float decimalInput = input - (int)input;
            if (decimalInput >= 0.5)
            {
                intToReturn = (int)input + 1;
                return intToReturn;
            }
            else 
                return (int)input;
        }

        // Interdictions :
        // classe Math & MathF
        // LINQ & Enumerable
        public static float CalculateAverage(int[] input)
        {
            if (input == null) throw new ArgumentNullException();
            if (input.Length == 0) throw new ArgumentNullException();

            int somme = 0;
            for (int i = 0; i < input.Length; i++)
            {
                somme += input[i];
            }
            return somme /= input.Length;

        }

    }
}
