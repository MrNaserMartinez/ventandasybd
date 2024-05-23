namespace ventandasybd
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
            this.botonPrueba = new System.Windows.Forms.Button();
            this.personajesdatos = new System.Windows.Forms.DataGridView();
            this.cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownNIVELPODER = new System.Windows.Forms.NumericUpDown();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNOMBRE = new System.Windows.Forms.TextBox();
            this.botonCrear = new System.Windows.Forms.Button();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerfecha = new System.Windows.Forms.DateTimePicker();
            this.historychanel = new System.Windows.Forms.TextBox();
            this.actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personajesdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNIVELPODER)).BeginInit();
            this.SuspendLayout();
            // 
            // botonPrueba
            // 
            this.botonPrueba.Location = new System.Drawing.Point(856, 92);
            this.botonPrueba.Name = "botonPrueba";
            this.botonPrueba.Size = new System.Drawing.Size(104, 62);
            this.botonPrueba.TabIndex = 0;
            this.botonPrueba.Text = "Prueba de conexion";
            this.botonPrueba.UseVisualStyleBackColor = true;
            this.botonPrueba.Click += new System.EventHandler(this.botonPrueba_Click);
            // 
            // personajesdatos
            // 
            this.personajesdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personajesdatos.Location = new System.Drawing.Point(65, 447);
            this.personajesdatos.Name = "personajesdatos";
            this.personajesdatos.RowHeadersWidth = 62;
            this.personajesdatos.RowTemplate.Height = 28;
            this.personajesdatos.Size = new System.Drawing.Size(928, 298);
            this.personajesdatos.TabIndex = 1;
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(823, 208);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(170, 65);
            this.cargar.TabIndex = 2;
            this.cargar.Text = "Cargar datos";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "POWER";
            // 
            // numericUpDownNIVELPODER
            // 
            this.numericUpDownNIVELPODER.Location = new System.Drawing.Point(148, 156);
            this.numericUpDownNIVELPODER.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numericUpDownNIVELPODER.Name = "numericUpDownNIVELPODER";
            this.numericUpDownNIVELPODER.Size = new System.Drawing.Size(140, 26);
            this.numericUpDownNIVELPODER.TabIndex = 7;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(148, 31);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(140, 26);
            this.textBoxID.TabIndex = 8;
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // textBoxNOMBRE
            // 
            this.textBoxNOMBRE.Location = new System.Drawing.Point(148, 67);
            this.textBoxNOMBRE.Name = "textBoxNOMBRE";
            this.textBoxNOMBRE.Size = new System.Drawing.Size(140, 26);
            this.textBoxNOMBRE.TabIndex = 9;
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(148, 343);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(98, 46);
            this.botonCrear.TabIndex = 11;
            this.botonCrear.Text = "crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(148, 105);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(156, 28);
            this.comboBoxRaza.TabIndex = 12;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(343, 28);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(103, 29);
            this.buttonbuscar.TabIndex = 13;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(283, 343);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(94, 46);
            this.eliminar.TabIndex = 14;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha creacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Historia";
            // 
            // dateTimePickerfecha
            // 
            this.dateTimePickerfecha.Enabled = false;
            this.dateTimePickerfecha.Location = new System.Drawing.Point(148, 217);
            this.dateTimePickerfecha.Name = "dateTimePickerfecha";
            this.dateTimePickerfecha.Size = new System.Drawing.Size(319, 26);
            this.dateTimePickerfecha.TabIndex = 17;
            // 
            // historychanel
            // 
            this.historychanel.Location = new System.Drawing.Point(151, 269);
            this.historychanel.Name = "historychanel";
            this.historychanel.Size = new System.Drawing.Size(277, 26);
            this.historychanel.TabIndex = 18;
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(423, 340);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(113, 49);
            this.actualizar.TabIndex = 19;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1052, 819);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.historychanel);
            this.Controls.Add(this.dateTimePickerfecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.textBoxNOMBRE);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.numericUpDownNIVELPODER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.personajesdatos);
            this.Controls.Add(this.botonPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personajesdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNIVELPODER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonPrueba;
        private System.Windows.Forms.DataGridView personajesdatos;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownNIVELPODER;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNOMBRE;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerfecha;
        private System.Windows.Forms.TextBox historychanel;
        private System.Windows.Forms.Button actualizar;
    }
}

