using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_Stock
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        // Crytal report rpt Design
        public cryEmployee rptEmployee = new cryEmployee();
        public cryDetailEmployee rptDetailEmployee = new cryDetailEmployee();

        public cryCustomer rptCustomer = new cryCustomer();
        public cryDetailCustomer rptDetailCustomer = new cryDetailCustomer();

        public cryHistoryStockReport rptHistoryStock = new cryHistoryStockReport();
        
        public cryOrder rptOrder = new cryOrder();
        public cryBill rptBill = new cryBill();

        public string sReport = "";

        public string pOrderID;
        public string pOrderQty;
        public string pOrderDate;
        public string pOrderCID;
        public string pOrderPID;
        public string pOrderUnit;
        public string pOrderPrice;
        public string pOrderTotal;


        private void FrmReportEmployee_Load(object sender, EventArgs e)
        {
            switch (sReport)
            {
                case "AllEmployee":
                    cryViewer.ReportSource = rptEmployee;
                    break;
                case "DetailEmployee":
                    cryViewer.ReportSource = rptDetailEmployee;
                    break;
                case "AllCustomer":
                    cryViewer.ReportSource = rptCustomer;
                    break;
                case "DetailCustomer":
                    sReport = "";
                    cryViewer.ReportSource = rptDetailCustomer;
                    break;
                case "AllHistoryStock":
                    cryViewer.ReportSource = rptHistoryStock;
                    break;
                case "AllOrder":
                    cryViewer.ReportSource = rptOrder;
                    break;
                case "CheckBill":
                    //cryViewer.ReportSource = rptBill;
                    //rptBill.SetParameterValue("OID", pOrderID);
                    rptBill.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    rptBill.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                    rptBill.PrintToPrinter(1, false, 0, 1);
                    this.Close();
                    break;

                default:
                    break;
                    
            }
            // crytal report control

            
        }
    }
}
