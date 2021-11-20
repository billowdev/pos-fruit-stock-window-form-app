sqlAddEmp = " INSERT INTO tb_employee(emp_id,emp_name,emp_lastname,emp_gender,emp_bdate,emp_phone) VALUES(@id,@name,@lastname,@gender,@bdate,@phone)";
sqlAddLogin = " INSERT INTO tb_login(Username, [Password], Status, emp_id) VALUES(@status,@user,@pass,@id)";

oCenter.cmd.Parameters.Clear();

oCenter.cmd.Parameters.AddWithValue("@id", txtEMPID.Text.Trim().ToString());
oCenter.cmd.Parameters.AddWithValue("@name", txtName.Text.Trim().ToString());
oCenter.cmd.Parameters.AddWithValue("@lastname", txtLastName.Text.Trim().ToString());
oCenter.cmd.Parameters.AddWithValue("@gender", stateGenter);
oCenter.cmd.Parameters.AddWithValue("@bdate", dtpBirthDate.Value.GetDateTimeFormats('d')[0]);
oCenter.cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim().ToString());

oCenter.pusvOpenConnection();
oCenter.cmd.CommandType = CommandType.Text;
oCenter.cmd.CommandText = sqlAddEmp;
oCenter.cmd.Connection = oCenter.conn;
oCenter.cmd.ExecuteNonQuery();

// ---------------------------- tb_login ------------------------ //

oCenter.pusvOpenConnection();

oCenter.cmd.Parameters.Clear();
oCenter.cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim().ToString());
oCenter.cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim().ToString());
oCenter.cmd.Parameters.AddWithValue("@status", stateStatus);
oCenter.cmd.Parameters.AddWithValue("@id", txtEMPID.Text.Trim().ToString());

oCenter.cmd.CommandType = CommandType.Text;
oCenter.cmd.CommandText = sqlAddLogin;
oCenter.cmd.Connection = oCenter.conn;
oCenter.cmd.ExecuteNonQuery();


// ---------------------------------------------- new ------------------------------------------- //
// ==================================== Get tb_ogin Data ====================================================== //
sqlAddEmp = " INSERT INTO tb_employee(emp_id,emp_name,emp_lastname,emp_gender,emp_bdate,emp_phone) VALUES(@id,@name,@lastname,@gender,@bdate,@phone)";
sqlAddLogin = " INSERT INTO tb_login(Username, [Password], Status, emp_id) VALUES(@status,@user,@pass,@id)";

oCenter.cmd.Parameters.Clear();

oCenter.cmd.Parameters.AddWithValue("@id", txtEMPID.Text.Trim().ToString());
oCenter.cmd.Parameters.AddWithValue("@name", txtName.Text.Trim().ToString());
oCenter.cmd.Parameters.AddWithValue("@lastname", txtLastName.Text.Trim().ToString());
oCenter.cmd.Parameters.AddWithValue("@gender", stateGenter);
oCenter.cmd.Parameters.AddWithValue("@bdate", dtpBirthDate.Value.GetDateTimeFormats('d')[0]);
oCenter.cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim().ToString());

oCenter.cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim().ToString());
oCenter.cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim().ToString());
oCenter.cmd.Parameters.AddWithValue("@status", stateStatus);

DataSet dsLogin = new DataSet();
DataSet dsEmp = new DataSet();

ocn.pudsLoadData(sqlAddEmp, "tb_employee", dsEmp);
ocn.pudsLoadData(sqlAddLogin, "tb_employee", dsLogin);


// ======================================== End  Get tb_ogin Data ================================================== //