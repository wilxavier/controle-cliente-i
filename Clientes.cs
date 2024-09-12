using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_Clientes_Inicial
{
    public class Clientes
    {
        public string nome {get; set; }

        public string endereco {get; set; }

        public float valor {get; set; }

        public float valorImposto {get; set; }

        public float total {get; set; }

        public virtual void PagarImposto (float v)
        {
            valor = v;
            valorImposto = valor * 10/100;
            total = valor + valorImposto;
        }
    }
}