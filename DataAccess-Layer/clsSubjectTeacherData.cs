using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsSubjectTeacherData
    {
        public static bool GetInfoByID(int? subjectTeacherID, ref int? subjectGradeLevelID,
            ref int? teacherID, ref DateTime assignmentDate,
            ref DateTime? lastModifiedDate, ref int? isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetSubjectTeacherInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectTeacherID", (object)subjectTeacherID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                subjectGradeLevelID = reader["SubjectGradeLevelID"] != DBNull.Value ? (int?)reader["SubjectGradeLevelID"] : null;
                                teacherID = reader["TeacherID"] != DBNull.Value ? (int?)reader["TeacherID"] : null;
                                assignmentDate = reader["AssignmentDate"] != DBNull.Value ? (DateTime)reader["AssignmentDate"] : DateTime.MinValue; // تجنب الخطأ في حالة NULL
                                lastModifiedDate = reader["LastModifiedDate"] != DBNull.Value ? (DateTime?)reader["LastModifiedDate"] : null;
                                isActive = reader["IsActive"] != DBNull.Value ? (int?)reader["IsActive"] : null;
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


        public static DataTable GetAllSubjectsTaughtByTeacher(int? teacherID)
        {
            DataTable dtSubjects = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllSubjectsTaughtByTeacher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TeacherID", teacherID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dtSubjects);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllSubjectsTaughtByTeacher: {ex.Message}");
            }

            return dtSubjects;
        }


        public static int? Add(int subjectGradeLevelID, int teacherID)
        {
            // This function will return the new person id if succeeded and null if not
            int? subjectTeacherID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewSubjectTeacher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectGradeLevelID", subjectGradeLevelID);
                        command.Parameters.AddWithValue("@TeacherID", teacherID);

                        SqlParameter outputIdParam = new SqlParameter("@NewSubjectTeacherID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        subjectTeacherID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return subjectTeacherID;
        }

        public static bool Update(int subjectTeacherID, int subjectGradeLevelID,
            int teacherID, int? isActive)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateSubjectTeacher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectTeacherID", subjectTeacherID);
                        command.Parameters.AddWithValue("@SubjectGradeLevelID", subjectGradeLevelID);
                        command.Parameters.AddWithValue("@TeacherID", teacherID);
                        command.Parameters.AddWithValue("@IsActive", isActive);

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


        public static DataTable GetAllSubjectsTaughtByTeacherID(int teacherID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllSubjectsTaughtByTeacherID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TeacherID", teacherID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
