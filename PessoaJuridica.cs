using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_Clientes_Inicial
{
    public class PessoaJuridica : Clientes
    {
        public string cnpj { get; set; }
        public string ie { get; set;}

        public override void PagarImposto(float v)
        {
            valor = v;
            valorImposto = valor * 20/100;
            total = valor + valorImposto;
            
        }

    }
}