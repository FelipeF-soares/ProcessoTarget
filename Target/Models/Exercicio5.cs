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
        string invertida = string.Empty;

        for(int i = texto.Length -1; i>= 0; i--)
        {
            invertida += texto[i];
        }

        return invertida;
    }
}
