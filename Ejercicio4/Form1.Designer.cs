namespace Ejercicio4
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
            this.txtMatrizEntrada = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMatrizQ = new System.Windows.Forms.TextBox();
            this.txtMatrizR = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMatrizEntrada
            // 
            this.txtMatrizEntrada.BackColor = System.Drawing.SystemColors.Info;
            this.txtMatrizEntrada.Location = new System.Drawing.Point(354, 71);
            this.txtMatrizEntrada.Multiline = true;
            this.txtMatrizEntrada.Name = "txtMatrizEntrada";
            this.txtMatrizEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatrizEntrada.Size = new System.Drawing.Size(444, 162);
            this.txtMatrizEntrada.TabIndex = 0;
            this.txtMatrizEntrada.Text = " ";
            this.txtMatrizEntrada.TextChanged += new System.EventHandler(this.txtMatrizEntrada_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(832, 95);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 33);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // txtMatrizQ
            // 
            this.txtMatrizQ.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMatrizQ.Location = new System.Drawing.Point(354, 300);
            this.txtMatrizQ.Multiline = true;
            this.txtMatrizQ.Name = "txtMatrizQ";
            this.txtMatrizQ.ReadOnly = true;
            this.txtMatrizQ.Size = new System.Drawing.Size(186, 174);
            this.txtMatrizQ.TabIndex = 2;
            this.txtMatrizQ.TextChanged += new System.EventHandler(this.txtMatrizQ_TextChanged);
            // 
            // txtMatrizR
            // 
            this.txtMatrizR.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtMatrizR.Location = new System.Drawing.Point(620, 300);
            this.txtMatrizR.Multiline = true;
            this.txtMatrizR.Name = "txtMatrizR";
            this.txtMatrizR.ReadOnly = true;
            this.txtMatrizR.Size = new System.Drawing.Size(178, 174);
            this.txtMatrizR.TabIndex = 3;
            this.txtMatrizR.TextChanged += new System.EventHandler(this.txtMatrizR_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(832, 153);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 34);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(498, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "DESCOMPOSICION QR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(402, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "MATRIZ Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(670, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "MATRIZ R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 569);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtMatrizR);
            this.Controls.Add(this.txtMatrizQ);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMatrizEntrada);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatrizEntrada;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtMatrizQ;
        private System.Windows.Forms.TextBox txtMatrizR;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

