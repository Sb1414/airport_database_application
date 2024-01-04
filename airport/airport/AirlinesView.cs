using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airport
{
	public partial class AirlinesView : Form
	{
		string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

		public AirlinesView()
		{
			InitializeComponent();
			LoadAirports();
			dataGridViewAirlines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void LoadAirports()
		{
			using (SQLiteConnection connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT * FROM Airports";

				using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
					{
						DataTable dt = new DataTable();
						adapter.Fill(dt);
						dataGridViewAirlines.DataSource = dt;
					}
					dataGridViewAirlines.Columns["Id"].Visible = false;
					dataGridViewAirlines.Columns["City"].HeaderText = "Город";
					dataGridViewAirlines.Columns["Name"].HeaderText = "Название аэропорта";
					dataGridViewAirlines.Columns["Code"].HeaderText = "Код";
				}
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			try
			{
				AirportAddView add = new AirportAddView();

				if (add.ShowDialog() == DialogResult.OK)
				{
					string name = add.AirName;
					string code = add.Code;
					string city = add.City;

					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();
						using (SQLiteCommand cmd = new SQLiteCommand(
							"INSERT INTO Airports (City, Name, Code) " +
							"VALUES (@City, @Name, @Code)",
							connection))
						{
							cmd.Parameters.AddWithValue("@City", city);
							cmd.Parameters.AddWithValue("@Name", name);
							cmd.Parameters.AddWithValue("@Code", code);

							int rowsUpdated = cmd.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadAirports();
							}
							else
							{
								MessageBox.Show("ошибка добавления данных");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ошибка", MessageBoxButtons.OK);
			}
		}
	}
}
