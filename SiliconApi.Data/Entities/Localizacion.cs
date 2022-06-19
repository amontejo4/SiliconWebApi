
using System;

namespace SiliconApi.Data.Entities
{
    public class Localizacion
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int Numero { get; set; }
        public int Codigo_postal { get; set; }

    }
}
