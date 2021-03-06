﻿
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassCharacterCapacidadesController : ControllerBase
    {
        private readonly IClassCharacterCpacidadesService _classCharacterCpacidadesService;

        public ClassCharacterCapacidadesController(IClassCharacterCpacidadesService classCharacterCpacidades)
        {
            _classCharacterCpacidadesService = classCharacterCpacidades;
        }

        // POST: api/User
        [HttpPost]
        public bool Post([FromBody] ClassCharacterCapacidades classCharacterCpacidades)
        {
            return _classCharacterCpacidadesService.AddClassCharacterCapacidades(classCharacterCpacidades);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public bool Delete([FromBody] ClassCharacterCapacidades personajeHabilidadActiva)
        {
            return _classCharacterCpacidadesService.DeleteClassCharacterCapacidades(personajeHabilidadActiva);
        }
    }
}