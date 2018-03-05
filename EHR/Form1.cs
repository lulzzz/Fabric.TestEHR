using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR
{
    public partial class Form1 : Form
    {
        private readonly SynchronizationContext _synchronizationContext;

        readonly List<string> _patients = new List<string>
        {
            "Jones, James",
            "Brown, Jolene",
            "Kane, Liam"
        };

        readonly string _patientId = ConfigurationManager.AppSettings["FacilityAccountId"];
        string PatientIdForAdt => _patientId.PadRight(20, '^');
        private string ewSepsisDataMartName = ConfigurationManager.AppSettings["EWSepsisDataMartName"];


        string batchDefinitionId = null;

        private static ConsoleLogger _logger = new ConsoleLogger();
        private readonly BatchRunner _batchRunner = new BatchRunner(_logger);

        public Form1()
        {
            InitializeComponent();
            _synchronizationContext = SynchronizationContext.Current;

            this.WindowState = FormWindowState.Maximized;
            this.findPatientToolStripMenuItem.DropDownItemClicked += FindPatientToolStripMenuItem_DropDownItemClicked;

            foreach (var item in _patients)
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

        private async void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ScrollBarsEnabled = false;

            // When the form loads, open this web page.
            //webBrowser1.Navigate("http://www.google.com/");
            //webBrowser1.Navigate("http://localhost:3000/1");

            SetControlsBasedOnPatient(_patientId);

            var dataMartIdByName = await _batchRunner.GetDataMartIDByName(ewSepsisDataMartName);
            batchDefinitionId = await _batchRunner.GetBatchDefinitionForDatamart(dataMartIdByName);

        }

        private void SetControlsBasedOnPatient(string clickedItemText)
        {
            var patientName = Convert.ToString(clickedItemText);

            labelPatientName.Text = patientName;

            labelMedication.Text = $@"Medications for {patientName}";

            UpdateFabricPane();

            UpdatePatientRisk();
        }

        private void UpdateFabricPane()
        {
            string selectedPatientId = _patientId;

            //int selectedPatientId = _patients.IndexOf(clickedItemText) + 1;
            //switch (clickedItemText)
            //{

            //}

            var urlToFabricEhr = ConfigurationManager.AppSettings["UrlToFabricEhr"];

            webBrowser1.Navigate($"{urlToFabricEhr}{selectedPatientId}");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void buttonSaveVitals_Click(object sender, EventArgs e)
        {
            var o2sat = numericO2Sat.Value;
            var pulse = numericPulse.Value;
            var temp = numericTemp.Value;

            string admitDateTime = DateTime.Now.AddMinutes(-10).ToString("yyyyMMddHHmmss");
            string currentDateTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string currentDate = DateTime.Now.ToString("yyyyMMdd");


            string hl7Message =
                @"
MSH|^~\&|App1^AppId^ISO|SendingFac^SendingFacId^ISO|ReceivingApp^ReceivingAppId^ISO|ReceivingFac^ReceivingFacId^ISO|2007509101832132||ADT^A01^ADT_A01|200760910183213200723|D|2.5
EVN||2007509101832132
PID|1||" + PatientIdForAdt + @"||||196505|M|||^^^OR^97007
PV1|1|I||||||||||||||||||||||||||||||||||||||||||" + admitDateTime + @"
PV2|||^^^^POSSIBLE MENINGITIS OR CVA
OBX|1|CE|SPO2||" + o2sat + @"|%||||N|F|" + currentDate + @"|| " + currentDateTime + @"|BN
OBX|2|CE|TEMPF||" + temp + @"|Degrees F||||N|F|20180301|| " + currentDateTime + @"|BN
OBX|3|CE|RR||9|/min||||N|F|20180301|| 20180301155800|BN
OBX|4|CE|PNN50||0.47|%||||N|F|20180301|| 20180301155800|BN
OBX|5|CE|HR||107|/min||||N|F|20180301|| 20180301155800|BN
OBX|6|CE|PVC||0|/min||||N|F|20180301|| 20180301155800|BN
OBX|7|CE|PULSE||" + pulse + @"|/min||||N|F|" + currentDate + @"|| " + currentDateTime + @"|BN
DG1|1||784.3^APHASIA^I9C||200750816|A
DG1|2||784.0^HEADACHE^I9C||200750816|A
DG1|3||781.6^MENINGISMUS^I9C||200750816|A";


            var server = "localhost";
            var port = 6661;
            _logger.AddStatus("Sending HL7 message");
            HL7Sender.SendHL7(server, port, hl7Message);

            await Task.WhenAll(
                _batchRunner.RunBatch("EW Sepsis SAM", Convert.ToInt32(batchDefinitionId))
                    .ContinueWith(async a =>
                        await _batchRunner.WaitForBatch("EW Sepsis SAM", a.Result)
                            .ContinueWith(b => UpdateFabricPane())
                            //.ContinueWith(b => _batchRunner.RunBatch("ERisk Binding", Convert.ToInt32(singleBindingBatchDefinitionId))
                            //    .ContinueWith(async c =>
                            //        await _batchRunner.WaitForBatch("Risk Binding SAM", c.Result)))
                    )
                , Task.Run(() => LoopToUpdateUI())
            );

            //await Task.Run(async () =>
            //{
            //    Thread.Sleep(30 * 1000);
            //    await RunSingleBinding();
            //});

            // await Task.Run(() => { LoopToUpdateUI(); });

        }

        // ReSharper disable once InconsistentNaming
        private void LoopToUpdateUI()
        {
            for (var i = 0; i <= 5000000; i++)
            {
                UpdateUI(i);
                Thread.Sleep(1000);
            }
        }

        // ReSharper disable once InconsistentNaming
        public void UpdateUI(int value)
        {
            var dt = new SqlLoader().LoadPatient(_patientId);

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];

                var now = DateTime.Now;

                _synchronizationContext.Post(new SendOrPostCallback(o =>
                {
                    labelRiskScore.Text = row["PredictedProbNBR"].ToString();
                    labelFactor1.Text = row["Factor1TXT"].ToString();
                    labelFactor2.Text = row["Factor2TXT"].ToString();
                    labelFactor3.Text = row["Factor3TXT"].ToString();
                    labelLastCalculatedDate.Text = row["LastCalculatedDTS"].ToString();
                    labelLastChecked.Text = now.ToLongTimeString();
                    labelStatus.Text = _logger.GetStatus();
                }), value);
            }
            else
            {
                var now = DateTime.Now;

                _synchronizationContext.Post(new SendOrPostCallback(o =>
                {
                    labelLastChecked.Text = now.ToLongTimeString();
                    labelStatus.Text = _logger.GetStatus();
                }), value);

            }
        }

        private void UpdatePatientRisk()
        {
            var dt = new SqlLoader().LoadPatient(_patientId);

            if (dt?.Rows != null && dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                labelRiskScore.Text = row["PredictedProbNBR"].ToString();
                labelFactor1.Text = row["Factor1TXT"].ToString();
                labelFactor2.Text = row["Factor2TXT"].ToString();
                labelFactor3.Text = row["Factor3TXT"].ToString();
                labelLastCalculatedDate.Text = row["LastCalculatedDTS"].ToString();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdatePatientRisk();
        }

        private void buttonRunEngine_Click(object sender, EventArgs e)
        {
            //await RunSingleBinding();
        }


    }
}
