namespace CrudApi
{
    partial class Form1
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
            button1 = new Button();
            dgvCharacters = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel4 = new Panel();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtSexo = new TextBox();
            txtEmail = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label1 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.SkyBlue;
            button1.FlatAppearance.BorderColor = Color.SkyBlue;
            button1.Image = Properties.Resources.obtener;
            button1.Location = new Point(1126, 97);
            button1.Name = "button1";
            button1.Size = new Size(67, 54);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvCharacters
            // 
            dgvCharacters.AllowUserToAddRows = false;
            dgvCharacters.AllowUserToDeleteRows = false;
            dgvCharacters.Anchor = AnchorStyles.None;
            dgvCharacters.BackgroundColor = SystemColors.Info;
            dgvCharacters.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvCharacters.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCharacters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCharacters.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Apellidos, Email, Sexo });
            dgvCharacters.GridColor = Color.DarkBlue;
            dgvCharacters.Location = new Point(36, 26);
            dgvCharacters.Name = "dgvCharacters";
            dgvCharacters.ReadOnly = true;
            dgvCharacters.RowHeadersWidth = 51;
            dgvCharacters.Size = new Size(1103, 327);
            dgvCharacters.TabIndex = 1;
            dgvCharacters.CellContentClick += dgvCharacters_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 75;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 275;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            Apellidos.ReadOnly = true;
            Apellidos.Width = 275;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 225;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 6;
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Width = 200;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 806);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PaleTurquoise;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnEditar);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(btnEliminar);
            panel4.Controls.Add(btnGuardar);
            panel4.Controls.Add(txtSexo);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(txtApellidos);
            panel4.Controls.Add(txtNombre);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(groupBox1);
            panel4.Location = new Point(58, 219);
            panel4.Name = "panel4";
            panel4.Size = new Size(1219, 554);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.Location = new Point(1126, 25);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(67, 54);
            btnEditar.TabIndex = 13;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = Properties.Resources.eliminar;
            btnEliminar.Location = new Point(1022, 97);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(67, 54);
            btnEliminar.TabIndex = 12;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.FlatAppearance.BorderColor = Color.White;
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.Location = new Point(1022, 25);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(67, 52);
            btnGuardar.TabIndex = 11;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(614, 83);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(380, 27);
            txtSexo.TabIndex = 10;
            txtSexo.TextChanged += txtSexo_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(614, 23);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(380, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(153, 83);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(380, 27);
            txtApellidos.TabIndex = 8;
            txtApellidos.TextChanged += txtApellidos_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(380, 27);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += tctNombre_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(539, 83);
            label6.Name = "label6";
            label6.Size = new Size(58, 23);
            label6.TabIndex = 6;
            label6.Text = "Sexo:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(539, 27);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 5;
            label5.Text = "Email:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 83);
            label4.Name = "label4";
            label4.Size = new Size(94, 23);
            label4.TabIndex = 4;
            label4.Text = "Apellidos:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 27);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 3;
            label3.Text = "Nombres:";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dgvCharacters);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(19, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1174, 394);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTROS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleTurquoise;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(58, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(1219, 61);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleTurquoise;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(454, 16);
            label2.Name = "label2";
            label2.Size = new Size(293, 34);
            label2.TabIndex = 0;
            label2.Text = "CRUD DE USUARIOS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1331, 108);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.Image = Properties.Resources.muñeco2;
            label7.Location = new Point(1054, -58);
            label7.Name = "label7";
            label7.Size = new Size(104, 207);
            label7.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.PaleGoldenrod;
            label1.Image = Properties.Resources.logo_en_negro1_removebg_preview;
            label1.Location = new Point(-4, -17);
            label1.Name = "label1";
            label1.Size = new Size(356, 138);
            label1.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(817, 356);
            label8.Name = "label8";
            label8.Size = new Size(55, 19);
            label8.TabIndex = 2;
            label8.Text = "label8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1334, 806);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvCharacters;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Label label2;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtSexo;
        private TextBox txtEmail;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Sexo;
        private Button btnEditar;
        private Label label7;
        private Label label8;
    }
}
