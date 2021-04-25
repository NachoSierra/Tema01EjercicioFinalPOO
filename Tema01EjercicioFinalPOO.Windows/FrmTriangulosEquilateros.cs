using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tema01EjercicioFinalPOO.BL;
using Tema01EjercicioFinalPOO.BL.Enums;
using Tema01EjercicioFinalPOO.DL;

namespace Tema01EjercicioFinalPOO.Windows
{
    public partial class FrmTriangulosEquilateros : Form
    {
        public FrmTriangulosEquilateros()
        {
            InitializeComponent();
        }
        private RepositorioDeTriangulosEquilateros _repositorio;
        private List<TrianguloEquilatero> _lista;
        private void FrmTriangulosEquilateros_Load(object sender, EventArgs e)
        {
            _repositorio = new RepositorioDeTriangulosEquilateros();
            try
            {
                _lista = _repositorio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var triangulo in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, triangulo);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TrianguloEquilatero triangulo)
        {
            r.Cells[colLados.Index].Value = triangulo.Lado;
            r.Cells[colBorde.Index].Value = triangulo.Borde;
            r.Cells[colPerimetro.Index].Value = triangulo.GetPerimetro();
            r.Cells[colSuperficie.Index].Value = triangulo.GetSuperficie();
            r.Tag = triangulo;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmTriangulosEquilaterosAE frm = new FrmTriangulosEquilaterosAE();
            frm.Text = "Agregar Lado";
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                try
                {
                    TrianguloEquilatero trianguloequilatero = frm.GetTrianguloEquilatero();
                    _repositorio.Agregar(trianguloequilatero);
                    DataGridViewRow r = ConstruirFila();
                    SetearFila(r, trianguloequilatero);
                    AgregarFila(r);
                    MessageBox.Show("Nuevo registro añadido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }
            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            TrianguloEquilatero trianguloEquilatero = (TrianguloEquilatero)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Eliminar el triangulo equilatero con lado {trianguloEquilatero.Lado}cm?",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            try
            {
                _repositorio.Borrar(trianguloEquilatero);
                BorrarFila(r);
                MessageBox.Show("Eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Remove(r);
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }
            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            TrianguloEquilatero trianguloEquilatero = (TrianguloEquilatero)r.Tag;
            TrianguloEquilatero trianguloCopia = (TrianguloEquilatero)trianguloEquilatero.Clone();

            FrmTriangulosEquilaterosAE frm = new FrmTriangulosEquilaterosAE();
            frm.Text = "Editar lado de triangulo equilatero";
            frm.SetTriangulo(trianguloEquilatero);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                trianguloEquilatero = frm.GetTrianguloEquilatero();
                _repositorio.Editar(trianguloEquilatero,trianguloCopia);
                SetearFila(r,trianguloEquilatero);
                MessageBox.Show("Registro modificado", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _lista=_repositorio.Filtrar(Borde.Linea);
            MostrarDatosEnGrilla();
        }

        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                _lista = _repositorio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void puntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _lista = _repositorio.Filtrar(Borde.Puntos);
            MostrarDatosEnGrilla();
        }

        private void rayasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _lista = _repositorio.Filtrar(Borde.Rayas);
            MostrarDatosEnGrilla();
        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _lista = _repositorio.OrdenarDeMenoraMayor();
            MostrarDatosEnGrilla();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _lista = _repositorio.OrdenarDeMayoraMenor();
            MostrarDatosEnGrilla();
        }
    }
    
}
