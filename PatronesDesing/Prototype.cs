using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDesing
{
    class Prototype
    {
        public class chicos : ICloneable
        {
            public int Pelo { get; set; }
            public string Nombre { get; set; }

            public Detalles Rasgos { get; set; }


            public object Clone()
            {
                chicos clonado = this.MemberwiseClone() as chicos;
                Detalles detalles = new Detalles();
                detalles.Color_piel = this.Rasgos.Altura;
                detalles.Color_piel = this.Rasgos.Color_piel;
                clonado.Rasgos = detalles;
                return clonado;
            }
        }

        public class Detalles
        {
            public string Altura { get; set; }
            public string Color_piel { get; set; }
        }

  


    }
}
