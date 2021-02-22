using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Console.WriteLine("test");

            using var logStream = new StreamWriter("ef-logs.txt", append: false) { AutoFlush = true };
            string connectionString = File.ReadAllText("C:/Users/piran/ef-dbconnect.txt");
            DbContextOptions<ChinookContext> options = new DbContextOptionsBuilder<ChinookContext>()
                .UseSqlServer(connectionString)
                .LogTo(action: abc => Debug.WriteLine(abc), minimumLevel: LogLevel.Information)
                .Options;

            using var context = new ChinookContext(options);


            /*
            var list = new List<Track>() { null };
            list.First();

            //Track aTrack = context.Tracks.Select<Track>(x => x.Name).Take(5);
            //IQueryable<string> query =
            IQueryable<string> query = context.Tracks
                .Select(x => x.Name)
                .Take(5);
            */

            Display5Tracks(context);


            static void Display5Tracks(ChinookContext context)
            {
                var query = context.Tracks
                    .Select(x => x.Name)
                    .Take(5);
                foreach (var track in query.ToList())
                {
                    Console.WriteLine(track);
                }
                Console.WriteLine();
            }





            /*
            
            public void testCode()
            {

                var list = new List<Track>() { null };
                list.First();

                Track aTrack = context.Track.FirstOrDefault(x => x.Name.Co);

            }
            
            static void demoCode()
            {
                var list = new List<Artist>() { null };
                list.First();
                // this is "LINQ to SQL", the IQueryable version of LINQ methods
                // the logic of the LINQ calls is not executed in .NET at all, it's examined, translated to SQL, and executed by the SQL server
                Artist anArtist = context.Artists.FirstOrDefault(x => x.Name.Contains("sabbath"));

                IQueryable<string> query = context.Artists
                    .Select(x => x.Name.ToLower())
                    .Where(x => x.Length > 10)
                    .Take(10);

                List<string> results = query.ToList();


            }
            */
            
        }
    }
}
