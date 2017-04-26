using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ScrollBarsEnabled = false;

            // When the form loads, open this web page.
            //webBrowser1.Navigate("http://www.google.com/");
            //webBrowser1.Navigate("http://localhost:3000/1");

            comboBoxPatients.SelectedIndex = 0;

            SetControlsBasedOnPatient();
        }

        private void comboBoxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetControlsBasedOnPatient();

            switch (comboBoxPatients.SelectedIndex + 1)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

            }
        }

        private void SetControlsBasedOnPatient()
        {
            var patientName = Convert.ToString(comboBoxPatients.SelectedItem);

            labelPatientName.Text = patientName;

            labelMedication.Text = $@"Medications for {patientName}";

            webBrowser1.Navigate($"http://localhost:3000/fabricpane/{comboBoxPatients.SelectedIndex + 1}");
        }
    }
}
