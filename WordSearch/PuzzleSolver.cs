using System.Collections.Generic;

namespace WordSearch
{
    public class PuzzleSolver : IPuzzleSolver
    {
        private IWordFinder _wordFinder;
        
        public PuzzleSolver(IWordFinder wordFinder)
        {
            _wordFinder = wordFinder;
        }

        public Dictionary<string,string> SolvePuzzle(List<string> searchWords, List<List<char>> gridListArray)
        {
            Dictionary<string,string> coordinateResults = new Dictionary<string, string>();
            
            foreach (var aWord in searchWords)
            {
                if (!coordinateResults.ContainsKey(aWord))
                {
                    var coords = _wordFinder.FindWordCoordinates(aWord, gridListArray);
                    coordinateResults.Add(aWord, coords);
                }
            }

            return coordinateResults;
        }
        
        
    }
}