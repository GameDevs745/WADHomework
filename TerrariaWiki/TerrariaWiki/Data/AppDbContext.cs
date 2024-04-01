using Microsoft.EntityFrameworkCore;
using TerrariaWiki.Models;

namespace TerrariaWiki.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<BiomeInformation> BiomeInformations { get; set; }
		public DbSet<ItemInformation> ItemInformations { get; set; }
		public DbSet<MobInformation> MobInformations { get; set; }
		public DbSet<NpcInformation> NpcInformations { get; set; }
		public DbSet<StructureInformation> StructureInformations { get; set; }
		public DbSet<VersionChanges> VersionChanges { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<NpcInformation>()
				.HasOne(n => n.Biome)
				.WithMany(b => b.NpcsInBiome)
				.HasForeignKey(n => n.BiomeInformationID)
				.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<NpcInformation>()
				.HasMany(n => n.ItemsToSell)
				.WithOne()
				.HasForeignKey(i => i.SellingNpcId)
				.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<MobInformation>()
				.HasOne(m => m.BiomeToSpawn)
				.WithMany(b => b.MobsInBiome)
				.HasForeignKey(m => m.BiomeInformationID)
				.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<StructureInformation>()
				.HasOne(s => s.Biome)
				.WithMany(b => b.StructuresInBiome)
				.HasForeignKey(s => s.BiomeInformationID)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
