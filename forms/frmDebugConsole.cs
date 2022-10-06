using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using ZappCash.packages;

namespace ZappCash.forms
{
    public partial class frmDebugConsole : Form
    {
        public frmDebugConsole()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string content = txtOutput.Text;
            IdGenerator hi = new IdGenerator();
            string ParentID = txtCommand.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vince\source\repos\ZappCash\data\accounts.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Accounts values (@Id,@Name,@Description,@Code,@Color,@AssetType,@IsPlaceholder,@Parent,@SmallestFraction,@Balance)", con);
            cmd.Parameters.AddWithValue("@Id", hi.GenerateID(ParentID));
            cmd.Parameters.AddWithValue("@Name", "");
            cmd.Parameters.AddWithValue("@Description", "");
            cmd.Parameters.AddWithValue("@Code", "");
            cmd.Parameters.AddWithValue("@Color", "#ffffff");
            cmd.Parameters.AddWithValue("@AssetType", "PHP");
            cmd.Parameters.AddWithValue("@IsPlaceholder", 0);
            cmd.Parameters.AddWithValue("@Parent", ParentID);
            cmd.Parameters.AddWithValue("@SmallestFraction", 2);
            cmd.Parameters.AddWithValue("@Balance", 2);

            cmd.ExecuteNonQuery();

            

            content += $"Successfully Saved {hi.GenerateID()} \r\n";

            txtOutput.Text = content;
        }
    }
}
