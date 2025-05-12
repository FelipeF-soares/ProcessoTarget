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
    public partial class UserControlExercicio5 : UserControl
    {
        public UserControlExercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            Exercicio5 exercicio5 = new Exercicio5(texto);
            label3.Text = exercicio5.Inverte().ToLower();
        }

        private void UserControlExercicio5_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Processo Seletivo - Target Sistemas";
        }
    }
}
