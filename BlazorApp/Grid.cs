using System;
using System.Collections.Generic;
using System.Linq;



namespace BlazorApp
{
    public class Grid : BlocksShape
    {

        public int width = 10;
        public int height = 20;

        public static List<List<int>> CreateGrid(int width, int height){            
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

        public static int WhichBlock( List<List<int>> grid, int line, int row){
            return grid.ElementAt(line).ElementAt(row);
        }

        // public List<List<int>> UpdateGrid(int line, int colonne, newBlocks blocks , List<List<int>> grid){
        //     for(){

        //     }
        // }
    }
}