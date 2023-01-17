Console.WriteLine("Welcome to the Pig Latin Simulator!");
Console.WriteLine();

bool runProgram = true;
//while loop
while (runProgram)
{
    Console.Write("Please enter a word you'd like to translate: ");
    string engword = Console.ReadLine().ToLower(); 

    //Indexing where the vowel is
    int vowelIndex = -1;
    foreach (char l in engword)
    {
        vowelIndex = vowelIndex + 1;
        if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u')
        {
            break;
        }
    }

    //Definitions
    string PigLatinWord = "";
    string BeforeLetters = "";
    string AfterLetters = "";

    //if this...than that
    if (vowelIndex == 0)
    {
        Console.WriteLine(engword + "way");
    }
    else
    {
        PigLatinWord = engword.Substring(0, vowelIndex);
        AfterLetters = engword.Substring(vowelIndex);
        BeforeLetters = AfterLetters + PigLatinWord + "ay";
        Console.WriteLine(BeforeLetters);
    }
    //Close or Continue
    Console.WriteLine("Enter any button to try again or n/no to stop");
    string userChoice = Console.ReadLine();

    if (userChoice == "n" || userChoice == "no")
    {
        Console.WriteLine("oodbyegay! Thanks for playing");
        break;
    }
}