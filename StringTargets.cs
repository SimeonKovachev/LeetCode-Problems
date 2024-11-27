using System.Text;

namespace LeetCode_Problems
{
    public class StringTargets
    {
        public int ScoreOfString(string s)
        {
            int sum = 0;
            for(int i = 0; i < s.Length; i++)
            {
                int firstNumber = (int)s[i];
                if (i+1 !< s.Length)
                {
                    int secondNumber = (int)s[i + 1];
                    sum += Math.Abs(firstNumber - secondNumber);
                }
            }

            return sum;
        }

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

        public string ConvertDateToBinary(string date)
        {
           string[] parts = date.Split('-');

            int year = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int day = int.Parse(parts[2]);

            string yearBinary = Convert.ToString(year, 2);
            string monthBinary = Convert.ToString(month, 2);
            string dayBinary = Convert.ToString(day, 2);

            return $"{yearBinary}-{monthBinary}-{dayBinary}";
        }

        public string Interpret(string command)
        {
            string result = command.Replace("()", "o").Replace("(al)", "al");
            return result;
        }

        public string ToLowerCase(string s)
        {
            return s.ToLower();
        }

        public string ReconstructSentence(string s)
        {
            string[] words = s.Split(' ');

            string[] sortedWords = new string[words.Length];

            foreach (string word in words)
            {
                int position = int.Parse(word[^1].ToString()) - 1;

                sortedWords[position] = word.Substring(0, word.Length - 1);
            }

            return string.Join(" ", sortedWords);
        }

        public bool IsBalanced(string num)
        {
            int oddSum = 0;
            int eventSum = 0;

            foreach (char digit in num)
            {
                if(digit % 2 == 0) eventSum += digit - '0';
                else oddSum += digit - '0';
            }

            if (oddSum == eventSum) return true;
            return false;
        }
    }
}
