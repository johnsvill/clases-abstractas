using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class clsClientesBase : clsAbsClientes
    {
        public clsClientesBase()
        {
            Id = 0;
            Nombre = string.Empty;
            RFC = string.Empty;
            Clave = string.Empty;
            TipoRegimen = 0;
            NombreContacto = string.Empty;
        }
        //Pueden haber 2 métodos con el mismo nombre pero la diferencia son los parámetros q reciben cada uno
        public clsClientesBase(int pId, string pNombre, string pClave,
           string pRFC, int pTipoRegimen, string pNombreContacto)
        {
            Id = pId;
            Nombre = pNombre;
            RFC = pRFC;
            Clave = pClave;
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
        }
        public override int Id { get; set; }//Override es para implementar una propiedad q viene de una clase abstracta
        public override string Nombre { get; set; }
        public override string Clave { get; set; }
        public override string RFC { get; set; }
        public override int TipoRegimen { get; set; }
        public override string NombreContacto { get; set; }
    }
}
