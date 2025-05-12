using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Target.Util;
using Target.Models;

namespace Target.Views;

public partial class UserControlExercicio3 : UserControl
{
    private OpenFileDialog openFileDialog;
    private string pathComNomeDoArquivo;
    public UserControlExercicio3()
    {
        InitializeComponent();
    }
    private void UserControlExercicio3_Load(object sender, EventArgs e)
    {
        openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Arquivos JSON (*.json)|*.json";
        openFileDialog.Title = "Selecione um arquivo JSON";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {

                string path = openFileDialog.FileName;
                string pathDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Arquivos/");

                if (!Directory.Exists(pathDestino))
                {
                    Directory.CreateDirectory(pathDestino);
                }

                string nomeArquivo = Path.GetFileName(path);
                string caminhoDestino = Path.Combine(pathDestino, nomeArquivo);
                pathComNomeDoArquivo = caminhoDestino;
                label2.Text = nomeArquivo;
                File.Copy(path, caminhoDestino, true);
                if (pathComNomeDoArquivo != null)
                {
                    button2.Enabled = true;
                }

                MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

    private void button2_Click(object sender, EventArgs e)
    {
        LeituraJson leituraJson = new LeituraJson(pathComNomeDoArquivo);
        var faturamentos = leituraJson.ArrayFaturamento();
        Exercicio3 exercicio3 = new Exercicio3(faturamentos);

        dataGridViewMenor.DataSource = exercicio3.MenorFaturamento().ToArray();
        dataGridViewMaior.DataSource = exercicio3.MaiorFaturamento().ToArray();
        dataGridViewDiasAcimaDaMedia.DataSource = exercicio3.MediaSuperioFaturamento().ToArray();
        var dias = exercicio3.MediaSuperioFaturamento().ToArray().Length;
        labelDias.Text = dias.ToString();

    }
}
