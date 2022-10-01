namespace programa4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblMultiplicacion = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "primer numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "segundo numero";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(365, 63);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(250, 47);
            this.txtnum1.TabIndex = 2;
            this.txtnum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum1_KeyPress);
            this.txtnum1.Validating += new System.ComponentModel.CancelEventHandler(this.txtnum1_Validating);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(365, 150);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(250, 47);
            this.txtnum2.TabIndex = 3;
            this.txtnum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum1_KeyPress);
            this.txtnum2.Validating += new System.ComponentModel.CancelEventHandler(this.txtnum1_Validating);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(928, 112);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(188, 58);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "calcular";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "suma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "multiplicaion";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(36, 491);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(97, 41);
            this.lblSuma.TabIndex = 7;
            this.lblSuma.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(960, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 41);
            this.label6.TabIndex = 8;
            this.label6.Text = "division";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 41);
            this.label7.TabIndex = 9;
            this.label7.Text = "resta";
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Location = new System.Drawing.Point(325, 491);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(97, 41);
            this.lblResta.TabIndex = 10;
            this.lblResta.Text = "label8";
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.Location = new System.Drawing.Point(699, 491);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(97, 41);
            this.lblMultiplicacion.TabIndex = 11;
            this.lblMultiplicacion.Text = "label9";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(960, 491);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(113, 41);
            this.lblDivision.TabIndex = 12;
            this.lblDivision.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 790);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblMultiplicacion);
            this.Controls.Add(this.lblResta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnum1;
        private TextBox txtnum2;
        private Button btnIngresar;
        private Label label3;
        private Label label4;
        private Label lblSuma;
        private Label label6;
        private Label label7;
        private Label lblResta;
        private Label lblMultiplicacion;
        private Label lblDivision;
    }
}