using HealthTracker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTracker.Models
{
	public class Measurement
	{
		public int Id { get; set; }
		public DateTime DateTime { get; set; }

		public double Value { get; set; }	
		public MeasurementType Type { get; set; }
		public string? Notes { get; set; }	

		//Optional Blood Preassure values
		public int? Systolic { get; set; }
		public int? Diastolic { get; set; }

	}
}
