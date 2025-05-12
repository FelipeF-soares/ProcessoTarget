using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target.Models;
using System.Runtime.Serialization.Json;

namespace Target.Views;

public partial class UserControlExercicio4 : UserControl
{
    public UserControlExercicio4()
    {
        InitializeComponent();
    }
    private void UserControlExercicio4_Load(object sender, EventArgs e)
    {
        textBoxSP.Text = "67.836,43";
        textBoxRJ.Text = "36.678,66";
        textBoxMG.Text = "29.229,88";
        textBoxES.Text = "27.165,48";
        textBoxOutros.Text = "19.849,53";
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            decimal sp = decimal.Parse(textBoxSP.Text);
            decimal rj = decimal.Parse(textBoxRJ.Text);
            decimal mg = decimal.Parse(textBoxMG.Text);
            decimal es = decimal.Parse(textBoxES.Text);
            decimal outros = decimal.Parse(textBoxOutros.Text);
            Exercicio4 exercicio4 = new Exercicio4(sp, rj, mg, es, outros);
            var chaveValor = exercicio4.PorCem();
            labelPorCemSP.Text = chaveValor["sp"].ToString("F2")+"%";
            labelPorCemRJ.Text = chaveValor["rj"].ToString("F2")+"%";
            labelPorCemMG.Text = chaveValor["mg"].ToString("F2")+"%";
            labelPorCemES.Text = chaveValor["es"].ToString("F2")+"%";
            labelPorCemOutros.Text = chaveValor["outros"].ToString("F2")+"%";
            labelTotal.Text = chaveValor["total"].ToString("C2");
        }
        catch (FormatException)
        {
            MessageBox.Show(
                    "Ocorreu um erro ao processar sua solicitação. Valor Inserido inválido",
                    "Erro Valor inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        }
    }
}
