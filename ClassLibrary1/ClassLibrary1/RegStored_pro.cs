using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    
public  class RegStored_pro
 {
  
       
        SqlConnection conn = new SqlConnection("Data Source=tss11;Initial Catalog=Vishal;User ID=sa;Password=sa123");

        public void insert(String a, string b, string c)
        {
            SqlCommand cmd = new SqlCommand("v_InsertCUST", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = a;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value=b;
            cmd.Parameters.AddWithValue("@Phone_No", SqlDbType.VarChar).Value = c;
            conn.Open();
            cmd.ExecuteNonQuery();
           
          
        }
}
}
