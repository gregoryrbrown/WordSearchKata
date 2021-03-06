using System.Collections.Generic;
using Xunit;

namespace WordSearchTest
{
    public class WordSearchTest
    {
        private WordSearch.WordFinder wordFinder;
        
        public WordSearchTest()
        {
            wordFinder = new WordSearch.WordFinder();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void WordSearch_Finds_Word_in_down_direction(int testCase)
        {
            string searchWord = "KIRK";

            List<List<char>> gridArrayList = GetGridList(testCase);

            string expectedResults = GetExpectedDownResults(testCase);
            string actualResults = wordFinder.FindWordCoordinates(searchWord, gridArrayList);

            Assert.Equal(expectedResults, actualResults);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        public void WordSearch_Finds_Word_in_up_direction(int testCase)
        {
            string searchWord = "BONES";

            List<List<char>> gridArrayList = GetGridList(testCase);

            string expectedResults = GetExpecteUpWorddResults(testCase);
            string actualResults = wordFinder.FindWordCoordinates(searchWord, gridArrayList);

            Assert.Equal(expectedResults, actualResults);
        }
        
        
        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        public void WordSearch_Finds_Word_in_left_to_right_direction(int testCase)
        {
            string searchWord = "UHURA";

            List<List<char>> gridArrayList = GetGridList(testCase);

            string expectedResults = GetExpectedLtRWorddResults(testCase);
            string actualResults = wordFinder.FindWordCoordinates(searchWord, gridArrayList);

            Assert.Equal(expectedResults, actualResults);
        }
        
        
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public void WordSearch_Finds_Word_in_right_to_left_direction(int testCase)
        {
            string searchWord = "ZECTTE";

            List<List<char>> gridArrayList = GetGridList(testCase);

            string expectedResults = GetExpectedRtLWorddResults(testCase);
            string actualResults = wordFinder.FindWordCoordinates(searchWord, gridArrayList);

            Assert.Equal(expectedResults, actualResults);
        }
        
        
        [Theory]
        [InlineData(1)]
        [InlineData(6)]
        public void WordSearch_Finds_Word_in_up_and_to_right_direction(int testCase)
        {
            string searchWord = "SPOCK";

            List<List<char>> gridArrayList = GetGridList(testCase);

            string expectedResults = GetExpectedUpRightWorddResults(testCase);
            string actualResults = wordFinder.FindWordCoordinates(searchWord, gridArrayList);

            Assert.Equal(expectedResults, actualResults);
        }
        
        
        [Theory]
        [InlineData(1)]
        [InlineData(7)]
        public void WordSearch_Finds_Word_in_up_and_to_left_direction(int testCase)
        {
            string searchWord = "SCOTTY";

            List<List<char>> gridArrayList = GetGridList(testCase);

            string expectedResults = GetExpectedUpLeftWorddResults(testCase);
            string actualResults = wordFinder.FindWordCoordinates(searchWord, gridArrayList);

            Assert.Equal(expectedResults, actualResults);
        }
        
        
        [Theory]
        [InlineData(1)]
        [InlineData(8)]
        public void WordSearch_Finds_Word_in_down_and_to_right_direction(int testCase)
        {
            string searchWord = "KHAN";

            List<List<char>> gridArrayList = GetGridList(testCase);

            string expectedResults = GetExpectedDownRightWorddResults(testCase);
            string actualResults = wordFinder.FindWordCoordinates(searchWord, gridArrayList);

            Assert.Equal(expectedResults, actualResults);
        }
        
        
        [Theory]
        [InlineData(1)]
        [InlineData(9)]
        public void WordSearch_Finds_Word_in_down_and_to_left_direction(int testCase)
        {
            string searchWord = "SULU";

            List<List<char>> gridArrayList = GetGridList(testCase);

            string expectedResults = GetExpectedDownLeftWorddResults(testCase);
            string actualResults = wordFinder.FindWordCoordinates(searchWord, gridArrayList);

            Assert.Equal(expectedResults, actualResults);
        }

        
        private string GetExpecteUpWorddResults(int testCase)
        {
            if (1 == testCase)
            {
                return "(3,4),(3,3),(3,2),(3,1),(3,0)";
            }
            
            if (3 == testCase)
            {
                return "(11,13),(11,12),(11,11),(11,10),(11,9)";
            }

            return "";
        }
        
        
        private string GetExpectedDownResults(int testCase)
        {
            if (1 == testCase)
            {
                return "(11,0),(11,1),(11,2),(11,3)";
            }

            if (2 == testCase)
            {
                return "(6,11),(6,12),(6,13),(6,14)";
            }

            return "";
        }

        private string GetExpectedLtRWorddResults(int testCase)
        {
            if (1 == testCase || 4 == testCase)
            {
                return "(9,8),(10,8),(11,8),(12,8),(13,8)";
            }

            return "";
        }
        
        
        private string GetExpectedRtLWorddResults(int testCase)
        {
            if (1 == testCase )
            {
                return "(7,14),(6,14),(5,14),(4,14),(3,14),(2,14)";
            }
            
            if (5 == testCase )
            {
                return "(14,9),(13,9),(12,9),(11,9),(10,9),(9,9)";
            }

            return "";
        }
        
        
        private string GetExpectedUpRightWorddResults(int testCase)
        {
            if (1 == testCase )
            {
                return "(7,4),(8,3),(9,2),(10,1),(11,0)";
            }

            
            if (6 == testCase )
            {
                return "(10,14),(11,13),(12,12),(13,11),(14,10)";
            }
            
            
            
            return "";
        }
        
        
        private string GetExpectedUpLeftWorddResults(int testCase)
        {
            if (1 == testCase || 7 == testCase)
            {
                return "(11,7),(10,6),(9,5),(8,4),(7,3),(6,2)";
            }
            
            return "";
        }
        
        
        private string GetExpectedDownRightWorddResults(int testCase)
        {
            if (1 == testCase )
            {
                return "(4,2),(5,3),(6,4),(7,5)";
            }

            if (8 == testCase )
            {
                return "(11,11),(12,12),(13,13),(14,14)";
            }
            
            return "";
        }
        
        
        private string GetExpectedDownLeftWorddResults(int testCase)
        {
            if (1 == testCase )
            {
                return "(12,11),(11,12),(10,13),(9,14)";
            }
            
            if (9 == testCase )
            {
                return "(14,11),(13,12),(12,13),(11,14)";
            }

            
            return "";
        }
        
        private List<List<char>> GetGridList(int testCase)
        {

            if (1 == testCase)
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
            
            if (2 == testCase)
            {
                return new List<List<char>>
                {
                    
                    new List<char> {'J', 'W', 'V', 'B', 'B', 'Y', 'A', 'S', 'T', 'Y', 'O', 'M', 'L', 'O', 'N'},
                    new List<char> {'J', 'R', 'L', 'M', 'C', 'U', 'C', 'N', 'O', 'O', 'W', 'U', 'U', 'W', 'X'},
                    new List<char> {'X', 'O', 'E', 'N', 'X', 'M', 'Y', 'S', 'V', 'I', 'C', 'S', 'R', 'Q', 'L'},
                    new List<char> {'K', 'Z', 'R', 'P', 'H', 'N', 'T', 'P', 'W', 'H', 'K', 'S', 'R', 'F', 'R'},
                    new List<char> {'Y', 'K', 'L', 'W', 'Z', 'T', 'M', 'Q', 'H', 'U', 'I', 'U', 'R', 'A', 'K'},
                    new List<char> {'D', 'D', 'O', 'I', 'H', 'H', 'N', 'P', 'M', 'C', 'R', 'N', 'O', 'K', 'V'},
                    new List<char> {'Y', 'X', 'X', 'I', 'V', 'K', 'E', 'G', 'A', 'G', 'J', 'P', 'M', 'P', 'R'},
                    new List<char> {'A', 'K', 'M', 'L', 'V', 'Y', 'E', 'I', 'J', 'C', 'U', 'S', 'S', 'T', 'N'},
                    new List<char> {'W', 'M', 'S', 'F', 'N', 'W', 'S', 'S', 'P', 'V', 'J', 'U', 'I', 'I', 'I'},
                    new List<char> {'C', 'V', 'Z', 'C', 'Z', 'B', 'Y', 'O', 'X', 'K', 'L', 'W', 'E', 'Z', 'O'},
                    new List<char> {'K', 'T', 'E', 'T', 'T', 'C', 'E', 'Z', 'V', 'U', 'D', 'O', 'N', 'K', 'A'},
                    new List<char> {'U', 'N', 'K', 'S', 'G', 'K', 'K', 'A', 'R', 'N', 'H', 'K', 'D', 'T', 'A'},
                    new List<char> {'W', 'T', 'F', 'E', 'C', 'Q', 'I', 'W', 'Q', 'J', 'C', 'I', 'H', 'S', 'N'},
                    new List<char> {'V', 'V', 'Q', 'N', 'K', 'M', 'R', 'C', 'Y', 'O', 'W', 'R', 'J', 'W', 'N'},
                    new List<char> {'M', 'Q', 'E', 'O', 'R', 'H', 'K', 'T', 'P', 'Y', 'E', 'M', 'Y', 'V', 'I'}
                };
            }
            
            if (3 == testCase)
            {
                return new List<List<char>>
                {
                    new List<char> {'U', 'N', 'K', 'S', 'G', 'K', 'M', 'A', 'R', 'N', 'H', 'K', 'D', 'T', 'A'},
                    new List<char> {'W', 'T', 'F', 'F', 'C', 'Q', 'M', 'W', 'Q', 'J', 'C', 'I', 'H', 'S', 'N'},
                    new List<char> {'V', 'V', 'Q', 'N', 'K', 'M', 'Y', 'C', 'Y', 'O', 'W', 'R', 'J', 'W', 'N'},
                    new List<char> {'M', 'Q', 'E', 'O', 'R', 'H', 'B', 'T', 'P', 'Y', 'E', 'K', 'Y', 'V', 'I'},
                    new List<char> {'J', 'W', 'V', 'B', 'B', 'Y', 'A', 'S', 'T', 'Y', 'O', 'M', 'L', 'O', 'N'},
                    new List<char> {'J', 'R', 'L', 'M', 'C', 'U', 'C', 'N', 'O', 'O', 'W', 'U', 'U', 'W', 'X'},
                    new List<char> {'X', 'O', 'E', 'N', 'X', 'M', 'Y', 'S', 'V', 'I', 'C', 'S', 'R', 'Q', 'L'},
                    new List<char> {'K', 'Z', 'R', 'P', 'H', 'N', 'T', 'P', 'W', 'H', 'D', 'S', 'R', 'F', 'R'},
                    new List<char> {'Y', 'K', 'L', 'W', 'Z', 'T', 'M', 'Q', 'H', 'U', 'H', 'U', 'R', 'A', 'K'},
                    new List<char> {'D', 'D', 'O', 'I', 'H', 'H', 'N', 'P', 'M', 'C', 'J', 'S', 'O', 'K', 'V'},
                    new List<char> {'Y', 'X', 'X', 'I', 'V', 'K', 'E', 'G', 'A', 'G', 'J', 'E', 'M', 'P', 'R'},
                    new List<char> {'A', 'K', 'M', 'L', 'V', 'Y', 'E', 'I', 'J', 'C', 'U', 'N', 'S', 'T', 'N'},
                    new List<char> {'W', 'M', 'S', 'F', 'N', 'W', 'S', 'S', 'P', 'V', 'J', 'O', 'I', 'I', 'I'},
                    new List<char> {'C', 'V', 'Z', 'C', 'Z', 'B', 'Y', 'O', 'X', 'K', 'L', 'B', 'E', 'Z', 'O'},
                    new List<char> {'K', 'T', 'E', 'T', 'T', 'C', 'E', 'Z', 'V', 'U', 'D', 'O', 'N', 'K', 'A'}
                };
            }
            
            if (4 == testCase)
            {
                return new List<List<char>>
                {
                    new List<char> {'U', 'N', 'K', 'S', 'G', 'K', 'M', 'A', 'R', 'N', 'H', 'K', 'D', 'T', 'A'},
                    new List<char> {'W', 'T', 'F', 'E', 'C', 'Q', 'M', 'W', 'Q', 'J', 'C', 'I', 'H', 'S', 'N'},
                    new List<char> {'V', 'V', 'Q', 'N', 'K', 'M', 'Y', 'C', 'Y', 'O', 'W', 'R', 'J', 'W', 'N'},
                    new List<char> {'M', 'Q', 'E', 'O', 'R', 'H', 'B', 'T', 'P', 'Y', 'E', 'K', 'Y', 'V', 'I'},
                    new List<char> {'J', 'W', 'V', 'B', 'B', 'Y', 'A', 'S', 'T', 'Y', 'O', 'U', 'H', 'U', 'R'},
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
            
            if (5 == testCase)
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
                    new List<char> {'D', 'D', 'O', 'I', 'H', 'H', 'N', 'P', 'M', 'E', 'T', 'T', 'C', 'E', 'Z'},
                    new List<char> {'Y', 'X', 'X', 'I', 'V', 'K', 'E', 'G', 'A', 'G', 'J', 'P', 'M', 'P', 'R'},
                    new List<char> {'A', 'K', 'M', 'L', 'V', 'Y', 'E', 'I', 'J', 'C', 'U', 'S', 'S', 'T', 'N'},
                    new List<char> {'W', 'M', 'S', 'F', 'N', 'W', 'S', 'S', 'P', 'V', 'J', 'U', 'I', 'I', 'I'},
                    new List<char> {'C', 'V', 'Z', 'C', 'Z', 'B', 'Y', 'O', 'X', 'K', 'L', 'W', 'E', 'Z', 'O'},
                    new List<char> {'K', 'T', 'E', 'R', 'T', 'C', 'E', 'Z', 'V', 'U', 'D', 'O', 'N', 'K', 'A'}
                };
            }
            
            if (6 == testCase)
            {
                return new List<List<char>>
                {
                    new List<char> {'U', 'N', 'K', 'S', 'G', 'K', 'M', 'A', 'R', 'N', 'H', 'X', 'D', 'T', 'A'},
                    new List<char> {'W', 'T', 'F', 'E', 'C', 'Q', 'M', 'W', 'Q', 'J', 'C', 'I', 'H', 'S', 'N'},
                    new List<char> {'V', 'V', 'Q', 'N', 'K', 'M', 'Y', 'C', 'Y', 'O', 'W', 'R', 'J', 'W', 'N'},
                    new List<char> {'M', 'Q', 'E', 'O', 'R', 'H', 'B', 'T', 'P', 'Y', 'E', 'K', 'Y', 'V', 'I'},
                    new List<char> {'J', 'W', 'V', 'B', 'B', 'Y', 'A', 'S', 'T', 'Y', 'O', 'M', 'L', 'O', 'N'},
                    new List<char> {'J', 'R', 'L', 'M', 'C', 'U', 'C', 'N', 'O', 'O', 'W', 'U', 'U', 'W', 'X'},
                    new List<char> {'X', 'O', 'E', 'N', 'X', 'M', 'Y', 'S', 'V', 'I', 'C', 'S', 'R', 'Q', 'O'},
                    new List<char> {'K', 'Z', 'R', 'P', 'H', 'N', 'T', 'P', 'W', 'H', 'D', 'S', 'R', 'P', 'R'},
                    new List<char> {'Y', 'K', 'L', 'W', 'Z', 'T', 'M', 'Q', 'H', 'U', 'H', 'U', 'S', 'A', 'K'},
                    new List<char> {'D', 'D', 'O', 'I', 'H', 'H', 'N', 'P', 'M', 'C', 'J', 'N', 'O', 'K', 'V'},
                    new List<char> {'Y', 'X', 'X', 'I', 'V', 'K', 'E', 'G', 'A', 'G', 'J', 'P', 'M', 'P', 'K'},
                    new List<char> {'A', 'K', 'M', 'L', 'V', 'Y', 'E', 'I', 'J', 'C', 'U', 'S', 'S', 'C', 'N'},
                    new List<char> {'W', 'M', 'S', 'F', 'N', 'W', 'S', 'S', 'P', 'V', 'J', 'U', 'O', 'I', 'I'},
                    new List<char> {'C', 'V', 'Z', 'C', 'Z', 'B', 'Y', 'O', 'X', 'K', 'L', 'P', 'E', 'Z', 'O'},
                    new List<char> {'K', 'T', 'E', 'T', 'T', 'C', 'E', 'Z', 'V', 'U', 'S', 'O', 'N', 'K', 'A'}
                };
            }

            if (7 == testCase)
            {
                return new List<List<char>>
                {
                    new List<char> {'U', 'N', 'K', 'S', 'G', 'K', 'M', 'A', 'T', 'N', 'H', 'K', 'D', 'T', 'A'},
                    new List<char> {'W', 'T', 'F', 'E', 'C', 'Q', 'M', 'W', 'Q', 'T', 'C', 'I', 'H', 'S', 'N'},
                    new List<char> {'V', 'V', 'Q', 'N', 'K', 'M', 'Y', 'C', 'Y', 'O', 'O', 'R', 'J', 'W', 'N'},
                    new List<char> {'M', 'Q', 'E', 'O', 'R', 'H', 'B', 'T', 'P', 'Y', 'E', 'C', 'Y', 'V', 'I'},
                    new List<char> {'J', 'W', 'V', 'B', 'B', 'Y', 'A', 'S', 'T', 'Y', 'O', 'M', 'S', 'O', 'N'},
                    new List<char> {'J', 'R', 'L', 'M', 'C', 'U', 'C', 'N', 'O', 'O', 'W', 'U', 'U', 'W', 'X'},
                    new List<char> {'X', 'O', 'E', 'N', 'X', 'M', 'Y', 'S', 'V', 'I', 'C', 'S', 'R', 'Q', 'L'},
                    new List<char> {'K', 'Z', 'R', 'P', 'H', 'N', 'T', 'P', 'W', 'H', 'D', 'S', 'R', 'F', 'R'},
                    new List<char> {'Y', 'K', 'L', 'W', 'Z', 'T', 'M', 'Q', 'H', 'U', 'H', 'U', 'R', 'A', 'K'},
                    new List<char> {'D', 'T', 'O', 'I', 'H', 'H', 'N', 'P', 'M', 'C', 'J', 'N', 'O', 'K', 'V'},
                    new List<char> {'Y', 'X', 'T', 'I', 'V', 'K', 'E', 'G', 'A', 'G', 'J', 'P', 'M', 'P', 'R'},
                    new List<char> {'T', 'K', 'M', 'O', 'V', 'Y', 'E', 'I', 'J', 'C', 'U', 'S', 'S', 'T', 'N'},
                    new List<char> {'W', 'O', 'S', 'F', 'R', 'W', 'S', 'S', 'P', 'V', 'J', 'U', 'I', 'I', 'I'},
                    new List<char> {'C', 'V', 'C', 'C', 'Z', 'S', 'Y', 'O', 'X', 'K', 'L', 'W', 'E', 'Z', 'O'},
                    new List<char> {'K', 'T', 'E', 'S', 'T', 'C', 'E', 'Z', 'V', 'U', 'D', 'O', 'N', 'K', 'A'}
                };
            }
            
            if (8 == testCase)
            {
                return new List<List<char>>
                {
                    new List<char> {'U', 'N', 'K', 'S', 'G', 'K', 'M', 'A', 'R', 'N', 'H', 'K', 'D', 'T', 'A'},
                    new List<char> {'W', 'T', 'F', 'E', 'C', 'Q', 'M', 'W', 'Q', 'J', 'C', 'I', 'H', 'S', 'N'},
                    new List<char> {'V', 'V', 'Q', 'N', 'K', 'M', 'Y', 'C', 'Y', 'O', 'W', 'R', 'J', 'W', 'N'},
                    new List<char> {'M', 'Q', 'E', 'O', 'R', 'H', 'B', 'T', 'P', 'Y', 'E', 'K', 'Y', 'V', 'I'},
                    new List<char> {'J', 'W', 'V', 'B', 'B', 'Y', 'R', 'S', 'T', 'Y', 'O', 'M', 'L', 'O', 'N'},
                    new List<char> {'J', 'R', 'L', 'M', 'C', 'U', 'C', 'N', 'O', 'O', 'W', 'U', 'U', 'W', 'X'},
                    new List<char> {'X', 'O', 'E', 'N', 'X', 'M', 'Y', 'S', 'V', 'I', 'C', 'S', 'K', 'Q', 'L'},
                    new List<char> {'K', 'Z', 'R', 'P', 'H', 'N', 'T', 'P', 'W', 'H', 'D', 'S', 'R', 'H', 'R'},
                    new List<char> {'Y', 'K', 'L', 'W', 'Z', 'T', 'M', 'Q', 'H', 'U', 'H', 'U', 'R', 'A', 'A'},
                    new List<char> {'D', 'D', 'O', 'I', 'H', 'H', 'N', 'P', 'M', 'C', 'J', 'N', 'O', 'K', 'V'},
                    new List<char> {'Y', 'X', 'X', 'I', 'V', 'K', 'E', 'G', 'A', 'G', 'J', 'P', 'M', 'P', 'R'},
                    new List<char> {'A', 'K', 'M', 'L', 'V', 'Y', 'E', 'I', 'J', 'C', 'U', 'K', 'S', 'T', 'N'},
                    new List<char> {'W', 'M', 'S', 'F', 'N', 'W', 'S', 'S', 'P', 'V', 'J', 'U', 'H', 'I', 'I'},
                    new List<char> {'C', 'V', 'Z', 'C', 'Z', 'B', 'Y', 'O', 'X', 'K', 'L', 'W', 'E', 'A', 'O'},
                    new List<char> {'K', 'T', 'E', 'T', 'T', 'C', 'E', 'Z', 'V', 'U', 'D', 'O', 'N', 'K', 'N'}
                };
            }
            
            if (9 == testCase)
            {
                return new List<List<char>>
                {
                    new List<char> {'U', 'N', 'K', 'S', 'G', 'S', 'M', 'A', 'R', 'N', 'H', 'K', 'D', 'T', 'A'},
                    new List<char> {'W', 'T', 'F', 'E', 'U', 'Q', 'M', 'W', 'Q', 'J', 'C', 'I', 'H', 'S', 'N'},
                    new List<char> {'V', 'V', 'Q', 'L', 'K', 'M', 'Y', 'C', 'Y', 'O', 'W', 'R', 'J', 'W', 'N'},
                    new List<char> {'M', 'Q', 'E', 'O', 'R', 'H', 'B', 'T', 'P', 'Y', 'E', 'K', 'Y', 'V', 'I'},
                    new List<char> {'J', 'W', 'V', 'B', 'B', 'Y', 'A', 'S', 'T', 'Y', 'O', 'M', 'L', 'O', 'N'},
                    new List<char> {'J', 'R', 'L', 'M', 'C', 'U', 'C', 'N', 'O', 'O', 'W', 'U', 'U', 'W', 'X'},
                    new List<char> {'X', 'O', 'E', 'N', 'X', 'M', 'Y', 'S', 'V', 'I', 'C', 'S', 'R', 'Q', 'L'},
                    new List<char> {'K', 'Z', 'R', 'P', 'H', 'N', 'T', 'P', 'W', 'H', 'D', 'S', 'R', 'F', 'R'},
                    new List<char> {'Y', 'K', 'L', 'W', 'Z', 'T', 'M', 'Q', 'H', 'U', 'H', 'U', 'R', 'A', 'S'},
                    new List<char> {'D', 'D', 'O', 'I', 'H', 'H', 'N', 'P', 'M', 'C', 'J', 'N', 'O', 'U', 'V'},
                    new List<char> {'Y', 'X', 'S', 'I', 'V', 'K', 'E', 'G', 'A', 'G', 'J', 'P', 'L', 'P', 'R'},
                    new List<char> {'A', 'U', 'M', 'L', 'V', 'Y', 'E', 'I', 'J', 'C', 'U', 'S', 'S', 'T', 'S'},
                    new List<char> {'L', 'M', 'S', 'F', 'N', 'W', 'S', 'S', 'P', 'V', 'J', 'U', 'I', 'U', 'I'},
                    new List<char> {'C', 'V', 'Z', 'C', 'Z', 'B', 'Y', 'O', 'X', 'K', 'K', 'W', 'L', 'Z', 'O'},
                    new List<char> {'K', 'T', 'E', 'T', 'T', 'C', 'E', 'Z', 'V', 'U', 'D', 'U', 'N', 'K', 'A'}
                };
            }
            
            return new List<List<char>>();

        }
        
    }
    
}