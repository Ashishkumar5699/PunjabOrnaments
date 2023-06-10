using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using System.Collections.ObjectModel;

namespace Punjab_Ornaments.Presentation.Viewmodels.Customer
{
    public partial class CustomerListViewModel : BaseViewModel
    {
        #region private Menbers
        private ObservableCollection<Models.Customer> _custmorList;
        #endregion

        #region Constructor and initial methods
        public CustomerListViewModel(ILocalDataService localDataService, INavigationService navigationservice) : base(localDataService, navigationservice)
        {
        }
        public async Task OnAppearing()
        {
            var listofCustomers = await _localDataService.GetAllCustomers();
            CustomerList = new ObservableCollection<Models.Customer>(listofCustomers);
        }
        #endregion

        #region BindableProperties
        public ObservableCollection<Models.Customer> CustomerList
        {
            get => _custmorList;
            set
            {
                _custmorList = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
