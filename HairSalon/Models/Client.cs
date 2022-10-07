using System.Collections.Generic;

namespace HairSalon.Models
{
	public class Client
	{
		public int ClientId { get; set; }
		public string Name { get; set; }
		public string HairType { get; set; }
		public string StylistId { get; set; }
		public virtual Stylist Stylist { get; set; }
	}
}