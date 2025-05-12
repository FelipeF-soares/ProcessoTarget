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

namespace Target.Views
{
    public partial class UserControlExercicio2 : UserControl
    {
        public UserControlExercicio2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string entradaString = textBox1.Text;
                int valorEntrada = int.Parse(entradaString);
                Exercicio2 exercicio2 = new Exercicio2(valorEntrada);
                string resposta = exercicio2.Resposta();
                labelResposta.Text = resposta;
            }
            catch(FormatException)
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
}
