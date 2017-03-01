/* adam 2017-01-30 libsql.cs */
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InsuranceApplication.Classes {
    struct SqlQuery
    {
        string Table;
        string Column;
        string Where;
        string Data;
    }

    static class libsql {
        /* properties */
        private static SqlConnection _conn = new SqlConnection(
            @"Server=tcp:insuranceclaim.database.windows.net,1433;
            Initial Catalog=InsuranceClaim;
            Persist Security Info=False;
            User ID=charlesroot;
            Password=Ieamainsuranceclaim123;
            MultipleActiveResultSets=False;
            Encrypt=True;
            TrustServerCertificate=False;
            Connection Timeout=30;");

        public static SqlConnection conn {
            get {
                return _conn;
            } private set {
                conn = value;
            }
        }

        private static bool CheckField(string table, string column, string data) {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select " + column + " from " + table + " where " + column + " = @field";
            cmd.Parameters.AddWithValue("@field", data);
            try {
                conn.Open();
                if (data.Equals((string)cmd.ExecuteScalar()))
                    return true;
            } catch (Exception ex) {
                return false;
            } finally {
                conn.Close();
            }
            return true;
        }

        private static object GetField(string table, string column, string where, string data) {
            SqlCommand cmd = new SqlCommand();
            object resp = null;
            cmd.Connection = conn;
            cmd.CommandText = "select " + column + " from " + table + " where " + where + " = @field";
            cmd.Parameters.AddWithValue("@field", data);
            try {
                conn.Open();
                resp = cmd.ExecuteScalar();
            } catch (Exception ex) {
                return null;
            } finally {
                conn.Close();
            }
            return resp;
        }

        private static bool UserDB(User user, bool register) {
            string query = string.Empty;
            if (register) {
                query = @"insert into users (firstname, lastname, username, password, birthday, phonenumber, rank)
                        values(@firstname, @lastname, @username, @password, @birthday, @phonenumber, @rank);";
                if (!CheckUsername(user.UserName))
                    return false;
            } else {
                query = @"update users set firstname = @firstname, lastname = @lastname, 
                          username = @username, password = @password, birthday = @birthday, 
                          phonenumber = @phonenumber, rank = @rank Where username = @username;";
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@firstname", user.FirstName);
            cmd.Parameters.AddWithValue("@lastname", user.LastName);
            cmd.Parameters.AddWithValue("@username", user.UserName);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@birthday", user.Birthday);
            cmd.Parameters.AddWithValue("@phonenumber", user.Phonenumber);
            cmd.Parameters.AddWithValue("@rank", user.Type);
            try {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                return false;
            } finally {
                conn.Close();
            }
            return true;
        }

        private static bool CheckUsername(string username) {
            return CheckField("users", "username", username);
        }

        private static bool CheckPassword(string password) {
            return CheckField("users", "password", password);
        }

        /* creates new user in database */
        public static bool RegisterUser(User user) {
            return UserDB(user, true);
        }

        /* updates existing user info */
        public static bool UpdateUser(User user) {
            return UserDB(user, false);
        }

        /* inserts claim in database */
        public static bool SendClaim(Claim claim) {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"insert into claims (username, date, status, claim) 
                                values(@username, @date, @status, @claim);";
            cmd.Parameters.AddWithValue("@username", claim.UserName);
            cmd.Parameters.AddWithValue("@date", claim.Date);
            cmd.Parameters.AddWithValue("@status", claim.Status);
            cmd.Parameters.AddWithValue("@claim", claim.Content);
            try {
                conn.Open();
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                return false;
            } finally {
                conn.Close();
            }
            return true;
        }

        /* inserts message in database */
        public static bool SendMessage(Message message) {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"insert into messages ([to], [from], date, subject, message)
                                values(@to, @from, @date, @subject, @message);";
            cmd.Parameters.AddWithValue("@to", message.To);
            cmd.Parameters.AddWithValue("@from", message.From);
            cmd.Parameters.AddWithValue("@date", message.Date);
            cmd.Parameters.AddWithValue("@subject", message.Subject);
            cmd.Parameters.AddWithValue("@message", message.Content);
            try {
                conn.Open();
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                return false;
            } finally {
                conn.Close();
            }
            return true;
        }

        public static DataTable GetInboxMessages(string username) {
            string query = "select * from messages where [to] = @username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable messages = new DataTable();
            sda.Fill(messages);
            return messages;
        }

        /* checks username and password in database */
        public static bool ValidateUser(string username, string password) {
            return (CheckUsername(username) && CheckPassword(password));
        }

        /* get user rank */
        public static int GetRank(string username) {
            return (int) GetField("users", "rank", "username", username);
        }

        public static string GetFirstName(string username) {
            return (string) GetField("users", "firstname", "username", username);
        }

        public static string GetLastName(string username) {
            return (string) GetField("users", "lastname", "username", username);
        }

        public static bool UpdateRank(string username, int rank) {
            string query = "update users set rank = @rank where username = @username;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@rank", rank);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.CommandType = CommandType.Text;
            try {
                conn.Open();
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                return false;
            } finally {
                conn.Close();
            }
            return true;
        }

        /* update password */
        public static bool UpdatePassword(string username, string password)
        {
            string query = "update users set password = @password where username = @username;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        /* returns data for single user */
        public static UserData GetUserData(string username) {
            string query = "select * from users where username = @username";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader sqlReader;
            UserData userdata = User.NullUserData;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", username);
            try {
                conn.Open();
                sqlReader = cmd.ExecuteReader();
                sqlReader.Read();
                userdata = new UserData
                {
                    FirstName = sqlReader.GetString(0),
                    LastName = sqlReader.GetString(1),
                    UserName = sqlReader.GetString(2),
                    Password = sqlReader.GetString(3),
                    Birthday = sqlReader.GetString(4),
                    Phonenumber = sqlReader.GetString(5),
                    Type = (UserType) sqlReader.GetInt32(6)
                };
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                conn.Close();
            }
            return userdata;
        }

        public static bool DeleteUser(string username)
        {
            string query = "delete from users where username = @username;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }
}