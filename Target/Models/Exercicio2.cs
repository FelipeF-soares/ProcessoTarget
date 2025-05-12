using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target.Models;

class Exercicio2
{
    private int valorEntrada;
    private int valorEntradaMaisQuatro;
    private int valorEntradaMenosQuatro;
    public Exercicio2(int valorEntrada)
    {
        this.valorEntrada = valorEntrada;
        valorEntradaMaisQuatro = (5 * valorEntrada * valorEntrada + 4);
        valorEntradaMenosQuatro = (5 * valorEntrada * valorEntrada - 4);
    }
    public int ValorEntrada 
    { 
        get { return valorEntrada; }
        set { valorEntrada = value;  }
    }

    private bool QuadradoPerfeito(int valorTeste)
    {
        int calculoRaiz = (int)Math.Sqrt(valorTeste);
        return calculoRaiz * calculoRaiz == valorTeste;
    }
    private bool EhFibonacci()
    {
        return QuadradoPerfeito(valorEntradaMaisQuatro) || QuadradoPerfeito(valorEntradaMenosQuatro);
    }

    public string Resposta()
    {
        if (EhFibonacci())
        {
            return $"{valorEntrada} pertence à sequência de Fibonacci.";
        }
        return $"{valorEntrada} não pertence à sequência de Fibonacci.";
    }

}
