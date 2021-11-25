using System;
using System.Collections.Generic;
using System.Linq;


namespace BlazorApp.Data
{
    public class Grid 
    {
        public int width = 10;
        public int height = 20;

        public List<List<Cell>> CreateGrid(int width, int height){            
            List<List<Cell>> Grid = new List<List<Cell>>();
            for(int j = 0; j < height; j++){
                List<Cell> line = new List<Cell>();
                for(int i = 0; i < width; i++){
                    line.Add(Cell.empty);
                    Console.Write(line[i]);
                }
                Console.WriteLine();
                Grid.Add(line);
            }
            return Grid;
        }

        public void UpdateGrid(int line, int colonne, Cell blocks){
            
        }
    }
}
