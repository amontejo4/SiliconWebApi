
using System;

namespace SiliconApi.Data.Entities
{
    public class Disponibilidad
    {
        public int Id { get; set; }
        public int ActividadId { get; set; }
        public Imagen Actividad { get; set; }
        public DateTime Date { get; set; }
    }
}
