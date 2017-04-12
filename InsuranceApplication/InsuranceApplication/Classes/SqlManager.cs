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

    static class SqlManager {
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
            return false;
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
                //if (!CheckUsername(user.UserName))
                //    return false;
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
                MessageBox.Show(ex.ToString());
                //return false;
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
            cmd.CommandText = @"insert into claims (username, date, status, claim, amount) 
                                values(@username, @date, @status, @claim, @amount);";
            cmd.Parameters.AddWithValue("@username", claim.UserName);
            cmd.Parameters.AddWithValue("@date", claim.Date);
            cmd.Parameters.AddWithValue("@status", claim.Status);
            cmd.Parameters.AddWithValue("@claim", claim.Content);
            cmd.Parameters.AddWithValue("@amount", claim.Amount);
            try {
                conn.Open();
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
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

        //get messages that are sent to a particular username
        public static DataTable GetInboxMessages(string username) {
            string query = "select * from messages where [to] = @username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable messages = new DataTable();
            sda.Fill(messages);
            return messages;
        }

        //get all claims from database
        public static DataTable GetClaims()
        {
            string query = "select * from claims";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable claims = new DataTable();
            sda.Fill(claims);
            return claims;
        }

        //get claims for clients based on username from database
        public static DataTable GetClaimStatus(string username)
        {
            string query = "select * from claims where username=@username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable claims = new DataTable();
            sda.Fill(claims);
            return claims;
        }

        //get all users with client rank from database
        public static DataTable GetClientList()
        {
            string query = "select * from users where rank=4";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable clients = new DataTable();
            sda.Fill(clients);
            return clients;
        }

        //get all users with rank as admin, claim manager, or finance manager from database
        public static DataTable GetManagement()
        {
            string query = "select * from users where rank=1 or rank=2 or rank=3";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable managers = new DataTable();
            sda.Fill(managers);
            return managers;
        }

        //get messages sent by a particular id from database
        public static Message GetMessage(string id)
        {
            string query = "select * from messages where id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader sqlReader;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                sqlReader = cmd.ExecuteReader();
                sqlReader.Read();
            Message message = new Message {
                To = sqlReader.GetString(0),
                From = sqlReader.GetString(1),
                Date = sqlReader.GetString(2),
                Subject = sqlReader.GetString(3),
                Content = sqlReader.GetString(4),
                Id = sqlReader.GetInt64(5)
                };
                conn.Close();
            return message;
        }

        /* checks username and password in database */
        public static bool ValidateUser(string username, string password) {
            return (CheckUsername(username) && CheckPassword(password));
        }

        /* get user rank */
        public static UserType GetRank(string username) {
            return (UserType) GetField("users", "rank", "username", username);
        }

        //get firstname given a username
        public static string GetFirstName(string username) {
            return (string) GetField("users", "firstname", "username", username);
        }

        //get lastname given a username
        public static string GetLastName(string username) {
            return (string) GetField("users", "lastname", "username", username);
        }

        //claim manager updates the status field for a claim
        public static bool UpdateClaimStatus(int id, int status)
        {
            string query = "update claims set status = @status where id = @id;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);
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

        //finance manager updates the amount field for the claim
        public static bool UpdateClaimAmount(int id, int amount)
        {
            string query = "update claims set amount = @amount where id = @id;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@id", id);
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

        //admin changes the rank field for a user
        public static bool UpdateRank(string username, UserType rank) {
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

        //admin deletes a user based on username from the database
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