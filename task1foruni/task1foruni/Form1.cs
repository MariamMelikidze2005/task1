using System;
using System.Data;
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
            SELECT b.BookId, b.Title, a.Name, b.PublishedYear, b.Price
            FROM Books b
            INNER JOIN Authors a ON b.AuthorId = a.AuthorId;", conn))
                {
                    cmd.CommandType = CommandType.Text;

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
                    getAuthorCmd.Parameters.AddWithValue("@Name", txtAuthorName.Text);
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
                    cmd.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar) { Value = txtTitle.Text });
                    cmd.Parameters.Add(new SqlParameter("@AuthorId", SqlDbType.Int) { Value = authorId });
                    cmd.Parameters.Add(new SqlParameter("@PublishedYear", SqlDbType.Int) { Value = Convert.ToInt32(txtPublishedYear.Text) });
                    cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Decimal) { Value = Convert.ToDecimal(txtPrice.Text) });

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            MessageBox.Show("Book Inserted Successfully!");
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
                        getAuthorCmd.Parameters.AddWithValue("@Name", txtAuthorName.Text);
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
                        cmd.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int) { Value = bookId });
                        cmd.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar) { Value = txtTitle.Text });
                        cmd.Parameters.Add(new SqlParameter("@AuthorId", SqlDbType.Int) { Value = authorId });
                        cmd.Parameters.Add(new SqlParameter("@PublishedYear", SqlDbType.Int) { Value = Convert.ToInt32(txtPublishedYear.Text) });
                        cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Decimal) { Value = Convert.ToDecimal(txtPrice.Text) });

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
                        cmd.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int) { Value = bookId });

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
                txtAuthorName.Text = row.Cells["Name"].Value.ToString();
                txtPublishedYear.Text = row.Cells["PublishedYear"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
