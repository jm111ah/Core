﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CCore.Lib
{
    public class Login
    {
        protected string Result = string.Empty;
        protected string DBConnection = string.Empty;
        protected string Sql = string.Empty;
        protected DataTable dt = new DataTable();

        public string LoginCheck(string Email , string PassWord)
        {
            DBConnection = "Data Source=127.0.0.1;Integrated Security=no;Database=DB명;Password=PassWord;User ID=UserID;Pooling=true;Min Pool Size=5;Connect Timeout=30;";
            Sql = "";
            using (SqlConnection connection = new SqlConnection(DBConnection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Sql,connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                connection.Close();

                if (dt.Rows.Count < 1)
                {
                    Result = "False";
                }
                else
                {
                    Result = "True";
                }
            }




            return Result;
        }
    }
}
