using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsStudentGroupsData
    {
        public static DataTable GetAvailableGroupsForStudent(int studentID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAvailableGroupsForStudent", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", studentID);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }


        public static int? Add(int studentID, int groupID, int CreatedByUserID)
        {
            // This function will return the new person id if succeeded and null if not
            int? studentGroupID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewStudentGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@GroupID", groupID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                        SqlParameter outputIdParam = new SqlParameter("@NewStudentGroupID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        studentGroupID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return studentGroupID;
        }

        public static bool Update(int studentGroupID, int studentID, int groupID,
            DateTime? endDate, bool isActive)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateStudentGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StudentGroupID", studentGroupID);
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@GroupID", groupID);
                        command.Parameters.AddWithValue("@EndDate", (object)endDate ?? DBNull.Value);
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


        public static bool GetInfoByID(int? studentGroupID, ref int? studentID,
            ref int? groupID, ref DateTime startDate,
            ref DateTime? endDate, ref bool isActive, ref int? CreatedByUserID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetStudentGroupInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StudentGroupID", (object)studentGroupID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                studentID = (reader["StudentID"] != DBNull.Value) ? (int?)reader["StudentID"] : null;
                                groupID = (reader["GroupID"] != DBNull.Value) ? (int?)reader["GroupID"] : null;
                                startDate = (DateTime)reader["StartDate"];
                                endDate = (reader["EndDate"] != DBNull.Value) ? (DateTime?)reader["EndDate"] : null;
                                isActive = (bool)reader["IsActive"];
                                CreatedByUserID = (reader["CreatedByUserID"] != DBNull.Value) ? (int?)reader["CreatedByUserID"] : null;
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
    }
}
