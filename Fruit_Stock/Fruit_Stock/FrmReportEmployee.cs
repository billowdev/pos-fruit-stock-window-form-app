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
    public partial class FrmReportEmployee : Form
    {
        public FrmReportEmployee()
        {
            InitializeComponent();
        }
        // Crytal report rpt Design
        public cryEmployee rptEmployee = new cryEmployee();
        private void FrmReportEmployee_Load(object sender, EventArgs e)
        {
            // crytal report control
            cryReportEmployee.ReportSource = rptEmployee;
        }
    }
}
