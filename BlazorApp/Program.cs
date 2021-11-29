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
            var test = new BlocksShape();
            // BlocksShape test = new BlockShape();
            // BlocksShape.RandomShape();
            test.BlockShape();
            // Console.WriteLine(BlocksShape.RandomShape());
            // Console.WriteLine(BlocksShape.shapesArray.Length);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
