using System;

namespace SiliconApi.Common.DTO.Request
{
    public class InsertReservaRequest
    {
        public int IdUsuario { get; set; }
        public int IdReserva { get; set; }
        public DateTime Date { get; set; }
    }
}