namespace CapaVista
{
    partial class FrmMenuInspec
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            btn_mostrar = new Guna.UI2.WinForms.Guna2GradientButton();
            btn_eliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dgv_menuinspec = new DataGridView();
            numhab = new DataGridViewTextBoxColumn();
            estadohab = new DataGridViewTextBoxColumn();
            no = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_menuinspec).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.Gold;
            guna2HtmlLabel1.Location = new Point(40, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(165, 23);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "ESTADO INSPECCION";
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2GradientButton1.CustomizableEdges = customizableEdges1;
            guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1.FillColor = Color.Orange;
            guna2GradientButton1.FillColor2 = Color.Gold;
            guna2GradientButton1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2GradientButton1.ForeColor = Color.Black;
            guna2GradientButton1.Location = new Point(691, 26);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientButton1.Size = new Size(140, 29);
            guna2GradientButton1.TabIndex = 1;
            guna2GradientButton1.Text = "Buscar";
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
            btn_mostrar.Location = new Point(84, 466);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_mostrar.Size = new Size(283, 53);
            btn_mostrar.TabIndex = 1;
            btn_mostrar.Text = "MOSTRAR";
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_eliminar.CustomizableEdges = customizableEdges5;
            btn_eliminar.DisabledState.BorderColor = Color.DarkGray;
            btn_eliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_eliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_eliminar.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_eliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_eliminar.FillColor = Color.Orange;
            btn_eliminar.FillColor2 = Color.Gold;
            btn_eliminar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.Black;
            btn_eliminar.Location = new Point(482, 466);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_eliminar.Size = new Size(283, 53);
            btn_eliminar.TabIndex = 1;
            btn_eliminar.Text = "ELIMINAR";
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.BorderColor = Color.Gold;
            guna2ComboBox1.CustomizableEdges = customizableEdges7;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FillColor = Color.Transparent;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2ComboBox1.ForeColor = Color.White;
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(40, 31);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ComboBox1.Size = new Size(165, 36);
            guna2ComboBox1.TabIndex = 4;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.CustomizableEdges = customizableEdges9;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = Color.Transparent;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2TextBox1.ForeColor = Color.White;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(387, 25);
            guna2TextBox1.Margin = new Padding(4, 4, 4, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox1.Size = new Size(277, 28);
            guna2TextBox1.TabIndex = 5;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dgv_menuinspec
            // 
            dgv_menuinspec.AllowUserToOrderColumns = true;
            dgv_menuinspec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgv_menuinspec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_menuinspec.BackgroundColor = Color.Black;
            dgv_menuinspec.BorderStyle = BorderStyle.None;
            dgv_menuinspec.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_menuinspec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_menuinspec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_menuinspec.Columns.AddRange(new DataGridViewColumn[] { numhab, estadohab, no, Column1, Column2 });
            dgv_menuinspec.Cursor = Cursors.No;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_menuinspec.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_menuinspec.EnableHeadersVisualStyles = false;
            dgv_menuinspec.Location = new Point(3, 73);
            dgv_menuinspec.Name = "dgv_menuinspec";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gold;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_menuinspec.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_menuinspec.RowTemplate.Height = 25;
            dgv_menuinspec.Size = new Size(853, 387);
            dgv_menuinspec.TabIndex = 6;
            dgv_menuinspec.CellContentClick += dgv_menuinspec_CellContentClick;
            // 
            // numhab
            // 
            numhab.DataPropertyName = "numhab";
            numhab.HeaderText = "No. HAB";
            numhab.Name = "numhab";
            // 
            // estadohab
            // 
            estadohab.DataPropertyName = "estadohab";
            estadohab.HeaderText = "EST. HAB";
            estadohab.Name = "estadohab";
            // 
            // no
            // 
            no.HeaderText = "No. INSPEC";
            no.Name = "no";
            // 
            // Column1
            // 
            Column1.HeaderText = "FECHA INSPEC";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "EST. INSPEC";
            Column2.Name = "Column2";
            // 
            // FrmMenuInspec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(859, 541);
            Controls.Add(dgv_menuinspec);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2ComboBox1);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_mostrar);
            Controls.Add(guna2GradientButton1);
            Controls.Add(guna2HtmlLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenuInspec";
            Text = "FrmMenuInspec";
            Load += FrmMenuInspec_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_menuinspec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_mostrar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_eliminar;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dgv_menuinspec;
        private DataGridViewTextBoxColumn numhab;
        private DataGridViewTextBoxColumn estadohab;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}