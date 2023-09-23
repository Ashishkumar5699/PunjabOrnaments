using Punjab_Ornaments.Infrastructure.BillGeneration;
using Punjab_Ornaments.Infrastructure.Database;
using Punjab_Ornaments.Infrastructure.Navigation;
using SQLite;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Punjab_Ornaments.Presentation.Viewmodels.HomePage.Sale
{
    public partial class SaleQuatationPageViewModel : BaseViewModel
    {
        public ICommand AddItemCommand => new Command(AddItemAsync);
        public ICommand BillGenerationCommnad => new Command(BillGenerationAsync);


        private readonly IBillGeneration _billGeneration;
        
        private SaleDTO _saleItems = new();
        private ObservableCollection<SaleDTO> _saleItemsList;


        public SaleQuatationPageViewModel(ILocalDataService localDataService, INavigationService navigationservice, IBillGeneration billGeneration) : base(localDataService, navigationservice)
        {
            _billGeneration = billGeneration;
        }

        public SaleDTO SaleItem
        {
            get => _saleItems;
            set => SetProperty(ref _saleItems, value);
        }
        
        public ObservableCollection<SaleDTO> SaleItems
        {
            get => _saleItemsList;
            set => SetProperty(ref _saleItemsList, value);
        }

        void AddItemAsync()
        {
            SaleItems ??= new ObservableCollection<SaleDTO>();
            OnPropertyChanged(nameof(SaleItem));
            SaleItems.Add(SaleItem);
        }
        void BillGenerationAsync()
        {
            var ms = _billGeneration.SaleBillGenerate();
            //Saves the memory stream as file.
            Infrastructure.Helpers.SaveService saveService = new();
            saveService.SaveAndView("Invoice.pdf", "application/pdf", ms);
        }
    }

    public class SaleDTO
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Rate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
