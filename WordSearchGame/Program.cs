using System;
using System.Collections.Generic;
using System.IO;
using WordSearch;
//using WordSearch = WordSearch.WordSearch;

namespace WordSearchGame
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || !File.Exists(args[0]))
            {
                Console.WriteLine("First argument must be the game definition file.");
                return;
            }

            WordFinder wordFinder = new WordFinder();
            PuzzleSolver _puzzleSolver = new PuzzleSolver(wordFinder);
            WordSearchFileParser _wordSearchFileParser = new WordSearchFileParser();
            
            PuzzleGameRunner _puzzleGameRunner = new PuzzleGameRunner(_puzzleSolver,_wordSearchFileParser);

            Dictionary<string, string> wordSearchResults = _puzzleGameRunner.Run(args[0]);

            foreach (KeyValuePair<string,string> aPair in wordSearchResults)
            {
                Console.WriteLine(aPair.Key + " : " + aPair.Value);
            }

        }
    }
}