namespace TerrariaWiki.Models
{
	public class MobInformation
	{
		public int MobInformationID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Notes { get; set; }
		public string Trivia { get; set; }
		public bool IsBoss { get; set; }
		public string SpawnItem { get; set; } = string.Empty;
		public int BiomeInformationID { get; set; } // Add this property

		public BiomeInformation BiomeToSpawn { get; set; }
	}
}
