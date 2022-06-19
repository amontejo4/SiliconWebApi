

namespace SiliconApi.Data.Entities
{
    public class Actividad_Categoria
    {
        public int Id { get; set; }
        public int ActividadId { get; set; }
        public Imagen Actividad { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }        
 
    }
}
