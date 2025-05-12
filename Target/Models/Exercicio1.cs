using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target.Models;

class Exercicio1
{
    public readonly int indice = 13;
    private int k = 0;
    private int soma = 0;

    public int Indice
    {
        get
        {
            return indice;
        }
    }

    public int CalcularSoma()
    {
        while(k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }
        return soma;
    }
}
