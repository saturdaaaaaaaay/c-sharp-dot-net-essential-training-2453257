// C# code​​​​​​‌‌‌​​​​​​​‌​‌‌‌‌‌‌​‌​‌‌‌‌ below
using System;
using System.Text.RegularExpressions;

// Write your answer here, and then test your code.
// This is how your code will be called.
// You can edit this code to try different testing cases.
string[] test_strs = {
	"12/25/2030",
	"1/1/2020",
	"Juneuary 6",
	"07/28/1980",
	"3/15/99"
};

// Try out the code by using each of the test_strs, or enter your own:
foreach (string test_str in test_strs) {
    string learnerResult = Answer.ReverseDate(test_str);
    Console.WriteLine(learnerResult);
}

public class Answer {

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
    public  static Boolean ShowExpectedResult = false;
    public  static Boolean ShowHints = false;

    public static string ReverseDate(string date_str) {
        Regex number = new Regex(@"\d+");
        Match digit = number.Match(date_str);
        if (digit.Success) {
            string month = digit.Value;
            digit = digit.NextMatch();
            if (digit.Success) {
                string day = digit.Value;
                digit = digit.NextMatch();
                if (digit.Success) {
                    string year = digit.Value;
                    return $"{year}-{month}-{day}";
                }
            }
        }
        return "";
    }

}
