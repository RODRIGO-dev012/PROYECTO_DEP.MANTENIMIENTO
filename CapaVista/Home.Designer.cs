namespace CapaVista
{
    partial class Home
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
            dgv_menuhome = new DataGridView();
            numhab = new DataGridViewTextBoxColumn();
            estadohab = new DataGridViewTextBoxColumn();
            btn_ = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)dgv_menuhome).BeginInit();
            SuspendLayout();
            // 
            // dgv_menuhome
            // 
            dgv_menuhome.AllowUserToOrderColumns = true;
            dgv_menuhome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgv_menuhome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_menuhome.BackgroundColor = Color.Black;
            dgv_menuhome.BorderStyle = BorderStyle.None;
            dgv_menuhome.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_menuhome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_menuhome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_menuhome.Columns.AddRange(new DataGridViewColumn[] { numhab, estadohab });
            dgv_menuhome.Cursor = Cursors.No;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_menuhome.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_menuhome.EnableHeadersVisualStyles = false;
            dgv_menuhome.Location = new Point(-1, 4);
            dgv_menuhome.Name = "dgv_menuhome";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gold;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_menuhome.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_menuhome.RowTemplate.Height = 25;
            dgv_menuhome.Size = new Size(536, 445);
            dgv_menuhome.TabIndex = 5;
            dgv_menuhome.CellClick += dgv_menuhome_CellClick;
            dgv_menuhome.CellContentClick += dgv_menuhome_CellContentClick;
            // 
            // numhab
            // 
            numhab.DataPropertyName = "numhab";
            numhab.HeaderText = "No. HABITACION";
            numhab.Name = "numhab";
            // 
            // estadohab
            // 
            estadohab.DataPropertyName = "estadohab";
            estadohab.HeaderText = "ESTADO HABITACION";
            estadohab.Name = "estadohab";
            // 
            // btn_
            // 
            btn_.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_.CustomizableEdges = customizableEdges1;
            btn_.DisabledState.BorderColor = Color.DarkGray;
            btn_.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_.FillColor = Color.Orange;
            btn_.FillColor2 = Color.Gold;
            btn_.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_.ForeColor = Color.Black;
            btn_.Location = new Point(553, -6);
            btn_.Name = "btn_";
            btn_.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_.Size = new Size(235, 75);
            btn_.TabIndex = 12;
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2GradientButton1.CustomizableEdges = customizableEdges3;
            guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1.FillColor = Color.Orange;
            guna2GradientButton1.FillColor2 = Color.Gold;
            guna2GradientButton1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2GradientButton1.ForeColor = Color.Black;
            guna2GradientButton1.Location = new Point(553, 91);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientButton1.Size = new Size(235, 67);
            guna2GradientButton1.TabIndex = 13;
            // 
            // guna2GradientButton2
            // 
            guna2GradientButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2GradientButton2.CustomizableEdges = customizableEdges5;
            guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton2.FillColor = Color.Orange;
            guna2GradientButton2.FillColor2 = Color.Gold;
            guna2GradientButton2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2GradientButton2.ForeColor = Color.Black;
            guna2GradientButton2.Location = new Point(553, 277);
            guna2GradientButton2.Name = "guna2GradientButton2";
            guna2GradientButton2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientButton2.Size = new Size(235, 72);
            guna2GradientButton2.TabIndex = 15;
            // 
            // guna2GradientButton3
            // 
            guna2GradientButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2GradientButton3.CustomizableEdges = customizableEdges7;
            guna2GradientButton3.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton3.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton3.FillColor = Color.Orange;
            guna2GradientButton3.FillColor2 = Color.Gold;
            guna2GradientButton3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2GradientButton3.ForeColor = Color.Black;
            guna2GradientButton3.Location = new Point(553, 184);
            guna2GradientButton3.Name = "guna2GradientButton3";
            guna2GradientButton3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2GradientButton3.Size = new Size(235, 72);
            guna2GradientButton3.TabIndex = 14;
            // 
            // guna2GradientButton5
            // 
            guna2GradientButton5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2GradientButton5.CustomizableEdges = customizableEdges9;
            guna2GradientButton5.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton5.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton5.FillColor = Color.Orange;
            guna2GradientButton5.FillColor2 = Color.Gold;
            guna2GradientButton5.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2GradientButton5.ForeColor = Color.Black;
            guna2GradientButton5.Location = new Point(553, 366);
            guna2GradientButton5.Name = "guna2GradientButton5";
            guna2GradientButton5.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2GradientButton5.Size = new Size(235, 72);
            guna2GradientButton5.TabIndex = 16;
            guna2GradientButton5.Click += guna2GradientButton5_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2GradientButton5);
            Controls.Add(guna2GradientButton2);
            Controls.Add(guna2GradientButton3);
            Controls.Add(guna2GradientButton1);
            Controls.Add(btn_);
            Controls.Add(dgv_menuhome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            Load += Home_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgv_menuhome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_menuhome;
        private DataGridViewTextBoxColumn numhab;
        private DataGridViewTextBoxColumn estadohab;
        private Guna.UI2.WinForms.Guna2GradientButton btn_;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
    }
}