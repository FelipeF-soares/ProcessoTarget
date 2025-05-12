using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target.Util;

class LeituraJson
{
    string path;
    public LeituraJson(string path)
    {
        this.path = path;
    }

    public Faturamento[] ArrayFaturamento()
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException("Arquivo Não Encontrado");
        }
        string faturamentoEmJson = File.ReadAllText(path);
        var faturamentos = JsonConvert.DeserializeObject<Faturamento[]>(faturamentoEmJson);
        return faturamentos;
    }
}
