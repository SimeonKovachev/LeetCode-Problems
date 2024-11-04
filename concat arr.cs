
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

        public int MostWordsFound(string[] sentences)
        {
            int maxNumberOfWords = 0;
            for (int i = 0; i < sentences.Length; i++)
            {
                string sentence = sentences[i].ToLower();
                int numberOfWords = sentence.Split(' ').Count();
                if (numberOfWords > maxNumberOfWords)
                {
                    maxNumberOfWords = numberOfWords;
                }
            }

            return maxNumberOfWords;
        }

        public string[] SortPeople(string[] names, int[] heights)
        {
           Array.Sort(heights, names);

            Array.Reverse(names);

            return names;
        }

        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string finalWord1 = string.Join("", word1);
            string finalWord2 = string.Join("", word2);

            if(finalWord1 == finalWord2) return true;
            return false;
        }

        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            int n = index.Length;
            List<int> target = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                int number = nums[i];
                int currentIndex = index[i];
                target.Insert(currentIndex, number);
            }
            return target.ToArray();
        }

        public int[] FindIntersectionValues(int[] nums1, int[] nums2)
        {
            int answer1 = 0;
            int answer2 = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                int currentNumber = nums1[i];
                if (nums2.Contains(currentNumber))
                {
                    answer1++;
                }
            }

            for (int j = 0; j < nums2.Length; j++)
            {
                int currentNumber = nums2[j];
                if (nums1.Contains(currentNumber))
                {
                    answer2++;
                }
            }

            int[] result = { answer1, answer2 };
            return result;
        }

        public string RestoreString(string s, int[] indices)
        {
            char[] result = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                char currentLetter = s[i];
                int index = indices[i];

                result[index] = currentLetter;
            }

            return new string(result);
        }

        public int[] RunningSum(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int runningSum = 0;
                for(int j = 0; j < i + 1; j++)
                {
                    runningSum += nums[j];
                }

                result[i] = runningSum;
            }

            return result;
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                int currentNumber = nums[i];
                for (int j = 0; j < n; j++)
                {
                    int diffNumber = nums[j];
                    if (currentNumber > diffNumber)
                    {
                        count++;
                    }
                }
                result[i] = count;
            }

            return result;
        }

        public int LargestAltitude(int[] gain)
        {
            int currentAltitude = 0;
            int highestAltitude = 0;

            foreach (int g in gain)
            {
                currentAltitude += g;
                highestAltitude = Math.Max(highestAltitude, currentAltitude);
            }

            return highestAltitude;
        }

        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int matchingItemNumber = 0;
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items[i].Count; j++)
                {
                    string currentValue = items[i][j];
                    if (ruleKey == "type" && ruleValue == currentValue && j == 0)
                    {
                        matchingItemNumber++;
                    }

                    else if (ruleKey == "color" && ruleValue == currentValue && j == 1)
                    {
                        matchingItemNumber++;
                    }

                    else if (ruleKey == "name" && ruleValue == currentValue && j == 2)
                    {
                        matchingItemNumber++;
                    }
                }
            }

            return matchingItemNumber;
        }

        public bool CanAliceWin(int[] nums)
        {
            int single_sum = 0;
            int double_sum = 0;

           foreach (int num in nums)
            {
                if(num>= 0 && num <= 9)
                    single_sum += num;
                else
                    double_sum += num;
            }

            return single_sum != double_sum;
        }

        public int SumOddLengthSubarrays(int[] arr)
        {
            int totalSum = 0;
            int n = arr.Length;

            for(int start = 0; start < n; start++)
            {
                for( int length = 1; start + length <= n; length += 2)
                {
                    int subarraySum = 0;

                    for( int i = start; i < start + length; i++)
                    {
                        subarraySum += arr[i];
                    }

                    totalSum += subarraySum;
                }

            }

            return totalSum;
        }

        public int AddedInteger(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            int x = nums2[0] - nums1[0];
            int n = nums1.Length;

            for(int i = 0; i < n; i++)
            {
                if (nums2[i] - nums1[i] != x)
                {
                    return 0;
                }
            }

            return x;
        }
    }
}
