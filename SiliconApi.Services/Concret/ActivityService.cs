
using APSiliconApiICore.Common.DTO.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.IdentityModel.Tokens;
using rlcx.suid;
using SiliconApi.Common.DTO.Request;
using SiliconApi.Data.Entities;
using SiliconApi.Data.UoW;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SiliconApi.Services.Concret
{
    public class ActivityService : IActivityService
    {
        private readonly IConfiguration _configuration;

        private readonly IUnitOfWork _uow;


        public ActivityService(IConfiguration configuration, IUnitOfWork uow)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _uow = uow ?? throw new ArgumentNullException(nameof(uow));
        }



        public Task<IQueryable<Actividad>> GetActividades(ComentarioRequest filtro)
        {
            return null;
        }
        public Task<IQueryable<Actividad>> GetActividadDetalles(ActividadRequest actividad)
        {
            return null;
        }

        public Task InsertComentarioValoracion(object actividad)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable> GetReservas(GetReservasByUSerRequest dato)
        {

            return null;
        }

        public Task InsertReserva(InsertReservaRequest reserva)
        {
            throw new NotImplementedException();
        }
               
    }
}