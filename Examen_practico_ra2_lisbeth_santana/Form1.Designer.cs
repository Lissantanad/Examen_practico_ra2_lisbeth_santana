namespace Examen_practico_ra2_lisbeth_santana
{
    partial class Estudiante
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
            lbl_Nombre_Estudiante = new Label();
            lbl_Matricula = new Label();
            lbl_Direccion = new Label();
            lbl_Telefono = new Label();
            lbl_Genero = new Label();
            lbl_Email = new Label();
            lbl_Curso = new Label();
            btn_Nuevo = new Button();
            btn_Guardar = new Button();
            btn_Agregar = new Button();
            btn_Limpiar = new Button();
            txt_Salir = new Button();
            lbl_Seccion = new Label();
            lbl_Area_Tecnica = new Label();
            lbl_Maestro_Encragado = new Label();
            txt_Seccion = new TextBox();
            txt_Maestro = new TextBox();
            txt_Area = new TextBox();
            txt_Nombre = new TextBox();
            txt_Matricula = new TextBox();
            txt_Direccion = new TextBox();
            txt_Telefono = new TextBox();
            txt_Genero = new TextBox();
            txt_Email = new TextBox();
            txt_Curso = new TextBox();
            rbFemenino = new RadioButton();
            rbMasculino = new RadioButton();
            cmbAreaTecnica = new ComboBox();
            cmbMaestro = new ComboBox();
            cmbCurso = new ComboBox();
            dgvEstudiantes = new DataGridView();
            cmbSeccion = new ComboBox();
            btn_Eliminar = new Button();
            Nombre = new DataGridViewTextBoxColumn();
            Matricula = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // lbl_Nombre_Estudiante
            // 
            lbl_Nombre_Estudiante.AutoSize = true;
            lbl_Nombre_Estudiante.Location = new Point(17, 28);
            lbl_Nombre_Estudiante.Name = "lbl_Nombre_Estudiante";
            lbl_Nombre_Estudiante.Size = new Size(170, 25);
            lbl_Nombre_Estudiante.TabIndex = 0;
            lbl_Nombre_Estudiante.Text = "Nombre estudiante ";
            // 
            // lbl_Matricula
            // 
            lbl_Matricula.AutoSize = true;
            lbl_Matricula.Location = new Point(95, 72);
            lbl_Matricula.Name = "lbl_Matricula";
            lbl_Matricula.Size = new Size(84, 25);
            lbl_Matricula.TabIndex = 1;
            lbl_Matricula.Text = "Matricula";
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new Point(94, 120);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(85, 25);
            lbl_Direccion.TabIndex = 2;
            lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(100, 160);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(79, 25);
            lbl_Telefono.TabIndex = 3;
            lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Genero
            // 
            lbl_Genero.AutoSize = true;
            lbl_Genero.Location = new Point(450, 482);
            lbl_Genero.Name = "lbl_Genero";
            lbl_Genero.Size = new Size(69, 25);
            lbl_Genero.TabIndex = 4;
            lbl_Genero.Text = "Genero";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(115, 216);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(54, 25);
            lbl_Email.TabIndex = 5;
            lbl_Email.Text = "Email";
            // 
            // lbl_Curso
            // 
            lbl_Curso.AutoSize = true;
            lbl_Curso.Location = new Point(60, 503);
            lbl_Curso.Name = "lbl_Curso";
            lbl_Curso.Size = new Size(58, 25);
            lbl_Curso.TabIndex = 6;
            lbl_Curso.Text = "Curso";
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.Location = new Point(946, 28);
            btn_Nuevo.Name = "btn_Nuevo";
            btn_Nuevo.Size = new Size(135, 49);
            btn_Nuevo.TabIndex = 7;
            btn_Nuevo.Text = "Nuevo";
            btn_Nuevo.UseVisualStyleBackColor = true;
            btn_Nuevo.Click += btn_Nuevo_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(946, 166);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(135, 49);
            btn_Guardar.TabIndex = 8;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(946, 96);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(135, 49);
            btn_Agregar.TabIndex = 9;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(946, 246);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(135, 49);
            btn_Limpiar.TabIndex = 10;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // txt_Salir
            // 
            txt_Salir.Location = new Point(946, 336);
            txt_Salir.Name = "txt_Salir";
            txt_Salir.Size = new Size(135, 49);
            txt_Salir.TabIndex = 11;
            txt_Salir.Text = "Salir";
            txt_Salir.UseVisualStyleBackColor = true;
            txt_Salir.Click += btn_Eliminar_Click;
            // 
            // lbl_Seccion
            // 
            lbl_Seccion.AutoSize = true;
            lbl_Seccion.Location = new Point(100, 270);
            lbl_Seccion.Name = "lbl_Seccion";
            lbl_Seccion.Size = new Size(72, 25);
            lbl_Seccion.TabIndex = 12;
            lbl_Seccion.Text = "Seccion";
            // 
            // lbl_Area_Tecnica
            // 
            lbl_Area_Tecnica.AutoSize = true;
            lbl_Area_Tecnica.Location = new Point(42, 396);
            lbl_Area_Tecnica.Name = "lbl_Area_Tecnica";
            lbl_Area_Tecnica.Size = new Size(110, 25);
            lbl_Area_Tecnica.TabIndex = 13;
            lbl_Area_Tecnica.Text = "Area_Tecnica";
            // 
            // lbl_Maestro_Encragado
            // 
            lbl_Maestro_Encragado.AutoSize = true;
            lbl_Maestro_Encragado.Location = new Point(450, 376);
            lbl_Maestro_Encragado.Name = "lbl_Maestro_Encragado";
            lbl_Maestro_Encragado.Size = new Size(166, 25);
            lbl_Maestro_Encragado.TabIndex = 14;
            lbl_Maestro_Encragado.Text = "Maestro Encargado";
            // 
            // txt_Seccion
            // 
            txt_Seccion.Location = new Point(258, 267);
            txt_Seccion.Name = "txt_Seccion";
            txt_Seccion.Size = new Size(103, 31);
            txt_Seccion.TabIndex = 15;
            // 
            // txt_Maestro
            // 
            txt_Maestro.Location = new Point(633, 370);
            txt_Maestro.Name = "txt_Maestro";
            txt_Maestro.Size = new Size(103, 31);
            txt_Maestro.TabIndex = 16;
            // 
            // txt_Area
            // 
            txt_Area.Location = new Point(168, 396);
            txt_Area.Name = "txt_Area";
            txt_Area.Size = new Size(103, 31);
            txt_Area.TabIndex = 17;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(258, 28);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(103, 31);
            txt_Nombre.TabIndex = 18;
            // 
            // txt_Matricula
            // 
            txt_Matricula.Location = new Point(258, 78);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(103, 31);
            txt_Matricula.TabIndex = 19;
            txt_Matricula.TextChanged += txt_Matricula_TextChanged;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(258, 126);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(103, 31);
            txt_Direccion.TabIndex = 20;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(258, 166);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(103, 31);
            txt_Telefono.TabIndex = 21;
            // 
            // txt_Genero
            // 
            txt_Genero.Location = new Point(633, 476);
            txt_Genero.Name = "txt_Genero";
            txt_Genero.Size = new Size(103, 31);
            txt_Genero.TabIndex = 22;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(258, 216);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(103, 31);
            txt_Email.TabIndex = 23;
            // 
            // txt_Curso
            // 
            txt_Curso.Location = new Point(168, 502);
            txt_Curso.Name = "txt_Curso";
            txt_Curso.Size = new Size(103, 31);
            txt_Curso.TabIndex = 24;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(778, 452);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(115, 29);
            rbFemenino.TabIndex = 25;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            rbFemenino.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(778, 500);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(117, 29);
            rbMasculino.TabIndex = 26;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // cmbAreaTecnica
            // 
            cmbAreaTecnica.FormattingEnabled = true;
            cmbAreaTecnica.Items.AddRange(new object[] { "informatica", "enfermeria", "contabilidad", "electicidad ", "gastronomia" });
            cmbAreaTecnica.Location = new Point(158, 396);
            cmbAreaTecnica.Name = "cmbAreaTecnica";
            cmbAreaTecnica.Size = new Size(132, 33);
            cmbAreaTecnica.TabIndex = 27;
            // 
            // cmbMaestro
            // 
            cmbMaestro.FormattingEnabled = true;
            cmbMaestro.Items.AddRange(new object[] { "Gamalier Reyes", "indiana", "Denis", "magnolo Fish" });
            cmbMaestro.Location = new Point(633, 368);
            cmbMaestro.Name = "cmbMaestro";
            cmbMaestro.Size = new Size(133, 33);
            cmbMaestro.TabIndex = 28;
            // 
            // cmbCurso
            // 
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Items.AddRange(new object[] { "4A1", "4A2", "4A3", "4A4", "5A1", "5A2", "5A3", "6A1", "6A2", "6A3", "4B", "5B", "6B", "4C1", "4C2", "5C", "6C", "4D1", "4D2", "5D1", "5D2", "6D1", "6D2", "4E1", "4E2", "5E", "6E" });
            cmbCurso.Location = new Point(158, 500);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(143, 33);
            cmbCurso.TabIndex = 29;
            cmbCurso.SelectedIndexChanged += cmbCurso_SelectedIndexChanged;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(17, 598);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 62;
            dgvEstudiantes.Size = new Size(1272, 303);
            dgvEstudiantes.TabIndex = 31;
            // 
            // cmbSeccion
            // 
            cmbSeccion.FormattingEnabled = true;
            cmbSeccion.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            cmbSeccion.Location = new Point(258, 267);
            cmbSeccion.Name = "cmbSeccion";
            cmbSeccion.Size = new Size(133, 33);
            cmbSeccion.TabIndex = 32;
            cmbSeccion.SelectedIndexChanged += cmbSeccion_SelectedIndexChanged;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(946, 416);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(135, 48);
            btn_Eliminar.TabIndex = 33;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click_1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Matricula
            // 
            Matricula.HeaderText = "Matricula";
            Matricula.MinimumWidth = 8;
            Matricula.Name = "Matricula";
            Matricula.Width = 150;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 8;
            Direccion.Name = "Direccion";
            Direccion.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
            // 
            // Estudiante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 1009);
            Controls.Add(btn_Eliminar);
            Controls.Add(cmbSeccion);
            Controls.Add(dgvEstudiantes);
            Controls.Add(cmbCurso);
            Controls.Add(cmbMaestro);
            Controls.Add(cmbAreaTecnica);
            Controls.Add(rbMasculino);
            Controls.Add(rbFemenino);
            Controls.Add(txt_Curso);
            Controls.Add(txt_Email);
            Controls.Add(txt_Genero);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_Direccion);
            Controls.Add(txt_Matricula);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Area);
            Controls.Add(txt_Maestro);
            Controls.Add(txt_Seccion);
            Controls.Add(lbl_Maestro_Encragado);
            Controls.Add(lbl_Area_Tecnica);
            Controls.Add(lbl_Seccion);
            Controls.Add(txt_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Agregar);
            Controls.Add(btn_Guardar);
            Controls.Add(btn_Nuevo);
            Controls.Add(lbl_Curso);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Genero);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbl_Direccion);
            Controls.Add(lbl_Matricula);
            Controls.Add(lbl_Nombre_Estudiante);
            Name = "Estudiante";
            Text = "Registrar Estudiantes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nombre_Estudiante;
        private Label lbl_Matricula;
        private Label lbl_Direccion;
        private Label lbl_Telefono;
        private Label lbl_Genero;
        private Label lbl_Email;
        private Label lbl_Curso;
        private Button btn_Nuevo;
        private Button btn_Guardar;
        private Button btn_Agregar;
        private Button btn_Limpiar;
        private Button txt_Salir;
        private Label lbl_Seccion;
        private Label lbl_Area_Tecnica;
        private Label lbl_Maestro_Encragado;
        private TextBox txt_Seccion;
        private TextBox txt_Maestro;
        private TextBox txt_Area;
        private TextBox txt_Nombre;
        private TextBox txt_Matricula;
        private TextBox txt_Direccion;
        private TextBox txt_Telefono;
        private TextBox txt_Genero;
        private TextBox txt_Email;
        private TextBox txt_Curso;
        private RadioButton rbFemenino;
        private RadioButton rbMasculino;
        private ComboBox cmbAreaTecnica;
        private ComboBox cmbMaestro;
        private ComboBox cmbCurso;
        private DataGridView dgvEstudiantes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn seccion;
        private ComboBox cmbSeccion;
        private Button button1;
        private Button btn_Eliminar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
    }
}
