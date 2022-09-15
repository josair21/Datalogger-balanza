using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;

namespace Programa_balanza
{
    public partial class Form1 : Form
    {
        bool Comunicacion_iniciada = false;
        string fecha = "";
        string hora = "";
        string path = @"";
        
        public Form1()
        {
            InitializeComponent();
            PuertoCom.Items.AddRange(SerialPort.GetPortNames());
            EnviarCaracter.Enabled = false;
            StartBtn.Enabled = false;
            TaraBtn.Enabled = false;
            ZeroBtn.Enabled = false;
            BaudRate.Enabled = false;
            PesoRecibido.Enabled = false;
            UnidadSel.Enabled = false;
            Terminal.Enabled = false;
            ModoContinuo.Enabled = false;   
            Unidad.Enabled = false; 
            GrabarFecha.Enabled = false;
            GrabarHora.Enabled = false;
            StopBtn.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void StartBtn_Click(object sender, EventArgs e)
        {
            fecha = DateTime.UtcNow.ToString("dd-MM-yy");
            hora = DateTime.Now.ToString("HH_mm_ss");
            string fileName = Directory.GetCurrentDirectory() + @"\" + fecha + "_" + hora + ".txt";
            path = fileName;
            if (!File.Exists(fileName))
            {
                // Create the file and use streamWriter to write text to it.
                //If the file existence is not check, this will overwrite said file.
                //Use the using block so the file can close and vairable disposed correctly
                using (System.IO.StreamWriter writer = File.CreateText(fileName))
                {
                    //writer.WriteLine("Hello World");
                }
            }
            serialPort1.PortName = PuertoCom.SelectedItem.ToString();
            serialPort1.BaudRate = Convert.ToInt32(BaudRate.SelectedItem);
            try
            {
                serialPort1.Open();
            }
            catch(Exception)
            {
                Terminal.AppendText("Imposible concetar" + Environment.NewLine);
            }
            if (serialPort1.IsOpen == true)
            {
                PuertoCom.Enabled = false;
                //serialPort1.Close();
                Comunicacion_iniciada = true;
                //MessageBox.Show("Port Opened");
                EnviarCaracter.Enabled = true;
                StartBtn.Enabled = false;
                StopBtn.Enabled = true;
                TaraBtn.Enabled = true;
                ZeroBtn.Enabled = true;
                BaudRate.Enabled = false;
                PesoRecibido.Enabled = false;
                UnidadSel.Enabled = true;
                Terminal.Enabled = true;
                ModoContinuo.Enabled = true;
                Unidad.Enabled = false;
                GrabarFecha.Enabled = false;
                GrabarHora.Enabled = false;

                if (Unidad.SelectedItem.ToString() == "Kilogramo")
                {
                    UnidadSel.Text = "Kg.";
                }
                else if (Unidad.SelectedItem.ToString() == "Gramo")
                {
                    UnidadSel.Text = "g.";
                }
                else if (Unidad.SelectedItem.ToString() == "Miligramo")
                {
                    UnidadSel.Text = "mg.";
                }
                else if (Unidad.SelectedItem.ToString() == "Libra")
                {
                    UnidadSel.Text = "Lb.";
                }

                Terminal.AppendText("Conectado Correctamente" + Environment.NewLine);
                timer1.Enabled = true;
            }
            else
            {
                Terminal.AppendText("Puerto cerrado u ocupado" + Environment.NewLine);
                serialPort1.Close();
            }
        }

        private void PuertoCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaudRate.Enabled = true;
            BaudRate.SelectedItem = "9600";
            ModoContinuo.Enabled = true;
            Unidad.Enabled = true;
            Unidad.SelectedItem = "Kilogramo";
            GrabarHora.Enabled = true;
            GrabarFecha.Enabled = true;
            StartBtn.Enabled = true;
        }

