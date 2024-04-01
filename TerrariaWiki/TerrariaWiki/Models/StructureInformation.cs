namespace TerrariaWiki.Models
{
	public class StructureInformation
	{
		public int StructureInformationID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Trivia { get; set; }
		public string Notes { get; set; }
		public bool HasLoot { get; set; }
		public bool IsItemNeededForAccess { get; set; }
		public int ItemID { get; set; } = 0;
		public int BiomeInformationID { get; set; } // Add this property

		public BiomeInformation Biome { get; set; }
	}
}
