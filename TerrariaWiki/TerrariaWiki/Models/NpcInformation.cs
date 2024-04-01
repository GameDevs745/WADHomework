using System.ComponentModel.DataAnnotations;

namespace TerrariaWiki.Models
{
	public class NpcInformation
	{
		public int NpcInformationId { get; set; }
		public string Name { get; set; }
		public int Rarity { get; set; }
		public string Description { get; set; }
		public string Trivia { get; set; }
		public string Notes { get; set; }
		public DateTime CreatedDate { get; set; }
		public string Housing { get; set; }
		public bool IsHardmode { get; set; }
		public int BiomeInformationID { get; set; } // Add this property

		public BiomeInformation Biome { get; set; }
		public ICollection<ItemInformation> ItemsToSell { get; set; }
	}
}
