using System;
using System.Collections.Generic;

namespace TerrariaWiki.Models
{
	public class BiomeInformation
	{
		public int BiomeInformationID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Trivia { get; set; }
		public string Notes { get; set; }
		public bool IsHardmode { get; set; }

		public ICollection<NpcInformation> NpcsInBiome { get; set; }
		public ICollection<MobInformation> MobsInBiome { get; set; }
		public ICollection<StructureInformation> StructuresInBiome { get; set; }
	}
}
