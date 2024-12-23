using System.Runtime.CompilerServices;

namespace Assignment_6_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 6.2.2
             * 
             * Given an integer array nums, return an array answer such that answer[i] 
             * is equal to the product of all the elements of nums except nums[i].
             * 
             * The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
             * You must write an algorithm that runs in O(n) time and without using the division operation.
            */

            int[] ints = { 3, 4, 5, 6 };
            int n = ints.Length;
            int excludingIndex = 2;

            Console.Write("Original array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{ints[i]} ");
            }

            int[] answer = ProductsExceptSelf( ints);

            Console.Write("Solved array using index 2: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{answer[i]} ");
            }
        }

        static int[] ProductsExceptSelf(int[] nums)
        {
            int n = nums.Length; 
            int[] leftProducts = new int[n]; 
            int[] rightProducts = new int[n]; 
            int[] answer = new int[n]; 
            
            // Initialize leftProducts array
            leftProducts[0] = 1; 
            for (int i = 1; i < n; i++)
                leftProducts[i] = nums[i - 1] * leftProducts[i - 1];
            
            // Initialize rightProducts array
            rightProducts[n - 1] = 1; 
            for (int i = n - 2; i >= 0; i--)
                rightProducts[i] = nums[i + 1] * rightProducts[i + 1];
            
            // Build the answer array
            for (int i = 0; i < n; i++) 
                answer[i] = leftProducts[i] * rightProducts[i];
            
            return answer;
        }
    }
}
