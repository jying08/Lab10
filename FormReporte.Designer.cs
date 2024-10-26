namespace Lab10
{
    partial class FormReporte
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
            this.btnBuscarBusRutaMasLarga = new System.Windows.Forms.Button();
            this.btnBuscarBusMenosLarga = new System.Windows.Forms.Button();
            this.btnBuscarRutasByConductor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbConductor = new System.Windows.Forms.TextBox();
            this.dgBuses = new System.Windows.Forms.DataGridView();
            this.dgRutas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarBusRutaMasLarga
            // 
            this.btnBuscarBusRutaMasLarga.Location = new System.Drawing.Point(91, 57);
            this.btnBuscarBusRutaMasLarga.Name = "btnBuscarBusRutaMasLarga";
            this.btnBuscarBusRutaMasLarga.Size = new System.Drawing.Size(207, 23);
            this.btnBuscarBusRutaMasLarga.TabIndex = 0;
            this.btnBuscarBusRutaMasLarga.Text = "Buscar Buses con Rutas mas largas ";
            this.btnBuscarBusRutaMasLarga.UseVisualStyleBackColor = true;
            this.btnBuscarBusRutaMasLarga.Click += new System.EventHandler(this.btnBuscarBusRutaMasLarga_Click);
            // 
            // btnBuscarBusMenosLarga
            // 
            this.btnBuscarBusMenosLarga.Location = new System.Drawing.Point(91, 97);
            this.btnBuscarBusMenosLarga.Name = "btnBuscarBusMenosLarga";
            this.btnBuscarBusMenosLarga.Size = new System.Drawing.Size(207, 23);
            this.btnBuscarBusMenosLarga.TabIndex = 1;
            this.btnBuscarBusMenosLarga.Text = "Buscar buses con menos Rutas";
            this.btnBuscarBusMenosLarga.UseVisualStyleBackColor = true;
            this.btnBuscarBusMenosLarga.Click += new System.EventHandler(this.btnBuscarBusMenosLarga_Click);
            // 
            // btnBuscarRutasByConductor
            // 
            this.btnBuscarRutasByConductor.Location = new System.Drawing.Point(91, 283);
            this.btnBuscarRutasByConductor.Name = "btnBuscarRutasByConductor";
            this.btnBuscarRutasByConductor.Size = new System.Drawing.Size(202, 23);
            this.btnBuscarRutasByConductor.TabIndex = 2;
            this.btnBuscarRutasByConductor.Text = "Buscar Rutas por conductor de Bus";
            this.btnBuscarRutasByConductor.UseVisualStyleBackColor = true;
            this.btnBuscarRutasByConductor.Click += new System.EventHandler(this.btnBuscarRutasByConductor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conductor";
            // 
            // txbConductor
            // 
            this.txbConductor.Location = new System.Drawing.Point(147, 222);
            this.txbConductor.Name = "txbConductor";
            this.txbConductor.Size = new System.Drawing.Size(100, 20);
            this.txbConductor.TabIndex = 4;
            // 
            // dgBuses
            // 
            this.dgBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuses.Location = new System.Drawing.Point(385, 27);
            this.dgBuses.Name = "dgBuses";
            this.dgBuses.Size = new System.Drawing.Size(240, 150);
            this.dgBuses.TabIndex = 5;
            // 
            // dgRutas
            // 
            this.dgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRutas.Location = new System.Drawing.Point(385, 211);
            this.dgRutas.Name = "dgRutas";
            this.dgRutas.Size = new System.Drawing.Size(240, 150);
            this.dgRutas.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(147, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 384);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgRutas);
            this.Controls.Add(this.dgBuses);
            this.Controls.Add(this.txbConductor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarRutasByConductor);
            this.Controls.Add(this.btnBuscarBusMenosLarga);
            this.Controls.Add(this.btnBuscarBusRutaMasLarga);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarBusRutaMasLarga;
        private System.Windows.Forms.Button btnBuscarBusMenosLarga;
        private System.Windows.Forms.Button btnBuscarRutasByConductor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbConductor;
        private System.Windows.Forms.DataGridView dgBuses;
        private System.Windows.Forms.DataGridView dgRutas;
        private System.Windows.Forms.Button btnSalir;
    }
}