using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace session2
{

    internal class Coche {
        int puertas;
        int ruedas;
        string marca;
        bool itv_vigente;

        Coche(int puertas, int ruedas, string marca, bool itv_vigente) {
            this.puertas = puertas;
            this.ruedas = ruedas;
            this.marca = marca;
            this.itv_vigente = itv_vigente;
        }
    }

    internal class Mesa {
        float peso;
        float largo;
        string material;
        string color;

        Mesa(float peso, float largo, string material, string color) { 
            this.peso = peso;
            this.largo = largo;
            this.material = material;
            this.color = color;
        }
    }
    
}
