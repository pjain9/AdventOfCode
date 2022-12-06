// Read the file.
// Find out number of Elves.
// Find the Elf carrying the most Calories. How many total Calories is that Elf carrying?

var textFile = @"C:\Users\piyjain\Desktop\Advent\2022\Day1\input.txt";
var calories = new Dictionary<int, int>();


if (File.Exists(textFile))
{
    string[] lines = File.ReadAllLines(textFile);

    int counter = 1;
    int calorie = 0;

    foreach (string line in lines)
    {
        if (line != string.Empty)
        {
            calorie += Convert.ToInt32(line);
            continue;
        }        
            calories.Add(counter, calorie);
            calorie = 0;
            counter++;                            
    }   
}


var maxCalories = calories.Values.Max();
var caloriesSortedbyValueDescending = calories.OrderByDescending(x => x.Value);

var total = 0;
var count = 0;

foreach (var item in caloriesSortedbyValueDescending)
{
    if(count == 3)
    {
        break;
    }

    total += item.Value;
    count++;
    Console.WriteLine($"The highest calorie values {item.Key} ,{item.Value} ");
}


Console.WriteLine($"Total Number of Elves: {calories.Count} ");
Console.WriteLine($"Max calories: {maxCalories}");
Console.WriteLine($"Total calories for three elvs are: {total}");


Console.ReadKey();

// Answer is maxCalories. = 70698
// Top three calories sum = 206643