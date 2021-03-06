using System;
using System.Collections.Generic;

namespace WordSearch
{
    public class PuzzleGameRunner
    {
        private IPuzzleSolver _puzzleSolver;
        private IWordSearchFileParser _wordSearchFileParser;
        
        public PuzzleGameRunner(IPuzzleSolver puzzleSolver, IWordSearchFileParser wordSearchFileParser)
        {
            _puzzleSolver = puzzleSolver;
            _wordSearchFileParser = wordSearchFileParser;
        }

        public Dictionary<string,string> Run(string filename)
        {
            Tuple<List<string>, List<List<char>>> puzzleParts = _wordSearchFileParser.ParsePuzzleFile(filename);

            return _puzzleSolver.SolvePuzzle(puzzleParts.Item1, puzzleParts.Item2);
        }
    }
}