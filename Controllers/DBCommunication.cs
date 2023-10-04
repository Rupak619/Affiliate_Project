using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Affiliate
{
    public class DBCommunication
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

        public DataTable ExecuteSelectQuery(string query, out string errMsg)
        {
            DataTable dt = new DataTable();
            errMsg = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }

        public int ExecuteNonQuery(string qry, out string errMsg)
        {
            errMsg = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(qry, conn);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                return -1;
            }

        }

        public int ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters, out string errMsg)
        {
            errMsg = null;

            using (SqlCommand cmd = new SqlCommand(procedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure; // Specify that it's a stored procedure

                // Add parameters if neededs
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    errMsg = ex.Message; // Store the error message
                                               // Handle exceptions or log errors here
                    return -1; // Indicates an error
                }
            }

        }


    }
}