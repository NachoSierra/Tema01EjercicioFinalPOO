using System;
using System.Windows.Forms;
using Tema01EjercicioFinalPOO.BL;
using Tema01EjercicioFinalPOO.BL.Enums;

namespace Tema01EjercicioFinalPOO.Windows
{
    public partial class FrmTriangulosEquilaterosAE : Form
    {
        public FrmTriangulosEquilaterosAE()
        {
            InitializeComponent();
        }
        private TrianguloEquilatero trianguloEquilatero; 
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboBordes(ref BordeComboBox);
            if (trianguloEquilatero!=null)
            {
                LadosTextBox.Text = trianguloEquilatero.Lado.ToString();
                BordeComboBox.SelectedItem=trianguloEquilatero.Borde;
            }
        }

        private void CargarDatosComboBordes(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Borde));
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (trianguloEquilatero==null)
                {
                    trianguloEquilatero = new TrianguloEquilatero();
                }
                trianguloEquilatero.Lado = double.Parse(LadosTextBox.Text);
                trianguloEquilatero.Borde = (Borde)BordeComboBox.SelectedItem;
                if (!trianguloEquilatero.Validar())
                {
                    errorProvider1.SetError(LadosTextBox, "Ingresar un valor dentro del rango permitido");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
                
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!double.TryParse(LadosTextBox.Text,out double triResult))
            {
                valido = false;
                errorProvider1.SetError(LadosTextBox, "Por favor, ingrese un valor valido");
            }
            return valido;
        }

        internal TrianguloEquilatero GetTrianguloEquilatero()
        {
            return trianguloEquilatero;
        }

        internal void SetTriangulo(TrianguloEquilatero trianguloEquilatero)
        {
            this.trianguloEquilatero = trianguloEquilatero;
        }
    }
}
