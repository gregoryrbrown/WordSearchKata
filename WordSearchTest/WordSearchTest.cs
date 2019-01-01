using System;
using System.Collections.Generic;
using Xunit;
using WordSearch;

namespace WordSearchTest
{
    public class WordSearchTest
    {
        [Fact]
        public void WordSearch_Finds_Word_in_down_direction()
        {
            WordSearch.WordSearch downwardsFinder = new WordSearch.WordSearch();

            string downWord = "KIRK";

            List<List<char>> gridArrayList = GetGridList();

            string expectedResults = "(11,0),(11,1),(11,2),(11,3)";
            string actualResults = downwardsFinder.FindWord(downWord, gridArrayList);

            Assert.Equal(expectedResults, actualResults);
        }
        
        
        private List<List<char>> GetGridList()
        {

                return new List<List<char>>
                {
                    new List<char> {'U', 'N', 'K', 'S', 'G', 'K', 'M', 'A', 'R', 'N', 'H', 'K', 'D', 'T', 'A'},
                    new List<char> {'W', 'T', 'F', 'E', 'C', 'Q', 'M', 'W', 'Q', 'J', 'C', 'I', 'H', 'S', 'N'},
                    new List<char> {'V', 'V', 'Q', 'N', 'K', 'M', 'Y', 'C', 'Y', 'O', 'W', 'R', 'J', 'W', 'N'},
                    new List<char> {'M', 'Q', 'E', 'O', 'R', 'H', 'B', 'T', 'P', 'Y', 'E', 'K', 'Y', 'V', 'I'},
                    new List<char> {'J', 'W', 'V', 'B', 'B', 'Y', 'A', 'S', 'T', 'Y', 'O', 'M', 'L', 'O', 'N'},
                    new List<char> {'J', 'R', 'L', 'M', 'C', 'U', 'C', 'N', 'O', 'O', 'W', 'U', 'U', 'W', 'X'},
                    new List<char> {'X', 'O', 'E', 'N', 'X', 'M', 'Y', 'S', 'V', 'I', 'C', 'S', 'R', 'Q', 'L'},
                    new List<char> {'K', 'Z', 'R', 'P', 'H', 'N', 'T', 'P', 'W', 'H', 'D', 'S', 'R', 'F', 'R'},
                    new List<char> {'Y', 'K', 'L', 'W', 'Z', 'T', 'M', 'Q', 'H', 'U', 'H', 'U', 'R', 'A', 'K'},
                    new List<char> {'D', 'D', 'O', 'I', 'H', 'H', 'N', 'P', 'M', 'C', 'J', 'N', 'O', 'K', 'V'},
                    new List<char> {'Y', 'X', 'X', 'I', 'V', 'K', 'E', 'G', 'A', 'G', 'J', 'P', 'M', 'P', 'R'},
                    new List<char> {'A', 'K', 'M', 'L', 'V', 'Y', 'E', 'I', 'J', 'C', 'U', 'S', 'S', 'T', 'N'},
                    new List<char> {'W', 'M', 'S', 'F', 'N', 'W', 'S', 'S', 'P', 'V', 'J', 'U', 'I', 'I', 'I'},
                    new List<char> {'C', 'V', 'Z', 'C', 'Z', 'B', 'Y', 'O', 'X', 'K', 'L', 'W', 'E', 'Z', 'O'},
                    new List<char> {'K', 'T', 'E', 'T', 'T', 'C', 'E', 'Z', 'V', 'U', 'D', 'O', 'N', 'K', 'A'}
                };

        }
        
        
        
        
        
    }
    
}