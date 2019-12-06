using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTIModelo.Modelos
{
    public class Models
    {

    }

    public class Iglesias
    {
        public int Iglesia_ID { get; set; }
        public string Iglesia { get; set; }

        public int Categoria_Iglesia_ID { get; set; }
    }

    public class Categorias_Iglesia
    {
        public int Categoria_Iglesia_ID { get; set; }
        public string Categoria_Iglesia { get; set; }

    }

    public class Responsables
    {
        public int Responsable_ID { get; set; }
        public string Responsable { get; set; }
        public string Password { get; set; }
        public int Cargo_ID { get; set; }
    }

    public class Cargos
    {
        public int Cargo_ID { get; set; }
        public string Cargo { get; set; }

    }

    public class Cuentas
    {
        public int Cuenta_ID { get; set; }

        public string Cuenta { get; set; }
    }

    public class Egresos
    {
        public int Egresos_ID { get; set; }

        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public int Responsable_ID { get; set; }

        public int Cuenta_ID { get; set; }

        public int Iglesia_ID { get; set; }
    }

    public class Ingresos
    {
        public int Ingresos_ID { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public int Responsable_ID { get; set; }

        public int Cuenta_ID { get; set; }

        public int Iglesia_ID { get; set; }


    }
}
