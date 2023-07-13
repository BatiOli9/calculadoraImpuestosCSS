namespace calculadoraImpuestosCSS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            productosTB = new TextBox();
            envioTB = new TextBox();
            label3 = new Label();
            button1 = new Button();
            impuestosVer = new Label();
            totalVer = new Label();
            oficialVer = new Label();
            label5 = new Label();
            oficialTB = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("DM Sans", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(784, 30);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a la calculadora de Impuestos para envios internacionales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("DM Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(259, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingresa precio de los productos:";
            // 
            // productosTB
            // 
            productosTB.Location = new Point(277, 74);
            productosTB.Name = "productosTB";
            productosTB.Size = new Size(324, 23);
            productosTB.TabIndex = 2;
            // 
            // envioTB
            // 
            envioTB.Location = new Point(217, 129);
            envioTB.Name = "envioTB";
            envioTB.Size = new Size(384, 23);
            envioTB.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("DM Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(199, 21);
            label3.TabIndex = 3;
            label3.Text = "Ingresa precio del envio:";
            // 
            // button1
            // 
            button1.Font = new Font("DM Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(314, 224);
            button1.Name = "button1";
            button1.Size = new Size(173, 41);
            button1.TabIndex = 5;
            button1.Text = "Calcular Impuestos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // impuestosVer
            // 
            impuestosVer.AutoSize = true;
            impuestosVer.BackColor = Color.Transparent;
            impuestosVer.Font = new Font("DM Sans", 20F, FontStyle.Bold, GraphicsUnit.Point);
            impuestosVer.ForeColor = Color.White;
            impuestosVer.Location = new Point(9, 268);
            impuestosVer.Name = "impuestosVer";
            impuestosVer.Size = new Size(406, 35);
            impuestosVer.TabIndex = 6;
            impuestosVer.Text = "Los impuestos te van a costar:";
            // 
            // totalVer
            // 
            totalVer.AutoSize = true;
            totalVer.BackColor = Color.Transparent;
            totalVer.Font = new Font("DM Sans", 20F, FontStyle.Bold, GraphicsUnit.Point);
            totalVer.ForeColor = Color.White;
            totalVer.Location = new Point(12, 371);
            totalVer.Name = "totalVer";
            totalVer.Size = new Size(403, 35);
            totalVer.TabIndex = 7;
            totalVer.Text = "El costo total del haul va a ser:";
            // 
            // oficialVer
            // 
            oficialVer.AutoSize = true;
            oficialVer.BackColor = Color.Transparent;
            oficialVer.Font = new Font("DM Sans", 20F, FontStyle.Bold, GraphicsUnit.Point);
            oficialVer.ForeColor = Color.White;
            oficialVer.Location = new Point(12, 317);
            oficialVer.Name = "oficialVer";
            oficialVer.Size = new Size(364, 35);
            oficialVer.TabIndex = 8;
            oficialVer.Text = "Costo impuestos en pesos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("DM Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 420);
            label5.Name = "label5";
            label5.Size = new Size(436, 21);
            label5.TabIndex = 9;
            label5.Text = "Tene en cuenta que los impuestos se pagan en USD oficial";
            // 
            // oficialTB
            // 
            oficialTB.Location = new Point(206, 181);
            oficialTB.Name = "oficialTB";
            oficialTB.Size = new Size(395, 23);
            oficialTB.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("DM Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 183);
            label6.Name = "label6";
            label6.Size = new Size(188, 21);
            label6.TabIndex = 10;
            label6.Text = "Cotizacion USD Oficial:";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(oficialTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(oficialVer);
            Controls.Add(totalVer);
            Controls.Add(impuestosVer);
            Controls.Add(button1);
            Controls.Add(envioTB);
            Controls.Add(label3);
            Controls.Add(productosTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora Impuestos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox productosTB;
        private TextBox envioTB;
        private Label label3;
        private Button button1;
        private Label impuestosVer;
        private Label totalVer;
        private Label oficialVer;
        private Label label5;
        private TextBox oficialTB;
        private Label label6;
    }
}