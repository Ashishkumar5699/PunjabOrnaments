using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punjab_Ornaments.Infrastructure.Navigation
{
    public partial class NavigationService : INavigationService
    {
        //public async Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        public async Task NavigateToAsync(string route, string routeParameters = null, object routeobj = null)
        {
            try
            {
                await Shell.Current.GoToAsync($"/{route}");
            }
            catch(Exception ex)
            {

            }
        }

        public async Task PopAsync() => await Shell.Current.GoToAsync("..");
    }
}
