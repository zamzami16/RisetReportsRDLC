using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace RisetReportsRDLC {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private string sql = @"select
                nomorpenjualan, kodebarang,jumlah, (hargabeli1+hargabeli2)/2 as hargabeli,
                diskontotal, catatan
                from detailpenjualan dp";
        private FbConnection Con => new FbConnection(@"User=SYSDBA;Password=masterkey;Database=192.168.100.73:C:\Users\yusuf\OneDrive\Desktop\Axata\DebugOfAxataMasPur\Debug\Axata.axt;Dialect=3;Charset=UTF8;Server=localhost;");
        private FbConnection Connection  {
            get {
                var con = Con;
                con.Open();
                return con;
            }
        }
        private void Form1_Load(object sender, EventArgs e) 
        {
            //this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e) {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            DataTable dt = new DataTable();
            using (var con = Connection) {
                using (var cmd = new FbCommand(sql, con)) {
                    cmd.CommandType = CommandType.Text;
                    var da = new FbDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTimeProcessData = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            stopWatch.Restart();

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet", dt));
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;
            string elapsedTimeProcessReport = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts1.Hours, ts1.Minutes, ts1.Seconds,
                ts1.Milliseconds / 10);
            
            lbl.Text = elapsedTimeProcessData + "||" + elapsedTimeProcessReport;
        }
    }
}
