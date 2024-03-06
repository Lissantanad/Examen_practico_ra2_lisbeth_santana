using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace Examen_practico_ra2_lisbeth_santana
{
    public partial class Estudiante : Form
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();
        private object st;

        public Estudiante()
        {
            InitializeComponent();
        }

        private void desactivarcotroles()
        {

            btn_Guardar.Enabled = false;
            txt_Salir.Enabled = false;
            btn_Nuevo.Enabled = false;
        }

        private void activarcontroles()
        {
            btn_Guardar.Enabled = false;
            txt_Salir.Enabled = false;
            btn_Nuevo.Enabled = false;
        }

        private void limpiarcampo()
        {

            txt_Matricula.Text = "";
            txt_Nombre.Text = "";
            txt_Direccion.Text = "";
            txt_Telefono.Text = "";
            txt_Email.Text = "";
            cmbCurso.SelectedIndex = -1;
            cmbMaestro.SelectedIndex = -1;
            cmbAreaTecnica.SelectedIndex = -1;
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            txt_Matricula.Focus();
        }

        private void GuardarRegistro()
        {
            string registro = $"{txt_Nombre.Text},{cmbSeccion.SelectedItem},{txt_Matricula.Text},{txt_Direccion.Text},{txt_Telefono.Text},{txt_Email.Text},{txt_Maestro.Text},{cmbCurso.SelectedItem},{cmbAreaTecnica.SelectedItem},";
            dgvEstudiantes.Rows.Add(registro.Split(','));
            GuardarArchivo(registro);
        }


        private void GuardarArchivo(string registro)
        {
            string filePath = "registros.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(registro);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Matricula.Clear();
            txt_Nombre.Clear();
            txt_Direccion.Clear();
            txt_Telefono.Clear();
            txt_Email.Clear();
           
            txt_Maestro.Clear();
            cmbAreaTecnica.SelectedIndex = -1;
            cmbCurso.SelectedIndex = -1;
            txt_Genero.SelectedText = "Femenino"; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            activarcontroles();
            limpiarcampo();
            activarcontroles();

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
            limpiarcampo();
            desactivarcotroles();
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Eliminar.Enabled = true;



        }

        private void txt_Matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string matricula = txt_Matricula.Text;
            string nombre = txt_Nombre.Text;
            string direccion = txt_Direccion.Text;
            string telefono = txt_Telefono.Text;
            string email = txt_Email.Text;
            string curso = txt_Curso.Text;
            string seccion = cmbSeccion.SelectedItem.ToString();
            string areaTecnica = cmbAreaTecnica.SelectedItem.ToString();
            string genero = rbMasculino.Checked ? "Masculino" : "Femenino";


            dgvEstudiantes.Rows.Add(matricula, nombre, curso, seccion, areaTecnica);

            limpiarcampo();
        }




        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                if (dgvEstudiantes.SelectedRows.Count > 0)
                {
                    dgvEstudiantes.Rows.RemoveAt(dgvEstudiantes.SelectedRows[0].Index);
                }
            }

        }

        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
