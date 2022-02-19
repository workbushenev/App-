using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AppТовари
{
    public partial class formТовари : Form
    {
        public formТовари()
        {
            InitializeComponent();
        }

        private void formТовари_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = MyPublic.connString;
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * From Товари";

            OleDbDataReader dr = cmd.ExecuteReader();

            int i;
            int[] len = new int[4] {3,25, 7, 7};
            while (dr.Read())
            {
                string stringList = "";
                for (i = 0; i < dr.FieldCount-1; i++)
                {
                    stringList += dr[i].ToString().PadRight(len[i]);
                }
                listBoxТовари.Items.Add(stringList);
            }

            dr.Close();

            cmd.CommandText = "SELECT AVG(Ціна) FROM Товари";
            textBoxСередня_ціна.Text = cmd.ExecuteScalar().ToString();
            conn.Close();
        }

        private void buttonЗмінити_Click(object sender, EventArgs e)
        {
            if(listBoxТовари.SelectedItem != null)
            {
                FormТовар вікноТовар = new FormТовар();
                вікноТовар.ShowDialog();
            }
            else
            {
                MessageBox.Show("Виберіть товар", "Змінення", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
