using System.Collections.Generic;

namespace WordSearch
{
    public class PuzzleSolver
    {
        private IWordSearch _wordSearch;
        
        public PuzzleSolver(IWordSearch wordSearch)
        {
            _wordSearch = wordSearch;
        }

        public void SolvePuzzle(List<string> searchWords, List<List<char>> gridListArray)
        {
            foreach (var aWord in searchWords)
            {
                _wordSearch.FindWordCoordinates(aWord, new List<List<char>>());                
            }
        }
        
        
    }
}