using LeetCode_Problems;

Arrays concatenator = new Arrays();
StringTargets stringTargets = new StringTargets();

//string[] words = ["ad", "bd", "aaab", "baa", "badab"];
string[] sentences = ["a", "b", "c", "ab", "bc", "abc"];
string[] students = ["an", "apple"];

int[] nums = [3, 4, 5, 2];
int[] index = [4, 5, 6, 7, 0, 2, 1, 3];

IList<IList<string>> list = [["London", "New York"], ["New York", "Lima"], ["Lima", "Sao Paulo"]];
string ruleKey = "type";
string ruleValue = "phone";

string allowed = "24123";

bool result = stringTargets.IsBalanced(allowed);

Console.WriteLine(result);
