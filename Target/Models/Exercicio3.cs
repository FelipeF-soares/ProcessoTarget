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
        decimal menorValorMaiorQueZero = dados.Where(valor => valor.Valor > 0m).Min(valor => valor.Valor);
        menor = dados.Where(faturamento => faturamento.Valor == menorValorMaiorQueZero).ToList();
      
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
        decimal mediaMaiorQueZero = dados.Where(v => v.Valor > 0m).Average(v => v.Valor);
        acimaDaMedia = dados.Where(faturamento => faturamento.Valor > mediaMaiorQueZero).ToList();
        return acimaDaMedia;
    }
}
