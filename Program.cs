using LeetCode_Problems;

Arrays concatenator = new Arrays();

//string[] words = ["ad", "bd", "aaab", "baa", "badab"];
string[] sentences = ["a", "b", "c", "ab", "bc", "abc"];
string[] students = ["$easy$", "$problem$"];

int[] nums = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];
int[] index = [4, 5, 6, 7, 0, 2, 1, 3];

IList<IList<string>> list = [["London", "New York"], ["New York", "Lima"], ["Lima", "Sao Paulo"]];
string ruleKey = "type";
string ruleValue = "phone";

string allowed = "codeleet";

int[] result = concatenator.PlusOne(nums);

Console.WriteLine(result);
