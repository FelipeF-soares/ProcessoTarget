using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target.Util;

namespace Target.Models;

class Exercicio3
{
    private Faturamento[] dados;
    public Exercicio3(Faturamento[] dados)
    {
        this.dados = dados;
    }
    public List<Faturamento> MenorFaturamento()
    {
        List<Faturamento> menor = new List<Faturamento>();
        decimal menorValor = dados.Min(valor => valor.Valor);
        menor = dados.Where(faturamento => faturamento.Valor == menorValor).ToList();
      
        return menor;
    }
    public List<Faturamento> MaiorFaturamento()
    {
        List<Faturamento> maior = new List<Faturamento>();
        decimal maiorValor = dados.Max(valor => valor.Valor);
        maior = dados.Where(faturamento => faturamento.Valor == maiorValor).ToList();

        return maior;
    }
    public List<Faturamento> MediaSuperioFaturamento()
    {
        List<Faturamento> acimaDaMedia = new List<Faturamento>();
        decimal media = dados.Average(valor => valor.Valor);
        acimaDaMedia = dados.Where(faturamento => faturamento.Valor > media).ToList();
        return acimaDaMedia;
    }
}
