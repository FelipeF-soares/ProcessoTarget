using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target.Models;

class Exercicio5
{
    private string texto;
    public Exercicio5(string texto)
    {
        this.texto = texto;
    }

    public string Inverte()
    {
        string invertida = new string(texto.Reverse().ToArray());
        return invertida;
    }
}
