﻿using Punjab_Ornaments.Infrastructure.APIService;
using Punjab_Ornaments.Infrastructure.Navigation;
using Punjab_Ornaments.Localization.Database;
using System.Collections.ObjectModel;

namespace Punjab_Ornaments.Presentation.Viewmodels.HomePage.Customer
{
    public partial class CustomerListViewModel : BaseViewModel
    {
        #region private Menbers
        private ObservableCollection<Models.Customer> _custmorList;
        #endregion

        #region Constructor and initial methods
        public CustomerListViewModel(IDataService localDataService, INavigationService navigationservice, IAPIService apiservice) : base(localDataService, navigationservice, apiservice)
        {
        }
        public async Task OnAppearing()
        {
            var listofCustomers = await _dataService.GetAllCustomers();
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
