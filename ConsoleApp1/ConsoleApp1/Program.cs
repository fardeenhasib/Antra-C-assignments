using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
// Assignment 1 coding problems

// Q1
Console.WriteLine($"sbyte's size is {sizeof(sbyte)} and min value is {sbyte.MinValue} and max value is {sbyte.MaxValue}");
Console.WriteLine($"byte's size is {sizeof(byte)} and min value is {byte.MinValue} and max value is {byte.MaxValue}");
Console.WriteLine($"short's size is {sizeof(short)} and min value is {short.MinValue} and max value is {short.MaxValue}");
Console.WriteLine($"ushort's size is {sizeof(ushort)} and min value is {ushort.MinValue} and max value is {ushort.MaxValue}");
Console.WriteLine($"int's size is {sizeof(int)} and min value is {int.MinValue} and max value is {int.MaxValue}");
Console.WriteLine($"uint's size is {sizeof(uint)} and min value is {uint.MinValue} and max value is {uint.MaxValue}");
Console.WriteLine($"long's size is {sizeof(long)} and min value is {long.MinValue} and max value is {long.MaxValue}");
Console.WriteLine($"ulong's size is {sizeof(ulong)} and min value is {ulong.MinValue} and max value is {ulong.MaxValue}");
Console.WriteLine($"float's size is {sizeof(float)} and min value is {float.MinValue} and max value is {float.MaxValue}");
Console.WriteLine($"double's size is {sizeof(double)} and min value is {double.MinValue} and max value is {double.MaxValue}");
Console.WriteLine($"decimal's size is {sizeof(decimal)} and min value is {decimal.MinValue} and max value is {decimal.MaxValue}");



// Q2
Console.WriteLine("Enter the number of centuries:");
int centuries = int.Parse(Console.ReadLine());

// Constants for conversion factors
const int YearsInCentury = 100;
const double DaysInYear = 365;
const int HoursInDay = 24;
const int MinutesInHour = 60;
const int SecondsInMinute = 60;
const long MillisecondsInSecond = 1000;
const long MicrosecondsInMillisecond = 1000;
const long NanosecondsInMicrosecond = 1000;

// Perform conversions
long years = centuries * YearsInCentury;
double days = years * DaysInYear;
double hours = days * HoursInDay;
double minutes = hours * MinutesInHour;
double seconds = minutes * SecondsInMinute;
double milliseconds = seconds * MillisecondsInSecond;
double microseconds = milliseconds * MicrosecondsInMillisecond;
double nanoseconds = microseconds * NanosecondsInMicrosecond;

// Display results
Console.WriteLine($"Years: {years}");
Console.WriteLine($"Days: {days}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Milliseconds: {milliseconds}");
Console.WriteLine($"Microseconds: {microseconds}");
Console.WriteLine($"Nanoseconds: {nanoseconds}");



//Practise loop and operations
// Q1

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}


// Generate a random number between 1 and 3
int correctNumber = new Random().Next(3) + 1;

Console.WriteLine("Guess the number between 1 and 3:");

