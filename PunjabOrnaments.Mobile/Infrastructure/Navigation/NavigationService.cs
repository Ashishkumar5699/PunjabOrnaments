
namespace Punjab_Ornaments.Infrastructure.Navigation
{
    public partial class NavigationService : INavigationService
    {
        public async Task NavigateToAsync(string route, string routeParameters = null, object routeobj = null)
        {
            try
            {
                if( routeParameters == null || routeobj == null )
                {
                    await Shell.Current.GoToAsync($"/{route}");
                }
                else
                {
                    await Shell.Current.GoToAsync($"/{route}", new Dictionary<string, object> { { routeParameters, routeobj } });
                }

            }
            catch(Exception ex)
            {

            }
        }

        public async Task PopAsync() => await Shell.Current.GoToAsync("..");
    }
}
