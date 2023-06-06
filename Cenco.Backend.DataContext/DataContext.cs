using Cenco.Backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Text.RegularExpressions;

namespace Cenco.Backend.DataContext
{
	public partial class DataContext : DbContext
	{

		public virtual DbSet<Usuario> Usuarios { get; set; }
		public virtual DbSet<Tarea> Tareas { get; set; }

        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var TimeOnlyConverter = new ValueConverter<TimeOnly, TimeSpan>(
				d => TimeSpan.FromTicks(d.Ticks),
				d => TimeOnly.FromTimeSpan(d)
			);
			
			modelBuilder.Entity<Usuario>(entity =>
			{
				entity.ToTable("app_usuario");
				entity.Property(e => e.id).HasColumnName("id_usuario");
			});

			modelBuilder.Entity<Tarea>(entity =>
			{
				entity.ToTable("app_tarea");
				entity.Property(e => e.id).HasColumnName("id_tarea");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

	}
}