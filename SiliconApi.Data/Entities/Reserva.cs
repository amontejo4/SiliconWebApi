
using System;

namespace SiliconApi.Data.Entities
{
    public class Reserva
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }       
        public int ActividadId { get; set; }
        public Imagen Actividad { get; set; }
        public DateTime Date { get; set; }
 
    }
}
