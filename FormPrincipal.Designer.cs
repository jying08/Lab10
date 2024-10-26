namespace Lab10
{
    partial class FormPrincipal
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
            this.btnVerBuses = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerBuses
            // 
            this.btnVerBuses.Location = new System.Drawing.Point(151, 93);
            this.btnVerBuses.Name = "btnVerBuses";
            this.btnVerBuses.Size = new System.Drawing.Size(75, 23);
            this.btnVerBuses.TabIndex = 0;
            this.btnVerBuses.Text = "Ver Buses";
            this.btnVerBuses.UseVisualStyleBackColor = true;
            this.btnVerBuses.Click += new System.EventHandler(this.btnVerBuses_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(151, 132);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.titulo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(87, 35);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(226, 22);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Lab IV Multilistas, Bus Rutas";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 233);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerBuses);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerBuses;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label titulo;
    }
}