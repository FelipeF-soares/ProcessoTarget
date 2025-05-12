using System.Windows.Forms;
using Target.Views;

namespace Target
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void AdicionarTapPages(string name, string text, UserControl userControl)
        {
            TabPage tabPage = new TabPage();
            userControl.Dock = DockStyle.Fill;
            tabPage.Name = name;
            tabPage.Text = text;
            tabPage.Controls.Add(userControl);
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectTab(tabPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageExercicio1";
            string text = "Exercicio 1";
            UserControlExercicio1 userControlExercicio1 = new UserControlExercicio1();
            AdicionarTapPages(name, text, userControlExercicio1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageExercicio2";
            string text = "Exercicio 2";
            UserControlExercicio2 userControlExercicio2 = new UserControlExercicio2();
            AdicionarTapPages(name, text, userControlExercicio2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageExercicio3";
            string text = "Exercicio 3";
            UserControlExercicio3 userControlExercicio3 = new UserControlExercicio3();
            AdicionarTapPages(name, text, userControlExercicio3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageExercicio4";
            string text = "Exercicio 4";
            UserControlExercicio4 userControlExercicio4 = new UserControlExercicio4();
            AdicionarTapPages(name, text, userControlExercicio4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageExercicio5";
            string text = "Exercicio 5";
            UserControlExercicio5 userControlExercicio5 = new UserControlExercicio5();
            AdicionarTapPages(name, text, userControlExercicio5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
