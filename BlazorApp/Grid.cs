using System;
using System.Collections.Generic;
using System.Linq;



namespace BlazorApp
{
    public class Grid : BlocksShape
    {

        public int width{get; set; }= 10;
        public int height{get; set;} = 20;

        public List<List<int>> CreateGrid(int Gridwidth, int Gridheight){  

            width = Gridwidth;
            height = Gridheight;          

            List<List<int>> Grid = new List<List<int>>();
            for(int j = 0; j < height; j++){
                List<int> line = new List<int>();
                for(int i = 0; i < width; i++){
                    line.Add(0);
                }
                Grid.Add(line);
            }
            return Grid;
        }

        public int WhichBlock( List<List<int>> grid, int line, int column){
            return grid.ElementAt(line).ElementAt(column);
        }

        public void RefreshGrid(List<List<int>> grid, int block, int line, int column){
            grid[line][column] = block;
        }

        public void PlaceBlock(List<List<int>> grid, int[,] block, int line, int column){
            int startcolumn = column;
            for(int i = 0; i < block.GetLength(0); i++){
                for(int j = 0; j < block.GetLength(1); j++){
                    grid[line][column] = block[i,j];
                    column++;
                }
                line++;
                column = startcolumn;
            }
        }
        public void DeleteLine(List<List<int>> grid){
            for(int i = height-1; i > -1; i--){
                for(int j = 0; j < width; j++){
                    if(grid[i][j] == 0){
                        height--;
                        Console.Write("test");
                        DeleteLine(grid);
                    }
                }
                Console.WriteLine();
                for(int z = 0; z < width; z++){
                    grid[i][z] = 0;
                }
            }   
        }

        public int MouvementRight(int column){
            return column++;
        }
    }
}
