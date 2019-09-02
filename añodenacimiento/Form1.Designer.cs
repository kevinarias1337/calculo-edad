namespace añodenacimiento
{
    partial class programa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblañonacimiento = new System.Windows.Forms.Label();
            this.añonacimientotxt = new System.Windows.Forms.TextBox();
            this.añoactualtxt = new System.Windows.Forms.TextBox();
            this.lblañoactual = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(209, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa para calcular la edad.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "________________________________________________________";
            // 
            // lblañonacimiento
            // 
            this.lblañonacimiento.AutoSize = true;
            this.lblañonacimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblañonacimiento.Location = new System.Drawing.Point(225, 109);
            this.lblañonacimiento.Name = "lblañonacimiento";
            this.lblañonacimiento.Size = new System.Drawing.Size(215, 18);
            this.lblañonacimiento.TabIndex = 2;
            this.lblañonacimiento.Text = "Ingrese su año de nacimiento:";
            // 
            // añonacimientotxt
            // 
            this.añonacimientotxt.Location = new System.Drawing.Point(446, 110);
            this.añonacimientotxt.Name = "añonacimientotxt";
            this.añonacimientotxt.Size = new System.Drawing.Size(66, 20);
            this.añonacimientotxt.TabIndex = 3;
            // 
            // añoactualtxt
            // 
            this.añoactualtxt.Location = new System.Drawing.Point(446, 151);
            this.añoactualtxt.Name = "añoactualtxt";
            this.añoactualtxt.Size = new System.Drawing.Size(66, 20);
            this.añoactualtxt.TabIndex = 4;
            // 
            // lblañoactual
            // 
            this.lblañoactual.AutoSize = true;
            this.lblañoactual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblañoactual.Location = new System.Drawing.Point(286, 151);
            this.lblañoactual.Name = "lblañoactual";
            this.lblañoactual.Size = new System.Drawing.Size(154, 18);
            this.lblañoactual.TabIndex = 5;
            this.lblañoactual.Text = "Ingrese el año actúal:";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(518, 128);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(63, 24);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::añodenacimiento.Properties.Resources.tool_113298;
            this.pictureBox1.Location = new System.Drawing.Point(756, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 222);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblañoactual);
            this.Controls.Add(this.añoactualtxt);
            this.Controls.Add(this.añonacimientotxt);
            this.Controls.Add(this.lblañonacimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "programa";
            this.Text = "Calculo de edad";
            this.Load += new System.EventHandler(this.Programa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblañonacimiento;
        private System.Windows.Forms.TextBox añonacimientotxt;
        private System.Windows.Forms.TextBox añoactualtxt;
        private System.Windows.Forms.Label lblañoactual;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

