using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1foruni
{
    public partial class Form1 : Form
    {
        private readonly string connectionString =
            "Server=DESKTOP-JFOLDL4\\SQLEXPRESS;Database=LibraryDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonSELECT_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(@"
                    SELECT b.BookId, b.Title, a.AuthorName, b.PublishedYear, b.Price
                    FROM Books b
                    INNER JOIN Authors a ON b.AuthorId = a.AuthorId;", conn))
                {
                    DataTable dt = new DataTable();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
                    }
                    dataGridViewforshowdata.DataSource = dt;
                }
            }
        }

        private async void buttonINSERT_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                int authorId;
                using (SqlCommand getAuthorCmd = new SqlCommand("SELECT AuthorId FROM Authors WHERE AuthorName = @Name", conn))
                {
                    getAuthorCmd.Parameters.Add(CreateParameter("@Name", txtAuthorName.Text, DbType.String));
                    object result = await getAuthorCmd.ExecuteScalarAsync();

                    if (result == null)
                    {
                        MessageBox.Show("Author not found!");
                        return;
                    }
                    authorId = Convert.ToInt32(result);
                }

                using (SqlCommand cmd = new SqlCommand("InsertBook", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(CreateParameter("@Title", txtTitle.Text, DbType.String));
                    cmd.Parameters.Add(CreateParameter("@AuthorId", authorId, DbType.Int32));
                    cmd.Parameters.Add(CreateParameter("@PublishedYear", Convert.ToInt32(txtPublishedYear.Text), DbType.Int32));
                    cmd.Parameters.Add(CreateParameter("@Price", Convert.ToDecimal(txtPrice.Text), DbType.Decimal));

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            MessageBox.Show("Book Inserted Successfully!");
        }

        private DbParameter CreateParameter(string name, object value, DbType type)
        {
            DbParameter param = new SqlParameter(name, value);
            param.DbType = type;
            return param;
        }

        private async void buttonUPDATE_Click(object sender, EventArgs e)
        {
            if (dataGridViewforshowdata.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(dataGridViewforshowdata.SelectedRows[0].Cells["BookId"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();

                    int authorId;
                    using (SqlCommand getAuthorCmd = new SqlCommand("SELECT AuthorId FROM Authors WHERE AuthorName = @Name", conn))
                    {
                        getAuthorCmd.Parameters.Add(CreateParameter("@Name", txtAuthorName.Text, DbType.String));
                        object result = await getAuthorCmd.ExecuteScalarAsync();

                        if (result == null)
                        {
                            MessageBox.Show("Author not found!");
                            return;
                        }
                        authorId = Convert.ToInt32(result);
                    }

                    using (SqlCommand cmd = new SqlCommand("UpdateBook", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(CreateParameter("@BookId", bookId, DbType.Int32));
                        cmd.Parameters.Add(CreateParameter("@Title", txtTitle.Text, DbType.String));
                        cmd.Parameters.Add(CreateParameter("@AuthorId", authorId, DbType.Int32));
                        cmd.Parameters.Add(CreateParameter("@PublishedYear", Convert.ToInt32(txtPublishedYear.Text), DbType.Int32));
                        cmd.Parameters.Add(CreateParameter("@Price", Convert.ToDecimal(txtPrice.Text), DbType.Decimal));

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
                MessageBox.Show("Book Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Please select a book to update.");
            }
        }

        private async void buttonDELETE_Click(object sender, EventArgs e)
        {
            if (dataGridViewforshowdata.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(dataGridViewforshowdata.SelectedRows[0].Cells["BookId"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand("DeleteBook", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(CreateParameter("@BookId", bookId, DbType.Int32));

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
                MessageBox.Show("Book Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }

        private void dataGridViewforshowdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewforshowdata.SelectedRows.Count > 0)
            {
                var row = dataGridViewforshowdata.SelectedRows[0];

                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAuthorName.Text = row.Cells["AuthorName"].Value.ToString();
                txtPublishedYear.Text = row.Cells["PublishedYear"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
