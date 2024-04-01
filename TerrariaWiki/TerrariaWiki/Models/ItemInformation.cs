using System.ComponentModel.DataAnnotations;

namespace TerrariaWiki.Models
{
	public class ItemInformation
	{
		[Key]
		public int ItemInformationID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Rarity { get; set; }
		public string Trivia { get; set; }
		public string Notes { get; set; }
		public bool HasValue { get; set; }
		public int CopperValue { get; set; } = 0;
		public int SilverValue { get; set; } = 0;
		public int GoldValue { get; set; } = 0;
		public int PlatinumValue { get; set; } = 0;
		public DateTime CreatedDate { get; set; }
		public bool IsHardmode { get; set; }

		// New property
		public int SellingNpcId { get; set; }

		public NpcInformation SellingNpc { get; set; }
	}
}
