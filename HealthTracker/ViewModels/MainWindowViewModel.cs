using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HealthTracker.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MeasurementListViewModel MeasurementListViewModel { get; set; } = new();

        [ObservableProperty]
        private ViewModelBase _currentPage;

        //List different pages here (temporary, until we have dependancy injection)
        private readonly HomePageViewModel _homePage = new ();
        private readonly WeightListViewModel _weightListPage = new ();

        //Constructors
        public MainWindowViewModel()
        {
            CurrentPage = _homePage;
        }

        //Can add settings here later


        //TODO: add menu action here. add button functionality might go here too, if it's an add button that is always present on the screen
        [RelayCommand]
        private void GoToHome()
        {
            CurrentPage = _homePage;
        }

        [RelayCommand]
        private void GoToWeightList()
        {
            CurrentPage = _weightListPage;
        }
    }
}
