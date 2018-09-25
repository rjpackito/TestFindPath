using System;
using System.Collections.Generic;
using Xunit;

namespace FindPath.Tests
{
    public class FindPathTests
    {
        [Fact]
        public void FindPathOkResult()
        {       
            //Arrange
            List<Route> inputRoutes = new List<Route> {
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
                    }};
            List<Route> outputRoutes = new List<Route> {
                new Route {
                    Start ="Мельбурн",
                    End="Кельн"
                    },
                new Route {
                    Start ="Кельн",
                    End="Москва"
                    },
                new Route {
                    Start ="Москва",
                    End="Париж"
                    }};
            RouteComparer routeComparer = new RouteComparer();
            //Act
            RoutesOutput result = FindPathService.FindPath(inputRoutes);

            //Assert
            Assert.Equal(result.Routes, outputRoutes, routeComparer);
        }
        [Fact]
        public void FindPathErrorResult()
        {
            //Arrange
            List<Route> inputRoutes = null;
            //Act
            RoutesOutput result = FindPathService.FindPath(inputRoutes);

            //Assert
            Assert.Null(result.Routes);
        }
           }
    public class RouteComparer : IEqualityComparer<Route>
    {
        public bool Equals(Route x, Route y)
        {
            if (x is null || y is null)
            return false;

            return x.Start == y.Start && x.End==y.End;
        }

        public int GetHashCode(Route route)
        {
            if (route is null) return 0;           

            return route.GetHashCode();
        }
    }
}
