using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions;

namespace Fruit_Stock
{
    public partial class FrmReportHistoryStock : Form
    {
        public FrmReportHistoryStock()
        {
            InitializeComponent();
        }
        // Crytal report rpt Design

        public cryHistoryStockReport rptHistoryStock = new cryHistoryStockReport();

        private void FrmReportHistoryStock_Load(object sender, EventArgs e)
        {
            // crytal report control
            cryReport.ReportSource = rptHistoryStock;
        }

     
    }
}
