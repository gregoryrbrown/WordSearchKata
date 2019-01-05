using System.Collections.Generic;

namespace WordSearch
{
    public interface IPuzzleSolver
    {
        Dictionary<string,string> SolvePuzzle(List<string> searchWords, List<List<char>> gridListArray);
    }
}