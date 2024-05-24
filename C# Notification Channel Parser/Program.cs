using System.Text.RegularExpressions;

Console.WriteLine("Notification Channel Parser");
Console.Write("Input: ");
string input = Console.ReadLine();

string[] tags = { "BE", "FE", "QA", "Urgent" };
string pattern = @"\[(.*?)\]";

MatchCollection matches = Regex.Matches(input, pattern);
List<string> validTags = new List<string>();

foreach (Match match in matches) {
    string tag = match.Groups[1].Value;

    if(Array.Exists(tags,element => element == tag))
    {
        validTags.Add(tag);
    }
}

Console.Write("Receive channels: ");
for (int i = 0; i < validTags.Count; i++)
{
    Console.Write(validTags[i]);
    if (i < validTags.Count - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();