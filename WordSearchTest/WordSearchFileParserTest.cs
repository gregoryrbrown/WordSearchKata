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
        
        
    }
}