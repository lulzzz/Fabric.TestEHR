using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        readonly List<string> _patients = new List<string>
        {
            "Jones, James",
            "Brown, Joe",
            "Kane, Liam"
        };

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.findPatientToolStripMenuItem.DropDownItemClicked += FindPatientToolStripMenuItem_DropDownItemClicked;

            foreach (var item in _patients )
            {
                this.findPatientToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem
                {
                    Name = "toolStripMenuItem1",
                    Size = new System.Drawing.Size(211, 30),
                    Text = item
                });
            }
            
        }

        private void FindPatientToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SetControlsBasedOnPatient(e.ClickedItem.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ScrollBarsEnabled = false;

            // When the form loads, open this web page.
            //webBrowser1.Navigate("http://www.google.com/");
            //webBrowser1.Navigate("http://localhost:3000/1");

            SetControlsBasedOnPatient(_patients[0]);
        }

        private void SetControlsBasedOnPatient(string clickedItemText)
        {
            var patientName = Convert.ToString(clickedItemText);

            labelPatientName.Text = patientName;

            labelMedication.Text = $@"Medications for {patientName}";

            int selectedPatientId =  _patients.IndexOf(clickedItemText) + 1;
            switch (clickedItemText)
            {
                    
            }

            var urlToFabricEhr = ConfigurationManager.AppSettings["UrlToFabricEhr"];

            webBrowser1.Navigate($"{urlToFabricEhr}{selectedPatientId}");
        }
    }
}
