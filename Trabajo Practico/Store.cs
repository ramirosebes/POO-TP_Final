using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace Trabajo_Practico
{
    public partial class Store : Form
    {
        //Fields
        private Form activeForm;

        //Variables global
        public string email_global;
        string sender_auxiliar;

        //Move
        int mov;
        int movX;
        int movY;

        public Store(string email_global)
        {
            InitializeComponent();
            OpenChildForm(new Forms.FormInicio(), sender_auxiliar);
        }

        private void Store_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        static public KeyPressEventArgs KeyPressSoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            return e;
        }
   
        public void enviarEmail()
        {
            //Variables
            string email, contrasena;
            email = "uaiprogramacion@outlook.com";
            contrasena = "programacionpruebas321";
            string path = @"C:\Users\ramir\Desktop\Trabajo Practico\Orden de compra\" + "Orden de compra n°" + ".txt"; // Establecer nueva ruta
            //Body
            string subject = "Orden de compra";
            string body = "Gracias por su compra";
            int port = 587;
            string host = "smtp.office365.com";

            MailMessage msg = new MailMessage();

            msg.To.Add("uramirosebes@gmail.com");
            msg.Subject = subject;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = body;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Attachments.Add(new Attachment(path));
            msg.From = new MailAddress(email);

            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential(email, contrasena);
            cliente.Port = port;
            cliente.EnableSsl = true;
            cliente.Host = host;

            try
            {
                cliente.Send(msg);
                MessageBox.Show("Se envio el email correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*DialogResult MensajeFinal = MessageBox.Show("Se envio el email correctamente.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MensajeFinal == DialogResult.OK)
                {
                    this.Close();
                    Application.Exit();
                }*/
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar");
            }
        }

        public void ordenCompraRegistro()
        {
            string PATHLOG = @"C:\Users\ramir\Desktop\Trabajo Practico\Orden de compra"; //Establecer la ruta de la carpeta donde se quiere crear
            string ARCHIVOLOG = "Orden de compra n°" + ".txt";

            StreamWriter sw;
            string pathCompleto = PATHLOG + @"\" + ARCHIVOLOG;
            var dirInfo = new DirectoryInfo(PATHLOG);
            if (!dirInfo.Exists)
            {
                Directory.CreateDirectory(PATHLOG);
            }
            if (File.Exists(pathCompleto))
            {
                sw = File.AppendText(pathCompleto);
            }
            else
            {
                sw = File.CreateText(pathCompleto);
            }

            sw.WriteLine("¡Orden de compra!");
            sw.WriteLine("Fecha de la compra: " + DateTime.Now.ToString());
            sw.WriteLine("-");
            sw.Close();
        }

        private void btn_volver_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_microprocesador_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMicroprocesador(),sender);
        }

        private void btn_motherboard_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMotherboard(), sender);
        }

        private void btn_placa_de_video_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPlacaDeVideo(), sender);
        }

        private void btn_memoria_ram_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMemoriaRAM(), sender);
        }

        private void bnt_almacenamiento_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAlmacenamiento(), sender);
        }

        private void btn_fuente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFuente(), sender);
        }

        private void btn_gabinete_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGabinete(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
                
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btn_vacio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInicio(), sender);
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY= e.Y;
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
