 private void Check_login()
        {
            
            
            oCenter.sql = "SELECT * FROM tb_login WHERE Username = @us AND Password = @pa";

            oCenter.cmd.Parameters.Clear();
            oCenter.cmd.CommandType = CommandType.Text;
            oCenter.cmd.CommandText = oCenter.sql;

            oCenter.cmd.Parameters.AddWithValue("@us", this.txtUsername.Text.Trim().ToString());
            oCenter.cmd.Parameters.AddWithValue("@pa", this.txtPassword.Text.Trim().ToString());

            oCenter.pusvOpenConnection();
            
            loginReader = oCenter.cmd.ExecuteReader();

            if (loginReader.HasRows)
            {
                while (loginReader.Read())
                {
                    oCenter.currentUsername = loginReader[0].ToString();
                    oCenter.currentStatus = loginReader[2].ToString();
                    oCenter.currentid = loginReader[3].ToString();
                }

                
            }
           
            else
            {
                MessageBox.Show("ผิดพลาด", "Invalid Username or Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (this.txtUsername.CanSelect)
                {
                    this.txtUsername.Select();
                    return;
                }


            }
            
            try
            {
                //loginReader.Close();
                oCenter.pusvOpenConnection();

                // get name
                string sSqlName = " SELECT * FROM tb_employee WHERE emp_id=@empid";

                oCenter.cmd.Parameters.Clear();
                oCenter.cmd.Parameters.AddWithValue("@empid", oCenter.currentid);
                oCenter.cmd.CommandType = CommandType.Text;
                oCenter.cmd.CommandText = sSqlName;
                loginReader = oCenter.cmd.ExecuteReader();

                string nName;
                string nLastName;
                if (loginReader.HasRows)
                {
                    while (loginReader.Read())
                    {
                        oCenter.currentName = loginReader["emp_name"].ToString();
                        oCenter.currentLastName = loginReader["emp_lastname"].ToString();
                    }
                }
                loginReader.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.txtPassword.Text = string.Empty;
            this.txtUsername.Text = string.Empty;
            FrmMain Frm = new FrmMain();
            Frm.Show();
            this.Hide();
        }