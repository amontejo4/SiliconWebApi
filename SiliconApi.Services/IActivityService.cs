using APSiliconApiICore.Common.DTO.Request;
using SiliconApi.Common.DTO.Request;
using SiliconApi.Data.Entities;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SiliconApi.Services
{
    public interface IActivityService
    {
        Task<IQueryable<Actividad>> GetActividades(ComentarioRequest filtro);
        Task<IQueryable<Actividad>> GetActividadDetalles(ActividadRequest actividad);
        Task InsertComentarioValoracion(object actividad);
        Task<IQueryable> GetReservas(GetReservasByUSerRequest dato);
        Task InsertReserva(InsertReservaRequest reserva);
    }
}