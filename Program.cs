﻿

//Lab 1
// Check edge cases
// Still need to add comment to explain why's and how's

//string[] wordsArray = { };
//int wordsNumber;
//char userChar;
//char[] userCharsArray = { };

//Console.WriteLine("Please input the number of words for this array");
//wordsNumber = Int32.Parse(Console.ReadLine());

//for (int index = 1; index <= wordsNumber; index++)
//{
//    Console.WriteLine($"Please enter word {index}");
//    string word = Console.ReadLine();
//    Array.Resize(ref wordsArray, wordsArray.Length + 1);
//    wordsArray[wordsArray.Length - 1] = word;

//}

//Console.WriteLine("Please enter a character to compare");
//userChar = Console.ReadKey().KeyChar;

//foreach (string word in wordsArray)
//{
//    int charCount = 0;

//    userCharsArray = word.ToCharArray(0, word.Length);
//    for (int index = 0; index < userCharsArray.Length; index++)
//    {
//        if (userCharsArray[index] == userChar)
//        {
//            charCount++;
//        }
//    }
//    Console.WriteLine($"charater count {charCount}, word length {userCharsArray.Length}");
//    double charInWordPercentage;
//    // Still need to decipher why charInWordsPercentage always result to 0 
//    charInWordPercentage = (charCount / userCharsArray.Length) * 100;
//    Console.WriteLine(charInWordPercentage);

//    if (charInWordPercentage >= 25)
//    {
//        Console.WriteLine($"The letter '{userChar}' appeared in {word} {charCount} times. This letter makes up more than 25% of the total number of characters.  ");
//    }
//    else if (charInWordPercentage < 25)
//    {
//        Console.WriteLine($"The letter '{userChar}' appeared in {word} {charCount} times.");
//    }

//}

double percent;

char[] chars = new char[10];

percent = 1.00 / chars.Length;

Console.WriteLine(percent);