

namespace SiliconApi.Data.Entities
{
    public class Actividad
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Precio { get; set; }
        public int LocalizacionId { get; set; }
        public Localizacion Localizacion { get; set; }
        public int ImagenId { get; set; }
        public Imagen Imagen { get; set; }
        public int Actividad_CategoriaId { get; set; }
        public virtual Actividad_Categoria Actividad_Categoria { get; set; }
    }
}