// Read user's guess
int guessedNumber;
if (int.TryParse(Console.ReadLine(), out guessedNumber))
{
    if (guessedNumber < 1 || guessedNumber > 3)
    {
        Console.WriteLine("Your guess is outside the valid range (1-3).");
    }
    else if (guessedNumber == correctNumber)
    {
        Console.WriteLine("Congratulations! You guessed the correct number.");
    }
    else if (guessedNumber < correctNumber)
    {
        Console.WriteLine("Your guess is too low.");
    }
    else
    {
        Console.WriteLine("Your guess is too high.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}


// Q2

int rows = 5;

for (int i = 1; i <= rows; i++)
{

    for (int j = 1; j <= rows - i; j++)
    {
        Console.Write(" ");
    }


    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}


// Q4
DateTime birthDate = new DateTime(1990, 4, 9); 

TimeSpan age = DateTime.Today - birthDate;
int daysOld = (int)age.TotalDays;

Console.WriteLine($"The person is {daysOld} days old.");

int daysToNextAnniversary = 10000 - (daysOld % 10000);

DateTime nextAnniversary = DateTime.Today.AddDays(daysToNextAnniversary);

Console.WriteLine($"Their next 10,000 day anniversary will be on: {nextAnniversary:d}");


// Q5
DateTime currentTime = DateTime.Now;

int hour = currentTime.Hour;

string greeting;
if (hour >= 6 && hour < 12)
{
    greeting = "Good Morning";
}
else if (hour >= 12 && hour < 18)
{
    greeting = "Good Afternoon";
}
else if (hour >= 18 && hour < 22)
{
    greeting = "Good Evening";
}
else
{
    greeting = "Good Night";
}

Console.WriteLine(greeting);


// Q7
for (int increment = 1; increment <= 4; increment++)
{
    Console.Write("Increment by " + increment + "s: ");

    for (int i = 0; i <= 24; i += increment)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}

// --------------------------------------------------------------------------------
// Assignment 2 coding problems
// Practise Arrays 

// Q1
int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int[] copiedArray = new int[originalArray.Length];

for (int i = 0; i < originalArray.Length; i++)
{
    copiedArray[i] = originalArray[i];
}

Console.WriteLine("Original Array:");
PrintArray(originalArray);

Console.WriteLine("\nCopied Array:");
PrintArray(copiedArray);
    

static void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

// Q2

List<string> itemList = new List<string>();

while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
    string input = Console.ReadLine();

    if (input.StartsWith("+"))
    {
        string item = input.Substring(1).Trim();
        itemList.Add(item);
    }
    else if (input.StartsWith("-"))
    {
        string item = input.Substring(1).Trim();
        itemList.Remove(item);
    }
    else if (input == "--")
    {
        itemList.Clear();
    }
    else
    {
        Console.WriteLine("Invalid command. Please try again.");
        break;
    }

    Console.WriteLine("\nCurrent list:");
    if (itemList.Count == 0)
    {
        Console.WriteLine("List is empty.");
    }
    else
    {
        foreach (var item in itemList)
        {
            Console.WriteLine("- " + item);
        }
    }
    Console.WriteLine();
}


//Q3
int startNum = 1;
int endNum = 100;

int[] primes = FindPrimesInRange(startNum, endNum);

Console.WriteLine("Prime numbers between {0} and {1}:", startNum, endNum);
foreach (var prime in primes)
{
    Console.Write(prime + " ");
}
    

static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> primesList = new List<int>();

    for (int num = startNum; num <= endNum; num++)
    {
        if (IsPrime(num))
        {
            primesList.Add(num);
        }
    }

    return primesList.ToArray();
}

static bool IsPrime(int number)
{
    if (number <= 1)
        return false;
    if (number == 2)
        return true;
    if (number % 2 == 0)
        return false;

    int boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}


   

// Q5
int[] array1 = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

int longestStart = 0;
int longestLength = 1;
int currentStart = 0;
int currentLength = 1;

for (int i = 1; i < array1.Length; i++)
{
    if (array1[i] == array1[i - 1])
    {
        currentLength++;
        if (currentLength > longestLength)
        {
            longestLength = currentLength;
            longestStart = currentStart;
        }
    }
    else
    {
        currentStart = i;
        currentLength = 1;
    }
}

Console.WriteLine("Longest sequence of equal elements:");
for (int i = longestStart; i < longestStart + longestLength; i++)
{
    Console.Write(array1[i] + " ");
}


// Q7
int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

foreach (int number in numbers)
{
    if (frequencyMap.ContainsKey(number))
    {
        frequencyMap[number]++;
    }
    else
    {
        frequencyMap[number] = 1;
    }
}

int mostFrequentNumber = numbers[0]; // Default to the first number
int maxFrequency = frequencyMap[mostFrequentNumber];

foreach (var kvp in frequencyMap)
{
    if (kvp.Value > maxFrequency || (kvp.Value == maxFrequency && Array.IndexOf(numbers, kvp.Key) < Array.IndexOf(numbers, mostFrequentNumber)))
    {
        mostFrequentNumber = kvp.Key;
        maxFrequency = kvp.Value;
    }
}

Console.WriteLine("Most frequent number: " + mostFrequentNumber);
Console.WriteLine("Frequency: " + maxFrequency);



// Strings
// Q1
Console.WriteLine("Enter a string:");
string input_s1 = Console.ReadLine();

// Method 1: Convert the string to char array, reverse it, then convert it to string again
string reversedString1 = ReverseStringMethod1(input_s1);
Console.WriteLine("Reversed string (Method 1): " + reversedString1);

// Method 2: Print the letters of the string in back direction (from the last to the first) in a for-loop
string reversedString2 = ReverseStringMethod2(input_s1);
Console.WriteLine("Reversed string (Method 2): " + reversedString2);

static string ReverseStringMethod1(string input_s1)
{
    char[] charArray = input_s1.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

static string ReverseStringMethod2(string input_s1)
{
    string reversedString = "";
    for (int i = input_s1.Length - 1; i >= 0; i--)
    {
        reversedString += input_s1[i];
    }
    return reversedString;
}


// Q2

Console.WriteLine("Enter a sentence:");
string sentence = Console.ReadLine();

string reversedSentence = ReverseWords(sentence);

Console.WriteLine("Reversed sentence:");
Console.WriteLine(reversedSentence);


static string ReverseWords(string sentence)
{
    string pattern = @"([\w\d]+|[\.,:;=\(\)\[\]""'\\\/\!\?])";

    MatchCollection matches = Regex.Matches(sentence, pattern);

    string[] wordsAndSeparators = new string[matches.Count];
    for (int i = 0; i < matches.Count; i++)
    {
        wordsAndSeparators[i] = matches[matches.Count - i - 1].Value;
    }

    return string.Join("", wordsAndSeparators);
}


// Q4

Console.WriteLine("Enter some text:");
string text = Console.ReadLine();

List<string> palindromes = FindPalindromes(text);

Console.WriteLine("Palindromes:");
Console.WriteLine(string.Join(", ", palindromes));
    

static List<string> FindPalindromes(string text)
{
    List<string> palindromes = new List<string>();
    string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '-', '_', '\'', '"', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

    foreach (string word in words)
    {
        if (IsPalindrome(word))
        {
            palindromes.Add(word.ToLower());
        }
    }

    palindromes = palindromes.Distinct().OrderBy(p => p).ToList();

    return palindromes;
}

static bool IsPalindrome(string word)
{
    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] != word[word.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}

