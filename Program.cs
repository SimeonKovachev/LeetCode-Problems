using LeetCode_Problems;

Arrays concatenator = new Arrays();

//string[] words = ["ad", "bd", "aaab", "baa", "badab"];
int[] seats = [3, 1, 5];
int[] students = [2, 7, 4];

string allowed = "ab";

int result = concatenator.MinMovesToSeat(seats, students);

Console.WriteLine(result);
