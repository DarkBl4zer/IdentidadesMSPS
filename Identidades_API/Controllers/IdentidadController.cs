using Identidades_API.Data;
using Identidades_API.Models;
using Identidades_API.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Identidades_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentidadController : ControllerBase
    {
        private readonly ILogger<IdentidadController> _logger;
        private readonly AppDBContext _dbContext;

        public IdentidadController(ILogger<IdentidadController> logger, AppDBContext dBContext)
        {
            _logger = logger;
            _dbContext = dBContext;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<UsuarioDTO>> GetUsuarios()
        {
            _logger.LogInformation("sdasd");
            return Ok(_dbContext.Usuarios.ToList());
        }
    }
}
