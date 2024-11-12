using LeetCode_Problems;

Arrays concatenator = new Arrays();

//string[] words = ["ad", "bd", "aaab", "baa", "badab"];
string[] sentences = ["a", "b", "c", "ab", "bc", "abc"];
string[] students = ["$easy$", "$problem$"];

int[] nums = [0, 1, 0, 3, 12];
int[] index = [4, 5, 6, 7, 0, 2, 1, 3];

IList<IList<string>> list = [["London", "New York"], ["New York", "Lima"], ["Lima", "Sao Paulo"]];
string ruleKey = "type";
string ruleValue = "phone";

string allowed = "codeleet";

void result = concatenator.MoveZeroes(nums);

Console.WriteLine(result);
