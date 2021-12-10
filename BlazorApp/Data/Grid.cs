using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;



namespace BlazorApp.Data
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
            currentBlock = BlocksShape.DisplayRandom(BlocksShape.shapesArray);
            this.PlaceBlock(currentBlock, currentBlockLine, currentBlockColumn);

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
        }

        public void MovementRight(int[,] block){

            PlaceBlock(CreateEmptyBlock(), currentBlockLine, currentBlockColumn);
            if(currentBlockColumn < width - currentBlock.GetLength(1)){
                currentBlockColumn++;
            }
            PlaceBlock(currentBlock, currentBlockLine, currentBlockColumn);
        }

        public void MovementLeft(int[,] block){

            PlaceBlock(CreateEmptyBlock(), currentBlockLine, currentBlockColumn);
            if(currentBlockColumn > 0){
                currentBlockColumn--;
            }
            
            PlaceBlock(currentBlock, currentBlockLine, currentBlockColumn);
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

        public void BlockDown(){
            PlaceBlock(CreateEmptyBlock(), currentBlockLine, currentBlockColumn);
            if(currentBlockLine < height - currentBlock.GetLength(0)){
                currentBlockLine++;
            }
            PlaceBlock(currentBlock, currentBlockLine, currentBlockColumn);
        }
    }
}
