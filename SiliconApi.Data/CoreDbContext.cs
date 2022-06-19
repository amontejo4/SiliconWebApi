using SiliconApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace SiliconApi.Data
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Imagen> Actividades { get; set; }
        public DbSet<Actividad_Categoria> Actividad_Categorias { get; set; }
        public DbSet<Actividad_Puntuacion> Actividad_Puntuaciones { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Disponibilidad> Disponibilidades { get; set; }
        public DbSet<Localizacion> Localizacions { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }

    }
}