using System;
using System.Collections.Generic;
using Moq;
using WordSearch;
using Xunit;

namespace WordSearchTest
{
    public class PuzzleGameRunnerTest
    {
        private PuzzleGameRunner _puzzleGameRunner;
        
        private Mock<IPuzzleSolver> _puzzleSolverMock;
        private Mock<IWordSearchFileParser> _wordSearchFileParserMock;

        private Dictionary<string, string> gameResultsDictionary;

        public PuzzleGameRunnerTest()
        {
            gameResultsDictionary = new Dictionary<string, string>(); 
            
            _puzzleSolverMock = new Mock<IPuzzleSolver>();

            _puzzleSolverMock.Setup(x => x.SolvePuzzle(It.IsAny<List<string>>(), It.IsAny<List<List<char>>>()))
                .Returns(gameResultsDictionary);
            
            _wordSearchFileParserMock = new Mock<IWordSearchFileParser>();

            _wordSearchFileParserMock.Setup(x => x.ParsePuzzleFile(It.IsAny<string>()))
                .Returns(new Tuple<List<string>, List<List<char>>>(new List<string>(), new List<List<char>>()));
            
            _puzzleGameRunner = new PuzzleGameRunner(_puzzleSolverMock.Object, _wordSearchFileParserMock.Object);
        }


        [Fact]
        public void PuzzleGameRunner_Run_calls_ParsePuzzleFile_once()
        {
            _puzzleGameRunner.Run("some_file_name.txt");

            _wordSearchFileParserMock.Verify(x => x.ParsePuzzleFile(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void PuzzleGameRunner_Run_calls_SolvePuzzle_once()
        {
            _puzzleGameRunner.Run("some_file_name.txt");

            _puzzleSolverMock.Verify(x => x.SolvePuzzle(It.IsAny<List<string>>(), It.IsAny<List<List<char>>>()), Times.Once);
        }
        
        [Fact]
        public void PuzzleGameRunner_Run_returns_Dictionary_returned_by_puzzleSolver()
        {
            Dictionary<string,string> gameResults = _puzzleGameRunner.Run("some_file_name.txt");

            Assert.Same(gameResults, gameResultsDictionary);
        }

    }
}