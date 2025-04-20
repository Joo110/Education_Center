using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsEductionLevelData
    {
        public static DataTable GetEductionLevelName()
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetEductionLevelName", conn))
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


        public static bool GetInfoByID(byte? educationLevelID, ref string levelName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetEductionLevelInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@EducationLevelID", (object)educationLevelID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                levelName = (string)reader["LevelName"];
                            }
                            else
                            {
                                // The record was not found
                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsDataAccessHelper.HandleException(ex);
            }

            return isFound;
        }


        public static int GetEducationLevelID(string educationLevelName)
        {
            int educationLevelID = -1; // القيمة الافتراضية في حالة عدم العثور على النتيجة

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetEducationID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // ✅ تأكد من أن اسم البارامتر متطابق مع تعريف الإجراء المخزن
                        command.Parameters.AddWithValue("@EducationName", educationLevelName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                educationLevelID = reader.GetInt32(0); // قراءة الـ ID من الصف الأول
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetEducationLevelID: {ex.Message}");
            }

            return educationLevelID;
        }



        public static string GetEducationLevelName(int? educationLevelID)
        {
            string levelName = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetEducationLevelName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@EducationLevelID", educationLevelID);

                        SqlParameter outputIdParam = new SqlParameter("@LevelName", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        levelName = outputIdParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return levelName;
        }
    }
}
