using System;
using System.Collections.Generic;
using System.Text;

namespace FindPath
{
    public class Route
    {
        public string Start { get; set; }
        public string End { get; set; }
    }
    public class RoutesOutput : BaseResponse
    {
        public List<Route> Routes { get; set; }
    }
    public class BaseResponse
    {
        public string ErrorMessage { get; set; }
        public int ErrorCode { get; set; }
    }
}
