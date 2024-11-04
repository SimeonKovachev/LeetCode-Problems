using LeetCode_Problems;

Arrays concatenator = new Arrays();

//string[] words = ["ad", "bd", "aaab", "baa", "badab"];
string[] sentences = ["a", "cb"];
string[] students = ["ab", "c"];

int[] nums = [1, 2, 3, 4, 5, 14];
int[] index = [4, 5, 6, 7, 0, 2, 1, 3];

IList<IList<string>> list = [["phone", "blue", "pixel"], ["computer", "silver", "phone"], ["phone", "gold", "iphone"]];
string ruleKey = "type";
string ruleValue = "phone";

string allowed = "codeleet";

bool result = concatenator.CanAliceWin(nums);

Console.WriteLine(result);
