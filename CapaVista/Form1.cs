using CapaDatos;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos.Clases;
using log4net;
using log4net.Config;


namespace Hotel
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));

        private Usuario usuarioAutenticado;
        private int borderSize = 2;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
        public Form1()
        {
            log4net.Config.XmlConfigurator.Configure();
            InitializeComponent();
            //CollapseMenu();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(190, 158, 68);//Border color
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        //Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelMedio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
            AdjustForm();

        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            BtnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        /// se esta usando aca los logs
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrase�a.Text;

            // Verificar si los campos est�n vac�os
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            UsuarioBusiness usuarioNegocio = new UsuarioBusiness();

            try
            {
                Usuario usuarioAutenticado = usuarioNegocio.IniciarSesion(usuario, contrasena);

                if (usuarioAutenticado != null)
                {
                    switch (usuarioAutenticado.Rol.nombreRol)
                    {
                        case "Administrador":
                            FrmMenu menu = new FrmMenu(usuarioAutenticado);
                            this.Hide();
                            menu.Show();

                            // Log de informaci�n: Inicio de sesi�n exitoso
                            log.Info($"Inicio de sesi�n exitoso para el usuario '{usuario}' con el rol de Administrador.");
                            break;
                        case "jefe de mantenimiento":
                            FrmMenu menu2 = new FrmMenu(usuarioAutenticado);
                            this.Hide();
                            menu2.Show();

                            // Log de informaci�n: Inicio de sesi�n exitoso
                            log.Info($"Inicio de sesi�n exitoso para el usuario '{usuario}' con el rol de Jefe de Mantenimiento.");
                            break;
                        case "Recepcionista":
                            FrmMenu menu3 = new FrmMenu(usuarioAutenticado);
                            this.Hide();
                            menu3.Show();

                            // Log de informaci�n: Inicio de sesi�n exitoso
                            log.Info($"Inicio de sesi�n exitoso para el usuario '{usuario}' con el rol de Recepcionista.");
                            break;
                        default:
                            // Acceso no autorizado
                            break;
                    }
                }
                else
                {
                    // Las credenciales no son v�lidas, muestra un mensaje de error al usuario
                    MessageBox.Show("Las credenciales ingresadas no son v�lidas.");

                    // Log de alerta: Credenciales no v�lidas
                    log.Warn($"Las credenciales ingresadas para el usuario '{usuario}' no son v�lidas.");
                }
            }
            catch (Exception ex)
            {
                // Maneja todas las excepciones generales, muestra un mensaje de error gen�rico al usuario
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Log de error: Excepci�n durante el inicio de sesi�n
                log.Error($"Excepci�n durante el inicio de sesi�n del usuario '{usuario}': {ex.Message}");
            }
        }

        private void txtContrase�a_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkmostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmostrar.Checked) // Si el RadioButton est� seleccionado
            {
                txtContrase�a.PasswordChar = '\0'; // Mostrar caracteres normales en el campo de texto de la contrase�a
                chkmostrar.Text = "Ocultar contrase�a"; // Cambiar el texto del RadioButton a "Ocultar contrase�a"
            }
            else // Si el RadioButton no est� seleccionado
            {
                txtContrase�a.PasswordChar = '*'; // Ocultar caracteres en el campo de texto de la contrase�a
                chkmostrar.Text = "Mostrar contrase�a"; // Cambiar el texto del RadioButton a "Mostrar contrase�a"
������������}
        }

        private void PanelMedio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}