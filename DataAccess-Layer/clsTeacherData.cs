using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsTeacherData
    {

        public static bool GetInfoByTeacherID(int? teacherID, ref int? personID, ref byte? educationLevelID,
            ref byte? teachingExperience, ref string certifications,
            ref int? createdByUserID, ref DateTime creationDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetTeacherInfoByTecherID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TeacherID", (object)teacherID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                educationLevelID = (reader["EducationLevelID"] != DBNull.Value) ? (byte?)Convert.ToByte(reader["EducationLevelID"]) : null;
                                teachingExperience = (reader["TeachingExperience"] != DBNull.Value) ? (byte?)reader["TeachingExperience"] : null;
                                certifications = (reader["Certifications"] != DBNull.Value) ? (string)reader["Certifications"] : null;
                                createdByUserID = (reader["CreatedByUserID"] != DBNull.Value) ? (int?)reader["CreatedByUserID"] : null;
                                creationDate = (DateTime)reader["CreationDate"];
                            }
                            else
                            {
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


        public static int GetAllTeacherCount()
        {
            int count = 0;
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllTeacherCount", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int value))
                    {
                        count = value;
                    }
                }
            }

            return count;
        }


        public static DataTable GetTeacherDeatails()
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllTeachersInPages", conn))
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


        public static int? Add(int personID, int educationLevelID, byte? teachingExperience,
            string certifications, int createdByUserID)
        {
            int? teacherID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewTeacher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@EducationLevelID", educationLevelID);
                        command.Parameters.AddWithValue("@TeachingExperience", (object)teachingExperience ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Certifications", (object)certifications ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                        SqlParameter outputIdParam = new SqlParameter("@NewTeacherID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        teacherID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return teacherID;
        }

        public static bool Update(int teacherID, int personID, int educationLevelID,
            byte? teachingExperience, string certifications,
            int createdByUserID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateTeacher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TeacherID", teacherID);
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@EducationLevelID", educationLevelID);
                        command.Parameters.AddWithValue("@TeachingExperience", (object)teachingExperience ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Certifications", (object)certifications ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return (rowAffected > 0);
        }


        public static bool Delete(int TeacherID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteTeacher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TeacherID", (object)TeacherID ?? DBNull.Value);

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return (rowAffected > 0);
        }
    }
}
