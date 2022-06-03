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
using NubimetricsApi.Models;

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
            var entities = await _context.Usuarios.ToListAsync<Usuario>();

            return entities;
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            var entity = await _context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();

            return entity;
        }


        public async Task<Usuario> SaveOrUpdateAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();

            _context.Usuarios.Remove(entity);
            await _context.SaveChangesAsync();
            
            return true;
        }

    }
}