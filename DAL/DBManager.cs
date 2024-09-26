using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DBManager
    {
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable Dt;
            
        public DBManager()
        {
            try
            {

                sqlCn = new SqlConnection();
                //sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["ElectronicsStoreDB"].ConnectionString;
                sqlCn.ConnectionString = "Data source=AHMED\\SQLEXPRESS;initial catalog=ElectronicsStore_Storage;Integrated Security=true;";
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = sqlCn;

                DA = new SqlDataAdapter(sqlCmd);

                Dt = new DataTable();
            }
            catch
            {

            }
        }
        public int ExecuteNonQuery(string SPname)
        {
            int R = -1;
            try
            {
                if(sqlCn?.State == ConnectionState.Closed)
                {
                    sqlCn.Open(); 
                    sqlCmd.CommandText = SPname;
                    sqlCmd.Parameters.Clear();

                    R = sqlCmd.ExecuteNonQuery();
                    sqlCn.Close();
                }
            }
            catch
            {

            }
            return R;
        }
        public object ExecuteScaler(string SPname)
        {
            object R = new object();
            try
            {
                if (sqlCn?.State == ConnectionState.Closed)
                {
                    sqlCn.Open();
                    sqlCmd.CommandText = SPname;
                    sqlCmd.Parameters.Clear();

                    R = sqlCmd.ExecuteScalar();
                    sqlCn.Close();
                }
            }
            catch
            {

            }
            return R;
        }
        public DataTable ExecuteDataTable(string SPname)
        {
            Dt.Clear();
            try
            {  
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = SPname;
                DA.Fill(Dt);
            }
            catch
            {

            }
            return Dt;
        }
    }
}
