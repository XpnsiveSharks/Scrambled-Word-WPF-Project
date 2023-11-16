using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Scrambled_Word_WPF_Project.Commons
{
    public class CoreObjects
    {
        static Random random = new Random();
        static List <int> usedInteger = new List<int>();
        static int TotalScore = 0;
        static int CorrectAnsScores = 0;
        public static string Scoring()
            => TotalScore.ToString();
        public static string CorrectGuessed()
            => CorrectAnsScores.ToString();
        public static string DisplayDifficulty()
        {
            return CorrectAnsScores <= 8 ? "Easy" :
                CorrectAnsScores >= 9 && CorrectAnsScores <= 18 ? "Average" :
                CorrectAnsScores >= 19 ? "Difficult" :
                null;
        }
        public static string wordInfo()
        {
            if (CorrectAnsScores <= 8)
            {
                return RandomizeWord(DataSource.scrambledWordInfo(1, radomNumberGenerator()));
            }
            else if(CorrectAnsScores >= 9 && CorrectAnsScores <= 18)
            {
                return RandomizeWord(DataSource.scrambledWordInfo(2, radomNumberGenerator()));
            }
            else if(CorrectAnsScores >= 19)
            {
                return RandomizeWord(DataSource.scrambledWordInfo(3, radomNumberGenerator()));
            }
            else
            {
                return null;
            }
        }
        public static string Hints()
        {
            if (CorrectAnsScores <= 5)
            {
                if (TotalScore >= 3)
                {
                    TotalScore -= 2;
                    return DataSource.scrambledWordHint(1, usedInteger[usedInteger.Count - 1]);
                }
                else
                {
                    return "Not enough points need 2 pts or more";
                }
            }
            else if(CorrectAnsScores >= 6 && CorrectAnsScores <= 15)
            {
                if(TotalScore >= 5) 
                {
                    TotalScore -= 5;
                    return DataSource.scrambledWordHint(2, usedInteger[usedInteger.Count - 1]);
                }
                else
                {
                    return "Not enough points need 5  pts or more";
                }
            }
            else if(CorrectAnsScores >= 15)
            {
                if (TotalScore >= 7)
                {
                    TotalScore -= 7;
                    return DataSource.scrambledWordHint(3, usedInteger[usedInteger.Count - 1]);
                }
                else
                {
                    return "Not enough points need 7 pts or more";
                }
            }
            else
            {
                return null;
            }
        }
        
        public static string CheckAnswer(string _answer)
        {
            if(_answer.ToLower().Equals(DataSource.scrambledWordInfo(1, usedInteger[usedInteger.Count - 1]))&& CorrectAnsScores <= 8)
            {  
                TotalScore += 1;
                CorrectAnsScores += 1;
                return wordInfo();
            }
            else if (_answer.ToLower().Equals(DataSource.scrambledWordInfo(2, usedInteger[usedInteger.Count - 1])) && CorrectAnsScores >= 9 && CorrectAnsScores <=18)
            {
                TotalScore += 2;
                CorrectAnsScores += 1;
                return wordInfo();
            }
            else if (_answer.ToLower().Equals(DataSource.scrambledWordInfo(3, usedInteger[usedInteger.Count - 1])) && CorrectAnsScores >= 19)
            {
                TotalScore += 3;
                CorrectAnsScores += 1;
                return wordInfo();
            }
            else
            {
                return RandomizeWord(DataSource.scrambledWordInfo(1, usedInteger[usedInteger.Count - 1]));// if wrong answer return the shuffled word again
            }  
        }
        static string RandomizeWord(string input)
        {
            char[] characters = input.ToCharArray();// Convert the string to an array of characters
            for (int i = characters.Length - 1; i > 0; i--)// Shuffle the characters using Fisher-Yates algorithm
            {
                int j = random.Next(i + 1);
                char temp = characters[i];
                characters[i] = characters[j];
                characters[j] = temp;
            }
            string randomizedString = new string(characters); // Convert the shuffled array back to a string
            return randomizedString;
        }
        static int radomNumberGenerator()
        {
            var numbers = new List<int>();
            for (int i = 0; i <= 19; i++)
                numbers.Add(i);

            int index = random.Next(numbers.Count);

            while (usedInteger.Contains(numbers[index]))
            index = random.Next(numbers.Count);

            usedInteger.Add(numbers[index]);
            return numbers[index];
        }
    }
}
