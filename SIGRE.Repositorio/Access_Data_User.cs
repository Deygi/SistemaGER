using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGRE.Entities;


namespace SIGRE.Repositorio
{
   public class Access_Data_User : iOperaciones<Usuario>
    {
        public bool actualizar(Usuario entidad)
        {
            try
            {
                using (SGEBDEntidades context =new SGEBDEntidades())
                {
                    Usuario usuario = context.Usuario.SingleOrDefault(x => x.idUser == entidad.idUser);
                    usuario.idTypeUser = entidad.idTypeUser;
                    usuario.nomUser = entidad.nomUser;
                    usuario.apeUser = entidad.apeUser;
                    usuario.password = entidad.password;
                    usuario.nickNameUser = entidad.nickNameUser;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Usuario consultar(int cod)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(int cod)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public bool registrar(Usuario entidad)
        {
            throw new NotImplementedException();
        }
    }
}
