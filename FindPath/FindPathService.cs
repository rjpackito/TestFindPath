using System;
using System.Collections.Generic;
using System.Linq;

namespace FindPath
{
    public static class FindPathService
    {
        public static RoutesOutput FindPath(List<Route> routes)
        {
            RoutesOutput result = new RoutesOutput();
            try
            {
                Dictionary<string, string> routeDictFromTo = new Dictionary<string, string>();
                routeDictFromTo = routes.ToDictionary(r => r.Start, r => r.End);
                
                string stationFrom = routes.Select(s => s.Start)
                    .Except(routes.Select(s => s.End))
                    .ToList()[0];

                result.Routes = new List<Route>();
                while (true)
                {
                    if (routeDictFromTo.ContainsKey(stationFrom))
                    {
                        result.Routes.Add(new Route
                        {
                            Start = stationFrom,
                            End = routeDictFromTo[stationFrom]
                        });
                        stationFrom = routeDictFromTo[stationFrom];
                    }
                    else
                        break;
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.ErrorCode = 1;
            }
            return result;

        }
    }
}
