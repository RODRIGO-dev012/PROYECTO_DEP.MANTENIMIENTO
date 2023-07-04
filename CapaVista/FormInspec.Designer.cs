namespace CapaVista
{
    partial class FormInspec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInspec));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            txt_noHabinspec = new TextBox();
            pictureBox1 = new PictureBox();
            btn_cancelar = new Guna.UI2.WinForms.Guna2GradientButton();
            btn_guardar = new Guna.UI2.WinForms.Guna2GradientButton();
            txt_observaciones = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            dgv_menucomponente = new DataGridView();
            Componente = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_menucomponente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(200, 1);
            label1.Name = "label1";
            label1.Size = new Size(368, 40);
            label1.TabIndex = 0;
            label1.Text = "FORMULARIO INSPECCIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(200, 68);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 5;
            label2.Text = "No.Habitación";
            // 
            // txt_noHabinspec
            // 
            txt_noHabinspec.Location = new Point(333, 66);
            txt_noHabinspec.Name = "txt_noHabinspec";
            txt_noHabinspec.Size = new Size(53, 23);
            txt_noHabinspec.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_cancelar.CustomizableEdges = customizableEdges1;
            btn_cancelar.DisabledState.BorderColor = Color.DarkGray;
            btn_cancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_cancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_cancelar.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_cancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_cancelar.FillColor = Color.Orange;
            btn_cancelar.FillColor2 = Color.Gold;
            btn_cancelar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.Black;
            btn_cancelar.Location = new Point(454, 490);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_cancelar.Size = new Size(199, 45);
            btn_cancelar.TabIndex = 10;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_guardar.CustomizableEdges = customizableEdges3;
            btn_guardar.DisabledState.BorderColor = Color.DarkGray;
            btn_guardar.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_guardar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_guardar.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_guardar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_guardar.FillColor = Color.Orange;
            btn_guardar.FillColor2 = Color.Gold;
            btn_guardar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.Black;
            btn_guardar.Location = new Point(454, 413);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_guardar.Size = new Size(199, 45);
            btn_guardar.TabIndex = 11;
            btn_guardar.Text = "GUARDAR";
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_observaciones
            // 
            txt_observaciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observaciones.BackColor = Color.White;
            txt_observaciones.BorderColor = Color.Gold;
            txt_observaciones.CustomizableEdges = customizableEdges5;
            txt_observaciones.DefaultText = "";
            txt_observaciones.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_observaciones.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_observaciones.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_observaciones.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_observaciones.FillColor = Color.Transparent;
            txt_observaciones.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_observaciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_observaciones.ForeColor = Color.White;
            txt_observaciones.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_observaciones.Location = new Point(13, 399);
            txt_observaciones.Margin = new Padding(4, 3, 4, 3);
            txt_observaciones.Multiline = true;
            txt_observaciones.Name = "txt_observaciones";
            txt_observaciones.PasswordChar = '\0';
            txt_observaciones.PlaceholderForeColor = Color.White;
            txt_observaciones.PlaceholderText = "";
            txt_observaciones.SelectedText = "";
            txt_observaciones.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_observaciones.Size = new Size(417, 150);
            txt_observaciones.TabIndex = 14;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(13, 373);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 5;
            label4.Text = "OBSERVACIONES";
            // 
            // dgv_menucomponente
            // 
            dgv_menucomponente.AllowUserToOrderColumns = true;
            dgv_menucomponente.AllowUserToResizeRows = false;
            dgv_menucomponente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgv_menucomponente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_menucomponente.BackgroundColor = Color.Black;
            dgv_menucomponente.BorderStyle = BorderStyle.None;
            dgv_menucomponente.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_menucomponente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_menucomponente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_menucomponente.Columns.AddRange(new DataGridViewColumn[] { Componente, estado });
            dgv_menucomponente.Cursor = Cursors.No;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_menucomponente.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_menucomponente.EnableHeadersVisualStyles = false;
            dgv_menucomponente.Location = new Point(13, 104);
            dgv_menucomponente.Name = "dgv_menucomponente";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gold;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_menucomponente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_menucomponente.RowTemplate.Height = 25;
            dgv_menucomponente.Size = new Size(657, 266);
            dgv_menucomponente.TabIndex = 15;
            dgv_menucomponente.CellContentClick += dgv_menucomponente_CellContentClick;
            // 
            // Componente
            // 
            Componente.Name = "Componente";
            // 
            // estado
            // 
            estado.HeaderText = "ESTADO";
            estado.Name = "estado";
            estado.Resizable = DataGridViewTriState.True;
            estado.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FormInspec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(684, 561);
            Controls.Add(dgv_menucomponente);
            Controls.Add(txt_observaciones);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_guardar);
            Controls.Add(pictureBox1);
            Controls.Add(txt_noHabinspec);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInspec";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            TransparencyKey = Color.Yellow;
            Load += FormInspec_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_menucomponente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_noHabinspec;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cancelar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_guardar;
        private Guna.UI2.WinForms.Guna2TextBox txt_observaciones;
        private Label label4;
        private DataGridView dgv_menucomponente;
        private DataGridViewTextBoxColumn Componente;
        private DataGridViewTextBoxColumn estado;
    }
}