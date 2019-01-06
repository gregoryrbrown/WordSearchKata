# WordSearchKata
Word Search Kata


Assumption: the list of words on the first line will not have duplicates

Assumption: there won't be spaces in the lines

Assumption: each word in the first line will only appear one time in the grid

Make sure the latest dotnet core sdk/runtime is installed. The WordSearchGame and WordSearchTest projects target netcoreapp2.0 . The WordSearch project targets netstandard2.0  



The following should be run from the WordSearchKata directory or whatever you have called the root directory of the git repo when you cloned it. The build step below should automatically restore all necessary NuGet packages.

To build, run:  dotnet build 

To run the command line application, run: dotnet run --project WordSearchGame/WordSearchGame.csproj some_file_here.txt

To run the unit tests in the solution, run: dotnet test WordSearchTest/

There should be 29 tests. 
