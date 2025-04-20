using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsSubjectGradeLevelData
    {
        public static DataTable GetSubjectGradeLevelData()
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllSubjectGradeLevel", conn))
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


        public static bool GetInfoByID(int? subjectGradeLevelID, ref int? subjectID,
            ref byte? gradeLevelID, ref decimal fees, ref string description)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetSubjectGradeLevelByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectGradeLevelID", (object)subjectGradeLevelID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                subjectID = (reader["SubjectID"] != DBNull.Value) ? (int?)reader["SubjectID"] : null;
                                gradeLevelID = (reader["GradeLevelID"] != DBNull.Value) ? (byte?)Convert.ToByte(reader["GradeLevelID"]) : null;
                                fees = (decimal)reader["Fees"];
                                description = (reader["Description"] != DBNull.Value) ? (string)reader["Description"] : null;
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



        public static int? Add(int? subjectID, int? gradeLevelID, decimal fees, string description)
        {
            if (!subjectID.HasValue || !gradeLevelID.HasValue)
            {
                throw new ArgumentNullException("SubjectID and GradeLevelID must have values.");
            }

            int? subjectGradeLevelID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewSubjectGradeLevel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectID", subjectID.Value);
                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID.Value);
                        command.Parameters.AddWithValue("@Fees", fees);
                        command.Parameters.AddWithValue("@Description", (object)description ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@NewSubjectGradeLevelID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        if (outputIdParam.Value != DBNull.Value)
                        {
                            subjectGradeLevelID = Convert.ToInt32(outputIdParam.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return subjectGradeLevelID;
        }


        public static bool Update(int subjectGradeLevelID, int subjectID, byte gradeLevelID,
            decimal fees, string description)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateSubjectGradeLevel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectGradeLevelID", subjectGradeLevelID);
                        command.Parameters.AddWithValue("@SubjectID", subjectID);
                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);
                        command.Parameters.AddWithValue("@Fees", fees);
                        command.Parameters.AddWithValue("@Description", (object)description ?? DBNull.Value);

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


        public static DataTable GetAllTeachersTeachSubject(int subjectGradeLevelID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllTeachersTeachSubject", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SubjectGradeLevelID", subjectGradeLevelID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static DataTable GetUntaughtSubjectsByTeacher(int? teacherID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetUntaughtSubjectsByTeacher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TeacherID", teacherID);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
