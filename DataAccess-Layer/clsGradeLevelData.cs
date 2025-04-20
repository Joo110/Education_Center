using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsGradeLevelData
    {
        
        public static DataTable GetAllGradeLevelsName()
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllGradeLevelsName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public static DataTable GetAllGradeName()
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllGradeName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public static string GetGradeLevelName(int? gradeLevelID)
        {
            string gradeName = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetGradeLevelName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);

                        SqlParameter outputIdParam = new SqlParameter("@GradeName", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        gradeName = outputIdParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return gradeName;
        }



        public static int GetGradeLevelID(string gradeName)
        {
            int gradeLevelID = -1; // القيمة الافتراضية إذا لم يتم العثور على الصف

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetGradeLevelID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // ✅ التأكد من تطابق اسم البارامتر
                        command.Parameters.AddWithValue("@GradeLevelName", gradeName);

                        // ✅ التأكد من تعريفه كـ OUTPUT
                        SqlParameter outputIdParam = new SqlParameter("@GradeLevelID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        if (outputIdParam.Value != DBNull.Value && int.TryParse(outputIdParam.Value.ToString(), out int result))
                        {
                            gradeLevelID = result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetGradeLevelID: {ex.Message}");
            }

            return gradeLevelID;
        }


        public static bool GetInfoByID(int? gradeLevelID, ref string gradeName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetGradeNameBySubjectID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeID", (object)gradeLevelID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                gradeName = reader["GradeName"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                Console.WriteLine("Error: " + ex.Message);
            }

            return isFound;
        }

    }
}
