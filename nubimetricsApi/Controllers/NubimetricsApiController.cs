using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using nubimetricsApi.Services;
using Flurl.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using System.Collections.Generic;
using NubimetricsApi.Models;

namespace nubimetricsApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class NubimetricsApiController : ControllerBase
    {

        private readonly IPaisesService _paisesService;
        private IProductosService _productosService;
        private readonly IUsuariosService _usuariosService;
        private readonly IMapper _mapper;

        public NubimetricsApiController(
                    IPaisesService colectivosService,
                    IProductosService productosService,
                    IUsuariosService usuariosService,
                   IMapper mapper)
        {
            _paisesService = colectivosService;
            _productosService = productosService;
            _usuariosService = usuariosService;
            _mapper = mapper;
        }

        /// <summary>
        /// busca pais by Acronimo, por ejmplo AR,CL,BR
        /// </summary>
        /// <remarks>
        /// Ejemplo de request:
        /// 
        /// busca pais by Acronimo, por ejmplo AR,CL,BR
        ///
        /// </remarks>
        [HttpGet("Paises/{pais}")]
        [ProducesResponseType(401)]
        public async Task<ActionResult<Models.MercadolibreModels.Paises.Root>> GetPaisByIdAsync(string pais)
        {
          if (pais == "CO" || pais == "BR")
          {
            return Unauthorized("para CO y BR");
          }
          var entity = await _paisesService.GetByIdAsync(pais);

          return entity;
        }

        /// <summary>
        /// Busca producto en ML por descripcion
        /// </summary>
        /// <remarks>
        ///
        /// El response es resumido a estos campos:
        /// id, site_id, title, price, seller.id, permalink
        ///
        /// </remarks>
        [HttpGet("busqueda/{descripcion}")]
        public async Task<ActionResult<IEnumerable<RootProductoDTO>>> FindProductosByDescripcion(string descripcion)
        {
          var entity = await _productosService.FindByDescripcionAsync(descripcion);

           var result = _mapper.Map<IEnumerable<Models.MercadolibreModels.Productos.Result>, IEnumerable<RootProductoDTO>>(entity.results);

           return Ok(result);
        }

        /// <summary>
        /// Retorna todos los usuarios
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        [HttpGet("Usuarios")]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetAllUsuarios()
        {
           var entities = await _usuariosService.GetAllAsync();

           return Ok(entities);
        }

        /// <summary>
        /// Retorna todos los usuarios
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        [HttpGet("Usuarios/{id}")]
        public async Task<Usuario> getUsuarioById(int id)
        {
           var entity = await _usuariosService.GetByIdAsync(id);

           return entity;
        }

        /// <summary>
        /// Retorna todos los usuarios
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        [HttpPost("Usuarios")]
        public async Task<Usuario> CreateUsuario( Usuario usuario )
        {
           var entity = await _usuariosService.SaveOrUpdateAsync(usuario);

           return entity;
        }

        /// <summary>
        /// Retorna todos los usuarios
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        [HttpPut("Usuarios")]
        public async Task<Usuario> UpdateUsuario( Usuario usuario )
        {
           var entity = await _usuariosService.SaveOrUpdateAsync(usuario);

           return entity;
        }

        /// <summary>
        /// Retorna todos los usuarios
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        [HttpDelete("Usuarios")]
        public async Task<bool> DeleteUsuario( int id )
        {
           var entity = await _usuariosService.DeleteAsync(id);

           return entity;
        }
    }

}
