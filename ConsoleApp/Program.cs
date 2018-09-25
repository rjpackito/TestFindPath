using FindPath;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Route> routes = new List<Route> {
                new Route {
                    Start ="Мельбурн",
                    End="Кельн"
                    },
                new Route {
                    Start ="Москва",
                    End="Париж"
                    },
                new Route {
                    Start ="Кельн",
                    End="Москва"
                    }   };
            RoutesOutput result = FindPathService.FindPath(routes);
            result.Routes?.ForEach(s => {
                Console.WriteLine($"{s.Start} -> {s.End}");
            });
            if (result.ErrorCode == 1)
                Console.WriteLine(result.ErrorMessage);
            Console.ReadLine();
        }

    }

}

