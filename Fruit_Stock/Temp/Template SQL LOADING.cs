// =====================================================================
oCenter ocn = new oCenter();
DataSet dsLogin = new DataSet();

sSql = "select * from tb_product";

dsProduct = ocn.pudsLoadData(sSql, "tb_login", dsLogin);

if (dsLogin.Tables["tb_login"].Rows.Count != 0)
{
	//MessageBox.Show();

	oCenter.currentUsername = dsLogin.Tables["tb_login"].Rows[0]["Username"].ToString();
	oCenter.currentStatus = dsLogin.Tables["tb_login"].Rows[0]["Status"].ToString();
	oCenter.currentid = dsLogin.Tables["tb_login"].Rows[0]["emp_id"].ToString();
}
// =====================================================================




// DataSet dsAdd = new DataSet();
// string sSqlAdd = " SELECT * FROM tb_product";
// dsAdd = ocn.pudsLoadData(sSqlAdd, "tb_product", dsAdd);
// if (dsAdd.Tables["tb_product"].Rows.Count <= 0)
// {
// DataRow dr = dsAdd.Tables["tb_product"].NewRow();
// dr["pro_id"] = txtProID.Text;
// dr["pro_name"] = txtProName.Text;
// dr["pro_price"] = txtProPrice.Text;
// dr["pro_unit"] = txtUnit.Text;
// dr["pro_quantity"] = 0;

// dsAdd.Tables["tb_product"].Rows.Add(dr);