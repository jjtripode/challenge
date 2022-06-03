using System.Threading.Tasks;
using Newtonsoft.Json;
using nubimetricsApi.Data;
using Flurl;
using Newtonsoft;
using Flurl.Http;
using Newtonsoft.Json;
using nubimetricsApi.Models.MercadolibreModels.Paises;
using System.Collections.Generic;
using nubimetricsApi.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace nubimetricsApi.Services
{
    public class UsuariosService : IUsuariosService
    {
        private ApplicationDbContext _context;

        public UsuariosService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            var entities = await _context.Usuarios.ToListAsync();
            
            return entities;
        }
    }
}