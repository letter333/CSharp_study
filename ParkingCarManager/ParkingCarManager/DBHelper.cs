using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DAO같은 것
namespace ParkingCarManager
{
    public class DBHelper
    {
        // DB 연결
        private static SqlConnection conn = new SqlConnection();
        // DB에 있는 데이터를 가져 오는 부분
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        private static void ConnectDB()
        {
            string dataSource = "local";
            string db = "MYDB";
            string security = "SSPI";
            conn.ConnectionString = string.Format("Data Source=({0}); initial catalog={1}; integrated Security = {2}; Timeout=3", dataSource, db, security);
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public static void selectQuery(int parkingSpot = -1)
        {
            try
            {
                ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if(parkingSpot == -1)
                {
                    cmd.CommandText = "select * from parkingManager";
                } else
                {
                    cmd.CommandText = "select * from parkingManager where parkingSpot = " + parkingSpot;
                }
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "ParkingManager");
                dt = ds.Tables[0];
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "select");
                DataManager.PrintLog("select" + e.StackTrace);
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void updateQuery(string parkingSpotText, string carNumber, string driverName, string phoneNumber, bool isRemove)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlCommand = "";
                if(isRemove)
                {
                    sqlCommand = "update parkingManager set carNumber='', driverName='', phoneNumber='', parkingTime = null where parkingSpot=@p1";
                    // sql injection 방지
                    cmd.Parameters.AddWithValue("@p1", parkingSpotText);
                }
                else
                {
                    sqlCommand = "update parkingManager set carNumber=@p1, driverName=@p2, phoneNumber=@p3, parkingTime=@p4 where parkingSpot=@p5";
                    // sql injection 방지
                    cmd.Parameters.AddWithValue("@p1", carNumber);
                    cmd.Parameters.AddWithValue("@p2", driverName);
                    cmd.Parameters.AddWithValue("@p3", phoneNumber);
                    cmd.Parameters.AddWithValue("@p4", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@p5", parkingSpotText);
                }
                cmd.CommandText = sqlCommand;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("update" + e.Message);
                DataManager.PrintLog(e.StackTrace + "update");
            }
            finally
            {
                conn.Close();
            }
        }
        private static void executeQuery(string parkingSpot, string command)
        {
            string sqlCommand = "";

            if(command == "insert")
            {
                sqlCommand = "insert into parkingManager(parkingSpot) values (@p1)";
            }
            else
            {
                sqlCommand = "delete from parkingManager where parkingSpot=@p1";
            }

            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", parkingSpot);
                cmd.CommandText = sqlCommand;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public static void deleteQuery(string parkingSpot)
        {
            executeQuery(parkingSpot, "delete");
        }

        public static void insertQuery(string parkingSpot)
        {
            executeQuery(parkingSpot, "insert");
        }

    }
}
