using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Affiliate.DBCommunication;

namespace Affiliate.Views.Admin
{
    public partial class AddProducts : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        DBCommunication dbcomm = new DBCommunication();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Description = txtDesc.Text;
            products.link = txtLink.Text;
            products.Img_Link = txtImgLnk.Text;
            SaveData(products);
        }

        protected void SaveData(Products prd)
        {
            try
            {
                //DataTable dt = new DataTable();
                //SqlDataAdapter sda = new SqlDataAdapter("USP_SaveProduct", conn);
                //sda.SelectCommand.Parameters.AddWithValue("@desc", prd.Description);
                //sda.SelectCommand.Parameters.AddWithValue("@link", prd.link);
                //sda.SelectCommand.Parameters.AddWithValue("@imglink", prd.Img_Link);
                //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                //sda.Fill(dt);
                SqlParameter[] _params =
                {
                    new SqlParameter("@desc", prd.Description),
                    new SqlParameter("@link", prd.link),
                    new SqlParameter("@imglink", prd.Img_Link)
                };
                int exec = dbcomm.ExecuteStoredProcedure("USP_SaveProduct", _params, out string errMsg);

                if (exec > 0)
                {
                    lblmsg.Text = "Data Inserted Successfully!";


                }
                else
                {
                    lblmsg.Text = "We are unable to process your request.";
                }

            }
            catch (Exception ex)
            {

                lblmsg.Text = ex.Message.ToString();
            }
        }
    }
}