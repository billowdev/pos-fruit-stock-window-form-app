using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fruit_Stock.static_classes;

namespace Fruit_Stock
{
    public partial class FrmHistoryStock : Form
    {
        public FrmHistoryStock()
        {
            InitializeComponent();
        }
        oCenter ocn = new oCenter();

        private void FrmEditStock_Load(object sender, EventArgs e)
        {
            FrmStock Frm = new FrmStock();
            Frm.puvShowAllStock();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmStock") == false)
            {
                
                FrmStock Frm = new FrmStock();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }
    }
}
