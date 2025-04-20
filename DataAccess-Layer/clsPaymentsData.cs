using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsPaymentsData
    {
        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllPayments", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static int GetAllPaymentsCount()
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllPaymentsCount", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count;
        }
    }
}
