using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HealthTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTracker.ViewModels
{
	public partial class MeasurementListViewModel: ViewModelBase
	{
		public ObservableCollection<Measurement> Measurements { get; set; } = new();

		[RelayCommand]
		private void AddDummyMeasurement()
		{
			Measurements.Add(new Measurement
			{
				Id = Measurements.Count + 1,
				DateTime = DateTime.Now,
				Value = 100,
				Type = Enums.MeasurementType.Weight,
				Notes = "Test Notes"
			});
		}
	}
}
