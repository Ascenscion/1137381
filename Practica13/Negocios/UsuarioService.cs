using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocios
{
    public class UsuarioService
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();

        public bool existeUser(string username, string contra)
        {
            bool existeUser = false;
            existeUser = usuarioDAO.BuscarUsuario(username, contra);
            return existeUser;
        }
    }
}
