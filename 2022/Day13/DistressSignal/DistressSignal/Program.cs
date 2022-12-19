
// Read the input.
// Compare every pair 


// Read the input from the file.
var textFile = @"C:\Users\piyjain\Desktop\Advent\2022\Day13\input.txt";
var pairs = new Dictionary<int, string>();

if (File.Exists(textFile))
{
    var lines = await File.ReadAllLinesAsync(textFile);
    
    for (int i =0; i <= lines.Length; i++)
    {
        if (!pairs.ContainsKey(i))
        {
            pairs.Add(i, lines[i]);
            pairs.Add(i, lines[i + 1]);
        }        
    }
}

Console.ReadKey();


public static 