using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // field
        private IconButton currentBtn;
        private Panel leftBorderBtn;
      //  private Form currentForm;

        //Constructor
        public Form1()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 77);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        //structs
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
        }

        //Methods

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Hom icon

                this.btnIncio.IconChar = currentBtn.IconChar;
                this.btnIncio.IconColor = currentBtn.IconColor;
               

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Red;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                //home icon
                this.btnIncio.IconChar = FontAwesome.Sharp.IconChar.Home;
                this.btnIncio.IconColor = Color.Red;
                this.btnIncio.Text = "Incio";
                panelBtnRep.Hide();
                panelMantenimiento.Hide();
                panelOpciones.Hide();
                panelVentas.Hide();

            }
        }
       
        
        private void iconReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color2);
            
            panelMantenimiento.Hide();
            panelOpciones.Hide();
            panelVentas.Hide();
            this.btnIncio.Text = currentBtn.Text;
            if (panelBtnRep.Visible == false)
            {
                panelBtnRep.Visible = true;
                panelBtnRep.Location = new Point(0, 67);
            }
            else
            {
                panelBtnRep.Visible = false; 
            }
            if (panelMantenimiento.Visible == true)
            {
                panelBtnRep.Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelBtnRep.Visible = false;
            panelMantenimiento.Visible = false;
            panelOpciones.Visible = false;
            panelVentas.Visible = false;

        }
       
        private void iconMantenimiento_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color3);
            panelBtnRep.Hide();
            panelOpciones.Hide();
            panelVentas.Hide();
            this.btnIncio.Text = currentBtn.Text;
            if (panelMantenimiento.Visible == false)
            {
                panelMantenimiento.Visible = true;
                panelMantenimiento.Location = new Point(0, 301);
            }
            else
            {
                panelMantenimiento.Visible = false;
            }
           
        }

        private void iconBtnOpciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color1);
            panelBtnRep.Hide();
            panelMantenimiento.Hide();
            panelVentas.Hide();
            this.btnIncio.Text = currentBtn.Text;
            if (panelOpciones.Visible == false)
            {
                panelOpciones.Visible = true;
                panelOpciones.Location = new Point(0, 376);
            }
            else
            {
                panelOpciones.Visible = false;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                
            }
            
      
            
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void iconVentas_Click(object sender, EventArgs e)
        {
            
            ActivateButton(sender, RGBcolors.color1);
            if (panelVentas.Visible == false)
            {
                panelVentas.Visible = true;
                panelVentas.Location = new Point(0, 144);
            }
            else
            {
                panelVentas.Visible = false;
            }
            panelVentas.BringToFront();
            panelBtnRep.Hide();
            panelMantenimiento.Hide();
            panelOpciones.Hide();
            this.btnIncio.Text = currentBtn.Text;
           
        }

        //Metodo para abrir un solo formulario
        private void AbrirFromulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormulario.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en el panel el formulario
            //Si el formulario no existe

            if(formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelFormulario.Controls.Add(formulario);
                panelFormulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AbrirFromulario<ConsultaClientes>();
            this.btnIncio.Text = "Clientes";
        }

        private void btnMtClientes_Click(object sender, EventArgs e)
        {
            AbrirFromulario<MantenimientoClientes>();
        }

        private void btnMtCpp_Click(object sender, EventArgs e)
        {
            AbrirFromulario<MantenimientoCpp>();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            AbrirFromulario<FrmVentas>();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            AbrirFromulario<FrmComprobanteVenta>();
        }
    }
}
