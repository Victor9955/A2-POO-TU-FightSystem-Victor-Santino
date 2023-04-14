using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace _2023_GC_A2_Partiel_POO.Level_1
{
    public class MyArray
    {
        // Pas d'utilisation de liste, pas d'utilisation de Linq
        // Vous devez produire vous même le nouveau tableau 
        public static int[] AppendElementInArray(int[] initialArray, int elementToAdd)
        {
            int[] arrayToReturn = new int[initialArray.Length+1];

            if (initialArray.Length == 0)
            {
                arrayToReturn[0] = elementToAdd;
            }
            else
            {
                for (int i = 0; i < initialArray.Length; i++)
                {
                    arrayToReturn[i] = initialArray[i];
                }
                arrayToReturn[(arrayToReturn.Length)+1] = elementToAdd;
            }
            return arrayToReturn;
        }

        // Pas d'utilisation de liste, pas d'utilisation de Linq
        // Vous devez produire vous même le nouveau tableau 
        public static int[] ConcatElementsInArray(int[] initialArray, int[] elementsToAdd)
        {
            throw new NotImplementedException();
        }

        // Pas d'utilisation de liste, pas d'utilisation de Linq
        // Vous devez produire vous même le nouveau tableau 
        public static int[] RemoveOccurenceInArray(int[] initialArray, int filter)
        {
            throw new NotImplementedException();
        }

        // Pas d'utilisation de liste, pas d'utilisation de Linq
        // Vous devez produire vous même le nouveau tableau 
        public static int[] RemoveOccurenceInArray(int[] initialArray, int[] filter)
        {
            throw new NotImplementedException();
        }
    }
}
