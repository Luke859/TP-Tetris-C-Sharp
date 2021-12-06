using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Data
{
    public class Grid
    {

        public int width{get; set; }= 10;
        public int height{get; set;} = 20;

        public  int[,] actualBlock;
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
            actualBlock = block;
        }

        public void MovementRight(int[,] block){

            int column = 0; 
            int line = 0;
            
            for(int i = 0; i < block.GetLength(0); i++){
                for(int j = 0; j < block.GetLength(1); j++){
                    block[i,j] =grid[line][column];
                    column++;
                }
            }
            PlaceBlock(grid, block, 0, column);
        }
        public void MovementLeft(int[,] block){

            var grid = CreateGrid(10,20);
            int column = 10; 
            
            for(int i = 0; i < block.GetLength(0); i++){
                for(int j = 0; j < block.GetLength(1); j++){
                    column--;
                }
            }
            PlaceBlock(grid, block, 0, column);
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
