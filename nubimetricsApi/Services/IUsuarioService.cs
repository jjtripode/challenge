using System.Collections.Generic;
using System.Threading.Tasks;
using NubimetricsApi.Models;

namespace nubimetricsApi.Services
{
    public interface IUsuariosService
    {
         Task<IEnumerable<Usuario>> GetAllAsync();
         Task<Usuario> GetByIdAsync(int id);
         Task<Usuario> SaveOrUpdateAsync(Usuario usuario);
         Task<bool> DeleteAsync(int id);

    }
}