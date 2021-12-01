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
            Console.WriteLine(BlocksShape.DisplayRandom());
        }
    }
}
