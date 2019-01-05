using System.Collections.Generic;
using System.Linq;
using Xunit;
using WordSearch;
using Moq;

namespace WordSearchTest
{
    public class PuzzleSolverTest
    {
        private PuzzleSolver _puzzleSolver;
        private Mock<IWordSearch> _wordSearchMock;
        
        public PuzzleSolverTest()
        {
            _wordSearchMock = new Mock<IWordSearch>();
            
            _wordSearchMock.Setup(x => x.FindWordCoordinates(It.IsAny<string>(), It.IsAny<List<List<char>>>()))
                .Returns("");
            
            _puzzleSolver = new PuzzleSolver(_wordSearchMock.Object);
        }

        [Theory]
        [InlineData("KIRK,SPOCK,BONES")]
        [InlineData("KIRK,SPOCK")]
        [InlineData("KIRK,SPOCK,SCOTTY,BONES")]
        public void PuzzleSolver_calls_FindWord_as_many_times_as_there_are_words(string wordsString)
        {

            List<string> wordStringList = wordsString.Split((",")).ToList();
            List<List<char>> gridArrayList = GetGridList();

            _puzzleSolver.SolvePuzzle(wordStringList, gridArrayList);
            
            _wordSearchMock.Verify(x => x.FindWordCoordinates(It.IsAny<string>(), It.IsAny<List<List<char>>>()), Times.Exactly(wordStringList.Count));

        }
        
        
        
        [Theory]
        [InlineData("KIRK,SPOCK,BONES")]
        [InlineData("KIRK,SPOCK")]
        [InlineData("KIRK,SPOCK,SCOTTY,BONES")]
        public void PuzzleSolver_calls_FindWord_once_for_each_word(string wordsString)
        {

            List<string> wordStringList = wordsString.Split((",")).ToList();
            List<List<char>> gridArrayList = GetGridList();

            _puzzleSolver.SolvePuzzle(wordStringList, gridArrayList);

            foreach (var aWord in wordStringList)
            {
                _wordSearchMock.Verify(x => x.FindWordCoordinates(aWord, It.IsAny<List<List<char>>>()), Times.Once);    
            }

        }
        
        
        [Fact]
        public void PuzzleSolver_returns_a_mapping_from_a_search_word_to_a_string_of_coordinates()
        {
            List<string> wordStringList = new List<string>(){ "KIRK","SPOCK","SCOTTY"};
            List<List<char>> gridArrayList = GetGridList();

            _wordSearchMock.Setup(x => x.FindWordCoordinates("KIRK", It.IsAny<List<List<char>>>()))
                .Returns("(1,1),(2,2),(3,3)");

            _wordSearchMock.Setup(x => x.FindWordCoordinates("SPOCK", It.IsAny<List<List<char>>>()))
                .Returns("(4,4),(5,5),(6,6)");
            
            _wordSearchMock.Setup(x => x.FindWordCoordinates("SCOTTY", It.IsAny<List<List<char>>>()))
                .Returns("(7,7),(8,8),(9,9)");
            
            Dictionary<string,string> resultDictionary = _puzzleSolver.SolvePuzzle(wordStringList, gridArrayList);

            string theCoords = "";

            Assert.True(resultDictionary.TryGetValue("KIRK", out theCoords));
            
            Assert.Equal("(1,1),(2,2),(3,3)", theCoords);
            
            Assert.True(resultDictionary.TryGetValue("SPOCK", out theCoords));
            
            Assert.Equal("(4,4),(5,5),(6,6)", theCoords);
            
            Assert.True(resultDictionary.TryGetValue("SCOTTY", out theCoords));
            
            Assert.Equal("(7,7),(8,8),(9,9)",theCoords);
            

        }

        
        private List<List<char>> GetGridList()
        {

            return new List<List<char>>
            {
                new List<char> {'U', 'N', 'K', 'S', 'G', 'K', 'M', 'A', 'R', 'N', 'H', 'K', 'D', 'T', 'A'},
                new List<char> {'W', 'T', 'F', 'E', 'C', 'Q', 'M', 'W', 'Q', 'J', 'C', 'I', 'H', 'S', 'N'},
                new List<char> {'V', 'V', 'Q', 'N', 'K', 'M', 'Y', 'C', 'Y', 'O', 'W', 'R', 'J', 'W', 'N'},
                new List<char> {'M', 'Q', 'E', 'O', 'R', 'H', 'B', 'T', 'P', 'Y', 'E', 'K', 'Y', 'V', 'I'},
                new List<char> {'J', 'W', 'V', 'B', 'B', 'Y', 'A', 'S', 'T', 'Y', 'O', 'M', 'L', 'O', 'N'},
                new List<char> {'J', 'R', 'L', 'M', 'C', 'U', 'C', 'N', 'O', 'O', 'W', 'U', 'U', 'W', 'X'},
                new List<char> {'X', 'O', 'E', 'N', 'X', 'M', 'Y', 'S', 'V', 'I', 'C', 'S', 'R', 'Q', 'L'},
                new List<char> {'K', 'Z', 'R', 'P', 'H', 'N', 'T', 'P', 'W', 'H', 'D', 'S', 'R', 'F', 'R'},
                new List<char> {'Y', 'K', 'L', 'W', 'Z', 'T', 'M', 'Q', 'H', 'U', 'H', 'U', 'R', 'A', 'K'},
                new List<char> {'D', 'D', 'O', 'I', 'H', 'H', 'N', 'P', 'M', 'C', 'J', 'N', 'O', 'K', 'V'},
                new List<char> {'Y', 'X', 'X', 'I', 'V', 'K', 'E', 'G', 'A', 'G', 'J', 'P', 'M', 'P', 'R'},
                new List<char> {'A', 'K', 'M', 'L', 'V', 'Y', 'E', 'I', 'J', 'C', 'U', 'S', 'S', 'T', 'N'},
                new List<char> {'W', 'M', 'S', 'F', 'N', 'W', 'S', 'S', 'P', 'V', 'J', 'U', 'I', 'I', 'I'},
                new List<char> {'C', 'V', 'Z', 'C', 'Z', 'B', 'Y', 'O', 'X', 'K', 'L', 'W', 'E', 'Z', 'O'},
                new List<char> {'K', 'T', 'E', 'T', 'T', 'C', 'E', 'Z', 'V', 'U', 'D', 'O', 'N', 'K', 'A'}
            };
        }
        
        
    }
}