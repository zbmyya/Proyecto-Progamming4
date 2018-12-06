namespace GestionVuelos
{
    partial class VuelosIda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultarIda = new System.Windows.Forms.Button();
            this.valFechaIda = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.valCiudadDestinoIda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valCiudadOrigenIda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridVuelosIda = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.reservarVuelo = new System.Windows.Forms.Button();
            this.btnEscalas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVuelosIda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConsultarIda);
            this.panel1.Controls.Add(this.valFechaIda);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.valCiudadDestinoIda);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.valCiudadOrigenIda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 131);
            this.panel1.TabIndex = 0;
            // 
            // btnConsultarIda
            // 
            this.btnConsultarIda.Location = new System.Drawing.Point(378, 95);
            this.btnConsultarIda.Name = "btnConsultarIda";
            this.btnConsultarIda.Size = new System.Drawing.Size(172, 23);
            this.btnConsultarIda.TabIndex = 8;
            this.btnConsultarIda.Text = "Consultar";
            this.btnConsultarIda.UseVisualStyleBackColor = true;
            this.btnConsultarIda.Click += new System.EventHandler(this.btnConsultarIda_Click_1);
            // 
            // valFechaIda
            // 
            this.valFechaIda.Location = new System.Drawing.Point(84, 89);
            this.valFechaIda.Name = "valFechaIda";
            this.valFechaIda.Size = new System.Drawing.Size(214, 20);
            this.valFechaIda.TabIndex = 7;
            this.valFechaIda.Value = new System.DateTime(2018, 11, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha:";
            // 
            // valCiudadDestinoIda
            // 
            this.valCiudadDestinoIda.FormattingEnabled = true;
            this.valCiudadDestinoIda.Location = new System.Drawing.Point(378, 46);
            this.valCiudadDestinoIda.Name = "valCiudadDestinoIda";
            this.valCiudadDestinoIda.Size = new System.Drawing.Size(172, 21);
            this.valCiudadDestinoIda.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ciudad destino:";
            // 
            // valCiudadOrigenIda
            // 
            this.valCiudadOrigenIda.FormattingEnabled = true;
            this.valCiudadOrigenIda.Location = new System.Drawing.Point(84, 46);
            this.valCiudadOrigenIda.Name = "valCiudadOrigenIda";
            this.valCiudadOrigenIda.Size = new System.Drawing.Size(172, 21);
            this.valCiudadOrigenIda.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad origen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Haga los filtros para encontrar tu vuelo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridVuelosIda);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(13, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 261);
            this.panel2.TabIndex = 1;
            // 
            // dataGridVuelosIda
            // 
            this.dataGridVuelosIda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVuelosIda.Location = new System.Drawing.Point(7, 38);
            this.dataGridVuelosIda.Name = "dataGridVuelosIda";
            this.dataGridVuelosIda.Size = new System.Drawing.Size(626, 210);
            this.dataGridVuelosIda.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Disponibilidad de vuelos";
            // 
            // reservarVuelo
            // 
            this.reservarVuelo.Location = new System.Drawing.Point(536, 420);
            this.reservarVuelo.Name = "reservarVuelo";
            this.reservarVuelo.Size = new System.Drawing.Size(125, 42);
            this.reservarVuelo.TabIndex = 4;
            this.reservarVuelo.Text = "Reservar vuelo";
            this.reservarVuelo.UseVisualStyleBackColor = true;
            this.reservarVuelo.Click += new System.EventHandler(this.reservarVuelo_Click);
            // 
            // btnEscalas
            // 
            this.btnEscalas.Location = new System.Drawing.Point(416, 420);
            this.btnEscalas.Name = "btnEscalas";
            this.btnEscalas.Size = new System.Drawing.Size(114, 42);
            this.btnEscalas.TabIndex = 7;
            this.btnEscalas.Text = "Ver escalas";
            this.btnEscalas.UseVisualStyleBackColor = true;
            this.btnEscalas.Visible = false;
            this.btnEscalas.Click += new System.EventHandler(this.btnEscalas_Click);
            // 
            // VuelosIda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(673, 468);
            this.Controls.Add(this.btnEscalas);
            this.Controls.Add(this.reservarVuelo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VuelosIda";
            this.Text = "VuelosIda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VuelosIda_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVuelosIda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker valFechaIda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox valCiudadDestinoIda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox valCiudadOrigenIda;
        private System.Windows.Forms.Button btnConsultarIda;
        private System.Windows.Forms.DataGridView dataGridVuelosIda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reservarVuelo;
        private System.Windows.Forms.Button btnEscalas;
    }
}