using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ef_DbFirstDemo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ef_Db_FirstDemo.DataAccess
{
    class Class1
    {
        static void Main(string[] args)
        {
            using var logStream = new StreamWriter("ef-logs.txt", append: true) { AutoFlush = true };
            string connectionString = File.ReadAllText("C:/Users/piran/Desktop/New folder/dot");
            DbContextOptions<ChinookContext> options = new DbContextOptionsBuilder<ChinookContext>()
                .UseSqlServer(connectionString)
                .LogTo(Console.WriteLine, minimumLevel: LogLevel.Information)
                .Options;

            using var context = new ChinookContext(options);


            var list = new List<Track>() { null };
            list.First();

            //Track aTrack = context.Tracks.Select<Track>(x => x.Name).Take(5);
            //IQueryable<string> query =
            IQueryable<string> query = context.Tracks
                .Select(x => x.Name)
                .Take(5);



            /*

            }
            public void testCode()
            {
                var list = new List<Track>() { null };
                list.First();

                Track aTrack = context.Track.FirstOrDefault(x => x.Name.Co)

            }
            */
        }
    }
}
