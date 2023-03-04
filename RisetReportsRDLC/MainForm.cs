using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RisetReportsRDLC
{
    public partial class MainForm : Form
    {
        private JenisForm _JenisForm;
        private bool BigDB = false;
        private bool Embedded = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(JenisForm)))
                cboJenisForm.Items.Add(item);
            cboJenisForm.SelectedIndex = cboJenisForm.SelectedIndex = cboDatabase.SelectedIndex = cboLoadDefinition.SelectedIndex = 0;

        }

        private void cboJenisForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            _JenisForm = (JenisForm)Enum.Parse(typeof(JenisForm), cboJenisForm.Text);
        }

        private void cboLoadDefinition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Embedded = cboLoadDefinition.Text == "EmbeddedDeffinition";
        }

        private void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            BigDB = nmRows.Enabled = cboDatabase.Text == "Besar";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var reports = String.Format("RisetReportsRDLC.{0}.rdlc", _JenisForm.ToString());
            using (var frm = new ReportsEmbedded())
            {
                if (Embedded)
                {

                    frm.LoadFirst = CheckLoadFirst.Checked;
                    frm.UsingEmbedded = true;
                    frm.NumRows = (int)nmRows.Value;
                    frm.UseBigDB = BigDB;
                    frm.EmbeddedResourceName = reports;
                    frm.ReportName = _JenisForm.ToString();
                }
                else
                {
                    frm.LoadFirst = CheckLoadFirst.Checked;
                    frm.UsingEmbedded = false;
                    frm.NumRows = (int)nmRows.Value;
                    frm.UseBigDB = BigDB;
                    frm.ReportName = _JenisForm.ToString();
                }
                frm.ShowDialog();
            }
        }
    }

    public enum JenisForm
    {
        Reports1,
        Reports2,
        Reports3,
        Reports4,
        Reports5,
        Reports6,
        Reports7,
        Reports8,
        Reports9,
        Reports10,
        Reports11,
        Reports12,
        Reports13,
        Reports14,
        Reports15,
    }
}
