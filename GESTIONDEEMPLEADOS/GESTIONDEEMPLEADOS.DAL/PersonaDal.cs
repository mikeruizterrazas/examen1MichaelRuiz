using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GESTIONDEEMPLEADOS.Modelos;
namespace GESTIONDEEMPLEADOS.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from persona";
            DataTable lista =conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.IDPersona + "'," +
                                                         "'" + persona.Nombre + "'," +
                                                         "'" + persona.Apellido + "'," +
                                                         "'Activo'";
            conexion.Ejecutar(consulta);

        }
        public Persona obtenerpersonaid(int id)
        {
            string consulta = "select * from persona where idpersona=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Persona p = new Persona();
            if (tabla.Rows.Count > 0)
            {
                p.IDPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Apellido = tabla.Rows[0]["apellido"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();

            }
            return p;
        }
        public void EditarPersonaDal(Persona p)
        {
            string consulta = "update persona set nombre='" + p.Nombre + "'," +
                                                 "apellido='" + p.Apellido + "'," +
                   
                               "where idpersona=" + p.IDPersona;
            conexion.Ejecutar(consulta);
        }
        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where idpersona" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
