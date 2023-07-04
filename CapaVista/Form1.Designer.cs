namespace Hotel
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PanelPrincipal = new Panel();
            PanelMedio = new Guna.UI2.WinForms.Guna2GradientPanel();
            chkmostrar = new CheckBox();
            btnIngresar = new Guna.UI2.WinForms.Guna2GradientButton();
            txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label1 = new Label();
            ptbLogo = new PictureBox();
            panel1 = new Panel();
            BtnRestaurar = new Guna.UI2.WinForms.Guna2Button();
            btnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnMaximizar = new Guna.UI2.WinForms.Guna2Button();
            PanelPrincipal.SuspendLayout();
            PanelMedio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = Color.Black;
            PanelPrincipal.Controls.Add(PanelMedio);
            PanelPrincipal.Controls.Add(panel1);
            PanelPrincipal.Dock = DockStyle.Fill;
            PanelPrincipal.Location = new Point(0, 0);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(789, 632);
            PanelPrincipal.TabIndex = 0;
            // 
            // PanelMedio
            // 
            PanelMedio.Controls.Add(chkmostrar);
            PanelMedio.Controls.Add(btnIngresar);
            PanelMedio.Controls.Add(txtContraseña);
            PanelMedio.Controls.Add(txtUsuario);
            PanelMedio.Controls.Add(label2);
            PanelMedio.Controls.Add(label1);
            PanelMedio.Controls.Add(ptbLogo);
            PanelMedio.CustomizableEdges = customizableEdges7;
            PanelMedio.Dock = DockStyle.Fill;
            PanelMedio.FillColor = Color.Black;
            PanelMedio.FillColor2 = Color.FromArgb(26, 26, 26);
            PanelMedio.Location = new Point(0, 34);
            PanelMedio.Name = "PanelMedio";
            PanelMedio.ShadowDecoration.CustomizableEdges = customizableEdges8;
            PanelMedio.Size = new Size(789, 598);
            PanelMedio.TabIndex = 1;
            PanelMedio.Paint += PanelMedio_Paint;
            PanelMedio.MouseDown += PanelMedio_MouseDown;
            // 
            // chkmostrar
            // 
            chkmostrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkmostrar.AutoSize = true;
            chkmostrar.ForeColor = Color.Gold;
            chkmostrar.Location = new Point(138, 438);
            chkmostrar.Name = "chkmostrar";
            chkmostrar.Size = new Size(159, 19);
            chkmostrar.TabIndex = 6;
            chkmostrar.Text = "MOSTRAR CONTRASEÑA";
            chkmostrar.UseVisualStyleBackColor = true;
            chkmostrar.CheckedChanged += chkmostrar_CheckedChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnIngresar.CustomizableEdges = customizableEdges1;
            btnIngresar.DisabledState.BorderColor = Color.DarkGray;
            btnIngresar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnIngresar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnIngresar.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnIngresar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnIngresar.FillColor = Color.Orange;
            btnIngresar.FillColor2 = Color.Gold;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(306, 530);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnIngresar.Size = new Size(199, 43);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Iniciar Sesion";
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContraseña.BackColor = Color.FromArgb(26, 26, 26);
            txtContraseña.BorderThickness = 0;
            txtContraseña.CustomizableEdges = customizableEdges3;
            txtContraseña.DefaultText = "";
            txtContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.FillColor = Color.FromArgb(26, 26, 26);
            txtContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Location = new Point(138, 368);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "";
            txtContraseña.SelectedText = "";
            txtContraseña.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtContraseña.Size = new Size(511, 51);
            txtContraseña.TabIndex = 4;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.BackColor = Color.FromArgb(26, 26, 26);
            txtUsuario.BorderThickness = 0;
            txtUsuario.CustomizableEdges = customizableEdges5;
            txtUsuario.DefaultText = "";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FillColor = Color.FromArgb(26, 26, 26);
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Location = new Point(138, 284);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.PlaceholderText = "";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtUsuario.Size = new Size(511, 47);
            txtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(138, 336);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(138, 247);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // ptbLogo
            // 
            ptbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ptbLogo.BackColor = Color.Transparent;
            ptbLogo.Image = (Image)resources.GetObject("ptbLogo.Image");
            ptbLogo.Location = new Point(233, 6);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(340, 231);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 0;
            ptbLogo.TabStop = false;
            ptbLogo.MouseDown += ptbLogo_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(BtnRestaurar);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(btnMaximizar);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 34);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.CustomizableEdges = customizableEdges9;
            BtnRestaurar.DisabledState.BorderColor = Color.DarkGray;
            BtnRestaurar.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnRestaurar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnRestaurar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnRestaurar.FillColor = Color.Gold;
            BtnRestaurar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRestaurar.ForeColor = Color.White;
            BtnRestaurar.Location = new Point(719, -2);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            BtnRestaurar.Size = new Size(33, 35);
            BtnRestaurar.TabIndex = 7;
            BtnRestaurar.Text = "=";
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.CustomizableEdges = customizableEdges11;
            btnMinimizar.DisabledState.BorderColor = Color.DarkGray;
            btnMinimizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinimizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinimizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinimizar.FillColor = Color.Gold;
            btnMinimizar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(681, -6);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnMinimizar.Size = new Size(36, 38);
            btnMinimizar.TabIndex = 8;
            btnMinimizar.Text = "-";
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.CustomizableEdges = customizableEdges13;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Gold;
            guna2Button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(754, 0);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Button1.Size = new Size(35, 33);
            guna2Button1.TabIndex = 5;
            guna2Button1.Text = "X";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.CustomizableEdges = customizableEdges15;
            btnMaximizar.DisabledState.BorderColor = Color.DarkGray;
            btnMaximizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMaximizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMaximizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMaximizar.FillColor = Color.Gold;
            btnMaximizar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaximizar.ForeColor = Color.White;
            btnMaximizar.Location = new Point(719, -2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnMaximizar.Size = new Size(36, 34);
            btnMaximizar.TabIndex = 6;
            btnMaximizar.Text = "=";
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 632);
            Controls.Add(PanelPrincipal);
            MinimumSize = new Size(736, 560);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            PanelPrincipal.ResumeLayout(false);
            PanelMedio.ResumeLayout(false);
            PanelMedio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPrincipal;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button BtnRestaurar;
        private Guna.UI2.WinForms.Guna2Button btnMinimizar;
        private Guna.UI2.WinForms.Guna2Button btnMaximizar;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelMedio;
        private Guna.UI2.WinForms.Guna2GradientButton btnIngresar;
        private Label label2;
        private Label label1;
        private PictureBox ptbLogo;
        private CheckBox chkmostrar;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
    }
}