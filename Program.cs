using LeetCode_Problems;

Arrays concatenator = new Arrays();

//string[] words = ["ad", "bd", "aaab", "baa", "badab"];
string[] sentences = ["a", "cb"];
string[] students = ["ab", "c"];

int[] nums = [2, 3, 2];
int[] index = [1, 2];

string allowed = "ab";

int[] result = concatenator.FindIntersectionValues(nums, index);

Console.WriteLine(result);
