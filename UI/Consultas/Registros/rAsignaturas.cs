using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace RegistroUniversitario.UI.Consultas.Registros
{
    public partial class rAsignaturas : Form
    {
        public rAsignaturas()
        {
            InitializeComponent();
        }
        private Asignaturas LLenaClase()
        {
            Asignaturas asignatura = new Asignaturas();
            asignatura.AsignaturaId = (int)AsignaturaIdnumericUpDown.Value;
            asignatura.Descripcion = DescripciontextBox.Text;
            asignatura.Creditos = (int)CreditonumericUpDown.Value;
            return asignatura;
        }
        public void LLenaCampo(Asignaturas asignaturas)
        {
            AsignaturaIdnumericUpDown.Value = asignaturas.AsignaturaId;
            DescripciontextBox.Text = asignaturas.Descripcion;
            CreditonumericUpDown.Value = asignaturas.Creditos;

        }
        public bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                ErrorProvider.SetError(DescripciontextBox, "No puede guardar espacios en blanco");
                DescripciontextBox.Focus();
                paso = false;
            }
            if (DescripciontextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(DescripciontextBox, "El campo descroipcion no puede esta vacio");
                DescripciontextBox.Focus();
                paso = false;

            }
            if (CreditonumericUpDown.Value < 0)
            {
                ErrorProvider.SetError(CreditonumericUpDown, "No puede existir credito menor que 0");
                CreditonumericUpDown.Focus();
                paso = false;
            }
            return paso;

        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
