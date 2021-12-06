using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;



namespace BlazorApp
{
    public class Grid
    {

        public int width{get; set; }= 10;
        public int height{get; set;} = 20;

        public List<List<int>> data;
        public int[,] actualBlock;

        public Grid(int Gridwidth, int Gridheight){  

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
            this.data = Grid;
        }

        public int WhichBlock( int line, int column){
            return this.data.ElementAt(line).ElementAt(column);
        }

        public void RefreshGrid(int block, int line, int column){
            this.data[line][column] = block;
        }

        public void PlaceBlock(int[,] block, int line, int column){
            int startcolumn = column;
            for(int i = 0; i < block.GetLength(0); i++){
                for(int j = 0; j < block.GetLength(1); j++){
                    this.data[line][column] = block[i,j];
                    column++;
                }
                line++;
                column = startcolumn;
            }
            actualBlock = block;
        }

        public void MovementRight(int[,] block){

            int column = 0; 
            
            for(int i = 0; i < block.GetLength(0); i++){
                for(int j = 0; j < block.GetLength(1); j++){
                    column++;
                }
            }
            block = actualBlock;
            PlaceBlock(block, 0, column);
        }


        public void DeleteLine(List<List<int>> grid){
            for(int i = height-1; i > -1; i--){
                for(int j = 0; j < width; j++){
                    if(grid[i][j] == 0){
                        height--;
                        DeleteLine(grid);
                    }
                }
                Console.WriteLine();
                for(int z = 0; z < width; z++){
                    grid[i][z] = 0;
                }
            }   
        }
    }
}
