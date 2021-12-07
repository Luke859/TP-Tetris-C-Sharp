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
            // var Grid = new Grid();
            // List<List<int>> LouisTheShit = Grid.CreateGrid(10, 20);
            var test = new BlocksShape();
            test.BlockShape();
            var Blocks = new Block();
            // var BlocksShape = new BlocksShape();
            // BlocksShape.BlockShape();
            // Console.WriteLine(BlocksShape.DisplayRandom()); 
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine(BlocksShape.shapesArray.Length);

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
