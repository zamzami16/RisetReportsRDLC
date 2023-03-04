using FirebirdSql.Data.FirebirdClient;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RisetReportsRDLC {
    public partial class ReportsEmbedded : Form {
        public bool LoadFirst { get; set; }
        public bool UsingEmbedded { get; set; }
        public int NumRows { get; set; }
        public bool UseBigDB { get; set;}
        public string EmbeddedResourceName { get; set; }
        public string ReportName { get; set; }

        private Stream ReportDefinition => _reportDefinitionCache[ReportName];
        private Dictionary<string, MemoryStream> _reportDefinitionCache = new Dictionary<string, MemoryStream>();

        public ReportsEmbedded() {
            InitializeComponent();
            LoadFirst = UsingEmbedded = UseBigDB = false;
            NumRows = 10000;
            foreach (var item in Enum.GetValues(typeof(JenisForm)))
                CacheReportDefinition(item.ToString());
        }

        private readonly string sql = @"select {0}
                nomorpenjualan, kodebarang,jumlah, (hargabeli1+hargabeli2)/2 as hargabeli,
                diskontotal, catatan
                from detailpenjualan dp;";
        private string DbMini => @"C:\Users\yusuf\OneDrive\Desktop\Axata\DebugOfAxataMasPur\Debug\Axata.axt";
        private string DbBesar => @"C:\Users\yusuf\OneDrive\Desktop\Axata\DB\WSS\Axata.axt";
        private FbConnection Con => new FbConnection($@"User=SYSDBA;Password=masterkey;Database=192.168.100.73:{(UseBigDB ? DbBesar:DbMini)};Dialect=3;Charset=UTF8;Server=localhost;");
        private FbConnection Connection {
            get {
                var con = Con;
                con.Open();
                return con;
            }
        }

        private string Msg = "";
        private string Message(string x) => Msg += " ||| " + x;

        private void Form1_Load(object sender, EventArgs e) {
            label1.Text = LoadFirst ? "Load Empty first" : "Tanpa Load";
            if (UsingEmbedded)
                this.reportViewer1.LocalReport.ReportEmbeddedResource = EmbeddedResourceName;
            else
                this.reportViewer1.LocalReport.LoadReportDefinition(ReportDefinition);

            if (LoadFirst)
                InitLoadReports();
            else
                this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e) {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            DataTable dt = new DataTable();
            using (var con = Connection) {
                using (var cmd = new FbCommand(String.Format(sql, cbAllData.Checked ? "" : $"first {NumRows}"), con)) 
                {
                    cmd.CommandType = CommandType.Text;
                    var da = new FbDataAdapter(cmd);
                    da.Fill(dt); da.Dispose();
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTimeProcessData = String.Format("Waktu proses data: {0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            stopWatch.Restart();

            ReportParameter[] parameters = new ReportParameter[] {
                new ReportParameter($"ReportParameter1", ($"Value1" + ReportName)),
                new ReportParameter($"ReportParameter2", ($"Value2" + ReportName)),
                new ReportParameter($"ReportParameter3", ($"Value3" + ReportName)),
                new ReportParameter($"ReportParameter4", ($"Value4" + ReportName)),
                new ReportParameter($"ReportParameter5", ($"Value5" + ReportName)),
                new ReportParameter($"ReportParameter6", ($"Value6" + ReportName)),
                new ReportParameter($"ReportParameter7", ($"Value7" + ReportName)),
                new ReportParameter($"ReportParameter8", ($"Value8" + ReportName)),
                new ReportParameter($"ReportParameter9", ($"Value9" + ReportName)),
                new ReportParameter($"ReportParameter10", ($"Value10" + ReportName)),
                new ReportParameter($"ReportParameter11", ($"Value11" + ReportName)),
                new ReportParameter($"ReportParameter12", ($"Value12" + ReportName)),
                new ReportParameter($"ReportParameter13", ($"Value13" + ReportName)),
                new ReportParameter($"ReportParameter14", ($"Value14" + ReportName)),
                new ReportParameter($"ReportParameter15", ($"Value15" + ReportName)),
                new ReportParameter($"ReportParameter16", ($"Value16" + ReportName)),
                new ReportParameter($"ReportParameter17", ($"Value17" + ReportName)),
                new ReportParameter($"ReportParameter18", ($"Value18" + ReportName)),
                new ReportParameter($"ReportParameter19", ($"Value19" + ReportName)),
                new ReportParameter($"ReportParameter20", ($"Value20" + ReportName))
            };

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet", dt));

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.ZoomMode = ZoomMode.FullPage;
            this.reportViewer1.RefreshReport();

            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;
            string elapsedTimeProcessReport = String.Format("Waktu proses report: {0:00}:{1:00}:{2:00}.{3:00}",
                ts1.Hours, ts1.Minutes, ts1.Seconds,
                ts1.Milliseconds / 10);
            var msg = (LoadFirst ? "Load First" : "") + elapsedTimeProcessData + " || " + elapsedTimeProcessReport;
            Message(msg);
        }

        private void InitLoadReports() {
            ReportParameter[] parameters = new ReportParameter[] {
                new ReportParameter($"ReportParameter1", ($"Value1" + ReportName)),
                new ReportParameter($"ReportParameter2", ($"Value2" + ReportName)),
                new ReportParameter($"ReportParameter3", ($"Value3" + ReportName)),
                new ReportParameter($"ReportParameter4", ($"Value4" + ReportName)),
                new ReportParameter($"ReportParameter5", ($"Value5" + ReportName)),
                new ReportParameter($"ReportParameter6", ($"Value6" + ReportName)),
                new ReportParameter($"ReportParameter7", ($"Value7" + ReportName)),
                new ReportParameter($"ReportParameter8", ($"Value8" + ReportName)),
                new ReportParameter($"ReportParameter9", ($"Value9" + ReportName)),
                new ReportParameter($"ReportParameter10", ($"Value10" + ReportName)),
                new ReportParameter($"ReportParameter11", ($"Value11" + ReportName)),
                new ReportParameter($"ReportParameter12", ($"Value12" + ReportName)),
                new ReportParameter($"ReportParameter13", ($"Value13" + ReportName)),
                new ReportParameter($"ReportParameter14", ($"Value14" + ReportName)),
                new ReportParameter($"ReportParameter15", ($"Value15" + ReportName)),
                new ReportParameter($"ReportParameter16", ($"Value16" + ReportName)),
                new ReportParameter($"ReportParameter17", ($"Value17" + ReportName)),
                new ReportParameter($"ReportParameter18", ($"Value18" + ReportName)),
                new ReportParameter($"ReportParameter19", ($"Value19" + ReportName)),
                new ReportParameter($"ReportParameter20", ($"Value20" + ReportName))
            };
            DataTable dt = new DataTable();
            dt.Columns.Add("nomorpenjualan");
            dt.Columns.Add("kodebarang");
            dt.Columns.Add("jumlah");
            dt.Columns.Add("hargabeli");
            dt.Columns.Add("diskontotal");
            dt.Columns.Add("catatan");

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet", dt));

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }


        // Load the report definition and store it in the cache.
        private void CacheReportDefinition(string reportName, string reportFilePath = null)
        {
            if (reportFilePath == null)
                reportFilePath = $@"D:\KERJA\AXATA\Riset\RisetReportsRDLC\RisetReportsRDLC\{reportName}.rdlc";

            using (FileStream stream = new FileStream(reportFilePath, FileMode.Open, FileAccess.Read))
            {
                MemoryStream memoryStream = new MemoryStream();
                stream.CopyTo(memoryStream);
                _reportDefinitionCache[reportName] = memoryStream;
            }
        }
    }
}
