using CrudApi.Controllers;
using CrudApi.Models;
using System.Windows.Forms;

namespace CrudApi
{
    public partial class Form1 : Form
    {
        private int currentEditingId = -1;
        private CharactersController CharactersController;
        private Characters characters;
        public Form1()
        {
            InitializeComponent();
            CharactersController = new CharactersController();
            characters = new Characters();
        }
        private async void GetCharacters()
        {
            characters = await CharactersController.GetAllCharacters();

            if (characters != null)
            {
                foreach (var character in characters?.data!)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvCharacters);

                    row.Cells[0].Value = character.id;
                    row.Cells[1].Value = character.Nombre;
                    row.Cells[2].Value = character.Apellidos;
                    row.Cells[3].Value = character.Email;
                    row.Cells[4].Value = character.Sexo;

                    dgvCharacters.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("No se pudo obtener la petición.",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetCharacters();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Maximiza la ventana
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCharacters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSexo.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            Character character = new Character
            {
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Sexo = txtSexo.Text.Trim()
            };

            bool resultado;
            if (currentEditingId == -1)
            {
                // Crear nuevo personaje
                resultado = await CharactersController.CreateCharacter(character);
            }
            else
            {
                // Actualizar personaje existente
                resultado = await CharactersController.UpdateCharacter(currentEditingId, character);
                currentEditingId = -1; // resetear id después de editar
                txtSexo.ReadOnly = false; // desbloquear campo sexo para próximo uso
            }

            if (resultado)
            {
                MessageBox.Show("¡Operación realizada con éxito!");
                dgvCharacters.Rows.Clear();
                GetCharacters();

                txtNombre.Clear();
                txtApellidos.Clear();
                txtEmail.Clear();
                txtSexo.Clear();
            }
            else
            {
                MessageBox.Show("Error al guardar el personaje.");
            }
        }


        private void tctNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCharacters.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvCharacters.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvCharacters.Rows[selectedRowIndex].Cells["id"].Value);

                CharactersController controller = new CharactersController();
                bool eliminado = await controller.DeleteCharacter(id);

                if (eliminado)
                {
                    MessageBox.Show("Personaje eliminado correctamente.");
                    dgvCharacters.Rows.RemoveAt(selectedRowIndex); // o recarga con GetCharacters()
                }
                else
                {
                    MessageBox.Show("Error al eliminar el personaje.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvCharacters.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dgvCharacters.SelectedRows[0];

                currentEditingId = Convert.ToInt32(filaSeleccionada.Cells[0].Value); // o usa Cells["id"].Value si así lo tienes

                txtNombre.Text = filaSeleccionada.Cells[1].Value?.ToString();
                txtApellidos.Text = filaSeleccionada.Cells[2].Value?.ToString();
                txtEmail.Text = filaSeleccionada.Cells[3].Value?.ToString();
                txtSexo.Text = filaSeleccionada.Cells[4].Value?.ToString();

                txtSexo.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para editar.");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;

            btnGuardar.BackColor = Color.Yellow;
            btnGuardar.ForeColor = Color.Black;


            btnEliminar.BackColor = Color.Red;

            btnEditar.BackColor = Color.Green;

        }

        private void btnContarRegistros_Click(object sender, EventArgs e)
        {
            int total = dgvCharacters.Rows.Count;

            // Si AllowUserToAddRows está activo, se resta 1 porque esa fila es vacía
            if (dgvCharacters.AllowUserToAddRows)
                total -= 1;

            lblContador.Text = "Total registros: " + total.ToString();
        }

    }
}