        private void PesoRecibido_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Comunicacion_iniciada)
            {
                try
                {
                    if(serialPort1.ReadBufferSize > 0)
                    {
                        if (!ModoContinuo.Checked)
                        {                            
                            //PesoRecibido.Text = String.Empty;
                            string aux = serialPort1.ReadLine();
                            aux = Regex.Replace(aux, " ", "");
                            aux = Regex.Replace(aux, @"\n", "");
                            aux = Regex.Replace(aux, "[^.-9]", "");
                            PesoRecibido.Text = Regex.Replace(aux, @"\r", "");
                            if (GrabarFecha.Checked)
                            {
                                fecha = DateTime.UtcNow.ToString("dd-MM-yy");
                                Terminal.AppendText(fecha + "  ");
                                File.AppendAllText(path, fecha + ",");

                            }
                            if (GrabarHora.Checked)
                            {
                                hora = DateTime.Now.ToString("HH:mm:ss");
                                Terminal.AppendText(hora + "  ");
                                File.AppendAllText(path, hora + ",");
                            }
                            if (GrabarUnidad.Checked)
                            {
                                Terminal.AppendText(PesoRecibido.Text + "  " + UnidadSel.Text + Environment.NewLine);
                            }
                            else
                            {
                                Terminal.AppendText(PesoRecibido.Text + Environment.NewLine);
                            }
                            var newLine = string.Format("{0},{1},{2},{3}", fecha, hora, PesoRecibido.Text, UnidadSel.Text);

                            File.AppendAllText(path, PesoRecibido.Text + ",");
                            File.AppendAllText(path, UnidadSel.Text + Environment.NewLine);
                            serialPort1.DiscardInBuffer();
                            serialPort1.DiscardOutBuffer();
                        }
                        else
                        {
                            byte[] Peso = new byte[20];
                            serialPort1.Read(Peso, 0, 20);
                            string aux = Encoding.UTF8.GetString(Peso);
                            aux = Regex.Replace(aux, " ", "");
                            aux = Regex.Replace(aux, @"\n", "");
                            aux = Regex.Replace(aux, "[^.-9]", "");
                            PesoRecibido.Text = Regex.Replace(aux, @"\r", "");
                            if (String.IsNullOrEmpty(PesoRecibido.Text))
                            {
                                //None
                            }
                            else
                            {
                                if (GrabarFecha.Checked)
                                {
                                    fecha = DateTime.UtcNow.ToString("dd-MM-yy");
                                    Terminal.AppendText(fecha + "  ");
                                    File.AppendAllText(path, fecha + ",");

                                }
                                if (GrabarHora.Checked)
                                {
                                    hora = DateTime.Now.ToString("HH:mm:ss");
                                    Terminal.AppendText(hora + "  ");
                                    File.AppendAllText(path, hora + ",");
                                }
                                if (GrabarUnidad.Checked)
                                {
                                    Terminal.AppendText(PesoRecibido.Text + "  " + UnidadSel.Text + Environment.NewLine);
                                }
                                else
                                {
                                    Terminal.AppendText(PesoRecibido.Text + Environment.NewLine);
                                }

                                File.AppendAllText(path, PesoRecibido.Text + ",");
                                File.AppendAllText(path, UnidadSel.Text + Environment.NewLine);
                                serialPort1.DiscardInBuffer();
                                serialPort1.DiscardOutBuffer();
                            }

                        }
                    }
                    
                }
                catch(TimeoutException)
                {
                    //Terminal.AppendText("---" +Environment.NewLine);
                }

            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            PuertoCom.Enabled = true;
            TaraBtn.Enabled = false;
            ZeroBtn.Enabled = false;
            Comunicacion_iniciada = false;
            timer1.Enabled = false;
            BaudRate.Enabled = true;
            ModoContinuo.Enabled = true;
            Unidad.Enabled = true;
            GrabarHora.Enabled = true;
            GrabarFecha.Enabled = true;
            StartBtn.Enabled = true;
            EnviarCaracter.Enabled = false;

            StopBtn.Enabled = false;
            PesoRecibido.Enabled = false;
            UnidadSel.Enabled = false;
            Terminal.Enabled = false;
        }

        private void Terminal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Terminal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (string.IsNullOrEmpty(PesoRecibido.Text))
                {
                    //NONE
                }
                else
                {
                    
                    if (GrabarFecha.Checked)
                    {
                        fecha = DateTime.UtcNow.ToString("dd-MM-yy");
                        Terminal.AppendText(fecha + "  ");
                    }
                    if (GrabarHora.Checked)
                    {
                        hora = DateTime.Now.ToString("HH:mm:ss");
                        Terminal.AppendText(hora + "  ");
                    }
                    Terminal.AppendText(PesoRecibido.Text + "  " + UnidadSel.Text + Environment.NewLine);
                    var newLine = string.Format("{0},{1},{2},{3}", fecha, hora, PesoRecibido.Text, UnidadSel.Text);
                }
            }
        }

        private void TaraBtn_Click(object sender, EventArgs e)
        {
            if (Comunicacion_iniciada)
            {
                try
                {
                    serialPort1.WriteLine("T");
                }
                    
                catch(Exception)
                {
                    //NONE
                }
            }
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (Comunicacion_iniciada)
            {
                try
                {
                    serialPort1.WriteLine("Z");
                }

                catch(Exception)
                {
                    //NONE
                }
            }
        }

        private void EnviarCaracter_KeyDown(object sender, KeyEventArgs e)
        {
            if (Comunicacion_iniciada)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    if (string.IsNullOrEmpty(EnviarCaracter.Text))
                    {
                        //NONE
                    }
                    else
                    {
                        try
                        {
                            serialPort1.WriteLine(EnviarCaracter.Text);
                            EnviarCaracter.Text = string.Empty;
                        }
                        catch (Exception)
                        {
                            //NONE
                        }
                        
                    }
                }
            }
        }

        private void BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GrabarUnidad_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
