namespace MudBlazorApp2.Data
{
	public class Device
	{
		public int Id { get; set; }
		public string DeviceName { get; set; }
		
		public DateTime FetchedTime { get; set; }

		public DateTime LastUpdated { get; set; }

		public List<int> SensorValues { get; set; }

	}
}
