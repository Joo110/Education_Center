using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsPeopleData
    {
        public static bool GetInfoByID(int? UserID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref short gender, ref DateTime dateOfBirth, ref string phoneNumber, ref string address)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPersonInfoByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                firstName = reader["FirstName"].ToString();
                                secondName = reader["SecondName"].ToString();
                                thirdName = reader["ThirdName"] != DBNull.Value ? reader["ThirdName"].ToString() : null;
                                lastName = reader["LastName"].ToString();
                                gender = (byte)reader["Gendor"];
                                dateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                                phoneNumber = reader["PhoneNumber"].ToString();
                                address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : null;
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

        public static bool GetInfoByStudentsID(int? StudentID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref short gender, ref DateTime dateOfBirth, ref string phoneNumber, ref string address)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPersonInfoStudentID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentID", (object)StudentID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                firstName = reader["FirstName"].ToString();
                                secondName = reader["SecondName"].ToString();
                                thirdName = reader["ThirdName"] != DBNull.Value ? reader["ThirdName"].ToString() : null;
                                lastName = reader["LastName"].ToString();
                                gender = (byte)reader["Gendor"];
                                dateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                                phoneNumber = reader["PhoneNumber"].ToString();
                                address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : null;
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



        public static bool GetInfoByPersonID(int? PersonID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref short gender, ref DateTime dateOfBirth, ref string phoneNumber, ref string address)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPersonInfoByPersonID2", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                firstName = reader["FirstName"].ToString();
                                secondName = reader["SecondName"].ToString();
                                thirdName = reader["ThirdName"] != DBNull.Value ? reader["ThirdName"].ToString() : null;
                                lastName = reader["LastName"].ToString();
                                gender = (byte)reader["Gendor"];
                                dateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                                phoneNumber = reader["PhoneNumber"].ToString();
                                address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : null;
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


        public static int? Add(string firstName, string secondName, string thirdName, string lastName, byte gender, DateTime dateOfBirth, string phoneNumber, string address)
        {
            // This function will return the new person id if succeeded and null if not
            int? personID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@SecondName", secondName);
                        command.Parameters.AddWithValue("@ThirdName", (object)thirdName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Address", (object)address ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        personID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return personID;
        }


        public static bool Update(int personID, string firstName, string secondName, string thirdName, string lastName, byte gender, DateTime dateOfBirth, string phoneNumber, string address)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@SecondName", secondName);
                        command.Parameters.AddWithValue("@ThirdName", (object)thirdName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Address", (object)address ?? DBNull.Value);

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
    }
}
