using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;//buffer de memoria
namespace CapaNegocio.Interfaces
{
   interface IEscuela
    {
        DataSet Listar();

        bool Agregar(string codEscuela, string escuela);

        bool Eliminar(string codEscuela);

        bool Actualizar(string codEscuela, string Escuela);

        DataSet Buscar(string texto, string criterio);
    }
}
