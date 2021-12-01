using System;
using System.Collections;

namespace BlazorApp {

    public class GameOver : Grid {

        public static Grid[,] grid = new Grid[width, height];
        
        public void GameIsOver()
        {
            for(int j = 0; j < width; j++)
            {
                if(grid[j, height - 1] != null)
                {
                    Console.WriteLine("GameOver !!");
                    Environment.Exit(0);
                }
            }
            
        }
    }
}