namespace HealthTracker.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MeasurementListViewModel MeasurementListViewModel { get; set; } = new();

        //Can add settings here later
    }
}
