using System.Data;
using System.Data.SqlClient;

namespace Seoul_Stay
{
    internal class SqlMethod
    {
        static SqlConnection SqlCon = new SqlConnection("Data Source=166.166.1.24;Initial Catalog=Session1;User ID=Rice;Password=0854649141;");
        public static void Execute(SqlCommand cmd)
        {
            if (SqlCon.State == System.Data.ConnectionState.Closed)
            {
                SqlCon.Open();
            }
            cmd.Connection = SqlCon;
            cmd.ExecuteNonQuery();
            SqlCon.Close();
        }
        public static DataTable GetData(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            cmd.Connection = SqlCon;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
