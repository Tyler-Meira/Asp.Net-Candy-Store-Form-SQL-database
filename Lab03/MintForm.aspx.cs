using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

/*
 
    Tyler Meira (N01432291)
    ASP.NET
    Lab03

*/

namespace Lab03
{
    public partial class MintForm : System.Web.UI.Page
    {
        //Creates a new sql conneciton and sets the location to the location of the database.
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\School\S4\ASP.NET\Lab03\Lab03\App_Data\Products.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Sets the lables color to black
            output.ForeColor = System.Drawing.Color.Black;
        }

        protected void insert_Click(object sender, EventArgs e)
        {
            
            //opens the connection to data base and startsnew command
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //sets the command text and exectues the query
            cmd.CommandText = "Insert into tblProducts values ('" + inputName.Text + "', " + inputPrice.Text + ", " + inputQuantity.Text + ")";
            cmd.ExecuteNonQuery();

            //Chagnes the text how the ouput lable to display message.
            output.ForeColor = System.Drawing.Color.Green;
            output.Text = "New Product Inserted :D";
            

        }

        protected void update_Click(object sender, EventArgs e)
        {
            //Opens connection and creates new object for a sql command 
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //sets up the command to update the products table and sets the values of the row depending on what id is entered.
            cmd.CommandText = "Update tblProducts set name='" + inputName.Text + "', price =" + inputPrice.Text + ", quantity=" + inputQuantity.Text + " WHERE id =" + inputId.Text;
            cmd.ExecuteNonQuery();

            //sets output message to confirm the update was successfull
            output.ForeColor = System.Drawing.Color.Green;
            output.Text = "Your Updated The Row With Id: " + inputId.Text;

        }

        protected void delete_Click(object sender, EventArgs e)
        {
            //opens connection and creates a new sql command object 
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //Sets the command to delete from the products table base on the id entered.
            cmd.CommandText = "Delete From tblProducts where id =" + inputId.Text;
            cmd.ExecuteNonQuery();

            //updates output message confimrs successfull delteion
            output.ForeColor = System.Drawing.Color.Green;
            output.Text = "Row With Id: " + inputId.Text + " has been deleted :D";

        }

        protected void clear_Click(object sender, EventArgs e)
        {
            //sets all the fields on the fourm to empty to allow user use flow a bit easier.
            inputId.Text = "";
            inputName.Text = "";
            inputPrice.Text = "";
            inputQuantity.Text = "";
            output.Text = "";
            output.ForeColor = System.Drawing.Color.Black;

        }

        protected void load_Click(object sender, EventArgs e)
        {
            //uses try catch block to output message if the object in the table does not exist and output a message.
            try
            {
                //opens database connection
                con.Open();

                //Creates three diffrent sql query strings for each collum in the products table
                string loadName = "select name from tblProducts Where id=" + inputId.Text;
                string loadPrice = "select price from tblProducts Where id=" + inputId.Text;
                string loadQ = "select quantity from tblProducts Where id=" + inputId.Text;

                //creates a new sql command object and gives it the commands and connection it is going to use.
                SqlCommand cName = new SqlCommand(loadName, con);
                SqlCommand cPrice = new SqlCommand(loadPrice, con);
                SqlCommand cQ = new SqlCommand(loadQ, con);

                //executes the querys and puts it into a variale.
                string name = (string)cName.ExecuteScalar();
                decimal price = (decimal)cPrice.ExecuteScalar();
                int q = (int)cQ.ExecuteScalar();

                //puts the values taken from the products table and puts them into the input fields on the form.
                inputName.Text = name.ToString();
                inputPrice.Text = price.ToString();
                inputQuantity.Text = q.ToString();

                //updates the output message to confrim the data has been loaded properly.
                output.ForeColor = System.Drawing.Color.Green;
                output.Text = "Product Loaded :D";
            }
            catch (Exception ex)
            {
                output.ForeColor = System.Drawing.Color.Red;
                output.Text = "Product Does Not Exist :C";
            }
            finally
            {
                //Close's the connection when the try catch block is finished exectuing.
                con.Close();
            }

        }
    }
}