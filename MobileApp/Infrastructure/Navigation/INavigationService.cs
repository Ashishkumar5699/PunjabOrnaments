namespace Punjab_Ornaments.Infrastructure.Navigation
{
    public interface INavigationService
    {
        //Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null);
        Task NavigateToAsync(string route, string routeParameters = null, object routeobj = null);


        Task PopAsync();
    }
}
