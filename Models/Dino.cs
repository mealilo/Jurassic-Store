using System;
using System.ComponentModel.DataAnnotations;

namespace Jurassic_Store.Models
{
	public class Dino
	{
		[Key]
		[Required]
		public int id { get; set; }
		public string? commonName { get; set; }
		public string? scientificName { get; set; }
		public string? weight { get; set; }
		public string? height { get; set; }
		public string? url { get; set; }
	}
}

