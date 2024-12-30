namespace Incidencias.Forms
{
    partial class Incidencias
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incidencias));
            lbl_Nombre = new Label();
            lbl_ApePat = new Label();
            lbl_ApeMat = new Label();
            txtB_Nombre = new TextBox();
            txtB_ApePat = new TextBox();
            txtB_ApeMat = new TextBox();
            dgv_Incidencias = new DataGridView();
            btn_Agregar = new Button();
            dtp_fecha = new DateTimePicker();
            lbl_Fecha = new Label();
            lbl_Observacion = new Label();
            cb_Observaciones = new ComboBox();
            lbl_HorasPermiso = new Label();
            nup_HorasPermiso = new NumericUpDown();
            lbl_Entrada = new Label();
            txtB_Entrada = new TextBox();
            lbl_Inicio = new Label();
            nup_Inicio = new NumericUpDown();
            lbl_Fin = new Label();
            nup_Fin = new NumericUpDown();
            lbl_HorasTotales = new Label();
            txtB_HorasTotales = new TextBox();
            btn_Guardar = new Button();
            btn_Back = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Incidencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nup_HorasPermiso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nup_Inicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nup_Fin).BeginInit();
            SuspendLayout();
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_Nombre.Location = new Point(44, 105);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(90, 20);
            lbl_Nombre.TabIndex = 0;
            lbl_Nombre.Text = "Nombre(s):";
            // 
            // lbl_ApePat
            // 
            lbl_ApePat.AutoSize = true;
            lbl_ApePat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_ApePat.Location = new Point(364, 105);
            lbl_ApePat.Name = "lbl_ApePat";
            lbl_ApePat.Size = new Size(130, 20);
            lbl_ApePat.TabIndex = 1;
            lbl_ApePat.Text = "Apellido Paterno:";
            // 
            // lbl_ApeMat
            // 
            lbl_ApeMat.AutoSize = true;
            lbl_ApeMat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_ApeMat.Location = new Point(674, 105);
            lbl_ApeMat.Name = "lbl_ApeMat";
            lbl_ApeMat.Size = new Size(135, 20);
            lbl_ApeMat.TabIndex = 2;
            lbl_ApeMat.Text = "Apellido Materno:";
            // 
            // txtB_Nombre
            // 
            txtB_Nombre.Font = new Font("Segoe UI", 11F);
            txtB_Nombre.Location = new Point(44, 128);
            txtB_Nombre.Name = "txtB_Nombre";
            txtB_Nombre.Size = new Size(270, 27);
            txtB_Nombre.TabIndex = 3;
            txtB_Nombre.TextChanged += txtB_Nombre_TextChanged;
            // 
            // txtB_ApePat
            // 
            txtB_ApePat.Font = new Font("Segoe UI", 11F);
            txtB_ApePat.Location = new Point(364, 128);
            txtB_ApePat.Name = "txtB_ApePat";
            txtB_ApePat.Size = new Size(244, 27);
            txtB_ApePat.TabIndex = 4;
            txtB_ApePat.TextChanged += txtB_ApePat_TextChanged;
            // 
            // txtB_ApeMat
            // 
            txtB_ApeMat.Font = new Font("Segoe UI", 11F);
            txtB_ApeMat.Location = new Point(674, 128);
            txtB_ApeMat.Name = "txtB_ApeMat";
            txtB_ApeMat.Size = new Size(244, 27);
            txtB_ApeMat.TabIndex = 5;
            txtB_ApeMat.TextChanged += txtB_ApeMat_TextChanged;
            // 
            // dgv_Incidencias
            // 
            dgv_Incidencias.AllowUserToAddRows = false;
            dgv_Incidencias.AllowUserToDeleteRows = false;
            dgv_Incidencias.AllowUserToResizeColumns = false;
            dgv_Incidencias.AllowUserToResizeRows = false;
            dgv_Incidencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_Incidencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Incidencias.Enabled = false;
            dgv_Incidencias.Location = new Point(44, 359);
            dgv_Incidencias.Name = "dgv_Incidencias";
            dgv_Incidencias.Size = new Size(1014, 342);
            dgv_Incidencias.TabIndex = 6;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Agregar.Location = new Point(963, 298);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(95, 33);
            btn_Agregar.TabIndex = 7;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // dtp_fecha
            // 
            dtp_fecha.Font = new Font("Segoe UI", 11F);
            dtp_fecha.Format = DateTimePickerFormat.Custom;
            dtp_fecha.Location = new Point(44, 218);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(215, 27);
            dtp_fecha.TabIndex = 8;
            dtp_fecha.ValueChanged += dtp_fecha_ValueChanged;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_Fecha.Location = new Point(44, 195);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(53, 20);
            lbl_Fecha.TabIndex = 9;
            lbl_Fecha.Text = "Fecha:";
            // 
            // lbl_Observacion
            // 
            lbl_Observacion.AutoSize = true;
            lbl_Observacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_Observacion.Location = new Point(364, 195);
            lbl_Observacion.Name = "lbl_Observacion";
            lbl_Observacion.Size = new Size(120, 20);
            lbl_Observacion.TabIndex = 10;
            lbl_Observacion.Text = "Marieli (Cabina)";
            // 
            // cb_Observaciones
            // 
            cb_Observaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Observaciones.Font = new Font("Segoe UI", 11F);
            cb_Observaciones.FormattingEnabled = true;
            cb_Observaciones.Location = new Point(364, 218);
            cb_Observaciones.Name = "cb_Observaciones";
            cb_Observaciones.Size = new Size(244, 28);
            cb_Observaciones.TabIndex = 11;
            cb_Observaciones.SelectedIndexChanged += cb_Observaciones_SelectedIndexChanged;
            // 
            // lbl_HorasPermiso
            // 
            lbl_HorasPermiso.AutoSize = true;
            lbl_HorasPermiso.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_HorasPermiso.Location = new Point(674, 195);
            lbl_HorasPermiso.Name = "lbl_HorasPermiso";
            lbl_HorasPermiso.Size = new Size(115, 20);
            lbl_HorasPermiso.TabIndex = 12;
            lbl_HorasPermiso.Text = "Horas permiso:";
            // 
            // nup_HorasPermiso
            // 
            nup_HorasPermiso.Enabled = false;
            nup_HorasPermiso.Font = new Font("Segoe UI", 11F);
            nup_HorasPermiso.Location = new Point(674, 218);
            nup_HorasPermiso.Name = "nup_HorasPermiso";
            nup_HorasPermiso.Size = new Size(120, 27);
            nup_HorasPermiso.TabIndex = 14;
            // 
            // lbl_Entrada
            // 
            lbl_Entrada.AutoSize = true;
            lbl_Entrada.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_Entrada.Location = new Point(44, 275);
            lbl_Entrada.Name = "lbl_Entrada";
            lbl_Entrada.Size = new Size(67, 20);
            lbl_Entrada.TabIndex = 15;
            lbl_Entrada.Text = "Entrada:";
            // 
            // txtB_Entrada
            // 
            txtB_Entrada.Font = new Font("Segoe UI", 11F);
            txtB_Entrada.Location = new Point(44, 298);
            txtB_Entrada.Name = "txtB_Entrada";
            txtB_Entrada.Size = new Size(142, 27);
            txtB_Entrada.TabIndex = 16;
            // 
            // lbl_Inicio
            // 
            lbl_Inicio.AutoSize = true;
            lbl_Inicio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_Inicio.Location = new Point(267, 274);
            lbl_Inicio.Name = "lbl_Inicio";
            lbl_Inicio.Size = new Size(47, 20);
            lbl_Inicio.TabIndex = 17;
            lbl_Inicio.Text = "Inicio";
            // 
            // nup_Inicio
            // 
            nup_Inicio.Font = new Font("Segoe UI", 11F);
            nup_Inicio.Location = new Point(267, 297);
            nup_Inicio.Maximum = new decimal(new int[] { 19, 0, 0, 0 });
            nup_Inicio.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            nup_Inicio.Name = "nup_Inicio";
            nup_Inicio.Size = new Size(120, 27);
            nup_Inicio.TabIndex = 18;
            nup_Inicio.Value = new decimal(new int[] { 6, 0, 0, 0 });
            nup_Inicio.ValueChanged += nup_Inicio_ValueChanged;
            // 
            // lbl_Fin
            // 
            lbl_Fin.AutoSize = true;
            lbl_Fin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_Fin.Location = new Point(475, 274);
            lbl_Fin.Name = "lbl_Fin";
            lbl_Fin.Size = new Size(30, 20);
            lbl_Fin.TabIndex = 19;
            lbl_Fin.Text = "Fin";
            // 
            // nup_Fin
            // 
            nup_Fin.Font = new Font("Segoe UI", 11F);
            nup_Fin.Location = new Point(475, 297);
            nup_Fin.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nup_Fin.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            nup_Fin.Name = "nup_Fin";
            nup_Fin.Size = new Size(120, 27);
            nup_Fin.TabIndex = 20;
            nup_Fin.Value = new decimal(new int[] { 6, 0, 0, 0 });
            nup_Fin.ValueChanged += nup_Fin_ValueChanged;
            // 
            // lbl_HorasTotales
            // 
            lbl_HorasTotales.AutoSize = true;
            lbl_HorasTotales.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_HorasTotales.Location = new Point(674, 274);
            lbl_HorasTotales.Name = "lbl_HorasTotales";
            lbl_HorasTotales.Size = new Size(106, 20);
            lbl_HorasTotales.TabIndex = 21;
            lbl_HorasTotales.Text = "Horas totales:";
            // 
            // txtB_HorasTotales
            // 
            txtB_HorasTotales.Cursor = Cursors.No;
            txtB_HorasTotales.Font = new Font("Segoe UI", 11F);
            txtB_HorasTotales.Location = new Point(674, 297);
            txtB_HorasTotales.Name = "txtB_HorasTotales";
            txtB_HorasTotales.ReadOnly = true;
            txtB_HorasTotales.Size = new Size(147, 27);
            txtB_HorasTotales.TabIndex = 22;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Guardar.Location = new Point(963, 125);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(95, 33);
            btn_Guardar.TabIndex = 23;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Back
            // 
            btn_Back.Image = (Image)resources.GetObject("btn_Back.Image");
            btn_Back.Location = new Point(3, 12);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(34, 40);
            btn_Back.TabIndex = 24;
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // Incidencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 738);
            Controls.Add(btn_Back);
            Controls.Add(btn_Guardar);
            Controls.Add(txtB_HorasTotales);
            Controls.Add(lbl_HorasTotales);
            Controls.Add(nup_Fin);
            Controls.Add(lbl_Fin);
            Controls.Add(nup_Inicio);
            Controls.Add(lbl_Inicio);
            Controls.Add(txtB_Entrada);
            Controls.Add(lbl_Entrada);
            Controls.Add(nup_HorasPermiso);
            Controls.Add(lbl_HorasPermiso);
            Controls.Add(cb_Observaciones);
            Controls.Add(lbl_Observacion);
            Controls.Add(lbl_Fecha);
            Controls.Add(dtp_fecha);
            Controls.Add(btn_Agregar);
            Controls.Add(dgv_Incidencias);
            Controls.Add(txtB_ApeMat);
            Controls.Add(txtB_ApePat);
            Controls.Add(txtB_Nombre);
            Controls.Add(lbl_ApeMat);
            Controls.Add(lbl_ApePat);
            Controls.Add(lbl_Nombre);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Incidencias";
            Text = "Incidencias";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Incidencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)nup_HorasPermiso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nup_Inicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nup_Fin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nombre;
        private Label lbl_ApePat;
        private Label lbl_ApeMat;
        private TextBox txtB_Nombre;
        private TextBox txtB_ApePat;
        private TextBox txtB_ApeMat;
        private DataGridView dgv_Incidencias;
        private Button btn_Agregar;
        private DateTimePicker dtp_fecha;
        private Label lbl_Fecha;
        private Label lbl_Observacion;
        private ComboBox cb_Observaciones;
        private Label lbl_HorasPermiso;
        private NumericUpDown nup_HorasPermiso;
        private Label lbl_Entrada;
        private TextBox txtB_Entrada;
        private Label lbl_Inicio;
        private NumericUpDown nup_Inicio;
        private Label lbl_Fin;
        private NumericUpDown nup_Fin;
        private Label lbl_HorasTotales;
        private TextBox txtB_HorasTotales;
        private Button btn_Guardar;
        private Button btn_Back;
    }
}
