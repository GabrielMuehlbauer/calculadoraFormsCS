namespace calculadora
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label2 = new Label();
            label1 = new Label();
            btnCalculadoraPrincipal = new PictureBox();
            btnIMC = new PictureBox();
            btnRegraDeTres = new PictureBox();
            btnTemperatura = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnCalculadoraPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnIMC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRegraDeTres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTemperatura).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sauce Sans", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(58, 80);
            label2.Name = "label2";
            label2.Size = new Size(294, 42);
            label2.TabIndex = 2;
            label2.Text = "Seja Bem Vindo!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sauce Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(39, 122);
            label1.Name = "label1";
            label1.Size = new Size(336, 24);
            label1.TabIndex = 3;
            label1.Text = "este é o meu programa de cálculos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculadoraPrincipal
            // 
            btnCalculadoraPrincipal.Cursor = Cursors.Hand;
            btnCalculadoraPrincipal.Image = (Image)resources.GetObject("btnCalculadoraPrincipal.Image");
            btnCalculadoraPrincipal.Location = new Point(79, 183);
            btnCalculadoraPrincipal.Name = "btnCalculadoraPrincipal";
            btnCalculadoraPrincipal.Size = new Size(254, 50);
            btnCalculadoraPrincipal.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCalculadoraPrincipal.TabIndex = 27;
            btnCalculadoraPrincipal.TabStop = false;
            btnCalculadoraPrincipal.Click += btnCalculadoraPrincipal_Click;
            // 
            // btnIMC
            // 
            btnIMC.Cursor = Cursors.Hand;
            btnIMC.Image = (Image)resources.GetObject("btnIMC.Image");
            btnIMC.Location = new Point(79, 239);
            btnIMC.Name = "btnIMC";
            btnIMC.Size = new Size(254, 50);
            btnIMC.SizeMode = PictureBoxSizeMode.CenterImage;
            btnIMC.TabIndex = 28;
            btnIMC.TabStop = false;
            btnIMC.Click += btnIMC_Click;
            // 
            // btnRegraDeTres
            // 
            btnRegraDeTres.Cursor = Cursors.Hand;
            btnRegraDeTres.Image = (Image)resources.GetObject("btnRegraDeTres.Image");
            btnRegraDeTres.Location = new Point(79, 295);
            btnRegraDeTres.Name = "btnRegraDeTres";
            btnRegraDeTres.Size = new Size(254, 50);
            btnRegraDeTres.SizeMode = PictureBoxSizeMode.CenterImage;
            btnRegraDeTres.TabIndex = 29;
            btnRegraDeTres.TabStop = false;
            btnRegraDeTres.Click += btnRegraDeTres_Click;
            // 
            // btnTemperatura
            // 
            btnTemperatura.Cursor = Cursors.Hand;
            btnTemperatura.Image = (Image)resources.GetObject("btnTemperatura.Image");
            btnTemperatura.Location = new Point(79, 351);
            btnTemperatura.Name = "btnTemperatura";
            btnTemperatura.Size = new Size(254, 50);
            btnTemperatura.SizeMode = PictureBoxSizeMode.CenterImage;
            btnTemperatura.TabIndex = 30;
            btnTemperatura.TabStop = false;
            btnTemperatura.Click += btnTemperatura_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sauce Sans", 10F);
            label3.ForeColor = Color.LightCyan;
            label3.Location = new Point(118, 471);
            label3.Name = "label3";
            label3.Size = new Size(172, 17);
            label3.TabIndex = 31;
            label3.Text = "um programa criado por";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sauce Sans Medium", 15F, FontStyle.Bold);
            label4.ForeColor = Color.LightCyan;
            label4.Location = new Point(91, 488);
            label4.Name = "label4";
            label4.Size = new Size(227, 25);
            label4.TabIndex = 32;
            label4.Text = "Gabriel Müehlbauer";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 43, 43);
            ClientSize = new Size(401, 642);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnTemperatura);
            Controls.Add(btnRegraDeTres);
            Controls.Add(btnIMC);
            Controls.Add(btnCalculadoraPrincipal);
            Controls.Add(label1);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Menu do Programa de Gabriel";
            ((System.ComponentModel.ISupportInitialize)btnCalculadoraPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnIMC).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRegraDeTres).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTemperatura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox btnCalculadoraPrincipal;
        private PictureBox btnIMC;
        private PictureBox btnRegraDeTres;
        private PictureBox btnTemperatura;
        private Label label3;
        private Label label4;
    }
}