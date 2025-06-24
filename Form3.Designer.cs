namespace calculadora
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            txbPeso = new TextBox();
            txbAltura = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txbSituacao = new TextBox();
            label4 = new Label();
            txbIMC = new TextBox();
            btnMenu = new PictureBox();
            btnCalcular = new PictureBox();
            label5 = new Label();
            btnDelete = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCalcular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            SuspendLayout();
            // 
            // txbPeso
            // 
            txbPeso.Font = new Font("Open Sauce Sans Medium", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbPeso.ForeColor = Color.Teal;
            txbPeso.Location = new Point(30, 173);
            txbPeso.Name = "txbPeso";
            txbPeso.Size = new Size(143, 67);
            txbPeso.TabIndex = 0;
            // 
            // txbAltura
            // 
            txbAltura.Font = new Font("Open Sauce One Medium", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbAltura.ForeColor = Color.Teal;
            txbAltura.Location = new Point(30, 281);
            txbAltura.Name = "txbAltura";
            txbAltura.Size = new Size(143, 67);
            txbAltura.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sauce Sans", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(96, 81);
            label2.Name = "label2";
            label2.Size = new Size(326, 42);
            label2.TabIndex = 2;
            label2.Text = "Calcule o seu IMC";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sauce Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(30, 150);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 4;
            label1.Text = "Coloque o seu peso:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sauce Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(30, 258);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 5;
            label3.Text = "Coloque a sua altura:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbSituacao
            // 
            txbSituacao.BackColor = Color.LightCyan;
            txbSituacao.Font = new Font("Open Sauce Sans SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbSituacao.ForeColor = Color.Teal;
            txbSituacao.Location = new Point(30, 404);
            txbSituacao.Name = "txbSituacao";
            txbSituacao.ReadOnly = true;
            txbSituacao.Size = new Size(251, 41);
            txbSituacao.TabIndex = 6;
            txbSituacao.TextChanged += txbSituacao_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sauce Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(30, 370);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 7;
            label4.Text = "Situação:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbIMC
            // 
            txbIMC.BackColor = Color.SteelBlue;
            txbIMC.Font = new Font("Open Sauce Sans SemiBold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbIMC.ForeColor = Color.LightCyan;
            txbIMC.Location = new Point(287, 308);
            txbIMC.Name = "txbIMC";
            txbIMC.ReadOnly = true;
            txbIMC.Size = new Size(177, 67);
            txbIMC.TabIndex = 8;
            txbIMC.TextChanged += txbIMC_TextChanged_1;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(12, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(53, 50);
            btnMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMenu.TabIndex = 27;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Image = Properties.Resources.calcular;
            btnCalcular.Location = new Point(342, 395);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(122, 50);
            btnCalcular.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCalcular.TabIndex = 28;
            btnCalcular.TabStop = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Open Sauce Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(287, 285);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 29;
            label5.Text = "IMC:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(287, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(52, 50);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabIndex = 30;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(502, 495);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(btnCalcular);
            Controls.Add(btnMenu);
            Controls.Add(txbIMC);
            Controls.Add(label4);
            Controls.Add(txbSituacao);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txbAltura);
            Controls.Add(txbPeso);
            Name = "Form3";
            Text = "Calcular o IMC";
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCalcular).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbPeso;
        private TextBox txbAltura;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txbSituacao;
        private Label label4;
        private TextBox txbIMC;
        private PictureBox btnMenu;
        private PictureBox btnCalcular;
        private Label label5;
        private PictureBox btnDelete;
    }
}