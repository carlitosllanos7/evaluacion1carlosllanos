using gestion.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestion.DAL;

namespace gestion.BSS
{
    public class personasbss
    {
        personasdal dal = new personasdal();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonasDAL();
        }
        public void InsertarPersonaBss(Personas persona)
        {
            dal.insertarPersonaDal(persona);
        }
        public Personas ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }
        public void EditarPersonaDss(Personas p)
        {
            dal.EditarPersonaDal(p);
        }
    }
}
