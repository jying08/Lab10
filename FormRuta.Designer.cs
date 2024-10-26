namespace Lab10
{
    partial class FormRuta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbOrigen = new System.Windows.Forms.TextBox();
            this.txbDestino = new System.Windows.Forms.TextBox();
            this.txbKilometros = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgRutas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kilómetros";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(136, 38);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(100, 20);
            this.txbCodigo.TabIndex = 4;
            // 
            // txbOrigen
            // 
            this.txbOrigen.Location = new System.Drawing.Point(136, 65);
            this.txbOrigen.Name = "txbOrigen";
            this.txbOrigen.Size = new System.Drawing.Size(100, 20);
            this.txbOrigen.TabIndex = 5;
            // 
            // txbDestino
            // 
            this.txbDestino.Location = new System.Drawing.Point(136, 95);
            this.txbDestino.Name = "txbDestino";
            this.txbDestino.Size = new System.Drawing.Size(100, 20);
            this.txbDestino.TabIndex = 6;
            // 
            // txbKilometros
            // 
            this.txbKilometros.Location = new System.Drawing.Point(136, 121);
            this.txbKilometros.Name = "txbKilometros";
            this.txbKilometros.Size = new System.Drawing.Size(100, 20);
            this.txbKilometros.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(148, 192);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(148, 221);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgRutas
            // 
            this.dgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRutas.Location = new System.Drawing.Point(335, 38);
            this.dgRutas.Name = "dgRutas";
            this.dgRutas.Size = new System.Drawing.Size(298, 223);
            this.dgRutas.TabIndex = 10;
            // 
            // FormRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 331);
            this.Controls.Add(this.dgRutas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txbKilometros);
            this.Controls.Add(this.txbDestino);
            this.Controls.Add(this.txbOrigen);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRuta";
            this.Text = "FormRuta";
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbOrigen;
        private System.Windows.Forms.TextBox txbDestino;
        private System.Windows.Forms.TextBox txbKilometros;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgRutas;
    }
}