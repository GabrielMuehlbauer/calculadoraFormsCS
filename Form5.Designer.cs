namespace calculadora
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label2 = new Label();
            cb1 = new ComboBox();
            tbxTemp1 = new TextBox();
            btnDelete = new PictureBox();
            btnCalcular = new PictureBox();
            tbxTemp2 = new TextBox();
            cb2 = new ComboBox();
            btnMenu = new PictureBox();
            pbSeta = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCalcular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSeta).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sauce Sans", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(39, 105);
            label2.Name = "label2";
            label2.Size = new Size(470, 42);
            label2.TabIndex = 4;
            label2.Text = "Conversor de Temperatura";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cb1
            // 
            cb1.BackColor = Color.Teal;
            cb1.Font = new Font("Open Sauce Sans", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb1.ForeColor = Color.White;
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin" });
            cb1.Location = new Point(84, 268);
            cb1.Name = "cb1";
            cb1.Size = new Size(141, 33);
            cb1.TabIndex = 5;
            // 
            // tbxTemp1
            // 
            tbxTemp1.Font = new Font("Open Sauce Sans SemiBold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxTemp1.Location = new Point(84, 211);
            tbxTemp1.Name = "tbxTemp1";
            tbxTemp1.Size = new Size(141, 51);
            tbxTemp1.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(192, 425);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(52, 50);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabIndex = 32;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Image = Properties.Resources.calcular;
            btnCalcular.Location = new Point(247, 425);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(122, 50);
            btnCalcular.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCalcular.TabIndex = 31;
            btnCalcular.TabStop = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // tbxTemp2
            // 
            tbxTemp2.Font = new Font("Open Sauce Sans SemiBold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxTemp2.Location = new Point(317, 211);
            tbxTemp2.Name = "tbxTemp2";
            tbxTemp2.Size = new Size(141, 51);
            tbxTemp2.TabIndex = 34;
            // 
            // cb2
            // 
            cb2.BackColor = Color.Teal;
            cb2.Font = new Font("Open Sauce Sans", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb2.ForeColor = Color.White;
            cb2.FormattingEnabled = true;
            cb2.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin" });
            cb2.Location = new Point(317, 268);
            cb2.Name = "cb2";
            cb2.Size = new Size(141, 33);
            cb2.TabIndex = 33;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(12, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(53, 50);
            btnMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMenu.TabIndex = 35;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pbSeta
            // 
            pbSeta.Cursor = Cursors.Hand;
            pbSeta.Image = (Image)resources.GetObject("pbSeta.Image");
            pbSeta.Location = new Point(247, 233);
            pbSeta.Name = "pbSeta";
            pbSeta.Size = new Size(53, 50);
            pbSeta.SizeMode = PictureBoxSizeMode.CenterImage;
            pbSeta.TabIndex = 36;
            pbSeta.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(545, 548);
            Controls.Add(pbSeta);
            Controls.Add(btnMenu);
            Controls.Add(tbxTemp2);
            Controls.Add(cb2);
            Controls.Add(btnDelete);
            Controls.Add(btnCalcular);
            Controls.Add(tbxTemp1);
            Controls.Add(cb1);
            Controls.Add(label2);
            Name = "Form5";
            Text = "Conversor de Temperatura";
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCalcular).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSeta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cb1;
        private TextBox tbxTemp1;
        private PictureBox btnDelete;
        private PictureBox btnCalcular;
        private TextBox tbxTemp2;
        private ComboBox cb2;
        private PictureBox btnMenu;
        private PictureBox pbSeta;
    }
}