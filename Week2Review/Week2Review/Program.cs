// Why would we choose an interface over a parent or abstract class?
// We can have multiple interfaces!! We can only inherit from ONE base/abstract class
// Implementing interfaces that exist allows for deeper compatability with our code and out of the box C# code
// IRatable - allowed us to add ratability functionality to some of our objects

// arrays, lists, loops
// foreach loops - performing an action to each item in a collection
// for loop - performing an action or manipulating values I number of times 
// while loop - continuing until our conditions have changed and its time to stop
// How can we loop through arrays, lists, etc. and use or manipulate those values?

string[] names = { "davis", "gavin", "aden", "miguel", "emily", "dina", "michael", "thomas", "michaela", "xavier"};
// 4th item? names[4 - 1];
// Xth item? names[X - 1];

int[] numbers = { 1, 4, 2, -13, 75, 0 };
foreach(int n in numbers)
{
    Console.WriteLine(n);
}
Array.Sort(numbers); // sorts an array of numbers in ascending order. 
foreach (int n in numbers)
{
    Console.WriteLine(n);
}
Array.Reverse(numbers);
foreach (int n in numbers)
{
    Console.WriteLine(n);
}

// take in a user's input, and print out the names at that index, down to 0.
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
// 0 1 2 3 ...

int input = Int32.Parse(Console.ReadLine()); // 10, 5, 8, 2
for (int i = input; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
// 5 4 3 2 1 0 

// bounds of an array (list) are 0 to length-1
//         5 - 1
// 0 1 2 3 4

// Can we iterate through a user's string?
// "hello my name is davis"
// computer views that sentence as a single string.
// "hello" "my" "name" "is" "davis"
// computer views that as a collection of strings (words)

// in order to loop through this sentence, we need to create a list of words
// split method takes in a character that we would like to use as our split
string phrase = Console.ReadLine();
string[] words = phrase.Split(' ');

// Once we have a array/list of words, we need to loop through them to find the longest.
// figure out how many letters are in each word
// find the word with the most letters
// comparing the number of letters in each word

// foreach example
string longestWord = "";
int longestLength = 0;
foreach (string word in words)
{
    //int length = word.Length; // for the hello example, this is 5
    if(word.Length > longestLength)
    {
        longestWord = word;
        longestLength = word.Length;
    }
}
Console.WriteLine(longestWord);

// for example
longestWord = ""; // variable reassignment
longestLength = 0;
for(int i = 0; i < words.Length; i++)
{
    int length = words[i].Length;
    if(length > longestLength)
    {
        longestWord = words[i];
        longestLength = length;
    }
}
Console.WriteLine(longestWord);

// while example
longestWord = "";
longestLength = 0;
int j = 0; // our index
while (j < words.Length)
{
    int length = words[j].Length;
    if (length > longestLength)
    {
        longestWord = words[j];
        longestLength = length;
    }
    j++;
}
Console.WriteLine(longestWord);

// do while loop - performs the code in the loop AT LEAST ONCE
longestWord = "";
longestLength = 0;
int k = 0;
do
{
    int length = words[k].Length;
    if (length > longestLength)
    {
        longestWord = words[k];
        longestLength = length;
    }
    k++;
} 
while (k < words.Length);
Console.WriteLine(longestWord);