using System.Collections.Generic;

namespace WordSearch
{
    public interface IWordSearch
    {
        string FindWordCoordinates(string searchWord, List<List<char>> searchGrid);
    }
}