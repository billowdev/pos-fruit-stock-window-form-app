//oCenter.rd.Close();
            //oCenter.pusvOpenConnection();
            //sSql = "";

            //sSql = " SELECT * FROM tb_login WHERE Username ='" + oCenter.currentUsername + "'";
            //oCenter.cmd.Connection = oCenter.conn;
            //oCenter.cmd.CommandText = sSql;
            //oCenter.cmd.ExecuteNonQuery();

            //oCenter.rd = oCenter.cmd.ExecuteReader();

            //if (oCenter.rd.HasRows)
            //{
            //    while (oCenter.rd.Read())
            //    {
            //        txtUsername.Text = oCenter.rd[0].ToString();
            //        txtPassword.Text = oCenter.rd[1].ToString();
            //        lbUserStatus.Text = oCenter.rd[2].ToString();
            //        lbID.Text = oCenter.rd[3].ToString();
            //    }
            //}

            //oCenter.rd.Close();
            //oCenter.pusvCloseConnection();



// it is fill all data from tb_login to dataGridView

sSql = "";
sSql = " SELECT * FROM tb_employee WHERE emp_id='" + lbID.Text + "'";

oCenter.cmd.CommandType = CommandType.Text;
oCenter.cmd.CommandText = sSql;

//oCenter.cmd.Parameters.Clear();
//oCenter.cmd.Parameters.AddWithValue("@empid", emp_id.Trim().ToString());
oCenter.pusvOpenConnection();


oCenter.rd = oCenter.cmd.ExecuteReader();

if (oCenter.rd.HasRows)
{
	while (oCenter.rd.Read())
	{

		txtName.Text = oCenter.rd[1].ToString();
		txtLastName.Text = oCenter.rd[2].ToString();

		if (oCenter.rd[3].ToString() == "ชาย")
		{
			rdbMale.Checked = true;
		}
		else
		{
			rdbFemale.Checked = true;
		}

		dtpBirthDate.Value = Convert.ToDateTime(oCenter.rd[4]);
		txtPhone.Text = oCenter.rd[5].ToString();
	}
}
oCenter.rd.Close();
oCenter.pusvCloseConnection();