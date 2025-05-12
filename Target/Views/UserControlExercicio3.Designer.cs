namespace Target.Views
{
    partial class UserControlExercicio3
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
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            dataGridViewMenor = new DataGridView();
            label4 = new Label();
            dataGridViewMaior = new DataGridView();
            label5 = new Label();
            dataGridViewDiasAcimaDaMedia = new DataGridView();
            labelDias = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiasAcimaDaMedia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 20);
            label1.Name = "label1";
            label1.Size = new Size(250, 21);
            label1.TabIndex = 0;
            label1.Text = "Análise de Faturamento Mensal";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(346, 67);
            button1.Name = "button1";
            button1.Size = new Size(149, 23);
            button1.TabIndex = 1;
            button1.Text = "Selecionar JSON";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(287, 107);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 2;
            label2.Text = "...";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Enabled = false;
            button2.Location = new Point(346, 158);
            button2.Name = "button2";
            button2.Size = new Size(149, 23);
            button2.TabIndex = 3;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(62, 194);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 4;
            label3.Text = "Menore(s) Faturamento:";
            // 
            // dataGridViewMenor
            // 
            dataGridViewMenor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMenor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenor.Location = new Point(62, 212);
            dataGridViewMenor.Name = "dataGridViewMenor";
            dataGridViewMenor.Size = new Size(220, 211);
            dataGridViewMenor.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(318, 194);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 6;
            label4.Text = "Maiore(s) Faturamentos:";
            // 
            // dataGridViewMaior
            // 
            dataGridViewMaior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMaior.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaior.Location = new Point(304, 212);
            dataGridViewMaior.Name = "dataGridViewMaior";
            dataGridViewMaior.Size = new Size(220, 211);
            dataGridViewMaior.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(548, 179);
            label5.Name = "label5";
            label5.Size = new Size(204, 30);
            label5.TabIndex = 8;
            label5.Text = "Quantidade de dias com\r\nfaturamento acima da média mensal:";
            // 
            // dataGridViewDiasAcimaDaMedia
            // 
            dataGridViewDiasAcimaDaMedia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDiasAcimaDaMedia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDiasAcimaDaMedia.Location = new Point(548, 212);
            dataGridViewDiasAcimaDaMedia.Name = "dataGridViewDiasAcimaDaMedia";
            dataGridViewDiasAcimaDaMedia.Size = new Size(220, 211);
            dataGridViewDiasAcimaDaMedia.TabIndex = 9;
            // 
            // labelDias
            // 
            labelDias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDias.AutoSize = true;
            labelDias.Location = new Point(752, 194);
            labelDias.Name = "labelDias";
            labelDias.Size = new Size(16, 15);
            labelDias.TabIndex = 10;
            labelDias.Text = "...";
            // 
            // UserControlExercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelDias);
            Controls.Add(dataGridViewDiasAcimaDaMedia);
            Controls.Add(label5);
            Controls.Add(dataGridViewMaior);
            Controls.Add(label4);
            Controls.Add(dataGridViewMenor);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "UserControlExercicio3";
            Size = new Size(906, 459);
            Load += UserControlExercicio3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaior).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiasAcimaDaMedia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label3;
        private DataGridView dataGridViewMenor;
        private Label label4;
        private DataGridView dataGridViewMaior;
        private Label label5;
        private DataGridView dataGridViewDiasAcimaDaMedia;
        private Label labelDias;
    }
}
