using CrystalDecisions.CrystalReports.Engine;
using PSI_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_System
{
    public partial class CrystalReportForm : Form
    {
        public CrystalReportForm()
        {
            InitializeComponent();
        }

        public DataTable dataTable_PO = null;

        private void CrystalReportForm_Load(object sender, EventArgs e)
        {
            ReportDocument crp = new ReportDocument();
            crp.Load("CrystalReport1.rpt");
            crp.SetDataSource(dataTable_PO);
            this.crystalReportViewer1.ReportSource = crp;
        }

    }
}
