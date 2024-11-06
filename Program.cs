using LeetCode_Problems;

Arrays concatenator = new Arrays();

//string[] words = ["ad", "bd", "aaab", "baa", "badab"];
string[] sentences = ["aa", "ab"];
string[] students = ["7868190130M7522", "5303914400F9211", "9273338290F4010"];

int[] nums = [12, 345, 2, 6, 7896];
int[] index = [4, 5, 6, 7, 0, 2, 1, 3];

IList<IList<string>> list = [["London", "New York"], ["New York", "Lima"], ["Lima", "Sao Paulo"]];
string ruleKey = "type";
string ruleValue = "phone";

string allowed = "codeleet";

int result = concatenator.FindNumbers(nums);

Console.WriteLine(result);
