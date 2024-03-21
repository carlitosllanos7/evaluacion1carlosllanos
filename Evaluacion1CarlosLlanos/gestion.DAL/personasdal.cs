using gestion.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.DAL
{
    public class personasdal
    {
        public DataTable ListarPersonasDAL()
        {
            string consulta = "select*from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void insertarPersonaDal(Personas persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "' ," +
                                                  "'" + persona.Apellido + "' ," +
                                                  "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Personas ObtenerPersonaId(int id)
        {
            string consulta = "selec * from persona where idpersona=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "escribiralgo");
            Personas p = new Personas();
            if (tabla.Rows.Count > 0)
            {
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Apellido = tabla.Rows[0]["apellido"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarPersonaDal(Personas p)
        {
            string consulta = "update persona set nombre='" + p.Nombre + "'," +
                                                "apellido='" + p.Apellido + "'," +
                                    "where idpersona=" + p.IdPersona;
            conexion.Ejecutar(consulta);
        }
    }
}
