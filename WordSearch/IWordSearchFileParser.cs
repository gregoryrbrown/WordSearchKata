using System;
using System.Collections.Generic;

namespace WordSearch
{
    public interface IWordSearchFileParser
    {
        Tuple<List<string>, List<List<char>>> ParsePuzzleFile(string filePath);
    }
}