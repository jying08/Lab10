namespace Lab10
{
    partial class FormBus
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
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.txbConductor = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.btnResgistrar = new System.Windows.Forms.Button();
            this.btnVerRutas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgBuses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conductor";
            // 
            // txbMatricula
            // 
            this.txbMatricula.Location = new System.Drawing.Point(88, 31);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(100, 20);
            this.txbMatricula.TabIndex = 3;
            // 
            // txbConductor
            // 
            this.txbConductor.Location = new System.Drawing.Point(88, 99);
            this.txbConductor.Name = "txbConductor";
            this.txbConductor.Size = new System.Drawing.Size(100, 20);
            this.txbConductor.TabIndex = 4;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "tipo 1",
            "tipo 2",
            "tipo 3"});
            this.cbxTipo.Location = new System.Drawing.Point(87, 65);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 5;
            // 
            // btnResgistrar
            // 
            this.btnResgistrar.Location = new System.Drawing.Point(133, 154);
            this.btnResgistrar.Name = "btnResgistrar";
            this.btnResgistrar.Size = new System.Drawing.Size(75, 23);
            this.btnResgistrar.TabIndex = 6;
            this.btnResgistrar.Text = "Registrar";
            this.btnResgistrar.UseVisualStyleBackColor = true;
            this.btnResgistrar.Click += new System.EventHandler(this.btnResgistrar_Click);
            // 
            // btnVerRutas
            // 
            this.btnVerRutas.Location = new System.Drawing.Point(133, 183);
            this.btnVerRutas.Name = "btnVerRutas";
            this.btnVerRutas.Size = new System.Drawing.Size(75, 23);
            this.btnVerRutas.TabIndex = 7;
            this.btnVerRutas.Text = "Ver Rutas";
            this.btnVerRutas.UseVisualStyleBackColor = true;
            this.btnVerRutas.Click += new System.EventHandler(this.btnVerRutas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(133, 212);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 23);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(133, 241);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgBuses
            // 
            this.dgBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuses.Location = new System.Drawing.Point(315, 35);
            this.dgBuses.Name = "dgBuses";
            this.dgBuses.Size = new System.Drawing.Size(341, 229);
            this.dgBuses.TabIndex = 10;
            // 
            // FormBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 311);
            this.Controls.Add(this.dgBuses);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnVerRutas);
            this.Controls.Add(this.btnResgistrar);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.txbConductor);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBus";
            this.Text = "FormBus";
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.TextBox txbConductor;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button btnResgistrar;
        private System.Windows.Forms.Button btnVerRutas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgBuses;
    }
}