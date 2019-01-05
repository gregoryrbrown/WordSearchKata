using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordSearch
{
    public class WordSearchFileParser
    {

        public Tuple<List<string>, List<List<char>>> ParsePuzzleFile(string filePath)
        {
            List<string> searchWords = new List<string>();
            List<List<char>> characterGrid = new List<List<char>>();
            try
            {
                string aline;
                using (StreamReader sr = File.OpenText(filePath))
                {

                    while((aline = sr.ReadLine()) != null)
                    {
                        if (searchWords.Count == 0)
                        {
                            searchWords = aline.Split(',').ToList();
                        }
                        else
                        {
                            aline = aline.Replace(",", "");
                            characterGrid.Add( aline.ToCharArray().ToList());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            
            
            return new Tuple<List<string>, List<List<char>>>(searchWords, characterGrid);
                
        }
        
    }
}