namespace CapaVista
{
    partial class FormMenuMant
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgv_menumant = new Guna.UI2.WinForms.Guna2DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NO_HABITACION = new DataGridViewTextBoxColumn();
            ESTADO_HAB = new DataGridViewTextBoxColumn();
            NO_INSPECCION = new DataGridViewTextBoxColumn();
            FECHA_INSPECCION = new DataGridViewTextBoxColumn();
            ESTADO_INSPECCION = new DataGridViewTextBoxColumn();
            btn_eliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            btn_mostrar = new Guna.UI2.WinForms.Guna2GradientButton();
            btn_registrar = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)dgv_menumant).BeginInit();
            SuspendLayout();
            // 
            // dgv_menumant
            // 
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dgv_menumant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_menumant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_menumant.BackgroundColor = Color.Black;
            dgv_menumant.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_menumant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_menumant.ColumnHeadersHeight = 25;
            dgv_menumant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_menumant.Columns.AddRange(new DataGridViewColumn[] { ID, NO_HABITACION, ESTADO_HAB, NO_INSPECCION, FECHA_INSPECCION, ESTADO_INSPECCION });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_menumant.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_menumant.GridColor = Color.Gold;
            dgv_menumant.Location = new Point(1, 24);
            dgv_menumant.Name = "dgv_menumant";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_menumant.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_menumant.RowHeadersVisible = false;
            dgv_menumant.RowTemplate.Height = 25;
            dgv_menumant.Size = new Size(853, 399);
            dgv_menumant.TabIndex = 11;
            dgv_menumant.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgv_menumant.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv_menumant.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv_menumant.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv_menumant.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv_menumant.ThemeStyle.BackColor = Color.Black;
            dgv_menumant.ThemeStyle.GridColor = Color.Gold;
            dgv_menumant.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgv_menumant.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgv_menumant.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_menumant.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv_menumant.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_menumant.ThemeStyle.HeaderStyle.Height = 25;
            dgv_menumant.ThemeStyle.ReadOnly = false;
            dgv_menumant.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgv_menumant.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_menumant.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_menumant.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgv_menumant.ThemeStyle.RowsStyle.Height = 25;
            dgv_menumant.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgv_menumant.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgv_menumant.CellContentClick += dgv_menumant_CellContentClick;
            // 
            // ID
            // 
            ID.FillWeight = 36.54822F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // NO_HABITACION
            // 
            NO_HABITACION.FillWeight = 112.690353F;
            NO_HABITACION.HeaderText = "NO_HABITACION";
            NO_HABITACION.Name = "NO_HABITACION";
            // 
            // ESTADO_HAB
            // 
            ESTADO_HAB.FillWeight = 112.690353F;
            ESTADO_HAB.HeaderText = "ESTADO_HAB";
            ESTADO_HAB.Name = "ESTADO_HAB";
            // 
            // NO_INSPECCION
            // 
            NO_INSPECCION.FillWeight = 112.690353F;
            NO_INSPECCION.HeaderText = "NO_INSPECCION";
            NO_INSPECCION.Name = "NO_INSPECCION";
            // 
            // FECHA_INSPECCION
            // 
            FECHA_INSPECCION.FillWeight = 112.690353F;
            FECHA_INSPECCION.HeaderText = "FECHA_INSPECCION";
            FECHA_INSPECCION.Name = "FECHA_INSPECCION";
            // 
            // ESTADO_INSPECCION
            // 
            ESTADO_INSPECCION.FillWeight = 112.690353F;
            ESTADO_INSPECCION.HeaderText = "ESTADO_INSPECCION";
            ESTADO_INSPECCION.Name = "ESTADO_INSPECCION";
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_eliminar.CustomizableEdges = customizableEdges1;
            btn_eliminar.DisabledState.BorderColor = Color.DarkGray;
            btn_eliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_eliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_eliminar.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_eliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_eliminar.FillColor = Color.Orange;
            btn_eliminar.FillColor2 = Color.Gold;
            btn_eliminar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.Black;
            btn_eliminar.Location = new Point(571, 465);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_eliminar.Size = new Size(283, 53);
            btn_eliminar.TabIndex = 12;
            btn_eliminar.Text = "ELIMINAR";
            // 
            // btn_mostrar
            // 
            btn_mostrar.Anchor = AnchorStyles.Bottom;
            btn_mostrar.CustomizableEdges = customizableEdges3;
            btn_mostrar.DisabledState.BorderColor = Color.DarkGray;
            btn_mostrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_mostrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_mostrar.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_mostrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_mostrar.FillColor = Color.Orange;
            btn_mostrar.FillColor2 = Color.Gold;
            btn_mostrar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mostrar.ForeColor = Color.Black;
            btn_mostrar.Location = new Point(286, 465);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_mostrar.Size = new Size(283, 53);
            btn_mostrar.TabIndex = 13;
            btn_mostrar.Text = "MOSTRAR";
            // 
            // btn_registrar
            // 
            btn_registrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_registrar.CustomizableEdges = customizableEdges5;
            btn_registrar.DisabledState.BorderColor = Color.DarkGray;
            btn_registrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_registrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_registrar.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_registrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_registrar.FillColor = Color.Orange;
            btn_registrar.FillColor2 = Color.Gold;
            btn_registrar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_registrar.ForeColor = Color.Black;
            btn_registrar.Location = new Point(1, 465);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_registrar.Size = new Size(283, 53);
            btn_registrar.TabIndex = 14;
            btn_registrar.Text = "REGISTRAR";
            // 
            // FormMenuMant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(859, 541);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_mostrar);
            Controls.Add(btn_registrar);
            Controls.Add(dgv_menumant);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuMant";
            Text = "FormMenuMant";
            ((System.ComponentModel.ISupportInitialize)dgv_menumant).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgv_menumant;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NO_HABITACION;
        private DataGridViewTextBoxColumn ESTADO_HAB;
        private DataGridViewTextBoxColumn NO_INSPECCION;
        private DataGridViewTextBoxColumn FECHA_INSPECCION;
        private DataGridViewTextBoxColumn ESTADO_INSPECCION;
        private Guna.UI2.WinForms.Guna2GradientButton btn_eliminar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_mostrar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_registrar;
    }
}