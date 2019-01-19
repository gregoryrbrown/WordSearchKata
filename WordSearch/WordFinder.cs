using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordSearch
{


    public class WordFinder : IWordFinder
    {

        public string FindWordCoordinates(string searchWord, List<List<char>> searchGrid)
        {
            //lift this out because linq pukes
            char firstchar = searchWord[0];
            
            for (int rowCountYPos = 0; rowCountYPos < searchGrid.Count; rowCountYPos++)
            {
                int matchCount = searchGrid[rowCountYPos].Count( x => x == firstchar);
                int currentMatchIndexXpos = 0;
                for(int currentMatch = 0; currentMatch <  matchCount; currentMatch++)
                {
                    currentMatchIndexXpos = searchGrid[rowCountYPos].IndexOf(firstchar, currentMatchIndexXpos);
                    
                    Tuple<string,string> testWordAndCoords = GetWordDown(currentMatchIndexXpos, rowCountYPos, searchWord.Length, searchGrid);
                    if (searchWord.Equals(testWordAndCoords.Item1))
                    {
                        return testWordAndCoords.Item2; 
                    }
                    
                    testWordAndCoords = GetWordUp(currentMatchIndexXpos, rowCountYPos, searchWord.Length, searchGrid);
                    if (searchWord.Equals(testWordAndCoords.Item1))
                    {
                        return testWordAndCoords.Item2;
                    }
                    
                    testWordAndCoords = GetWordLtR(currentMatchIndexXpos, rowCountYPos, searchWord.Length, searchGrid);
                    if (searchWord.Equals(testWordAndCoords.Item1))
                    {
                        return testWordAndCoords.Item2;
                    }
                    
                    testWordAndCoords = GetWordRtL(currentMatchIndexXpos, rowCountYPos, searchWord.Length, searchGrid);
                    if (searchWord.Equals(testWordAndCoords.Item1))
                    {
                        return testWordAndCoords.Item2;
                    }
                    
                    testWordAndCoords = GetWordUpRight(currentMatchIndexXpos, rowCountYPos, searchWord.Length, searchGrid);
                    if (searchWord.Equals(testWordAndCoords.Item1))
                    {
                        return testWordAndCoords.Item2;
                    }
                    
                    testWordAndCoords = GetWordUpLeft(currentMatchIndexXpos, rowCountYPos, searchWord.Length, searchGrid);
                    if (searchWord.Equals(testWordAndCoords.Item1))
                    {
                        return testWordAndCoords.Item2;
                    }
                    
                    testWordAndCoords = GetWordDownRight(currentMatchIndexXpos, rowCountYPos, searchWord.Length, searchGrid);
                    if (searchWord.Equals(testWordAndCoords.Item1))
                    {
                        return testWordAndCoords.Item2;
                    }
                    
                    testWordAndCoords = GetWordDownLeft(currentMatchIndexXpos, rowCountYPos, searchWord.Length, searchGrid);
                    if (searchWord.Equals(testWordAndCoords.Item1))
                    {
                        return testWordAndCoords.Item2;
                    }

                    currentMatchIndexXpos++;
                }
                    
            }

            return "";
        }


        private Tuple<string,string> GetWordDown(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> searchGrid)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            StringBuilder testwordCoords = new StringBuilder();
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos + characterCount < searchGrid.Count && firstLetterXpos < searchGrid[0].Count)
                {
                    testword.Append(searchGrid[firstLetterYPos + characterCount][firstLetterXpos]);
                    if (characterCount > 0)
                    {
                        testwordCoords.Append(",");
                    }
                    testwordCoords.Append("(" + firstLetterXpos +"," + (firstLetterYPos + characterCount) + ")");
                }
            }
            return new Tuple<string,string>( item1: testword.ToString(), item2: testwordCoords.ToString());
        }
        
        private Tuple<string,string> GetWordUp(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> searchGrid)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            StringBuilder testwordCoords = new StringBuilder();
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos - characterCount >= 0 && firstLetterXpos < searchGrid[0].Count)
                {
                    testword.Append(searchGrid[firstLetterYPos - characterCount][firstLetterXpos]);
                    
                    if (characterCount > 0)
                    {
                        testwordCoords.Append(",");
                    }
                    testwordCoords.Append("(" + firstLetterXpos +"," + (firstLetterYPos - characterCount) + ")");
                }
            }
            return new Tuple<string,string>( item1: testword.ToString(), item2: testwordCoords.ToString());
        }

        
        private Tuple<string,string> GetWordLtR(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> searchGrid)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            StringBuilder testwordCoords = new StringBuilder();
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos < searchGrid.Count && (firstLetterXpos + characterCount) < searchGrid[firstLetterYPos].Count )
                {
                    testword.Append(searchGrid[firstLetterYPos][firstLetterXpos+ characterCount]);
                    if (characterCount > 0)
                    {
                        testwordCoords.Append(",");
                    }
                    testwordCoords.Append("(" + (firstLetterXpos + characterCount) +"," + firstLetterYPos  + ")");
                }
            }
            return new Tuple<string,string>( item1: testword.ToString(), item2: testwordCoords.ToString());
        }

        
        private Tuple<string,string> GetWordRtL(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> searchGrid)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            StringBuilder testwordCoords = new StringBuilder();
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos < searchGrid.Count && (firstLetterXpos - characterCount) >= 0 )
                {
                    testword.Append(searchGrid[firstLetterYPos][firstLetterXpos - characterCount]);
                    if (characterCount > 0)
                    {
                        testwordCoords.Append(",");
                    }
                    testwordCoords.Append("(" + (firstLetterXpos - characterCount) +"," + firstLetterYPos  + ")");
                }
            }
            return new Tuple<string,string>( item1: testword.ToString(), item2: testwordCoords.ToString());
        }

        
        private Tuple<string,string> GetWordUpRight(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> searchGrid)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            StringBuilder testwordCoords = new StringBuilder();
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos - characterCount >= 0 && (firstLetterXpos + characterCount) < searchGrid.Count)
                {
                    testword.Append(searchGrid[firstLetterYPos - characterCount][firstLetterXpos + characterCount]);
                    if (characterCount > 0)
                    {
                        testwordCoords.Append(",");
                    }
                    testwordCoords.Append("(" + (firstLetterXpos + characterCount) +"," + (firstLetterYPos - characterCount) + ")");
                }
            }
            return new Tuple<string,string>( item1: testword.ToString(), item2: testwordCoords.ToString());
        }

        
        private Tuple<string,string> GetWordUpLeft(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> searchGrid)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            StringBuilder testwordCoords = new StringBuilder();
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos - characterCount >= 0 && (firstLetterXpos - characterCount) >= 0)
                {
                    testword.Append(searchGrid[firstLetterYPos - characterCount][firstLetterXpos - characterCount]);
                    if (characterCount > 0)
                    {
                        testwordCoords.Append(",");
                    }
                    testwordCoords.Append("(" + (firstLetterXpos - characterCount) +"," + (firstLetterYPos - characterCount) + ")");
                }
            }
            return new Tuple<string,string>( item1: testword.ToString(), item2: testwordCoords.ToString());
        }

        
        private Tuple<string,string> GetWordDownRight(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> searchGrid)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            StringBuilder testwordCoords = new StringBuilder();
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos + characterCount < searchGrid.Count && (firstLetterXpos + characterCount) < searchGrid.Count)
                {
                    testword.Append(searchGrid[firstLetterYPos + characterCount][firstLetterXpos + characterCount]);
                    if (characterCount > 0)
                    {
                        testwordCoords.Append(",");
                    }
                    testwordCoords.Append("(" + (firstLetterXpos + characterCount) +"," + (firstLetterYPos + characterCount) + ")");
                }
            }

            return new Tuple<string, string>(item1: testword.ToString(), item2: testwordCoords.ToString());
        }

        
        private Tuple<string,string> GetWordDownLeft(int firstLetterXpos, int firstLetterYPos, int wordLength,
            List<List<char>> searchGrid)
        {
            StringBuilder testword = new StringBuilder(wordLength);
            StringBuilder testwordCoords = new StringBuilder();
            for (int characterCount = 0; characterCount < wordLength; characterCount++)
            {
                if (firstLetterYPos + characterCount < searchGrid.Count && (firstLetterXpos - characterCount) >= 0)
                {
                    testword.Append(searchGrid[firstLetterYPos + characterCount][firstLetterXpos - characterCount]);
                    if (characterCount > 0)
                    {
                        testwordCoords.Append(",");
                    }
                    testwordCoords.Append("(" + (firstLetterXpos - characterCount) +"," + (firstLetterYPos + characterCount) + ")");
                }
            }
            return new Tuple<string,string>( item1: testword.ToString(), item2: testwordCoords.ToString());
        }

        
    }
}