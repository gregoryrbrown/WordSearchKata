using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordSearch
{
    public class WordSearch
    {
        public WordSearch()
        {
            
        }

        public string FindWord(string searchWord, List<List<char>> gridArrayList)
        {
            //lift this out because linq pukes
            char firstchar = searchWord[0];
            
            for (int rowCountYPos = 0; rowCountYPos < gridArrayList.Count; rowCountYPos++)
            {
                int matchCount = gridArrayList[rowCountYPos].Count( x => x == firstchar);
                int currentMatchIndexXpos = 0;
                for(int currentMatch = 0; currentMatch <  matchCount; currentMatch++)
                {
                    currentMatchIndexXpos = gridArrayList[rowCountYPos].IndexOf(firstchar, currentMatchIndexXpos);
                    string testWord = GetWordDown(currentMatchIndexXpos, rowCountYPos, searchWord.Length, gridArrayList);
                    if (searchWord.Equals(testWord))
                    {
                        return GetWordDownCoordinateString(currentMatchIndexXpos, rowCountYPos, searchWord.Length);
                    }
                    
                    testWord = GetWordUp(currentMatchIndexXpos, rowCountYPos, searchWord.Length, gridArrayList);
                    if (searchWord.Equals(testWord))
                    {
                        return GetWordUpCoordinateString(currentMatchIndexXpos, rowCountYPos, searchWord.Length);
                    }
                    
                    
                    testWord = GetWordLtR(currentMatchIndexXpos, rowCountYPos, searchWord.Length, gridArrayList);
                    if (searchWord.Equals(testWord))
                    {
                        return GetWordLtRCoordinateString(currentMatchIndexXpos, rowCountYPos, searchWord.Length);
                    }
                    
                    
                    
                    testWord = GetWordRtL(currentMatchIndexXpos, rowCountYPos, searchWord.Length, gridArrayList);
                    if (searchWord.Equals(testWord))
                    {
                        return GetWordRtLCoordinateString(currentMatchIndexXpos, rowCountYPos, searchWord.Length);
                    }

                    currentMatchIndexXpos++;
                }
                    
            }

            return "";
        }


        private string GetWordDown(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> gridArrayList)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos + characterCount < gridArrayList.Count && firstLetterXpos < gridArrayList[0].Count)
                {
                    testword.Append(gridArrayList[firstLetterYPos + characterCount][firstLetterXpos]);
                }
            }
            return testword.ToString();
        }

        private string GetWordDownCoordinateString(int firstLetterXpos, int firstLetterYPos, int wordLength)
        {
            StringBuilder testword = new StringBuilder();
            testword.Append("(" + firstLetterXpos +"," + firstLetterYPos + ")");
            for (int characterCount = 1; characterCount < wordLength; characterCount++)
            {
                    testword.Append(",(" + firstLetterXpos +"," + (firstLetterYPos+ characterCount) + ")");
            }
            return testword.ToString();
        }
        
        private string GetWordUp(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> gridArrayList)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos - characterCount >= 0 && firstLetterXpos < gridArrayList[0].Count)
                {
                    testword.Append(gridArrayList[firstLetterYPos - characterCount][firstLetterXpos]);
                }
            }
            return testword.ToString();
        }

        private string GetWordUpCoordinateString(int firstLetterXpos, int firstLetterYPos, int wordLength)
        {
            StringBuilder testword = new StringBuilder();
            testword.Append("(" + firstLetterXpos +"," + firstLetterYPos + ")");
            for (int characterCount = 1; characterCount < wordLength; characterCount++)
            {
                testword.Append(",(" + firstLetterXpos +"," + (firstLetterYPos - characterCount) + ")");
            }
            return testword.ToString();
        }
        
        
        
        private string GetWordLtR(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> gridArrayList)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos < gridArrayList.Count && (firstLetterXpos + characterCount) < gridArrayList[firstLetterYPos].Count )
                {
                    testword.Append(gridArrayList[firstLetterYPos][firstLetterXpos+ characterCount]);
                }
            }
            return testword.ToString();
        }

        private string GetWordLtRCoordinateString(int firstLetterXpos, int firstLetterYPos, int wordLength)
        {
            StringBuilder testword = new StringBuilder();
            testword.Append("(" + firstLetterXpos +"," + firstLetterYPos + ")");
            for (int characterCount = 1; characterCount < wordLength; characterCount++)
            {
                testword.Append(",(" + (firstLetterXpos + characterCount) +"," + firstLetterYPos  + ")");
            }
            return testword.ToString();
        }


        private string GetWordRtL(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> gridArrayList)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos < gridArrayList.Count && (firstLetterXpos - characterCount) >= 0 )
                {
                    testword.Append(gridArrayList[firstLetterYPos][firstLetterXpos - characterCount]);
                }
            }
            return testword.ToString();
        }

        private string GetWordRtLCoordinateString(int firstLetterXpos, int firstLetterYPos, int wordLength)
        {
            StringBuilder testword = new StringBuilder();
            testword.Append("(" + firstLetterXpos +"," + firstLetterYPos + ")");
            for (int characterCount = 1; characterCount < wordLength; characterCount++)
            {
                testword.Append(",(" + (firstLetterXpos - characterCount) +"," + firstLetterYPos  + ")");
            }
            return testword.ToString();
        }

        
    }
}