namespace EjemploPerceptronMultiCapa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEntrenar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBRojo = new System.Windows.Forms.TextBox();
            this.lbRojo = new System.Windows.Forms.Label();
            this.lbVerde = new System.Windows.Forms.Label();
            this.txtBVerde = new System.Windows.Forms.TextBox();
            this.LbAzul = new System.Windows.Forms.Label();
            this.txtBAzul = new System.Windows.Forms.TextBox();
            this.lbRespuestaPerceptron = new System.Windows.Forms.Label();
            this.btnReconococer = new System.Windows.Forms.Button();
            this.lbPerceptron = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrenar
            // 
            this.btnEntrenar.Location = new System.Drawing.Point(51, 33);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrenar.TabIndex = 0;
            this.btnEntrenar.Text = "Entrenar";
            this.btnEntrenar.UseVisualStyleBackColor = true;
            this.btnEntrenar.Click += new System.EventHandler(this.BtnEntrenar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 565);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // txtBRojo
            // 
            this.txtBRojo.Location = new System.Drawing.Point(12, 105);
            this.txtBRojo.Name = "txtBRojo";
            this.txtBRojo.Size = new System.Drawing.Size(100, 20);
            this.txtBRojo.TabIndex = 3;
            // 
            // lbRojo
            // 
            this.lbRojo.AutoSize = true;
            this.lbRojo.Location = new System.Drawing.Point(12, 86);
            this.lbRojo.Name = "lbRojo";
            this.lbRojo.Size = new System.Drawing.Size(127, 13);
            this.lbRojo.TabIndex = 4;
            this.lbRojo.Text = "Num. Hexadecimal Rojo: ";
            // 
            // lbVerde
            // 
            this.lbVerde.AutoSize = true;
            this.lbVerde.Location = new System.Drawing.Point(12, 128);
            this.lbVerde.Name = "lbVerde";
            this.lbVerde.Size = new System.Drawing.Size(133, 13);
            this.lbVerde.TabIndex = 6;
            this.lbVerde.Text = "Num. Hexadecimal Verde: ";
            // 
            // txtBVerde
            // 
            this.txtBVerde.Location = new System.Drawing.Point(12, 147);
            this.txtBVerde.Name = "txtBVerde";
            this.txtBVerde.Size = new System.Drawing.Size(100, 20);
            this.txtBVerde.TabIndex = 5;
            // 
            // LbAzul
            // 
            this.LbAzul.AutoSize = true;
            this.LbAzul.Location = new System.Drawing.Point(12, 170);
            this.LbAzul.Name = "LbAzul";
            this.LbAzul.Size = new System.Drawing.Size(125, 13);
            this.LbAzul.TabIndex = 8;
            this.LbAzul.Text = "Num. Hexadecimal Azul: ";
            // 
            // txtBAzul
            // 
            this.txtBAzul.Location = new System.Drawing.Point(12, 189);
            this.txtBAzul.Name = "txtBAzul";
            this.txtBAzul.Size = new System.Drawing.Size(100, 20);
            this.txtBAzul.TabIndex = 7;
            // 
            // lbRespuestaPerceptron
            // 
            this.lbRespuestaPerceptron.AutoSize = true;
            this.lbRespuestaPerceptron.Location = new System.Drawing.Point(12, 238);
            this.lbRespuestaPerceptron.Name = "lbRespuestaPerceptron";
            this.lbRespuestaPerceptron.Size = new System.Drawing.Size(0, 13);
            this.lbRespuestaPerceptron.TabIndex = 9;
            // 
            // btnReconococer
            // 
            this.btnReconococer.Location = new System.Drawing.Point(187, 36);
            this.btnReconococer.Name = "btnReconococer";
            this.btnReconococer.Size = new System.Drawing.Size(75, 23);
            this.btnReconococer.TabIndex = 11;
            this.btnReconococer.Text = "Reconocerr";
            this.btnReconococer.UseVisualStyleBackColor = true;
            this.btnReconococer.Click += new System.EventHandler(this.BtnReconococer_Click);
            // 
            // lbPerceptron
            // 
            this.lbPerceptron.AutoSize = true;
            this.lbPerceptron.Location = new System.Drawing.Point(18, 238);
            this.lbPerceptron.Name = "lbPerceptron";
            this.lbPerceptron.Size = new System.Drawing.Size(10, 13);
            this.lbPerceptron.TabIndex = 12;
            this.lbPerceptron.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 579);
            this.Controls.Add(this.lbPerceptron);
            this.Controls.Add(this.btnReconococer);
            this.Controls.Add(this.lbRespuestaPerceptron);
            this.Controls.Add(this.LbAzul);
            this.Controls.Add(this.txtBAzul);
            this.Controls.Add(this.lbVerde);
            this.Controls.Add(this.txtBVerde);
            this.Controls.Add(this.lbRojo);
            this.Controls.Add(this.txtBRojo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEntrenar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrenar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBRojo;
        private System.Windows.Forms.Label lbRojo;
        private System.Windows.Forms.Label lbVerde;
        private System.Windows.Forms.TextBox txtBVerde;
        private System.Windows.Forms.Label LbAzul;
        private System.Windows.Forms.TextBox txtBAzul;
        private System.Windows.Forms.Label lbRespuestaPerceptron;
        private System.Windows.Forms.Button btnReconococer;
        private System.Windows.Forms.Label lbPerceptron;
    }
}

