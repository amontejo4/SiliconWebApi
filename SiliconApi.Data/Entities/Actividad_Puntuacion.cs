

namespace SiliconApi.Data.Entities
{
    public class Actividad_Puntuacion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public User User { get; set; }
        public int ActividadId { get; set; }
        public Imagen Actividad { get; set; }
        public float Puntuacion { get; set; }
        public string Comentario { get; set; }
    }
}
