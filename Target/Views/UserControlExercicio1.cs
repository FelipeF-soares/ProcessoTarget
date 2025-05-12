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
    public partial class UserControlExercicio1 : UserControl
    {
        Exercicio1 exercicio1 = new Exercicio1();
        public UserControlExercicio1()
        {
            InitializeComponent();
        }

        private void UserControlExercicio1_Load(object sender, EventArgs e)
        {
            
            valorDeIndice.Text = exercicio1.Indice.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           valorDeSoma.Text =  exercicio1.CalcularSoma().ToString();
        }
    }
}
