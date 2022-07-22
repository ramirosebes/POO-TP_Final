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
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Trabajo_Practico
{
    public partial class Store : Form
    {
        //Variables Precio
        double precio_micro = 0;
        double precio_mother = 0;
        double precio_memoria = 0;
        double precio_placa = 0;
        double precio_almacenamiento = 0;
        double precio_fuente = 0;

        double subtotal_compra = 0;
        double impuestos = 0;
        double total = 0;

        public int contador = 0;

        //Variables Seleccion
        public string email_global;

        public Store(string email_global)
        {
            InitializeComponent();
            this.email_global = email_global;
            txt_email.Text = email_global;
        }

        private void Store_Load(object sender, EventArgs e)
        {
            //ComboBox Memoria Ram
            comboBox_memoria.Items.Add("Seleccione una opcion");
            comboBox_memoria.Items.Add("Corsair 8GB DDR5 5600Mhz");
            comboBox_memoria.Items.Add("Corsair 8GB DDR5 5600Mhz x2");
            comboBox_memoria.Items.Add("Corsair 16GB DDR5 5600Mhz");
            comboBox_memoria.Items.Add("Corsair 16GB DDR5 5600Mhz x2");
            comboBox_memoria.SelectedItem = "Seleccione una opcion";

            //ComboBox Placa de Video
            comboBox_placa.Items.Add("Seleccione una opcion");
            comboBox_placa.Items.Add("RTX 3080TI");
            comboBox_placa.Items.Add("RTX 3060TI");
            comboBox_placa.Items.Add("RX6700XT");
            comboBox_placa.Items.Add("RX6600XT");
            comboBox_placa.SelectedItem = "Seleccione una opcion";

            //ComboBox Almacenamiento
            comboBox_almacenamiento.Items.Add("Seleccione una opcion");
            comboBox_almacenamiento.Items.Add("HDD 1TB");
            comboBox_almacenamiento.Items.Add("HDD 2TB");
            comboBox_almacenamiento.Items.Add("SSD 1TB");
            comboBox_almacenamiento.Items.Add("SDD M.2 500GB");
            comboBox_almacenamiento.SelectedItem = "Seleccione una opcion";

            //ComBox Fuente
            comboBox_fuente.Items.Add("Seleccione una opcion");
            comboBox_fuente.Items.Add("Fuente 800W");
            comboBox_fuente.Items.Add("Fuente 1000W");
            comboBox_fuente.Items.Add("Fuente 1200W");
            comboBox_fuente.Items.Add("Fuente 1400W");
            comboBox_fuente.SelectedItem = "Seleccione una opcion";

            //ComboBox Micro
            comboBox_micro.Items.Add("Seleccione una opcion");
            comboBox_micro.SelectedItem = "Seleccione una opcion";

            //ComboBox Mother
            comboBox_mother.Items.Add("Seleccione una opcion");
            comboBox_mother.SelectedItem = "Seleccione una opcion";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_intel.Checked == true)
            {
                //comboBox_micro
                checkBox_amd.Checked = false;
                comboBox_micro.Items.Add("Intel I9 12900k LGA1700");
                comboBox_micro.Items.Add("Intel I7 12700K LGA1700");
                comboBox_micro.Items.Add("Intel I5 12600K LGA1700");
                comboBox_micro.Items.Add("Intel I3 12100 LGA1700");

                //comboBox_mother
                comboBox_mother.Items.Add("Mother Gigabyte Z690 Aourus Ultra LGA1700");
                comboBox_mother.Items.Add("Mother Asus TUF Z690 Plus Wifi D4 LGA1700");
            }
            else if (checkBox_intel.Checked == false)
            {
                //comboBox_micro
                comboBox_micro.Items.Clear();
                comboBox_micro.Items.Add("Seleccione una opcion");
                comboBox_micro.SelectedItem = "Seleccione una opcion";
                lbl_precio_micro.Text = "";
                lbl_precio_micro.Visible = false;

                //comboBox_mother
                comboBox_mother.Items.Clear();
                comboBox_mother.Items.Add("Selccione una opcion");
                comboBox_mother.SelectedItem = "Selccione una opcion";
                lbl_precio_mother.Text = "";
                lbl_precio_micro.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_amd.Checked == true)
            {
                //comboBox_micro
                checkBox_intel.Checked = false;
                comboBox_micro.Items.Add("ADM Ryzen 9 5900X AM4");
                comboBox_micro.Items.Add("ADM Ryzen 7 5800X3D AM4");
                comboBox_micro.Items.Add("ADM Ryzen 5 5600G Vega 7 AM4");

                //comboBox_mother
                comboBox_mother.Items.Add("Mother Gigabyte B550 Aorus Elite V2 AM4");
                comboBox_mother.Items.Add("Mother Asus Prime X570-P AM4");
            }
            else if (checkBox_amd.Checked == false)
            {
                //comboBox_micro
                comboBox_micro.Items.Clear();
                comboBox_micro.Items.Add("Seleccione una opcion");
                comboBox_micro.SelectedItem = "Seleccione una opcion";
                lbl_precio_micro.Text = "";
                lbl_precio_micro.Visible = false;

                //comboBox_mother
                comboBox_mother.Items.Clear();
                comboBox_mother.Items.Add("Selccione una opcion");
                comboBox_mother.SelectedItem = "Selccione una opcion";
                lbl_precio_mother.Text = "";
                lbl_precio_micro.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //
        }

        private void combobox_micro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_micro.SelectedItem == "Intel I9 12900k LGA1700")
            {
                lbl_precio_micro.Visible = true;
                precio_micro = 126280.00;
                lbl_precio_micro.Text = "$" + Convert.ToString(precio_micro);
            }
            else if (comboBox_micro.SelectedItem == "Intel I7 12700K LGA1700")
            {
                lbl_precio_micro.Visible = true;
                precio_micro = 88550.00;
                lbl_precio_micro.Text = "$" + Convert.ToString(precio_micro);
            }
            else if (comboBox_micro.SelectedItem == "Intel I5 12600K LGA1700")
            {
                lbl_precio_micro.Visible = true;
                precio_micro = 61600.00;
                lbl_precio_micro.Text = "$" + Convert.ToString(precio_micro);
            }
            else if (comboBox_micro.SelectedItem == "Intel I3 12100 LGA1700")
            {
                lbl_precio_micro.Visible = true;
                precio_micro = 28490.00;
                lbl_precio_micro.Text = "$" + Convert.ToString(precio_micro);
            }
            else if (comboBox_micro.SelectedItem == "ADM Ryzen 9 5900X AM4")
            {
                lbl_precio_micro.Visible = true;
                precio_micro = 92400.00;
                lbl_precio_micro.Text = "$" + Convert.ToString(precio_micro);
            }
            else if (comboBox_micro.SelectedItem == "ADM Ryzen 7 5800X3D AM4")
            {
                lbl_precio_micro.Visible = true;
                precio_micro = 83160.00;
                lbl_precio_micro.Text = "$" + Convert.ToString(precio_micro);
            }
            else if (comboBox_micro.SelectedItem == "ADM Ryzen 5 5600G Vega 7 AM4")
            {
                lbl_precio_micro.Visible = true;
                precio_micro = 41580.00;
                lbl_precio_micro.Text = "$" + Convert.ToString(precio_micro);
            }
            else if (comboBox_micro.SelectedItem == "")
            {
                lbl_precio_micro.Visible = false;
                precio_micro = 0;
            }
        }

        private void comboBox_mother_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_mother.SelectedItem == "Mother Gigabyte Z690 Aourus Ultra LGA1700")
            {
                lbl_precio_mother.Visible = true;
                precio_mother = 90860.00;
                lbl_precio_mother.Text = "$" + Convert.ToString(precio_mother);
            }
            else if (comboBox_mother.SelectedItem == "Mother Asus TUF Z690 Plus Wifi D4 LGA1700")
            {
                lbl_precio_mother.Visible = true;
                precio_mother = 72380.00;
                lbl_precio_mother.Text = "$" + Convert.ToString(precio_mother);
            }
            else if (comboBox_mother.SelectedItem == "Mother Gigabyte B550 Aorus Elite V2 AM4")
            {
                lbl_precio_mother.Visible = true;
                precio_mother = 36960.00;
                lbl_precio_mother.Text = "$" + Convert.ToString(precio_mother);
            }
            else if (comboBox_mother.SelectedItem == "Mother Asus Prime X570-P AM4")
            {
                lbl_precio_mother.Visible = true;
                precio_mother = 35112.00;
                lbl_precio_mother.Text = "$" + Convert.ToString(precio_mother);
            }
            else if (comboBox_mother.SelectedItem == "")
            {
                precio_mother = 0;
                lbl_precio_mother.Visible = false;
            }
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressSoloNumeros(e);
        }

        private void comboBox_memoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            double total = 0;

            if (comboBox_memoria.SelectedItem == "Seleccion una opccion")
            {
                precio_memoria = 0;
            }
            else if (comboBox_memoria.SelectedItem == "Corsair 8GB DDR5 5600Mhz")
            {
                precio_memoria = 15092.00;
                lbl_precio_memoria.Text = "$" + Convert.ToString(precio_memoria);
                lbl_precio_memoria.Visible = true;
            }
            else if (comboBox_memoria.SelectedItem == "Corsair 8GB DDR5 5600Mhz x2")
            {
                precio_memoria = 30184.00;
                lbl_precio_memoria.Text = "$" + Convert.ToString(precio_memoria);
                lbl_precio_memoria.Visible = true;
            }
            else if (comboBox_memoria.SelectedItem == "Corsair 16GB DDR5 5600Mhz")
            {
                precio_memoria = 28674.00;
                lbl_precio_memoria.Text = "$" + Convert.ToString(precio_memoria);
                lbl_precio_memoria.Visible = true;
            }
            else if (comboBox_memoria.SelectedItem == "Corsair 16GB DDR5 5600Mhz x2")
            {
                precio_memoria = 57348.00;
                lbl_precio_memoria.Text = "$" + Convert.ToString(precio_memoria);
                lbl_precio_memoria.Visible = true;
            }
            else if (comboBox_memoria.SelectedItem == "")
            {
                precio_memoria = 0;
                lbl_precio_memoria.Visible = false;
            }

        }

        private void comboBox_placa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_placa.SelectedItem == "RTX 3080TI")
            {
                precio_placa = 265650.00;
                lbl_precio_placa.Text = "$" + Convert.ToString(precio_placa);
                lbl_precio_placa.Visible = true;
            }
            else if (comboBox_placa.SelectedItem == "RTX 3060TI")
            {
                precio_placa = 117810.00;
                lbl_precio_placa.Text = "$" + Convert.ToString(precio_placa);
                lbl_precio_placa.Visible = true;
            }
            else if (comboBox_placa.SelectedItem == "RX6700XT")
            {
                precio_placa = 131670.00;
                lbl_precio_placa.Text = "$" + Convert.ToString(precio_placa);
                lbl_precio_placa.Visible = true;
            }
            else if (comboBox_placa.SelectedItem == "RX6600XT")
            {
                precio_placa = 92400.00;
                lbl_precio_placa.Text = "$" + Convert.ToString(precio_placa);
                lbl_precio_placa.Visible = true;
            }
            else if (comboBox_placa.SelectedItem == "")
            {
                precio_placa = 0;
                lbl_precio_placa.Visible = false;
            }

        }

        private void comboBox_almacenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_almacenamiento.SelectedItem == "HDD 1TB")
            {
                precio_almacenamiento = 7700.00;
                lbl_precio_almacenamiento.Text = "$" + Convert.ToString(precio_almacenamiento);
                lbl_precio_almacenamiento.Visible = true;
            }
            else if (comboBox_almacenamiento.SelectedItem == "HDD 2TB")
            {
                precio_almacenamiento = 10472.00;
                lbl_precio_almacenamiento.Text = "$" + Convert.ToString(precio_almacenamiento);
                lbl_precio_almacenamiento.Visible = true;
            }
            else if (comboBox_almacenamiento.SelectedItem == "SSD 1TB")
            {
                precio_almacenamiento = 19250.00;
                lbl_precio_almacenamiento.Text = "$" + Convert.ToString(precio_almacenamiento);
                lbl_precio_almacenamiento.Visible = true;
            }
            else if (comboBox_almacenamiento.SelectedItem == "SDD M.2 500GB")
            {
                precio_almacenamiento = 16940.00;
                lbl_precio_almacenamiento.Text = "$" + Convert.ToString(precio_almacenamiento);
                lbl_precio_almacenamiento.Visible = true;
            }
            else if (comboBox_almacenamiento.SelectedItem == "")
            {
                precio_almacenamiento = 0;
                lbl_precio_almacenamiento.Visible = false;
            }
        }

        private void comboBox_fuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_fuente.SelectedItem == "Fuente 800W")
            {
                precio_fuente = 30200.00;
                lbl_precio_fuente.Text = "$" + Convert.ToString(precio_fuente);
                lbl_precio_fuente.Visible = true;
            }
            else if (comboBox_fuente.SelectedItem == "Fuente 1000W")
            {
                precio_fuente = 58700.00;
                lbl_precio_fuente.Text = "$" + Convert.ToString(precio_fuente);
                lbl_precio_fuente.Visible = true;
            }
            else if (comboBox_fuente.SelectedItem == "Fuente 1200W")
            {
                precio_fuente = 78100.00;
                lbl_precio_fuente.Text = "$" + Convert.ToString(precio_fuente);
                lbl_precio_fuente.Visible = true;
            }
            else if (comboBox_fuente.SelectedItem == "Fuente 1400W")
            {
                precio_fuente = 92400.00;
                lbl_precio_fuente.Text = "$" + Convert.ToString(precio_fuente);
                lbl_precio_fuente.Visible = true;
            }
            else if (comboBox_fuente.SelectedItem == "")
            {
                precio_fuente = 0;
                lbl_precio_fuente.Visible = false;
            }
        }

        private void lbl_precio_micro_TextChanged(object sender, EventArgs e)
        {
            subtotal_compra = precio_micro + precio_mother + precio_memoria + precio_placa + precio_almacenamiento + precio_fuente;
            lbl_subtotal.Text = "$" + Convert.ToString(subtotal_compra);
            impuestos = subtotal_compra * 0.21;
            lbl_impuestos.Text = "$" + Convert.ToString(impuestos);
            total = subtotal_compra + impuestos;
            lbl_total.Text = "$" + Convert.ToString(total);
        }

        private void lbl_precio_mother_TextChanged(object sender, EventArgs e)
        {
            subtotal_compra = precio_micro + precio_mother + precio_memoria + precio_placa + precio_almacenamiento + precio_fuente;
            lbl_subtotal.Text = "$" + Convert.ToString(subtotal_compra);
            impuestos = subtotal_compra * 0.21;
            lbl_impuestos.Text = "$" + Convert.ToString(impuestos);
            total = subtotal_compra + impuestos;
            lbl_total.Text = "$" + Convert.ToString(total);
        }

        private void lbl_precio_memoria_TextChanged(object sender, EventArgs e)
        {
            subtotal_compra = precio_micro + precio_mother + precio_memoria + precio_placa + precio_almacenamiento + precio_fuente;
            lbl_subtotal.Text = "$" + Convert.ToString(subtotal_compra);
            impuestos = subtotal_compra * 0.21;
            lbl_impuestos.Text = "$" + Convert.ToString(impuestos);
            total = subtotal_compra + impuestos;
            lbl_total.Text = "$" + Convert.ToString(total);
        }

        private void lbl_precio_placa_TextChanged(object sender, EventArgs e)
        {
            subtotal_compra = precio_micro + precio_mother + precio_memoria + precio_placa + precio_almacenamiento + precio_fuente;
            lbl_subtotal.Text = "$" + Convert.ToString(subtotal_compra);
            impuestos = subtotal_compra * 0.21;
            lbl_impuestos.Text = "$" + Convert.ToString(impuestos);
            total = subtotal_compra + impuestos;
            lbl_total.Text = "$" + Convert.ToString(total);
        }

        private void lbl_precio_almacenamiento_TextChanged(object sender, EventArgs e)
        {
            subtotal_compra = precio_micro + precio_mother + precio_memoria + precio_placa + precio_almacenamiento + precio_fuente;
            lbl_subtotal.Text = "$" + Convert.ToString(subtotal_compra);
            impuestos = subtotal_compra * 0.21;
            lbl_impuestos.Text = "$" + Convert.ToString(impuestos);
            total = subtotal_compra + impuestos;
            lbl_total.Text = "$" + Convert.ToString(total);
        }

        private void lbl_precio_fuente_TextChanged(object sender, EventArgs e)
        {
            subtotal_compra = precio_micro + precio_mother + precio_memoria + precio_placa + precio_almacenamiento + precio_fuente;
            lbl_subtotal.Text = "$" + Convert.ToString(subtotal_compra);
            impuestos = subtotal_compra * 0.21;
            lbl_impuestos.Text = "$" + Convert.ToString(impuestos);
            total = subtotal_compra + impuestos;
            lbl_total.Text = "$" + Convert.ToString(total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_micro.SelectedItem == "Seleccione una opcion")
            {
                MessageBox.Show("Seleccione un microprocesador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_mother.SelectedItem == "Seleccione una opcion")
            {
                MessageBox.Show("Seleccione una motherboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_memoria.SelectedItem == "Seleccione una opcion")
            {
                MessageBox.Show("Seleccioneuna memoria RAM.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_placa.SelectedItem == "Seleccione una opcion")
            {
                MessageBox.Show("Seleccione una placa de video.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_almacenamiento.SelectedItem == "Seleccione una opcion")
            {
                MessageBox.Show("Seleccione una unidad de almacenamiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_fuente.SelectedItem == "Seleccione una opcion")
            {
                MessageBox.Show("Seleccione una fuente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                email_global = txt_email.Text;
                contador += 1;
                orden_compra_registro();
                enviar_email();
            }
        }

        public void enviar_email()
        {
            //Variables
            string email, contrasena;
            email = "uaiprogramacion@outlook.com";
            contrasena = "programacionpruebas321";
            string path = @"C:\Users\ramir\Desktop\Trabajo Practico\Orden de compra\" + "Orden de compra n°" + contador + ".txt"; // Establecer nueva ruta
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

        public void orden_compra_registro()
        {
            string PATHLOG = @"C:\Users\ramir\Desktop\Trabajo Practico\Orden de compra"; //Establecer la ruta de la carpeta donde se quiere crear
            string ARCHIVOLOG = "Orden de compra n°" + contador + ".txt";

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
            sw.WriteLine("Detalle de su copra");
            sw.WriteLine("Microprocesador: -" + comboBox_micro.Text);
            sw.WriteLine("Motherboard: -" + comboBox_mother.Text);
            sw.WriteLine("Memoria RAM: -" + comboBox_memoria.Text);
            sw.WriteLine("Placa de video: -" + comboBox_placa.Text);
            sw.WriteLine("Almacenamiento: -" + comboBox_almacenamiento.Text);
            sw.WriteLine("Fuente: -" + comboBox_fuente.Text);
            sw.WriteLine("¡Gracias por su compra, que lo disfrute!");

            sw.Close();
        }
    }
}
