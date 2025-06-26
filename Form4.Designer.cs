namespace calculadora
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label2 = new Label();
            txbValor1 = new TextBox();
            txbValor2 = new TextBox();
            txbValor3 = new TextBox();
            txbValorX = new TextBox();
            btnCalcular = new PictureBox();
            btnDelete = new PictureBox();
            btnMenu = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnCalcular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sauce Sans", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(179, 45);
            label2.Name = "label2";
            label2.Size = new Size(253, 42);
            label2.TabIndex = 3;
            label2.Text = "Regra de Três";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbValor1
            // 
            txbValor1.Font = new Font("Open Sauce Sans Medium", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbValor1.ForeColor = Color.Teal;
            txbValor1.Location = new Point(147, 132);
            txbValor1.Name = "txbValor1";
            txbValor1.Size = new Size(143, 67);
            txbValor1.TabIndex = 4;
            // 
            // txbValor2
            // 
            txbValor2.Font = new Font("Open Sauce Sans Medium", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbValor2.ForeColor = Color.Teal;
            txbValor2.Location = new Point(307, 132);
            txbValor2.Name = "txbValor2";
            txbValor2.Size = new Size(143, 67);
            txbValor2.TabIndex = 5;
            // 
            // txbValor3
            // 
            txbValor3.Font = new Font("Open Sauce Sans Medium", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbValor3.ForeColor = Color.Teal;
            txbValor3.Location = new Point(147, 243);
            txbValor3.Name = "txbValor3";
            txbValor3.Size = new Size(143, 67);
            txbValor3.TabIndex = 6;
            // 
            // txbValorX
            // 
            txbValorX.BackColor = Color.Teal;
            txbValorX.Font = new Font("Open Sauce Sans Medium", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbValorX.ForeColor = Color.LightCyan;
            txbValorX.Location = new Point(307, 243);
            txbValorX.Name = "txbValorX";
            txbValorX.ReadOnly = true;
            txbValorX.Size = new Size(143, 67);
            txbValorX.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Image = Properties.Resources.calcular;
            btnCalcular.Location = new Point(204, 344);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(122, 50);
            btnCalcular.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCalcular.TabIndex = 29;
            btnCalcular.TabStop = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(332, 344);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(52, 50);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabIndex = 31;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(12, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(53, 50);
            btnMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMenu.TabIndex = 32;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sauce Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(147, 220);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 33;
            label3.Text = "Valor 3:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sauce Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(147, 109);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 34;
            label1.Text = "Valor 1:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sauce Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(307, 109);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 35;
            label4.Text = "Valor 2:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Open Sauce Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(307, 220);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 36;
            label5.Text = "Valor x:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(598, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnMenu);
            Controls.Add(btnDelete);
            Controls.Add(btnCalcular);
            Controls.Add(txbValorX);
            Controls.Add(txbValor3);
            Controls.Add(txbValor2);
            Controls.Add(txbValor1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Regra de Três";
            ((System.ComponentModel.ISupportInitialize)btnCalcular).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txbValor1;
        private TextBox txbValor2;
        private TextBox txbValor3;
        private TextBox txbValorX;
        private PictureBox btnCalcular;
        private PictureBox btnDelete;
        private PictureBox btnMenu;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}