using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Target.Models;

class Exercicio4
{
    private decimal sp;
    private decimal rj;
    private decimal mg;
    private decimal es;
    private decimal outros;
    public Exercicio4(decimal sp,decimal rj,decimal mg,decimal es, decimal outros)
    {
        this.sp = sp;
        this.rj = rj;
        this.mg = mg;
        this.es = es;
        this.outros = outros;
    }

    public Dictionary<string,decimal> PorCem()
    {
        Dictionary<string, decimal> porCemEstado = new Dictionary<string, decimal>();
        decimal[] estados = { sp, rj, mg, es, outros };
        decimal soma = estados.Sum();
        porCemEstado.Add("sp", ((sp*100)/soma));
        porCemEstado.Add("rj", ((rj*100)/soma));
        porCemEstado.Add("mg", ((mg*100)/soma));
        porCemEstado.Add("es", ((es*100)/soma));
        porCemEstado.Add("outros", ((outros*100)/soma));
        porCemEstado.Add("total", soma);

        return porCemEstado;
    }
}
