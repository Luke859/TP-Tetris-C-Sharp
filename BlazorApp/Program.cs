using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BlazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Blocks = new newBlocks();
            var BlocksShape = new BlocksShape();
            BlocksShape.BlockShape();
            // Console.WriteLine(BlocksShape.DisplayRandom(BlocksShape.shapesArray));
            // BlocksShape.shapesArray;
            int[,] test =  BlocksShape.DisplayRandom(BlocksShape.shapesArray);
            for (int i = 0; i < test.GetLength(0); i++){                 
                for (int j = 0; j < test.GetLength(1); j++){

                   Console.Write(test[i,j]); 
                }
               Console.WriteLine();
            }; 
        }
    }
}
