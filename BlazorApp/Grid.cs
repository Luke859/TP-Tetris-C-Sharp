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
        public int currentBlockLine = 0;
        public int currentBlockColumn = 3;
        public int[,] currentBlock;
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
            this.PlaceBlock(BlocksShape.DisplayRandom(BlocksShape.shapesArray), currentBlockLine, currentBlockColumn);
        }

        public int WhichBlock( int line, int column){
            return this.data.ElementAt(line).ElementAt(column);
        }

        public int[,] CreateEmptyBlock(){
            int[,] emptyBlock = new int[currentBlock.GetLength(0), currentBlock.GetLength(1)];
            for(int i = 0; i < currentBlock.GetLength(0); i++){
                for(int j = 0; j < currentBlock.GetLength(1); j++){
                    emptyBlock[i,j] = 0;
                }
            }
            return emptyBlock;
        }
        public void RefreshGrid(int block, int line, int column){
            this.data[line][column] = block;
        }

        public void PlaceBlock(int[,] block, int line, int column){
            int startcolumn = column;
            for(int i = 0; i < block.GetLength(0); i++){
                for(int j = 0; j < block.GetLength(1); j++){
                    data[line][column] = block[i,j];
                    column++;
                }
                line++;
                column = startcolumn;
                
            }
            currentBlock = block;
        }

        public void MovementRight(int[,] block){

            int column = 0; 
            block = currentBlock;

            for(int i = 0; i < block.GetLength(0); i++){
                for(int j = 0; j < block.GetLength(1); j++){
                    column++;
                }
                // Console.WriteLine("TEST");
                PlaceBlock(block, 0, column);
            }
        }

        public void ReplaceCurrentBlock(){       
            int lengthBlock = currentBlock.Length;
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

        public void Update(){
            PlaceBlock(CreateEmptyBlock(), currentBlockLine, currentBlockColumn);
            currentBlockLine++;
            PlaceBlock(currentBlock, currentBlockLine, currentBlockColumn);
        }
    }
}
