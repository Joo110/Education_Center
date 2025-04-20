using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsGroupData
    {
        public static bool GetInfoByID(int? groupID, ref string groupName,
    ref int? classID, ref int? teacherID, ref int? subjectTeacherID,
    ref int? meetingTimeID, ref int? studentCount, ref int? createdByUserID,
    ref DateTime creationDate, ref DateTime? lastModifiedDate, ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetGroupInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GroupID", (object)groupID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                classID = reader["ClassID"] != DBNull.Value ? (int?)reader["ClassID"] : null;
                                teacherID = reader["TeacherID"] != DBNull.Value ? (int?)reader["TeacherID"] : null;
                                subjectTeacherID = reader["SubjectTeacherID"] != DBNull.Value ? (int?)reader["SubjectTeacherID"] : null;
                                meetingTimeID = reader["MeetingTimeID"] != DBNull.Value ? (int?)reader["MeetingTimeID"] : null;
                                studentCount = reader["StudentCount"] != DBNull.Value ? (int?)reader["StudentCount"] : null;
                                createdByUserID = reader["CreatedByUserID"] != DBNull.Value ? (int?)reader["CreatedByUserID"] : null;
                                creationDate = (DateTime)reader["CreationDate"];
                                lastModifiedDate = reader["LastModifiedDate"] != DBNull.Value ? (DateTime?)reader["LastModifiedDate"] : null;
                                isActive = (bool)reader["IsActive"];
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


        public static DataTable GetScheduleForToday()
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetScheduleForToday", conn))
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


        public static DataTable GetAllGroupsDetails()
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllGroupsDetails", conn))
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


        public static DataTable GetAllGroupName()
        {
            DataTable dt = new DataTable();
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllGroupName", conn))
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

        public static int? Add(int classID, int teacherID, int subjectTeacherID,
int meetingTimeID, int createdByUserID)
        {
            int? groupID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ClassID", classID);
                        command.Parameters.AddWithValue("@TeacherID", teacherID);
                        command.Parameters.AddWithValue("@SubjectTeacherID", subjectTeacherID);
                        command.Parameters.AddWithValue("@MeetingTimeID", meetingTimeID);
                        command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                        // ✅ تعريف وإضافة الباراميتر الخارج
                        SqlParameter outputIdParam = new SqlParameter("@NewGroupID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        // ✅ استخراج القيمة الجديدة بعد الإدراج بطريقة صحيحة
                        if (outputIdParam.Value != DBNull.Value)
                        {
                            groupID = Convert.ToInt32(outputIdParam.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // معالجة الخطأ (يفضل تسجيله)
                Console.WriteLine(ex.Message);
            }

            return groupID;
        }

        public static bool Update(int groupID, int classID,
            int teacherID, int subjectTeacherID, int meetingTimeID,
             bool isActive)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GroupID", groupID);
                        command.Parameters.AddWithValue("@ClassID", classID);
                        command.Parameters.AddWithValue("@TeacherID", teacherID);
                        command.Parameters.AddWithValue("@SubjectTeacherID", subjectTeacherID);
                        command.Parameters.AddWithValue("@MeetingTimeID", meetingTimeID);
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


        public static decimal GetSubjectFeesByGroupID(int? groupID)
        {
            decimal fees = 0m;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetSubjectFeesByGroupID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GroupID", groupID);

                        SqlParameter outputIdParam = new SqlParameter("@Fees", SqlDbType.SmallMoney)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        fees = (decimal)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return fees;
        }


        public static DataTable GetAllStudentsInGroup(int groupID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllStudentsInGroup", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@GroupID", groupID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error retrieving students in group: " + ex.Message);
                    }
                }
            }
            return dt;
        }
    }
}
