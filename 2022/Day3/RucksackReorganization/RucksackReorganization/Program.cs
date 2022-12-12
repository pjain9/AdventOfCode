
// Read the input.
// Divide every itemtype with 2 for compartment 1 and compartment 2.
// Check what character is in both compartment item.
// Check priority and add it in a dictionary.


//int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//int[] b = new int[] { 10, 11, 12, 13, 6, 14, 15};
//int[] c = new int[] { 16, 17, 18, 19, 6, 20, 21, 22 };

//bool hasCommonElements = a.Intersect(b).Count() > 0;
//int[] commonElements = a.Intersect(b).Intersect(c).ToArray();

//Console.WriteLine(commonElements[0]);


var priority = new Dictionary<char, int>()
{
    {'a', 1},    {'b', 2},    {'c', 3 },    {'d', 4 },    {'e', 5 },    {'f', 6 },    {'g',7 },    {'h',8 },    {'i', 9 },    {'j', 10 },    {'k', 11 },    {'l', 12 },    {'m', 13 },    {'n', 14 },    {'o', 15 },    {'p', 16 },
    {'q', 17 },    {'r', 18 },    {'s', 19 },    {'t', 20 },    {'u', 21 },    {'v', 22 },    {'w', 23 },    {'x', 24 },    {'y', 25 },    {'z', 26 },    {'A', 27 },    {'B', 28 },    {'C', 29 },    {'D', 30 },    {'E', 31 },
    {'F', 32 },    {'G', 33 },    {'H', 34 },    {'I', 35 },    {'J', 36 },    {'K', 37 },    {'L', 38 },    {'M', 39 },    {'N', 40 },    {'O', 41 },    {'P', 42 },    {'Q', 43 },    {'R', 44 },    {'S', 45 },    {'T', 46 },
    {'U', 47 },    {'V', 48 },    {'W', 49 },    {'X', 50 },    {'Y', 51 },    {'Z', 52 }

};

// Read the input from the file.
var textFile = @"C:\Users\piyjain\Desktop\Advent\2022\Day3\input.txt";

if (File.Exists(textFile))
{
    string[] lines = File.ReadAllLines(textFile);

    var sum = 0;   var sequence = 1;
    int count = 0;

    // Second Question
    for (int i = 0; i < lines.Length; i+=3)
    {
        string line1 = lines[i];
        string line2 = lines[i + 1];
        string line3 = lines[i + 2];

        // Find the common characters in the 3 lines
        char commonChars;
        foreach (char c in line1)
        {
            if (line2.Contains(c) && line3.Contains(c))
            {
                commonChars = c;

                if (priority.TryGetValue(commonChars, out int value))
                {
                    sum += value;                    
                }
                break;
            }
        }

        

    // Print the common characters
    Console.WriteLine($"{i} - commonChars {sum}");
    }

    
// First Question
    //foreach (var line in lines)
    //{   

        //var count = line.Length;        

        //var splitedString = line.Chunk(count / 2);
        //var firstCompartment = splitedString.ToArray()[0];
        //var secondCompartment = splitedString.ToArray()[1];

        //var matchingValue = firstCompartment.Intersect(secondCompartment).ToArray();
        //if (matchingValue.Length > 0)
        //{
        //    if (priority.TryGetValue(matchingValue[0], out int value))
        //    {
        //        sum += value;
        //        Console.WriteLine($"{sequence} - {line} - {count} - Matching alphabet {matchingValue[0]} with Value as {value}. The total sum is {sum}");                
        //        sequence++;
        //    }
        //}

        //continue;

        // Another way
        //bool isMatched = false;
        //int outerIteration = 0;
        //int innerIteration = 0;
        //for (int i = 0; i < count / 2; i++)
        //{
        //    outerIteration++;
        //    for (int j = count - 1; j >= count / 2; j--)
        //    {
        //        innerIteration++;
        //        if (line[j] == line[i])
        //        {
        //            isMatched = true;
        //            if (priority.TryGetValue(line[j], out int value))
        //            {
        //                sum += value;
        //                Console.WriteLine($"{sequence} - {line} - {count} - Matching alphabet {line[j]} with Value as {value}. The total sum is {sum}");
        //                sequence++;
        //            }
        //            break;
        //        }
        //    }

        //    if (isMatched)
        //    {
        //        break;
        //    }
        //}          

    //}
    //Console.WriteLine($"Number of times the outer loop runs {outerIteration}");
    //Console.WriteLine($"Number of times the inner loop runs {innerIteration}");

    Console.WriteLine($"The total Sum is:  {sum}");  
}

Console.ReadLine();
