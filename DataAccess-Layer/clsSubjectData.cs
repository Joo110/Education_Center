using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsSubjectData
    {
        public static DataTable GetAllSubjectName()
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllSubjectsName", conn))
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


        public static bool GetInfoByID(int? subjectID, ref string subjectName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetSubjectNameBySubjectID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectID", (object)subjectID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                subjectName = (string)reader["SubjectName"];
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

        public static int? GetSubjectID(string subjectName)
        {
            int? subjectID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetSubjectID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectName", subjectName);

                        SqlParameter outputIdParam = new SqlParameter("@SubjectID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        subjectID = (byte?)(int)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return subjectID;
        }




        public static int? AddNewSubject(string subjectName)
        {
            int? subjectID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // ✅ التأكد من تمرير قيمة البارامتر
                        command.Parameters.AddWithValue("@NewSubject", (object)subjectName ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@SubjectID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        // ✅ التأكد من أن القيمة ليست NULL قبل التحويل
                        if (outputIdParam.Value != DBNull.Value)
                        {
                            subjectID = Convert.ToInt32(outputIdParam.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return subjectID;
        }


        public static string GetSubjectNameBySubjectGradeLevelID(int? subjectGradeLevelID)
        {
            string subjectName = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetSubjectNameBySubjectGradeLevelID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectGradeLevelID", subjectGradeLevelID);

                        SqlParameter outputIdParam = new SqlParameter("@SubjectName", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        subjectName = outputIdParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return subjectName;
        }
    }
}
