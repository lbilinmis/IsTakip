namespace IsTakip.WebUI.Constraints
{
    public class Programlama : IRouteConstraint
    {
        public List<string> programlamaDiller = new List<string>() { "c##","c","java","android"};
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return programlamaDiller.Contains(values[routeKey].ToString().ToLower());
        }
    }
}
