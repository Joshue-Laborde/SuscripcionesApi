using System;
using System.Threading.Tasks;
using WebAPIAutores.Entidades;

namespace WebAPIAutores.Servicios
{
    public class ServicioLlaves
    {
        private readonly ApplicationDbContext context;

        public ServicioLlaves(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CrearLlave(string usuarioId, TipoLlave tipoLlave)
        {
            var llave = Guid.NewGuid().ToString().Replace("-", "");

            var llaveApi = new LlaveApi
            {
                Activa = true,
                Llave = llave,
                TipoLlave = tipoLlave,
                UsuarioId = usuarioId
            };

            context.Add(llaveApi);
            await context.SaveChangesAsync();
        }
    }
}
