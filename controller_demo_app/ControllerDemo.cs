using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;      // Deze heb je nodig voor communicatie met serial port

// Meer info kan je ook vinden op:
// http://www.codeproject.com/Articles/678025/Serial-Comms-in-Csharp-for-Beginners

namespace controller_demo_app
{
    public partial class ControllerDemo : Form
    {
        private SerialPort comPort;
        private const int BAUDRATE = 9600;

        public ControllerDemo()
        {
            InitializeComponent();
        }

        private void btnSendByteValue_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = (byte)(numByte.Value);

            try
            {
                comPort.Write(buffer, 0, 1);
            }
            catch (Exception)
            {
                MessageBox.Show("Kan de byte-waarde niet verzenden", "Controller Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
   
        private void getListOfSerialPorts()
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cmbSerialPorts.Items.Add(ArrayComPortsNames[index]);
            }
            while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Eerst gaan we lijst maken van seriele poorten die we vinden (User Friendly !!)
            getListOfSerialPorts();
        }

        private void btnOpenComPort_Click(object sender, EventArgs e)
        {
            // Eerst controleren of gebruiker wel com-poort heeft gekozen
            if (cmbSerialPorts.SelectedIndex != -1)
            {
                String comname = cmbSerialPorts.SelectedItem.ToString();

                // COM-poort object maken en poort openen
                comPort = new SerialPort(comname, BAUDRATE, Parity.None, 8, StopBits.One);
                try
                {
                    comPort.Open();

                    // Door timeouts te zetten kan je ervoor zorgen dat je programma niet vasthangt als het staat te wachten
                    comPort.ReadTimeout = 2000;
                    comPort.WriteTimeout = 2000;

                    cmbSerialPorts.BackColor = Color.LimeGreen;
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Geen COM-poort geselecteerd", "Controller Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
