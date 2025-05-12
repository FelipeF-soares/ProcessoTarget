namespace Target.Views
{
    partial class UserControlExercicio4
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
            label2 = new Label();
            label3 = new Label();
            textBoxSP = new TextBox();
            textBoxRJ = new TextBox();
            textBoxMG = new TextBox();
            textBoxES = new TextBox();
            textBoxOutros = new TextBox();
            button1 = new Button();
            labelPorCemSP = new Label();
            labelPorCemRJ = new Label();
            labelPorCemMG = new Label();
            labelPorCemES = new Label();
            labelPorCemOutros = new Label();
            labelTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 112);
            label1.Name = "label1";
            label1.Size = new Size(126, 180);
            label1.TabIndex = 0;
            label1.Text = "SP - R$\r\nRJ - R$\r\nMG - R$\r\nES - R$\r\nOutros - R$\r\nTotal - ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(313, 29);
            label2.Name = "label2";
            label2.Size = new Size(327, 21);
            label2.TabIndex = 1;
            label2.Text = "Cálculo de Representatividade por Estado";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(237, 69);
            label3.Name = "label3";
            label3.Size = new Size(501, 15);
            label3.TabIndex = 2;
            label3.Text = "Calcular o percentual de participação de cada estado no faturamento mensal da distribuidora:";
            // 
            // textBoxSP
            // 
            textBoxSP.Location = new Point(157, 118);
            textBoxSP.Name = "textBoxSP";
            textBoxSP.Size = new Size(137, 23);
            textBoxSP.TabIndex = 3;
            // 
            // textBoxRJ
            // 
            textBoxRJ.Location = new Point(157, 147);
            textBoxRJ.Name = "textBoxRJ";
            textBoxRJ.Size = new Size(137, 23);
            textBoxRJ.TabIndex = 4;
            // 
            // textBoxMG
            // 
            textBoxMG.Location = new Point(157, 176);
            textBoxMG.Name = "textBoxMG";
            textBoxMG.Size = new Size(137, 23);
            textBoxMG.TabIndex = 5;
            // 
            // textBoxES
            // 
            textBoxES.Location = new Point(157, 205);
            textBoxES.Name = "textBoxES";
            textBoxES.Size = new Size(137, 23);
            textBoxES.TabIndex = 6;
            // 
            // textBoxOutros
            // 
            textBoxOutros.Location = new Point(187, 234);
            textBoxOutros.Name = "textBoxOutros";
            textBoxOutros.Size = new Size(137, 23);
            textBoxOutros.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(55, 297);
            button1.Name = "button1";
            button1.Size = new Size(269, 23);
            button1.TabIndex = 8;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelPorCemSP
            // 
            labelPorCemSP.AutoSize = true;
            labelPorCemSP.Location = new Point(313, 124);
            labelPorCemSP.Name = "labelPorCemSP";
            labelPorCemSP.Size = new Size(16, 15);
            labelPorCemSP.TabIndex = 9;
            labelPorCemSP.Text = "...";
            // 
            // labelPorCemRJ
            // 
            labelPorCemRJ.AutoSize = true;
            labelPorCemRJ.Location = new Point(313, 150);
            labelPorCemRJ.Name = "labelPorCemRJ";
            labelPorCemRJ.Size = new Size(16, 15);
            labelPorCemRJ.TabIndex = 10;
            labelPorCemRJ.Text = "...";
            // 
            // labelPorCemMG
            // 
            labelPorCemMG.AutoSize = true;
            labelPorCemMG.Location = new Point(313, 179);
            labelPorCemMG.Name = "labelPorCemMG";
            labelPorCemMG.Size = new Size(16, 15);
            labelPorCemMG.TabIndex = 11;
            labelPorCemMG.Text = "...";
            // 
            // labelPorCemES
            // 
            labelPorCemES.AutoSize = true;
            labelPorCemES.Location = new Point(313, 208);
            labelPorCemES.Name = "labelPorCemES";
            labelPorCemES.Size = new Size(16, 15);
            labelPorCemES.TabIndex = 12;
            labelPorCemES.Text = "...";
            // 
            // labelPorCemOutros
            // 
            labelPorCemOutros.AutoSize = true;
            labelPorCemOutros.Location = new Point(344, 242);
            labelPorCemOutros.Name = "labelPorCemOutros";
            labelPorCemOutros.Size = new Size(16, 15);
            labelPorCemOutros.TabIndex = 13;
            labelPorCemOutros.Text = "...";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = Color.FromArgb(0, 192, 0);
            labelTotal.Location = new Point(145, 272);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(22, 21);
            labelTotal.TabIndex = 14;
            labelTotal.Text = "...";
            // 
            // UserControlExercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTotal);
            Controls.Add(labelPorCemOutros);
            Controls.Add(labelPorCemES);
            Controls.Add(labelPorCemMG);
            Controls.Add(labelPorCemRJ);
            Controls.Add(labelPorCemSP);
            Controls.Add(button1);
            Controls.Add(textBoxOutros);
            Controls.Add(textBoxES);
            Controls.Add(textBoxMG);
            Controls.Add(textBoxRJ);
            Controls.Add(textBoxSP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlExercicio4";
            Size = new Size(906, 459);
            Load += UserControlExercicio4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxSP;
        private TextBox textBoxRJ;
        private TextBox textBoxMG;
        private TextBox textBoxES;
        private TextBox textBoxOutros;
        private Button button1;
        private Label labelPorCemSP;
        private Label labelPorCemRJ;
        private Label labelPorCemMG;
        private Label labelPorCemES;
        private Label labelPorCemOutros;
        private Label labelTotal;
    }
}
