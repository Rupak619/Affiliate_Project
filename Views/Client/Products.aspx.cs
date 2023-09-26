using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Affiliate.Views.Client
{
    public partial class Products : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindProducts();
            }
        }

        protected void BindProducts()
        {
            DataTable dt = new DataTable();
            string qry = "select * from vw_products;";
            SqlDataAdapter sda = new SqlDataAdapter(qry, conn);
            sda.SelectCommand.CommandType = CommandType.Text;
            sda.Fill(dt);

            if (dt != null && dt.Rows.Count > 0 )
            {
                // Create a StringBuilder to build the HTML markup
                StringBuilder htmlBuilder = new StringBuilder();

                // Loop through the DataTable rows and generate HTML for each product
                foreach (DataRow row in dt.Rows)
                {
                    string productName = row["Description"].ToString();
                    string productLink = row["Img_Link"].ToString();
                    string imageSource = row["Img_Link"].ToString();

                    // Generate HTML for the product and append it to the StringBuilder
                    htmlBuilder.Append($"<div class='product-item'>");
                    htmlBuilder.Append($"<h2>{productName}</h2>");
                    htmlBuilder.Append($"<a href='{productLink}' target='_blank'><img src='{imageSource}' alt='{productName}' /></a>");
                    htmlBuilder.Append($"</div>");
                }

                // Set the InnerHtml of the productContainer div to the generated HTML
                productContainer.InnerHtml = htmlBuilder.ToString();

                //grdProd.DataSource = dt;
                //grdProd.DataBind();
            }
        }
    }
}