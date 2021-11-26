using System;
using System.Collections.Generic;
using System.Linq;



namespace BlazorApp
{
    public class Grid
    {

        public int width = 10;
        public int height = 20;

        public List<List<int>> CreateGrid(int width, int height){            
            List<List<int>> Grid = new List<List<int>>();
            for(int j = 0; j < height; j++){
                List<int> line = new List<int>();
                for(int i = 0; i < width; i++){
                    line.Add(0);
                    Console.Write(line[i]);
                }
                Console.WriteLine();
                Grid.Add(line);
            }
            return Grid;
        }

        public List<List<int>> UpdateGrid(int line, int colonne, blocks = new NewBlocks, List<List<int>> grid){
            for(int i = 0; i < blocks.GetLength(0); i++){

            }
        }
    }
}