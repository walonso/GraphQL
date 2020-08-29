using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompleteGraphQL
{
public class CaducidadDAO
{
    private readonly CaducaContext contexto;
    private readonly LocService localizacion;

    private readonly AccesoDAO<Caducidad> caducidadDAO;

    public CustomError customError;

    public CaducidadDAO(CaducaContext context, LocService locService)
    {
        this.contexto = context;
        this.localizacion = locService;
        caducidadDAO = new AccesoDAO<Caducidad>(context, locService);
    }

    public async Task<List<Caducidad>> ObtenerTodoAsync()
    {
         return await caducidadDAO.ObtenerTodoAsync();
    }

    public async Task<Caducidad> ObtenerPorIdAsync(int id)
    {
         return await caducidadDAO.ObtenerPorIdAsync(id);
    }

    public async Task<bool> AgregarAsync(Caducidad caducidad)
    {
         List<IRegla> reglas = new List<IRegla>();
         if (await caducidadDAO
                 .AgregarAsync(caducidad, reglas))
             return true;
         else
         {
             customError = caducidadDAO.customError;
             return false;
         }
    }
      
      /*
    public async Task<bool> ModificarAsync(Cliente cliente)
    {
        List<IRegla> reglas = new List<IRegla>();
        if (await clienteDAO.ModificarAsync(cliente, reglas))
                return true;
        else
        {
                customError = clienteDAO.customError;
                return false;
        
        }
    }*/

    public async Task<bool> BorraAsync(int id)
    {
        var caducidad = await ObtenerPorIdAsync(id);
        if (caducidad == null)
        {
            customError = new CustomError(404, String.Format(this.localizacion
                  .GetLocalizedHtmlString("NotFound"), 
                  "La Caducidad"), "Id");
            return false;
        }
        contexto.Caducidad.Remove(caducidad);
        await contexto.SaveChangesAsync();
        return true;
    }
}
}