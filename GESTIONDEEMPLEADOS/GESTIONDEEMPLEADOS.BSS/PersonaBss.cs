using GESTIONDEEMPLEADOS.DAL;
using GESTIONDEEMPLEADOS.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONDEEMPLEADOS.BSS
{
    public class PersonaBss
    { PersonaDal dal = new PersonaDal();
        public DataTable ListaPersonaBss()
        {
            return dal.ListarPersonasDal();
        }
        public Persona Obtenerid(int id)
        {
            return dal.obtenerpersonaid(id);
        }
        public void EditarPersonaBss(Persona p)
        {
            dal.EditarPersonaDal(p);
        }
        public void EliminarPersonaBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }
    }

}
