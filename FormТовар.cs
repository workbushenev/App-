using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AppТовари
{
    public partial class FormТовар : Form
    {
        public FormТовар()
        {
            InitializeComponent();
        }

        private void FormТовар_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = MyPublic.connString;
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            string Код_товару = MyPublic.вікноТовари.listBoxТовари.SelectedItem.ToString().Substring(0, 3).Trim();


            cmd.CommandText = "SELECT * FROM Товари WHERE Код_товару = " + Код_товару;
            OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            dr.Read();

            textBoxКод_товару.Text = dr[0].ToString();
            textBoxТовар.Text = dr[1].ToString();
            textBoxЦіна.Text = dr[2].ToString();
            textBoxЦіна_закупівлі.Text = dr[3].ToString();
            dr.Close();
        }

        private void buttonЗберегти_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = MyPublic.connString;
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Товари SET Товар = '" + textBoxТовар.Text + 
                "'" + ", Ціна = " + textBoxЦіна.Text.Replace(",", ".") + 
                ", Ціна_закупівлі = " + textBoxЦіна_закупівлі.Text.Replace(",", ".") + 
                " WHERE Код_товару=" + textBoxКод_товару.Text;

            int КількістьЗаписів = cmd.ExecuteNonQuery();

            MessageBox.Show(КількістьЗаписів.ToString(), "Змінено записів");

            conn.Close();
        }
    }
}
