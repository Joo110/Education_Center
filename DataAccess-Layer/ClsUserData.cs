using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class ClsUserData
    {
        public static DataTable GetAllUsers()
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GetAllUsers", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtUsers = new DataTable();

                conn.Open();
                da.Fill(dtUsers);

                return dtUsers;
            }
        }


        public static bool Exists(string value1, string value2)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DoesUserExistByUsernameAndPassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@UserName", (object)value1 ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Password", (object)value2 ?? DBNull.Value);


                        var result = command.ExecuteScalar();
                        isFound = result != null && (int)result == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                isFound = false;
            }

            return isFound;
        }


        public static bool DeleteUser(int userID)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SP_DeleteUser", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", userID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public static bool GetUserInfoByUsernameAndPassword(ref int? userID, ref int? personID,
      string username, string password, ref int permissions, ref int isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserInfoByUsernameAndPassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                userID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                permissions = (reader["Permissions"] != DBNull.Value) ? (int)reader["Permissions"] : -1;
                                userID = (reader["IsActive"] != DBNull.Value) ? (int?)reader["IsActive"] : null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                Console.WriteLine($"Error: {ex.Message}");
            }

            return isFound;
        }


        public static int GetAllUsersCount()
        {
            int count = 0;
            string connectionString = clsDataAccessSettings.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllUsersCount", conn))
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


        public static bool GetUserInfoByPersonID(int UserID, ref int PersonID, ref string username,
      ref string password, ref int permissions, ref int isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserInfoByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                username = reader["Username"] != DBNull.Value ? reader["Username"].ToString() : string.Empty;
                                password = reader["Password"] != DBNull.Value ? reader["Password"].ToString() : string.Empty;
                                permissions = reader["Permissions"] != DBNull.Value ? (int)reader["Permissions"] : 0;
                                PersonID = reader["PersonID"] != DBNull.Value ? (int)reader["PersonID"] : 0;
                                isActive = reader["IsActive"] != DBNull.Value ? (int)reader["IsActive"] : 0;
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


        public static bool ChangePassword(int UserID, string NewPassword)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_ChangePassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NewPassword", NewPassword);

                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return (RowAffected > 0);
        }


        public static int? Add(int personID, string username, string password, int permissions,
            int isActive)
        {
            int? userID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Permissions", permissions);
                        command.Parameters.AddWithValue("@IsActive", isActive);

                        SqlParameter outputIdParam = new SqlParameter("@NewUserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        userID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return userID;
        }

        public static bool Update(int userID, int personID, string username, string password,
            int permissions, int isActive)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Permissions", permissions);
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


        public static bool DoesUserExistByUsername(string username)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DoesUserExistByUsername", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", username ?? (object)DBNull.Value);

                        SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        command.Parameters.Add(returnParameter);

                        command.ExecuteNonQuery();
                        isFound = (int)returnParameter.Value == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                //HandleException(ex);
            }

            return isFound;
        }
    }  
 }
