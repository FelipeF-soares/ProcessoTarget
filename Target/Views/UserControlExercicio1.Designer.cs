namespace Target.Views
{
    partial class UserControlExercicio1
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            valorDeIndice = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            valorDeSoma = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(133, 257);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Indice:";
            // 
            // valorDeIndice
            // 
            valorDeIndice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            valorDeIndice.AutoSize = true;
            valorDeIndice.Location = new Point(197, 257);
            valorDeIndice.Name = "valorDeIndice";
            valorDeIndice.Size = new Size(0, 15);
            valorDeIndice.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(154, 23);
            label2.Name = "label2";
            label2.Size = new Size(244, 15);
            label2.TabIndex = 2;
            label2.Text = "Cálculo de Soma com Estrutura de Repetição";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.ex1;
            pictureBox1.Location = new Point(179, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 283);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Soma:";
            label3.Click += label3_Click;
            // 
            // valorDeSoma
            // 
            valorDeSoma.AutoSize = true;
            valorDeSoma.Location = new Point(179, 283);
            valorDeSoma.Name = "valorDeSoma";
            valorDeSoma.Size = new Size(13, 15);
            valorDeSoma.TabIndex = 5;
            valorDeSoma.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(302, 312);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserControlExercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(valorDeSoma);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(valorDeIndice);
            Controls.Add(label1);
            Name = "UserControlExercicio1";
            Size = new Size(648, 404);
            Load += UserControlExercicio1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label valorDeIndice;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label valorDeSoma;
        private Button button1;
    }
}
