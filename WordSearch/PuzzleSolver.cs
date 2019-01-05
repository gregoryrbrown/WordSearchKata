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

        public Dictionary<string,string> SolvePuzzle(List<string> searchWords, List<List<char>> gridListArray)
        {
            Dictionary<string,string> coordinateResults = new Dictionary<string, string>();
            
            foreach (var aWord in searchWords)
            {
                    var coords = _wordSearch.FindWordCoordinates(aWord, new List<List<char>>());
                    coordinateResults.Add(aWord, coords);
            }

            return coordinateResults;
        }
        
        
    }
}