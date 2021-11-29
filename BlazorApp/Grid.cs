using System;
using System.Collections.Generic;
using System.Linq;



namespace BlazorApp
{
    public class Grid : BlocksShape
    {

        public static int width {get; set; } = 10;
        public static int height {get; set; } = 20;

        public static List<List<int>> CreateGrid(int Gridwidth, int Gridheight){            
            
            width = Gridwidth; 
            height = Gridheight;

            List<List<int>> Grid = new List<List<int>>();
            for(int j = 0; j < Gridheight; j++){
                List<int> line = new List<int>();
                for(int i = 0; i < Gridwidth; i++){
                    line.Add(0);
                    Console.Write(line[i]);
                }
                Console.WriteLine();
                Grid.Add(line);
            }
            return Grid;
        }

        // public List<List<int>> UpdateGrid(int line, int colonne, newBlocks blocks , List<List<int>> grid){
        //     for(){

        //     }
        // }
    }
}
