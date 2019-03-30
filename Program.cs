using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesConContacto cliente = new clsClientesConContacto(0, "Jonathan Villeda",
                "001",
                "JSVP",
                1, "Jonathan Villeda", "12345", "", "johnsvill@hotmail.com", "Av Chapin", "119", "", "la calle de las Ilusiones",
                   "Mixcp", "Ciudad de Guatemala", "12345678");
            clsImpresion Impresion;
            Impresion = new clsImpresion();
            Impresion.ImprimeCliente(cliente);
        }
    }
}

