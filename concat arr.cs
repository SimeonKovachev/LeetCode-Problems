using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode_Problems
{
    public class Arrays
    {
        public int[] GetConcatenation(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n * 2];

            for (int i = 0; i < n; i++)
            {
                int value = nums[i];
                ans[i] = value;
                ans[i + n] = value;
            }

            return ans;
        }

        public int[] BuildArray(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n];

            for (int i = 0; i < n; i++)
            {
                ans[i] = nums[nums[i]];
            }

            return ans;
        }

        public int MinimumOperations(int[] nums)
        {
            int operations = 0;

            foreach (int num in nums)
            {
                int reminder = num % 3;

                if (reminder == 1 || reminder == 2)
                {
                    operations++;
                }
            }

            return operations;
        }

        /* public int NumIdenticalPairs(int[] nums)
         {
             int pairs = 0;
             for (int i = 0; i < nums.length; i++)
             {
                 for (int j = 0; j < nums.length; j++)
                 {
                     if (nums[i] == nums[j] & i < j)
                     {
                         pairs++;
                     }
                 }
             }
         }*/

        public int FinalValueAfterOperations(string[] operations)
        {
            int result = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "++X" || operations[i] == "X++") {
                result++;
            }
            else if (operations[i] == "--X" || operations[i] == "X--") {
                result--;
            }
        }
        return result;
    }

        public int MaximumWealth(int[][] accounts)
        {
            int customer = accounts.Length;
            int richestPersonSum = 0;

            for (int i = 0; i < customer; i++)
            {
                int currentSum = 0;
                int bank = accounts[i].Length;

                for (int j = 0; j < bank; j++)
                {
                    int currentBankAmount = accounts[i][j];
                    currentSum += currentBankAmount;
                }

                if (richestPersonSum < currentSum)
                {
                    richestPersonSum = currentSum;
                }
            }

            return richestPersonSum;
        }

        public int CountConsistentStrings(string allowed, string[] words)
        {
            int resultCount = 0;

            HashSet<char> allowedSet = new HashSet<char>(allowed);

            foreach (string word in words)
            {
                bool isConsistent = true;

                foreach (char c in word)
                {
                    if (!allowedSet.Contains(c))
                    {
                        isConsistent = false;
                        break;
                    }
                }

                if (isConsistent)
                {
                    resultCount++;
                }
            }

            return resultCount;
        }

        public string longestCommonPrefix(string[] words)
        {
            string longestCommonPrefix = "";
            for (int i = 0; i < words.Length; i++)
            {

            }
            return longestCommonPrefix;
        }

        public int climbStairs(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return climbStairs(n - 1) + climbStairs(n - 2);
        }

        public int titleToNumber(string columnTitle)
        {
            int result = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                result *= 26;
                result += columnTitle[i] - 'A' + 1;
            }
            return result;
        }

        public int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            foreach (int num in nums)
            {
                actualSum += num;
            }

            return expectedSum - actualSum;
        }

        public int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);
            int minNumberOfMoves = 0;

            for (int i = 0; i < seats.Length; i++)
            {
                minNumberOfMoves += Math.Abs(seats[i] - students[i]);
            }

            return minNumberOfMoves;
        }

        public int[] LeftRightDifference(int[] nums)
        {
            int n = nums.Length;
            int[] answers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for(int j = 0; j < i; j++)
                {
                    leftSum += nums[j];
                }

                for(int k = i + 1;  k < n; k++)
                {
                    rightSum += nums[k];
                }

                answers[i] = Math.Abs(leftSum - rightSum);
            }

            return answers;
        }

        public int[] NumberGame(int[] nums)
        {
            Array.Sort(nums);
            List<int> numsList = nums.ToList();

            int[] arr = new int[nums.Length];
            int arrIndex = 0;

            while (numsList.Count > 0) { 
                int aliceRemoved = numsList[0];
                numsList.RemoveAt(0);

                if(numsList.Count == 0)
                {
                    arr[arrIndex] = aliceRemoved;
                    break;
                }

                int bobRemoved = numsList[0];
                numsList.RemoveAt(0);

                arr[arrIndex] = bobRemoved;
                arrIndex++;

                arr[arrIndex] = aliceRemoved;
                arrIndex++;
            }

            return arr;
        }
    }
}
