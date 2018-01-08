using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHee.ProductsClass
{
    class Products
    {
        //getters and setters
        public int ProductID { get; set; }
        public String? ProductName { get; set; }
        public String? ProductDescription { get; set; }
        public int? PurchsePrice { get; set; }
        public int? SellingPrice { get; set; }
        public int? Quantity { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            //db connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //writting sql query
                String sql = "SELECT * FROM products";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //inserting data
        public bool Insert(Products c)
        {
            //create a default return type and setting its value to false
            bool isSuccess = false;

            //connect db
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql query to insert
                string sql = "INSERT INTO products(product_name, product_description, purchase_price, selling_price, quantity) VALUES (@ProductName, @ProductDescription, @PurchasePrice, @SellingPrice, @Quantity)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ProductName", c.ProductName);
                cmd.Parameters.AddWithValue("@ProductDescription", c.ProductDescription);
                cmd.Parameters.AddWithValue("@PurchsePrice", c.PurchsePrice);
                cmd.Parameters.AddWithValue("@SellingPrice", c.SellingPrice);
                cmd.Parameters.AddWithValue("@Quantity", c.Quantity);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //UPDATE DB
        public bool Update(Products c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE products SET product_name=@ProductName, product_description=@ProductDescription, purchase_price=@PurchsePrice, selling_price=@SellingPrice, quantity=@Quantity WHERE product_id=@ProductID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //parameters
                cmd.Parameters.AddWithValue("@ProductName", c.ProductName);
                cmd.Parameters.AddWithValue("@ProductDescription", c.ProductDescription);
                cmd.Parameters.AddWithValue("@PurchsePrice", c.PurchsePrice);
                cmd.Parameters.AddWithValue("@SellingPrice", c.SellingPrice);
                cmd.Parameters.AddWithValue("@Quantity", c.Quantity);
                cmd.Parameters.AddWithValue("@ProductID", c.ProductID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //DELETE FROM DB
        public bool Delete(Products c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM products WHERE product_id =@ProductID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", c.ProductID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
