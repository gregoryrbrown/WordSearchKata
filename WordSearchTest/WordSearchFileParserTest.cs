using System;
using System.Collections.Generic;
using WordSearch;
using Xunit;

namespace WordSearchTest
{
    public class WordSearchFileParserTest
    {
        private WordSearchFileParser _wordSearchFileParser;

        public WordSearchFileParserTest()
        {
            _wordSearchFileParser = new WordSearchFileParser();
        }
        
        [Fact]
        public void WordSearchFileParser_returns_tuple_with_word_list_string_and_grid_char_array()
        {

            string filePath = "testWordSearchPuzzle.txt";

            Tuple<List<string>, List<List<char>>> results = _wordSearchFileParser.ParsePuzzleFile(filePath);

            Assert.Equal(5, results.Item1.Count);

            Assert.Equal(15, results.Item2.Count);

        }
        
        
        
        [Fact]
        public void WordSearchFileParser_returns_tuple_with_word_list_string_and_grid_char_array_with_expected_character_arrays()
        {

            string filePath = "testWordSearchPuzzle.txt";

            Tuple<List<string>, List<List<char>>> results = _wordSearchFileParser.ParsePuzzleFile(filePath);

            Assert.Equal(15, results.Item2.Count);
            
            
            Assert.Equal(new List<char>{'U','N','K','S','G','K','M','A','R','N','H','K','D','T','A'}, results.Item2[0]);
            
            Assert.Equal(new List<char>{'K','T','E','T','T','C','E','Z','V','U','D','O','N','K','A'}, results.Item2[14]);

        }
        
        
    }
}