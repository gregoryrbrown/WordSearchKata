using System.Collections.Generic;

namespace WordSearch
{
    public interface IWordFinder
    {
        string FindWordCoordinates(string searchWord, List<List<char>> searchGrid);
    }
}