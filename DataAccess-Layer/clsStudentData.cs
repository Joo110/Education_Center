using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsStudentData
    {
        public static DataTable GetStudents()
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetStudents", conn))
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


        public static bool GetInfoByStudentID(int? studentID, ref int? personID, ref int? gradeLevelID,
            ref int? createdByUserID, ref DateTime creationDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetStudentInfoByStudentID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StudentID", (object)studentID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                gradeLevelID = (reader["GradeLevelID"] != DBNull.Value) ? (int?)reader["GradeLevelID"] : null;
                                createdByUserID = (reader["CreatedByUserID"] != DBNull.Value) ? (int?)reader["CreatedByUserID"] : null;
                                creationDate = (DateTime)reader["CreationDate"];
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
            }

            return isFound;
        }



        public static bool UpdateGradeLevel(int studentID, string gradeName)
        {
            bool isUpdated = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateGradeLevelToStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@GradeName", gradeName);

                        int rowsAffected = command.ExecuteNonQuery();
                        isUpdated = (rowsAffected > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return isUpdated;
        }


        public static bool Delete(int studentID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StudentID", (object)studentID ?? DBNull.Value);

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return (rowAffected > 0);
        }


        public static int? Add(int personID, int gradeLevelID, int createdByUserID)
        {
            int? studentID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);
                        command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                        SqlParameter outputIdParam = new SqlParameter("@NewStudentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0 && outputIdParam.Value != DBNull.Value)
                        {
                            studentID = Convert.ToInt32(outputIdParam.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return studentID;
        }
    }
}
